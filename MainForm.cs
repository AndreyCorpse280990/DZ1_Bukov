using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ1_Bukov
{
    public partial class MainForm : Form
    {
        private bool isTextChanged = false;
        public MainForm()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (!isTextChanged)
            {
                label3.Text = "Текст любой";
                isTextChanged = true;
            }
            else
            {
                label3.Text = "Любой текст";
                isTextChanged = false;
            }           
        }

        private void Exit_click(object sender, EventArgs e)
        {
            Close();
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult reply = MessageBox.Show(
               "Вы действительно хотите выйти?", "Выход",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question
           );
            if (reply == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
