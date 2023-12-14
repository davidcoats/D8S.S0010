using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;
using R5T.T0172;
using R5T.T0181;


namespace D8S.S0010
{
    [FunctionalityMarker]
    public partial interface IOperator : IFunctionalityMarker
    {
        public (IProjectFilePath writtenProjectFilePath, ITextFilePath humanOutputTextFilePath, ILogFilePath logFilePath)
            In_SampleProjectFileContext(
            string logCategoryName,
            IEnumerable<Action<R5T.L0033.T000.N001.IProjectElementContext>> projectElementContextActions)
        {
            var projectFilePath = Instances.FilePaths.Sample_ProjectFilePath;

            var (humanOutputTextFilePath, logFilePath) = Instances.TextOutputOperator.In_TextOutputContext_Synchronous(
                logCategoryName,
                textOutput =>
                {
                    var projectElement = Instances.ProjectElementContextOperator.In_NewProjectElementContext(
                        projectFilePath,
                        textOutput,
                        projectElementContextActions);

                    Instances.ProjectXElementOperator.To_File_Separated_Synchronous(
                        projectFilePath,
                        projectElement);
                });

            return (projectFilePath, humanOutputTextFilePath, logFilePath);
        }

        public (IProjectFilePath writtenProjectFilePath, ITextFilePath humanOutputTextFilePath, ILogFilePath logFilePath)
            In_SampleProjectFileContext(
            string logCategoryName,
            params Action<R5T.L0033.T000.N001.IProjectElementContext>[] projectElementContextActions)
        {
            return this.In_SampleProjectFileContext(
                logCategoryName,
                projectElementContextActions.AsEnumerable());
        }
    }
}
