namespace Common.BehaviourTrees
{
    public interface BT_ITask
    {
        BT_EStatus Status { get; }

        BT_IDecorator Decorator { get; }

        BT_EStatus Execute();

        void Abort();
    }

    public static class BT_ITaskExtensions
    {
        public static BT_EStatus DecoratedExecute(this BT_ITask node)
        {
            var decorator = node.Decorator;
            if (decorator != null)
            {
                return decorator.Execute(node);
            }
            return node.Execute();
        }
    }
}
