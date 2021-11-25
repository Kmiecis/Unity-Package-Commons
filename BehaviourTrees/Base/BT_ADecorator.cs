namespace Common.BehaviourTrees
{
    public abstract class BT_ADecorator : BT_ADecizer
    {
        public BT_ADecorator(string name = null) :
            base(name)
        {
        }

        protected override bool CanExecute()
        {
            return true;
        }
    }
}
