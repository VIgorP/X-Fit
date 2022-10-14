using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace FitnessClub
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
       public static ClassBaseFIT BaseFIT = new ClassBaseFIT();
       public static Boolean modified;
       public static string selectspr = "";
       public static Boolean insert;
       public static Boolean guest=false;
       public static readonly string UserTempdir = Path.GetTempPath();
    }


}
