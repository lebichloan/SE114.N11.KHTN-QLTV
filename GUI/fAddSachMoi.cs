﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class fAddSachMoi : Form
    {
        public fAddSachMoi()
        {
            InitializeComponent();
            List<TUASACH> TuaSachList = BUSTuaSach.Instance.GetAllTuaSach();
            foreach(TUASACH ts in TuaSachList)
            {
                ts.TenTuaSach = ts.TenTuaSach + " (" + ts.MaTuaSach + ")";
            }
            
            comboTuaSach.DataSource = TuaSachList;
            comboTuaSach.DisplayMember = "TenTuaSach" ;
            comboTuaSach.ValueMember = "id";
        }
        private int DonGia;
        private int SoLuongNhap;
        private void butOK_Click(object sender, EventArgs e)
        {
            if (NgayNhap.Date > DateTime.Now)
            {
                ErrorDia.Show("Ngày nhập không hợp lệ");
                return;
            }
            if (comboTuaSach.SelectedValue==null || txtNamXB.Text=="" || txtNhaXB.Text=="" || txtDonGia.Text=="" || txtSoLuongNhap.Text=="")
            {
                ErrorDia.Show("Chưa nhập đủ dữ liệu");
                return;
            }

            int Nam;
            try
            {
                Nam = Convert.ToInt32(txtNamXB.Text);
            }
            catch
            {
                txtNamXB.Text = null;
                ErrorDia.Show("Năm không hợp lệ");
                return;
            }
            string NXB = txtNhaXB.Text.ToString();
            
            DateTime NgayNhap = dateNgayNhap.Value.Date;
            int ThanhTien = this.SoLuongNhap * this.DonGia;
            int id = (int)comboTuaSach.SelectedValue;
            labelThanhTien.Text = "Thành tiền: " + ThanhTien.ToString();
            Tuple<string,int> kq = BUSSach.Instance.AddSach(id,this.SoLuongNhap,this.DonGia,Nam,NXB);
            int idSach = kq.Item2;
            string err = kq.Item1;
            if(err != "")
            {
                ErrorDia.Show(err);
                return;
            }
            int MaPhieuNhap = BUSPhieuNhap.Instance.AddPhieuNhap(NgayNhap);
            if(MaPhieuNhap == -1)
            {
                ErrorDia.Show("Ngày nhập không hợp lệ");
                BUSSach.Instance.DelSach(idSach);
                return;
            }
            err = BUSCT_PhieuNhap.Instance.AddCtPhieuNhap(MaPhieuNhap,idSach,DonGia,SoLuongNhap);
            if(err!="")
            {
                BUSSach.Instance.DelSach(idSach);
                
                ErrorDia.Show(err);
                return;
            }
            SuccDia.Show("Thêm sách mới thành công");
            this.Close();
        }

        private void txtSoLuongNhap_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuongNhap.Text == null || txtSoLuongNhap.Text =="") return;
         
            try
            {
                this.SoLuongNhap = Convert.ToInt32(txtSoLuongNhap.Text);
                
            }
            catch
            {
                ErrorDia.Show("Không đúng format");
                txtSoLuongNhap.Text = null;
                return;
            }
            if (txtDonGia.Text == null || txtSoLuongNhap.Text == null) return;
            //soLuongNhap = Convert.ToInt32(txtSoLuongNhap.Text);
            
            int ThanhTien = DonGia * SoLuongNhap;
            labelThanhTien.Text = "Thành tiền: " + ThanhTien.ToString();
            
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text == null || txtDonGia.Text =="") return;
            try
            {
                this.DonGia = Convert.ToInt32(txtDonGia.Text);
            }
            catch
            {
                ErrorDia.Show("Không đúng format");
                txtDonGia.Text = null;
                return;
                
            }
            if(this.SoLuongNhap != null )
            {
                int ThanhTien = DonGia * SoLuongNhap;
                labelThanhTien.Text = "Thành tiền: "+ ThanhTien.ToString();
            }

        }

       
    }
}
