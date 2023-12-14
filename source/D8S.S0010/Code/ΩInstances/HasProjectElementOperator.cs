using System;


namespace D8S.S0010
{
    public class HasProjectElementOperator : IHasProjectElementOperator
    {
        #region Infrastructure

        public static IHasProjectElementOperator Instance { get; } = new HasProjectElementOperator();


        private HasProjectElementOperator()
        {
        }

        #endregion
    }
}
