using System;

using R5T.T0131;
using R5T.T0143;


namespace D8S.S0010
{
    [ValuesMarker]
    public partial interface IProjectXElementOperationSets : IValuesMarker,
        Common.IProjectXElementOperationSets,
        Rivet.IProjectXElementOperationSets,
        Personal.IProjectXElementOperationSets
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Common.IProjectXElementOperationSets _Common => Common.ProjectXElementOperationSets.Instance;

        [Ignore]
        public Rivet.IProjectXElementOperationSets _Rivet => Rivet.ProjectXElementOperationSets.Instance;

        [Ignore]
        public Personal.IProjectXElementOperationSets _Personal => Personal.ProjectXElementOperationSets.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
