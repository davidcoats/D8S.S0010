using System;

using R5T.T0131;


namespace D8S.S0010
{
    [ValuesMarker]
    public partial interface IPropertyGroupXElementOperations : IValuesMarker,
        Common.IPropertyGroupXElementOperations,
        Rivet.IPropertyGroupXElementOperations,
        Personal.IPropertyGroupXElementOperations
    {

    }
}
