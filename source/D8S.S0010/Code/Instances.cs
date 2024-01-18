using System;


namespace D8S.S0010
{
    public class Instances :
        R5T.L0055.Instances
    {
        public static R5T.L0066.IActionOperator ActionOperator => R5T.L0066.ActionOperator.Instance;
        public static R5T.L0066.IActions Actions => R5T.L0066.Actions.Instance;
        public static R5T.Z0051.ICOMReferences COMReferences => R5T.Z0051.COMReferences.Instance;
        public static R5T.L0066.IContextOperator ContextOperator => R5T.L0066.ContextOperator.Instance;
        public static R5T.L0032.Z002.IGroupLabels GroupLabels => R5T.L0032.Z002.GroupLabels.Instance;
        public static R5T.Z0050.Z001.IPackageReferences PackageReferences => R5T.Z0050.Z001.PackageReferences.Instance;
        public static R5T.L0033.F001.IProjectElementContextOperator ProjectElementContextOperator => R5T.L0033.F001.ProjectElementContextOperator.Instance;
        public static R5T.L0032.F003.IValues Values => R5T.L0032.F003.Values.Instance;

        public static IAuthors Authors => S0010.Authors.Instance;
        public static IItemGroupXElementOperations ItemGroupXElementOperations => S0010.ItemGroupXElementOperations.Instance;
        public static IItemGroupXElementOperator ItemGroupXElementOperator => S0010.ItemGroupXElementOperator.Instance;
        public static IProjectXElementOperations ProjectXElementOperations => S0010.ProjectXElementOperations.Instance;
        public static IProjectXElementOperationSets ProjectXElementOperationSets => S0010.ProjectXElementOperationSets.Instance;
        public static IProjectXElementOperator ProjectXElementOperator => S0010.ProjectXElementOperator.Instance;
        public static IPropertyGroupXElementOperations PropertyGroupXElementOperations => S0010.PropertyGroupXElementOperations.Instance;
        public static IPropertyGroupXElementOperator PropertyGroupXElementOperator => S0010.PropertyGroupXElementOperator.Instance;

        public static IHasProjectElementOperations HasProjectElementOperations => S0010.HasProjectElementOperations.Instance;
        public static N001.IHasProjectElementOperations HasProjectElementOperations_N001 => N001.HasProjectElementOperations.Instance;
        public static IOperator Operator => S0010.Operator.Instance;
    }
}