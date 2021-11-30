using System;

namespace Common.StateMachines
{
    public interface SM_IState
    {
        Type Execute();
    }
}
