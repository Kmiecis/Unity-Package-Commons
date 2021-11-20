namespace Common.BehaviourTrees
{
    public interface BT_ITask
    {
        BT_EStatus Execute();

        BT_IDecorator Decorator { get; }
    }

    public static class BT_INodeExtensions
    {
        public static BT_EStatus WrappedExecute(this BT_ITask node)
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
