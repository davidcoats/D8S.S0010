using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

using R5T.T0131;


namespace D8S.S0010
{
    [ValuesMarker]
    public partial interface IHasProjectElementOperations : IValuesMarker
    {
        public Action<R5T.L0032.T000.IHasProjectElement> In_XElementContext(
            IEnumerable<Action<XElement>> elementActions) =>
            hasProjectElement => Instances.ContextOperator.In_Context(
                hasProjectElement.ProjectElement.Value,
                elementActions);

        public Action<R5T.L0032.T000.IHasProjectElement> In_XElementContext(
            params Action<XElement>[] elementActions) =>
            this.In_XElementContext(elementActions.AsEnumerable());
    }
}
