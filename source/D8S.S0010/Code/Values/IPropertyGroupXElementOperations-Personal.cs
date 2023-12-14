using System;
using System.Xml.Linq;

using R5T.T0131;


namespace D8S.S0010.Personal
{
    [ValuesMarker]
    public partial interface IPropertyGroupXElementOperations : IValuesMarker
    {
        public Action<XElement> Set_Authors_DCoats =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_Authors(
                propertyGroupElement,
                Instances.Authors.DCoats.Value);
    }
}
