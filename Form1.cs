using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(idnumber.Text);
            item.SubItems.Add(firstnametextbox.Text);
            item.SubItems.Add(lastnametextbox.Text);
            item.SubItems.Add(itemtextbox.Text);
            item.SubItems.Add(categorycombobox.Text);
            item.SubItems.Add(pricetextbox.Text);
            item.SubItems.Add(buyingsellingcombobox.Text);
            item.SubItems.Add(phonenumbertextbox.Text);
            item.SubItems.Add(emailtextbox.Text);
            ListView1.Items.Add(item); 
          
        }

        private void phonenumbertextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; 
            if (!Char.IsDigit(ch) && ch !=8)
            {
                e.Handled = true;
            }
        }

        private void idnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; 
            if (!Char.IsDigit(ch) && ch!=5)
            {
                e.Handled = true; 
            }
        }

        private void pricetextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; 
            if (!Char.IsDigit(ch) && ch!=10)
            {
                e.Handled = true; 
            }
        }
    }
}
