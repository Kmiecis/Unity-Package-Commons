namespace Common.BehaviourTrees
{
    public abstract class BT_ARunnable : BT_IRunnable
    {
        protected string _name;

        public BT_ARunnable(string name = null)
        {
            _name = name ?? GetType().Name;
        }

        public abstract void Execute();

        public override string ToString()
        {
            return _name;
        }
    }
}
