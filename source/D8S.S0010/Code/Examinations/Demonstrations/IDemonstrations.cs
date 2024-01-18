using System;

using R5T.L0032.T000.Extensions;
using R5T.T0141;


namespace D8S.S0010
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        public void In_ProjectElementContext()
        {
            /// Inputs.
            var expectedProjectFilePath = Instances.FilePaths.Example_ProjectFilePath;
            var referenceProjectFilePaths = new[]
            {
                @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0000\source\R5T.F0000\R5T.F0000.csproj",
                @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.NG0010\source\R5T.NG0010\R5T.NG0010.csproj"
            };
            var projectDescription =
                //Instances.Values.DescriptionForProject_Default
                Instances.Values.DescriptionForProject_Example
                ;


            /// Run.
            var projectXElementContextActions = Instances.ProjectXElementOperationSets
                //._Common.Net_8_Console
                //._Rivet.Net_8_Console(
                //    expectedProjectFilePath.Value,
                //    projectDescription,
                //    referenceProjectFilePaths,
                //    Instances.PropertyGroupXElementOperations.Set_RepositoryUrl("https://github.com/SafetyCone/R5T.F0069.git"))
                //._Rivet.Console_WithCOMReference(
                //    expectedProjectFilePath.Value,
                //    projectDescription,
                //    referenceProjectFilePaths,
                //    Instances.PropertyGroupXElementOperations.Set_RepositoryUrl("https://github.com/SafetyCone/R5T.F0069.git"))
                //._Common.BlazorWebAssemblyClient_Net_8
                ._Rivet.BlazorWebAssemblyClient_Net_8(
                    projectDescription,
                    Instances.Authors.DCoats.Value,
                    Instances.PropertyGroupXElementOperations.Set_RepositoryUrl("https://github.com/SafetyCone/R5T.F0069.git"))
                ;

            var (writtenProjectFilePath, humanOutputTextFilePath, _) = Instances.Operator.In_SampleProjectFileContext(
                nameof(In_ProjectElementContext),
                Instances.HasProjectElementOperations.In_XElementContext(projectXElementContextActions));

            Instances.NotepadPlusPlusOperator.Open(
                //humanOutputTextFilePath,
                writtenProjectFilePath);
        }

        /// <summary>
        /// A first demonstration of working in a project element context.
        /// </summary>
        public void In_ProjectElementContext_First()
        {
            /// Inputs.
            var projectFilePath = Instances.FilePaths.Sample_ProjectFilePath;


            /// Run.
            var (humanOutputTextFilePath, logFilePath) = Instances.TextOutputOperator.In_TextOutputContext_Synchronous(
                nameof(In_ProjectElementContext_First),
                textOutput =>
                {
                    var projectElement = Instances.ProjectXElementOperator.New_ProjectXElement()
                        .ToProjectElement();

                    var projectElementContextActions = Instances.EnumerableOperator.From<Action<R5T.L0033.T000.N001.IProjectElementContext>>(
                        // Shows how XElement-level methods can be used on either an XElement- or IProjectElement-level abstraction.
                        Instances.HasProjectElementOperations.In_XElementContext(
                            Instances.Actions.DoNothing_Synchronous),
                        Instances.HasProjectElementOperations_N001.In_XElementContext(
                            Instances.Actions.DoNothing_Synchronous)
                    );

                    Instances.ProjectElementContextOperator.In_Context(
                        projectElement,
                        projectFilePath,
                        textOutput,
                        projectElementContextActions);

                    Instances.ProjectXElementOperator.To_File_Separated_Synchronous(
                        projectFilePath,
                        projectElement);
                });

            Instances.NotepadPlusPlusOperator.Open(
                projectFilePath,
                humanOutputTextFilePath);
        }
    }
}
