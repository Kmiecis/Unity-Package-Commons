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
        public static BT_EStatus WrappedExecute(this BT_ITask node)
        {
            var decorator = node.Decorator;
            if (decorator != null)
            {
                var result = decorator.Execute(node);
                if (
                    result != BT_EStatus.Running &&
                    node.Status == BT_EStatus.Running
                )
                {
                    node.Abort();
                }
                return result;
            }
            return node.Execute();
        }
    }
}
