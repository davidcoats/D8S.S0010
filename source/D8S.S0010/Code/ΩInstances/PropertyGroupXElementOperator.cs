using System;


namespace D8S.S0010
{
    public class PropertyGroupXElementOperator : IPropertyGroupXElementOperator
    {
        #region Infrastructure

        public static IPropertyGroupXElementOperator Instance { get; } = new PropertyGroupXElementOperator();


        private PropertyGroupXElementOperator()
        {
        }

        #endregion
    }
}


namespace D8S.S0010.Common
{
    public class PropertyGroupXElementOperator : IPropertyGroupXElementOperator
    {
        #region Infrastructure

        public static IPropertyGroupXElementOperator Instance { get; } = new PropertyGroupXElementOperator();


        private PropertyGroupXElementOperator()
        {
        }

        #endregion
    }
}
