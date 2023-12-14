using System;


namespace D8S.S0010
{
    public class Authors : IAuthors
    {
        #region Infrastructure

        public static IAuthors Instance { get; } = new Authors();


        private Authors()
        {
        }

        #endregion
    }
}


namespace D8S.S0010.Personal
{
    public class Authors : IAuthors
    {
        #region Infrastructure

        public static IAuthors Instance { get; } = new Authors();


        private Authors()
        {
        }

        #endregion
    }
}


namespace D8S.S0010.Personal.Raw
{
    public class Authors : IAuthors
    {
        #region Infrastructure

        public static IAuthors Instance { get; } = new Authors();


        private Authors()
        {
        }

        #endregion
    }
}
