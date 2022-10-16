using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class OpenFileDialog
    {
        // Source: https://www.pinvoke.net/default.aspx/Structures/OPENFILENAME.html
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private struct OpenFileName
        {
            public int lStructSize;
            public IntPtr hwndOwner;
            public IntPtr hInstance;
            public string lpstrFilter;
            public string lpstrCustomFilter;
            public int nMaxCustFilter;
            public int nFilterIndex;
            public string lpstrFile;
            public int nMaxFile;
            public string lpstrFileTitle;
            public int nMaxFileTitle;
            public string lpstrInitialDir;
            public string lpstrTitle;
            public int Flags;
            public short nFileOffset;
            public short nFileExtension;
            public string lpstrDefExt;
            public IntPtr lCustData;
            public IntPtr lpfnHook;
            public string lpTemplateName;
            public IntPtr pvReserved;
            public int dwReserved;
            public int flagsEx;
        }

        // Source: https://www.pinvoke.net/default.aspx/comdlg32/GetOpenFileName.html
        [DllImport("comdlg32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern bool GetOpenFileName(ref OpenFileName ofn);

        public string GetFileName()
        {
            var ofn = new OpenFileName();
            ofn.lStructSize = Marshal.SizeOf(ofn);
            // Define Filter for your extensions (Excel, ...)
            ofn.lpstrFilter = "XML Files (*.xml)\0*.xml\0";
            ofn.lpstrFile = new string(new char[256]);
            ofn.nMaxFile = ofn.lpstrFile.Length;
            ofn.lpstrFileTitle = new string(new char[64]);
            ofn.nMaxFileTitle = ofn.lpstrFileTitle.Length;
            ofn.lpstrTitle = "Open File Dialog...";
            if (GetOpenFileName(ref ofn))
                return ofn.lpstrFile;
            return string.Empty;
        }
    }
}
