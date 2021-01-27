using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace TAD_website
{
    class Program
    {
        static void Main(string[] args)
        {
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "cmd.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;
            p.StartInfo = info;
            p.Start();
            using (StreamWriter sw = p.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("conda activate website_prod");
                    sw.WriteLine("flask run");
                }
            }
        }
    }
}
