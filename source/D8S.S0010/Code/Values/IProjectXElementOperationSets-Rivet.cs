using System;
using System.Collections.Generic;
using System.Xml.Linq;

using R5T.T0131;


namespace D8S.S0010.Rivet
{
    [ValuesMarker]
    public partial interface IProjectXElementOperationSets : IValuesMarker
    {
        public IEnumerable<Action<XElement>> Net_8_Console(
            string expectedProjectFilePath,
            string projectDescription,
            IEnumerable<string> referenceProjectFilePaths,
            Action<XElement> setRepositoryUrl = default
        )
            => Instances.EnumerableOperator.From(
            Instances.ProjectXElementOperations.Set_SDK_NET,
            Instances.ProjectXElementOperations.In_NewPropertyGroupXElementContext(
                Instances.PropertyGroupXElementOperations.Set_Label_Main,
                Instances.PropertyGroupXElementOperations.Set_OutputType_Exe,
                Instances.PropertyGroupXElementOperations.Set_TargetFramework_Default,
                Instances.PropertyGroupXElementOperations.Enable_ImplicitUsings,
                Instances.PropertyGroupXElementOperations.Enable_Nullable
            ),
            Instances.ProjectXElementOperations.In_NewPropertyGroupXElementContext(
                Instances.PropertyGroupXElementOperations.Set_Label_Package,
                Instances.PropertyGroupXElementOperations.Set_Version_Initial_Default,
                Instances.PropertyGroupXElementOperations.Set_Authors_DCoats,
                Instances.PropertyGroupXElementOperations.Set_Company_Rivet,
                Instances.PropertyGroupXElementOperations.Set_Copyright_Rivet,
                Instances.PropertyGroupXElementOperations.Set_Description(projectDescription),
                Instances.PropertyGroupXElementOperations.Set_PackageLicenseExpression_MIT,
                Instances.PropertyGroupXElementOperations.Set_PackageRequireLicenseAcceptance,
                setRepositoryUrl
            ),
            Instances.ProjectXElementOperations.In_NewItemGroupXElementContext(
                Instances.ItemGroupXElementOperations.Set_Label_ProjectReferences,
                Instances.ItemGroupXElementOperations.Add_ProjectReferences(
                    expectedProjectFilePath,
                    referenceProjectFilePaths)
            )
        );

        public IEnumerable<Action<XElement>> Console_WithCOMReference(
            string expectedProjectFilePath,
            string projectDescription,
            IEnumerable<string> referenceProjectFilePaths,
            Action<XElement> setRepositoryUrl = default
        )
            => Instances.EnumerableOperator.From(
            Instances.ProjectXElementOperations.Set_SDK_NET,
            Instances.ProjectXElementOperations.In_NewPropertyGroupXElementContext(
                Instances.PropertyGroupXElementOperations.Set_Label_Main,
                Instances.PropertyGroupXElementOperations.Set_OutputType_Exe,
                Instances.PropertyGroupXElementOperations.Set_TargetFramework_Default,
                Instances.PropertyGroupXElementOperations.Enable_ImplicitUsings,
                Instances.PropertyGroupXElementOperations.Enable_Nullable
            ),
            Instances.ProjectXElementOperations.In_NewPropertyGroupXElementContext(
                Instances.PropertyGroupXElementOperations.Set_Label_Package,
                Instances.PropertyGroupXElementOperations.Set_Version_Initial_Default,
                Instances.PropertyGroupXElementOperations.Set_Authors_DCoats,
                Instances.PropertyGroupXElementOperations.Set_Company_Rivet,
                Instances.PropertyGroupXElementOperations.Set_Copyright_Rivet,
                Instances.PropertyGroupXElementOperations.Set_Description(projectDescription),
                Instances.PropertyGroupXElementOperations.Set_PackageLicenseExpression_MIT,
                Instances.PropertyGroupXElementOperations.Set_PackageRequireLicenseAcceptance,
                setRepositoryUrl
            ),
            Instances.ProjectXElementOperations.In_NewItemGroupXElementContext(
                Instances.ItemGroupXElementOperations.Set_Label_ProjectReferences,
                Instances.ItemGroupXElementOperations.Add_ProjectReferences(
                    expectedProjectFilePath,
                    referenceProjectFilePaths)
            ),
            Instances.ProjectXElementOperations.In_NewItemGroupXElementContext(
                Instances.ItemGroupXElementOperations.Set_Label_COMReferences,
                Instances.ItemGroupXElementOperations.Add_COMReference(
                    Instances.COMReferences.Microsoft_Office_Interop_Excel)
            )
        );
    }
}
