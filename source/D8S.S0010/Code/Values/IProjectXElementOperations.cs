using System;

using R5T.T0131;


namespace D8S.S0010
{
    [ValuesMarker]
    public partial interface IProjectXElementOperations : IValuesMarker,
        Common.IProjectXElementOperations,
        Rivet.IProjectXElementOperations,
        Personal.IProjectXElementOperations
    {

    }
}
