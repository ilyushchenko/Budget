using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget
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
            Fabric fabric = new Fabric();
            Categories cat = fabric.GetCategories();
            Application.Run(new Budget(fabric.GetArticles(), cat));
        }
    }
}
