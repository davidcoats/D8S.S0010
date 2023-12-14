using System;

using R5T.T0131;


namespace D8S.S0010.Personal.Raw
{
    [ValuesMarker]
    public partial interface IAuthors : IValuesMarker
    {
        /// <summary>
        /// "DCoats", see <see href="https://www.nuget.org/profiles/DCoats"/>.
        /// </summary>
        public string DCoats => "DCoats";
    }
}
