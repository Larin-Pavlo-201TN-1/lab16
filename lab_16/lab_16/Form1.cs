using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSearch1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            e.Handled = true;
        }

        private void txtSearch2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            e.Handled = true;
        }

        private void Search1_Click(object sender, EventArgs e)
        {
            char[] sign = new char[] { ';' };
            ARR arr1 = new ARR(txtArr1.Text.Split(sign, StringSplitOptions.RemoveEmptyEntries));
            int n = Convert.ToInt32(txtSearch1.Text);
            string m = arr1.search(n);
            result5.Text = m;
        }

        private void Search2_Click(object sender, EventArgs e)
        {
            char[] sign = new char[] { ';' };
            ARR arr2 = new ARR(txtArr2.Text.Split(sign, StringSplitOptions.RemoveEmptyEntries));
            int n = Convert.ToInt32(txtSearch2.Text);
            string m = arr2.search(n);
            result6.Text = m;
        }

        private void Write_Click(object sender, EventArgs e)
        {
            char[] sign = new char[] { ';' };
            ARR arr1 = new ARR(txtArr1.Text.Split(sign, StringSplitOptions.RemoveEmptyEntries));
            ARR arr2 = new ARR(txtArr2.Text.Split(sign, StringSplitOptions.RemoveEmptyEntries));
            result1.Text = arr1.Write();
            result2.Text = arr2.Write();
            ARR arr3 = arr1.ADD(arr2);
            result3.Text = arr3.Write();
            ARR arr4 = arr1.AddAndRemovingDuplicates(arr3);
            result4.Text = arr4.Write();

        }
    }
}
