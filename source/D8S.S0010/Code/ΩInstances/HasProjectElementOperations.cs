using System;


namespace D8S.S0010
{
    public class HasProjectElementOperations : IHasProjectElementOperations
    {
        #region Infrastructure

        public static IHasProjectElementOperations Instance { get; } = new HasProjectElementOperations();


        private HasProjectElementOperations()
        {
        }

        #endregion
    }
}


namespace D8S.S0010.N001
{
    public class HasProjectElementOperations : IHasProjectElementOperations
    {
        #region Infrastructure

        public static IHasProjectElementOperations Instance { get; } = new HasProjectElementOperations();


        private HasProjectElementOperations()
        {
        }

        #endregion
    }
}
