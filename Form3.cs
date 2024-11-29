using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tạo 1 dòng dữ liệu
            ListViewItem it = new ListViewItem(tbLastName.Text);
            //thêm cacs cột còn lại
            it.SubItems.Add(tbFirstname.Text);
            it.SubItems.Add(tbPhone.Text);
            lvThongTin.Items.Add(it);

            tbLastName.Text = "";
            tbFirstname.Text = "";
            tbPhone.Text = "";
        }

        private void lvThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lvThongTin.SelectedItems.Count > 0)
            {
                tbLastName.Text = lvThongTin.SelectedItems[0].SubItems[0].Text;
                tbFirstname.Text = lvThongTin.SelectedItems[0].SubItems[1].Text;
                tbPhone.Text = lvThongTin.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lvThongTin.SelectedItems[0].SubItems[0].Text = tbLastName.Text;
            lvThongTin.SelectedItems[0].SubItems[1].Text = tbFirstname.Text;
            lvThongTin.SelectedItems[0].SubItems[2].Text = tbPhone.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            lvThongTin.Items.Remove(lvThongTin.SelectedItems[0]);
            
        }

        
    }
}
