﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatLieuXayDung
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatHang datHang = new DatHang();
            datHang.Show();
        }

        private void traCứuSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraCuuSanPham traCuuSanPham = new TraCuuSanPham();
            traCuuSanPham.Show();
        }
    }
}
