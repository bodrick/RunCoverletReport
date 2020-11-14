//namespace RunCoverletReport.PackageDetection
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Linq;
//    using System.Text;
//    using EnvDTE80;
//    using ExtensionManager;
//    using Microsoft.VisualStudio.ExtensionManager;
//    using Microsoft.VisualStudio.Shell;
//    using Microsoft.VisualStudio.Shell.Interop;
//    using VSLangProj;
//    using VSLangProj140;
//    using VSLangProj80;

// using Microsoft.VisualStudio.Shell;

// using VSLangProj150;

using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Shell;
using VSLangProj;
using VSLangProj150;

public class PackageDetector
{
    public PackageDetector()
    {
    }

    public async System.Threading.Tasks.Task X()
    {
        await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();

        try
        {
            EnvDTE.DTE dte;
            dte = (EnvDTE.DTE)Package.GetGlobalService(typeof(EnvDTE.DTE));

            EnvDTE.Project project;
            project = dte.Solution.Projects.Item(1);
            var projX = project.Object as VSProject;
            var imports = projX.Imports;
            ;
        }
        catch (Exception ex)
        {
            Debug.Write(ex.Message);
            throw;
        }

        // var vslangProj = (VSLangProj150.PackageReferences)project;

        // IVsSolution solution; solution = (IVsSolution)Package.GetGlobalService(typeof(SVsSolution));

        // IVsHierarchy hierarchy; int res = solution.GetProjectOfUniqueName(project.UniqueName, out hierarchy);

        // for (int i = 1; i <= dte.Solution.Projects.Count; i++) { var proj =
        // dte.Solution.Projects.Item(i); if (proj.Object is IVsProject4) { var vsProj = (VSProject3)proj.Object;

        // List<string> references = new List<string>(); foreach (Reference reference in
        // vsProj.References) { references.Add(reference.Name); }

        // var projInfo = (proj.Name, proj.FileName, references); } }
    }
}