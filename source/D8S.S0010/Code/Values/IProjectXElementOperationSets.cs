using System;

using R5T.T0131;


namespace D8S.S0010
{
    [ValuesMarker]
    public partial interface IProjectXElementOperationSets : IValuesMarker,
        Common.IProjectXElementOperationSets,
        Rivet.IProjectXElementOperationSets,
        Personal.IProjectXElementOperationSets
    {
#pragma warning disable IDE1006 // Naming Styles
        public Common.IProjectXElementOperationSets _Common => Common.ProjectXElementOperationSets.Instance;
        public Rivet.IProjectXElementOperationSets _Rivet => Rivet.ProjectXElementOperationSets.Instance;
        public Personal.IProjectXElementOperationSets _Personal => Personal.ProjectXElementOperationSets.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
