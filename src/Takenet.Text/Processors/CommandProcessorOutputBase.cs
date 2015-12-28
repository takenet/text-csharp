﻿using System.Threading.Tasks;

namespace Takenet.Text.Processors
{
    public abstract class CommandProcessorOutputBase<TOutput> : ICommandProcessor
    {
        protected CommandProcessorOutputBase(OutputProcessorBase<TOutput> commandOutputProcessor, params Syntax[] syntaxes)
        {
            CommandOutputProcessor = commandOutputProcessor;
            Syntaxes = syntaxes;
        }

        public OutputProcessorBase<TOutput> CommandOutputProcessor { get; }

        public IOutputProcessor OutputProcessor => CommandOutputProcessor;

        public Syntax[] Syntaxes { get; protected set; }

        public abstract Task ProcessAsync(Expression expression);
    }
}