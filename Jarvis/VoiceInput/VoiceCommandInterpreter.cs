﻿using System;
using System.Linq;
using System.Speech.Recognition;
using Jarvis.Commands;
using Jarvis.Interfaces;
using Jarvis.Logging;
using Jarvis.Utils;

namespace Jarvis.VoiceInput
{
    public class VoiceCommandInterpreter : ICommandInterpreter
    {
        private readonly VoiceCommandRepository _Repository;
        private readonly IGrammarConstructor _GrammarConstructor;

        public Action<string, string> InterpretCallback;

        public VoiceCommandInterpreter(VoiceCommandRepository Repository, IGrammarConstructor GrammarConstructor)
        {
            _Repository = Repository;
            _GrammarConstructor = GrammarConstructor;
            _GrammarConstructor.SetRepository(Repository);
        }

        public void AddCommands(VoiceCommandRepository AdditionalCommands)
        {
            _Repository.AddCommands(AdditionalCommands);
        }

        public Grammar[] GetGrammars()
        {
            return _GrammarConstructor.ConstructGrammars();
        }

        public void Interpret(string Input)
        {
            var FoundCommand = _Repository.GetCommands();

            var Matches = FoundCommand.Where(Entry => StringTools.MatchesWithWildcard(Entry.SpokenCommand, Input));
            var Found = Matches as Command[] ?? Matches.ToArray();

            Command Chosen = Found.FirstOrDefault();

            //Todo: set precedence to entries without wildcards (more specific entries)
            if (Chosen == null) return;

            if (Found.Length > 1)
                Logger.Instance.LogError($"Found multiple commands for input [{Input}], executing [{Chosen.Name}]");

            string Result = Chosen.Execute(Input);

            InterpretCallback?.Invoke(Chosen.Name, Result);
        }
    }
}
