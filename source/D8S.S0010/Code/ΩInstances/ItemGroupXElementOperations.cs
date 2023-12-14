using System;


namespace D8S.S0010
{
    public class ItemGroupXElementOperations : IItemGroupXElementOperations
    {
        #region Infrastructure

        public static IItemGroupXElementOperations Instance { get; } = new ItemGroupXElementOperations();


        private ItemGroupXElementOperations()
        {
        }

        #endregion
    }
}
