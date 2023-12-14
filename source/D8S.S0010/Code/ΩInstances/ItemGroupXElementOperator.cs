using System;


namespace D8S.S0010
{
    public class ItemGroupXElementOperator : IItemGroupXElementOperator
    {
        #region Infrastructure

        public static IItemGroupXElementOperator Instance { get; } = new ItemGroupXElementOperator();


        private ItemGroupXElementOperator()
        {
        }

        #endregion
    }
}
