using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Bench_Test
{
    static class Program
    {
        /// <summary>
        /// GUI Created by Quentin OTERNAUD for a wonderful person name Wael BEN JEMAA
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
