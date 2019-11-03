using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace GregApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 100; x++)
            {
                String pathName = (x + ".txt");
                String fileName = "C:\\Users\\Slodysko\\Dropbox\\Remote_Control\\" + pathName;

                if (File.Exists(fileName))
                {
                    // execute exe

                    String exeFile = "F:\\nutcracker-xlights\\Sequences\\Shows\\AutoIt Exec files\\" + pathName;

                    Process.Start(exeFile);

                    // wait two seconds

                    Thread.Sleep(2000);

                    // delete file
                    File.Delete(fileName);
                }
            }

        }
    }
}
