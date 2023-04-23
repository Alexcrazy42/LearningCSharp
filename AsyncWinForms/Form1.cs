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
        }

        async private void button1_Click(object sender, EventArgs e)
        {

            await Task.Run(() =>
            {
                MessageBox.Show($"задача началась в потоке {Thread.CurrentThread.ManagedThreadId}");
            }
            );

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
            MessageBox.Show($"задача завершилась в потоке {Thread.CurrentThread.ManagedThreadId}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 150)
            {
                Thread.Sleep(100);
                i++;
                label2.Text = i.ToString();
            }
        }
    }
}
