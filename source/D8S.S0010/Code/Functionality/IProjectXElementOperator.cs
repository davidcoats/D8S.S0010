using System;

using R5T.T0132;


namespace D8S.S0010
{
    /// <summary>
    /// All (common, non-Rivet, and non-personal) XElement-level project element functionality.
    /// </summary>
    [FunctionalityMarker]
    public partial interface IProjectXElementOperator : IFunctionalityMarker,
        Common.IProjectXElementOperator,
        Rivet.IProjectXElementOperator,
        Personal.IProjectXElementOperator
    {

    }
}
