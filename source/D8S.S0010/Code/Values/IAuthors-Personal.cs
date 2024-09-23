using System;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;
using R5T.T0131;
using R5T.T0143;


namespace D8S.S0010.Personal
{
    [ValuesMarker]
    public partial interface IAuthors : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IAuthors _Raw => Raw.Authors.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IAuthors.DCoats"/>
        public INugetUserName DCoats => _Raw.DCoats.ToNugetUserName();
    }
}
