using System;

namespace Common.StateMachines
{
    public interface SM_ITransition
    {
        Type Target { get; }

        bool IsValid();
    }
}
