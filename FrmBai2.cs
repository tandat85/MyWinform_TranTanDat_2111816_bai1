using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinform_TranTanDat_bai1
{
    public partial class FrmBai2 : Form
    {
        public FrmBai2()
        {
            InitializeComponent();
        }

        private void FrmBai2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox2.Items.Add(item);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soTien = 0;

            foreach ( string hang in listBox2.Items)
            {
                switch (hang)
                {
                    case "Chuột":
                        soTien += 100000;
                        break;
                    case "Bàn Phím":
                        soTien += 150000;
                        break;
                    case "Máy In":
                        soTien += 2000000;
                        break;
                    case "USB KingMax ":
                        soTien += 200000;
                        break;
                    default:
                        break;
                }
                lblSoTien.Text = soTien + "đồng";
            }
        }
    }
}
