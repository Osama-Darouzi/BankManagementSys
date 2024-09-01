using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BankBusinessLayer
{
    public static class AppGlobals
    {
        public static clsUser SysUser;

        public static string AppDataPath = @"C:\Users\ASUS\AppData\Roaming\MyBank\";

        static AppGlobals()
        {
            if (!Directory.Exists(AppDataPath))
            {
                Directory.CreateDirectory(AppDataPath);
            }
        }
    }
}
