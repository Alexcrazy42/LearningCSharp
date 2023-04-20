using System;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace AsyncWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "1";
        }

        async private void button1_Click(object sender, EventArgs e)
        {



            int i = 0;
            await Task.Run(async () =>
            {

                while (i < 1000)
                {
                    await Task.Delay(100);
                    i++;
                    label1.Text = i.ToString();
                }
            }
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = (Int32.Parse(label2.Text) + 1).ToString();
        }
    }
}
