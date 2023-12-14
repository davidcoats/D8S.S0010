using System;
using System.Collections.Generic;
using System.Xml.Linq;

using R5T.T0131;


namespace D8S.S0010.Common
{
    [ValuesMarker]
    public partial interface IProjectXElementOperationSets : IValuesMarker
    {
        public IEnumerable<Action<XElement>> Net_8_Console => Instances.EnumerableOperator.From(
            Instances.ProjectXElementOperations.Set_SDK_NET,
            Instances.ProjectXElementOperations.In_NewPropertyGroupXElementContext(
                Instances.PropertyGroupXElementOperations.Set_OutputType_Exe,
                Instances.PropertyGroupXElementOperations.Set_TargetFramework_Default,
                Instances.PropertyGroupXElementOperations.Enable_ImplicitUsings,
                Instances.PropertyGroupXElementOperations.Enable_Nullable
            )
        );
    }
}
