using System.IO;
using System.Security.AccessControl;

namespace Chapter4
{
    public static class DirectoryInfoExample
    {
        public static void HowToGrantAccess()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("TestDirectory");
            directoryInfo.Create();
            DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();
            directorySecurity.AddAccessRule(
                    new FileSystemAccessRule("everyone",
                        FileSystemRights.ReadAndExecute,
                        AccessControlType.Allow));
            directoryInfo.SetAccessControl(directorySecurity);
        }
    }
}