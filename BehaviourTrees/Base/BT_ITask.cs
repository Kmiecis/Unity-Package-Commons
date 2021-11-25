namespace Common.BehaviourTrees
{
    public interface BT_ITask
    {
        BT_EStatus Status { get; }

        BT_IDecizer Decizer { get; }

        BT_EStatus Execute();

        void Abort();
    }

    public static class BT_ITaskExtensions
    {
        public static BT_EStatus WrappedExecute(this BT_ITask node)
        {
            var decizer = node.Decizer;
            if (decizer != null)
            {
                return decizer.Execute(node);
            }
            return node.Execute();
        }
    }
}
