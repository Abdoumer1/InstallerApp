using System;
using System.Collections.Generic;

namespace InstallerApp.Class
{
    public static class informations
    {
        public static string appname;
        public static string appver;
        public static string apppubl;
        public static string appweb;
        public static string folder = null;
        public static string direct = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string filename;
        public static string filetype;
        public static string filemain;
        public static List<string> selectedFilePaths = new List<string>();
        public static List<string> selectedFolderPaths = new List<string>();
    }
}
