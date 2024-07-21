using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphQL.Types;
using System.Reflection;
using OnePiece1.formss;
using DevExpress.XtraEditors;
using OnePiece1.frm;
using OnePiece1.forms;
using DevExpress.LookAndFeel;
using OnePiece1.Properties;
using OnePiece1.dal;
using OnePiece1.Class;

namespace OnePiece1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        //Frm_Invoce(Class.master.InvoiceType.purchase) شاشة الفاتوره
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserLookAndFeel.Default.SkinName = Settings.Default.SkinName.ToString();
            UserLookAndFeel.Default.SetSkinStyle(Settings.Default.SkinName.ToString(), Settings.Default.PaletteName.ToString());
            new frm_Login().Show();
            Application.Run();
            
        }
     
        
    }
}
