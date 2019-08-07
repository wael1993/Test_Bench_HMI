using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bench_Test
{
    
    public partial class Form_splash : Form
    {
        public static int move = 0;
        public Form_splash()
        {
            InitializeComponent();
            // Initialize the loading bar
            timer1.Start();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Function that make the slidebar slide, ahah
        private void Timer1_Tick(object sender, EventArgs e)
        {
            panel_slide.Left += 2;

            if(panel_slide.Left > 574)
            {
                panel_slide.Left = 318;
            }
            if (panel_slide.Left < 0)
            {
               move = 2;
            }

        }
    }
}
