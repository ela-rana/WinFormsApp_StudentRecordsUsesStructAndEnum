//Coded using C# Windows Forms App on .NET Framework 4.8 on Visual Studio 2022
//A program to do the following:
//Create a form where user can enter, view and delete student records
//Records are not saved to a database or file and only exists during program run

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDataStoreUsingStruct
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
