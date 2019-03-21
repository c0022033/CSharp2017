using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        private System.Threading.SynchronizationContext _ContextUI;

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Delay(5000);

            label1.Text = "1";

            await Task.Delay(5000);

            label1.Text = "2";

            await Task.Delay(5000);

            label1.Text = "3";


            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _ContextUI = SynchronizationContext.Current;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                System.Threading.Thread.Sleep(5000);
                _ContextUI.Post(x =>
                {
                    label1.Text = "1";
                }, null);
                System.Threading.Thread.Sleep(5000);
                _ContextUI.Post(x =>
                {
                    label1.Text = "2";
                }, null);
                System.Threading.Thread.Sleep(5000);
                _ContextUI.Post(x =>
                {
                    label1.Text = "3";
                }, null);
            });
        }
    }
}
