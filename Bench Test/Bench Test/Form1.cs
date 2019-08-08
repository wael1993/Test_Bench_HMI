using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;


namespace Bench_Test
{
    public partial class Form1 : Form
    {
        private object ProgressBar1;
        // This is where everything is initialized, the main function
        public Form1()
        {
            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(2000); // Change loading time / 5000 = 5 sec
            
            trd.Abort();
            InitializeComponent();
            getAvailableports();

            // Add items to the list class combobox
            list_Baud.Items.Add("1");
            list_Baud.Items.Add("2");
            list_Baud.Items.Add("3");

            // Add items to the list size combobox
            list_size.Items.Add("0-N");
            list_size.Items.Add("0-L");
            list_size.Items.Add("1-N");
            list_size.Items.Add("1-L");
            list_size.Items.Add("2-N");
            list_size.Items.Add("2-L");
            list_size.Items.Add("3-N");
            list_size.Items.Add("3-L");
            list_size.Items.Add("4-N");
            list_size.Items.Add("4-L");
            list_size.Items.Add("5-N");
            list_size.Items.Add("5-L");
            list_size.Items.Add("check");

            // Change date inside the input date
            DateTime datetime = DateTime.Now;
            input_date.Text = datetime.ToString();
        }
        private void Button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "" || comboBox2.Text == "")
                {
                    textBox2.Text = "Please select port settings";
                }
                else
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                    serialPort1.Open();
                    progressBar1.Value = 100;
                    button3.Enabled = true;
                    button2.Enabled = true;
                    textBox16.Enabled = true;
                    button1.Enabled = false;
                    button4.Enabled = true;



                }

            }
            catch (UnauthorizedAccessException)
            {
                textBox2.Text = "Unothorized access exeption";
            }
        }
        void getAvailableports()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }
        private void formRun()
        {
            Application.Run(new Form_splash());
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void NewMethod()
        {
            // progressBar1.Value = 100;
        }
        // Fonction pour gérer l'export vers excel
        private void M_test_bench_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le rapport est entrain d'être exporté", "Excel");
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        //in case someone try to insert a fake class
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( list_Baud.Text != "1" && list_Baud.Text != "2" && list_Baud.Text != "3")
            {
                serrage1.BackColor = System.Drawing.Color.DarkGray;
                serrage2.BackColor = System.Drawing.Color.DarkGray;
                serrage3.BackColor = System.Drawing.Color.DarkGray;
                serrage4.BackColor = System.Drawing.Color.DarkGray;
                serrage5.BackColor = System.Drawing.Color.DarkGray;
                serrage6.BackColor = System.Drawing.Color.DarkGray;
                serrage7.BackColor = System.Drawing.Color.DarkGray;
                serrage8.BackColor = System.Drawing.Color.DarkGray;
            }
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }
        

        // Ici sont gérés les couleurs pour les niveaux de pressions
        // C'est aussi ici que sont gérés les cas ou on change la valeur d'une pression
        private void Serrage1_TextChanged(object sender, EventArgs e)
        {

            if (serrage1.TextLength > 0)
            {
                if (list_Baud.Text == "1")
                {
                    if (int.Parse(serrage1.Text) < 13)
                    {
                        serrage1.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage1.Text) > 13 && int.Parse(serrage1.Text) < 20)
                    {
                        serrage1.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage1.Text) > 20)
                    {
                        serrage1.BackColor = System.Drawing.Color.Red;
                    }
                }
                else if (list_Baud.Text == "2")
                {
                    if (int.Parse(serrage1.Text) < 20.1)
                    {
                        serrage1.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage1.Text) > 20.1 && int.Parse(serrage1.Text) < 27)
                    {
                        serrage1.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage1.Text) > 27)
                    {
                        serrage1.BackColor = System.Drawing.Color.Red;
                    }
                }
                else if (list_Baud.Text == "3")
                {
                    if (int.Parse(serrage1.Text) < 27.1)
                    {
                        serrage1.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage1.Text) > 27.1 && int.Parse(serrage1.Text) < 46)
                    {
                        serrage1.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage1.Text) > 46)
                    {
                        serrage1.BackColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    serrage1.Text = "Pas de classe";
                }
            }

        }

        private void Serrage2_TextChanged(object sender, EventArgs e)
        {
            if (serrage2.TextLength > 0)
            {
                if (list_Baud.Text == "1")
                {
                    if (int.Parse(serrage2.Text) < 13)
                    {
                        serrage2.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage2.Text) > 13 && int.Parse(serrage2.Text) < 20)
                    {
                        serrage2.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage2.Text) > 20)
                    {
                        serrage2.BackColor = System.Drawing.Color.Red;
                    }
                }
                else if (list_Baud.Text == "2")
                {
                    if (int.Parse(serrage2.Text) < 20.1)
                    {
                        serrage2.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage2.Text) > 20.1 && int.Parse(serrage2.Text) < 27)
                    {
                        serrage2.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage2.Text) > 27)
                    {
                        serrage2.BackColor = System.Drawing.Color.Red;
                    }
                }
                else if (list_Baud.Text == "3")
                {
                    if (int.Parse(serrage2.Text) < 27.1)
                    {
                        serrage2.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage2.Text) > 27.1 && int.Parse(serrage2.Text) < 46)
                    {
                        serrage2.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage2.Text) > 46)
                    {
                        serrage2.BackColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    serrage2.Text = "Pas de classe";
                }
            }
        }

        private void Serrage3_TextChanged(object sender, EventArgs e)
        {
            if (serrage3.TextLength > 0)
            {
                if (list_Baud.Text == "1")
                {
                    if (int.Parse(serrage3.Text) < 13)
                    {
                        serrage3.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage3.Text) > 13 && int.Parse(serrage3.Text) < 20)
                    {
                        serrage3.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage3.Text) > 20)
                    {
                        serrage3.BackColor = System.Drawing.Color.Red;
                    }
                }
                else if (list_Baud.Text == "2")
                {
                    if (int.Parse(serrage3.Text) < 20.1)
                    {
                        serrage3.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage3.Text) > 20.1 && int.Parse(serrage3.Text) < 27)
                    {
                        serrage3.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage3.Text) > 27)
                    {
                        serrage3.BackColor = System.Drawing.Color.Red;
                    }
                }
                else if (list_Baud.Text == "3")
                {
                    if (int.Parse(serrage3.Text) < 27.1)
                    {
                        serrage3.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage3.Text) > 27.1 && int.Parse(serrage3.Text) < 46)
                    {
                        serrage3.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage3.Text) > 46)
                    {
                        serrage3.BackColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    serrage3.Text = "Pas de classe";
                }
            }
        }

        private void Serrage4_TextChanged(object sender, EventArgs e)
        {
            if (serrage4.TextLength > 0)
            {
                if (list_Baud.Text == "1")
                {
                    if (int.Parse(serrage4.Text) < 13)
                    {
                        serrage4.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage4.Text) > 13 && int.Parse(serrage4.Text) < 20)
                    {
                        serrage4.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage4.Text) > 20)
                    {
                        serrage4.BackColor = System.Drawing.Color.Red;
                    }
                }
                else if (list_Baud.Text == "2")
                {
                    if (int.Parse(serrage4.Text) < 20.1)
                    {
                        serrage4.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage4.Text) > 20.1 && int.Parse(serrage4.Text) < 27)
                    {
                        serrage4.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage4.Text) > 27)
                    {
                        serrage4.BackColor = System.Drawing.Color.Red;
                    }
                }
                else if (list_Baud.Text == "3")
                {
                    if (int.Parse(serrage4.Text) < 27.1)
                    {
                        serrage4.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage4.Text) > 27.1 && int.Parse(serrage4.Text) < 46)
                    {
                        serrage4.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage4.Text) > 46)
                    {
                        serrage4.BackColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    serrage4.Text = "Pas de classe";
                }
            }
        }

        private void Serrage5_TextChanged(object sender, EventArgs e)
        {
            if (serrage5.TextLength > 0)
            {
                if (list_Baud.Text == "1")
                {
                    if (int.Parse(serrage5.Text) < 13)
                    {
                        serrage5.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage5.Text) > 13 && int.Parse(serrage5.Text) < 20)
                    {
                        serrage5.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage5.Text) > 20)
                    {
                        serrage5.BackColor = System.Drawing.Color.Red;
                    }
                }
                else if (list_Baud.Text == "2")
                {
                    if (int.Parse(serrage5.Text) < 20.1)
                    {
                        serrage5.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage5.Text) > 20.1 && int.Parse(serrage5.Text) < 27)
                    {
                        serrage5.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage5.Text) > 27)
                    {
                        serrage5.BackColor = System.Drawing.Color.Red;
                    }
                }
                else if (list_Baud.Text == "3")
                {
                    if (int.Parse(serrage5.Text) < 27.1)
                    {
                        serrage5.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage5.Text) > 27.1 && int.Parse(serrage5.Text) < 46)
                    {
                        serrage5.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage5.Text) > 46)
                    {
                        serrage5.BackColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    serrage5.Text = "Pas de classe";
                }
            }
        }

        private void Serrage6_TextChanged(object sender, EventArgs e)
        {
            if (serrage6.TextLength > 0)
            {
                if (list_Baud.Text == "1")
                {
                    if (int.Parse(serrage6.Text) < 13)
                    {
                        serrage6.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage6.Text) > 13 && int.Parse(serrage6.Text) < 20)
                    {
                        serrage6.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage6.Text) > 20)
                    {
                        serrage6.BackColor = System.Drawing.Color.Red;
                    }
                }
                else if (list_Baud.Text == "2")
                {
                    if (int.Parse(serrage6.Text) < 20.1)
                    {
                        serrage6.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage6.Text) > 20.1 && int.Parse(serrage6.Text) < 27)
                    {
                        serrage6.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage6.Text) > 27)
                    {
                        serrage6.BackColor = System.Drawing.Color.Red;
                    }
                }
                else if (list_Baud.Text == "3")
                {
                    if (int.Parse(serrage6.Text) < 27.1)
                    {
                        serrage6.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage6.Text) > 27.1 && int.Parse(serrage6.Text) < 46)
                    {
                        serrage6.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage6.Text) > 46)
                    {
                        serrage6.BackColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    serrage6.Text = "Pas de classe";
                }
            }
        }

        private void Serrage7_TextChanged(object sender, EventArgs e)
        {
            if (serrage7.TextLength > 0)
            {
                if (list_Baud.Text == "1")
                {
                    if (int.Parse(serrage7.Text) < 13)
                    {
                        serrage7.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage7.Text) > 13 && int.Parse(serrage7.Text) < 20)
                    {
                        serrage7.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage7.Text) > 20)
                    {
                        serrage7.BackColor = System.Drawing.Color.Red;
                    }
                }
                else if (list_Baud.Text == "2")
                {
                    if (int.Parse(serrage7.Text) < 20.1)
                    {
                        serrage7.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage7.Text) > 20.1 && int.Parse(serrage7.Text) < 27)
                    {
                        serrage7.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage7.Text) > 27)
                    {
                        serrage7.BackColor = System.Drawing.Color.Red;
                    }
                }
                else if (list_Baud.Text == "3")
                {
                    if (int.Parse(serrage7.Text) < 27.1)
                    {
                        serrage7.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage7.Text) > 27.1 && int.Parse(serrage7.Text) < 46)
                    {
                        serrage7.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage7.Text) > 46)
                    {
                        serrage7.BackColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    serrage7.Text = "Pas de classe";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Serrage8_TextChanged(object sender, EventArgs e)
        {
            if (serrage8.TextLength > 0)
            {
                if (list_Baud.Text == "1")
                {
                    if (int.Parse(serrage8.Text) < 13)
                    {
                        serrage8.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage8.Text) > 13 && int.Parse(serrage8.Text) < 20)
                    {
                        serrage8.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage8.Text) > 20)
                    {
                        serrage8.BackColor = System.Drawing.Color.Red;
                    }
                }
                else if (list_Baud.Text == "2")
                {
                    if (int.Parse(serrage8.Text) < 20.1)
                    {
                        serrage8.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage8.Text) > 20.1 && int.Parse(serrage8.Text) < 27)
                    {
                        serrage8.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage8.Text) > 27)
                    {
                        serrage8.BackColor = System.Drawing.Color.Red;
                    }
                }
                else if (list_Baud.Text == "3")
                {
                    if (int.Parse(serrage8.Text) < 27.1)
                    {
                        serrage8.BackColor = System.Drawing.Color.Red;
                    }
                    else if (int.Parse(serrage8.Text) > 27.1 && int.Parse(serrage8.Text) < 46)
                    {
                        serrage8.BackColor = System.Drawing.Color.Green;
                    }
                    else if (int.Parse(serrage8.Text) > 46)
                    {
                        serrage8.BackColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    serrage8.Text = "Pas de classe";
                }
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            
        }

        private void Tests_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            var rnd = random.Next(1, 60);
            serrage1.Text = rnd+"";
            rnd = random.Next(1, 60);
            serrage2.Text = rnd + "";
            rnd = random.Next(1, 60);
            serrage3.Text = rnd + "";
            rnd = random.Next(1, 60);
            serrage4.Text = rnd + "";
            rnd = random.Next(1, 60);
            serrage5.Text = rnd + "";
            rnd = random.Next(1, 60);
            serrage6.Text = rnd + "";
            rnd = random.Next(1, 60);
            serrage7.Text = rnd + "";
            rnd = random.Next(1, 60);
            serrage8.Text = rnd + "";
            

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ProgressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox15.Text = serialPort1.ReadLine();
            }
            catch (TimeoutException)
            {
                textBox15.Text = "Timeout Exeption";
            }
        }

       

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar1.Value = 0;
            button3.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = true;
            textBox16.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(textBox16.Text);
            textBox16.Text = "";
        }

        private void TextBox16_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
