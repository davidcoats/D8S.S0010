using System;


namespace D8S.S0010
{
    public class Operator : IOperator
    {
        #region Infrastructure

        public static IOperator Instance { get; } = new Operator();


        private Operator()
        {
        }

        #endregion
    }
}
