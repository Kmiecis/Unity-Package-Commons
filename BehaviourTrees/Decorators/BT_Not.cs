namespace Common.BehaviourTrees
{
    public class BT_Not : BT_ADecorator
    {
        public BT_Not() :
            base("Not")
        {
        }

        protected override BT_EStatus OnUpdate(BT_ITask node)
        {
            var result = base.OnUpdate(node);

            switch (result)
            {
                case BT_EStatus.Failure:
                    return BT_EStatus.Success;

                case BT_EStatus.Success:
                    return BT_EStatus.Failure;
            }

            return result;
        }
    }
}
