﻿using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.BM
{
    public partial class fPhieuMuonSach : Form
    {
        public fPhieuMuonSach()
        {
            InitializeComponent();
            init();
            
        }
        private void init()
        {
            List<CUONSACH> CuonSachList = BUSCuonSach.Instance.GetAllCuonSachAvai();
            
            comboCuonSach.DataSource = CuonSachList;
            comboCuonSach.DisplayMember = "MaCuonSach";
            comboCuonSach.ValueMember = "id";
            comboDocGia.DataSource = BUSDocGia.Instance.GetAllDocGia();
            comboDocGia.DisplayMember = "MaDocGia";
            comboDocGia.ValueMember = "id";
            comboCuonSach.SelectedIndex = 0;
            CUONSACH cuonsach = BUSCuonSach.Instance.GetCuonSach(Convert.ToInt32(comboCuonSach.SelectedValue));
            labelTenCS.Text = "Tên: " + cuonsach.SACH.TUASACH.TenTuaSach;
            labelTheLoai.Text = "Thể loại: " + cuonsach.SACH.TUASACH.THELOAI.TenTheLoai;
            DOCGIA docgia = BUSDocGia.Instance.GetDocGia(Convert.ToInt32(comboDocGia.SelectedValue));
            labelHoTen.Text = "Họ tên: " + docgia.TenDocGia;
            labelTongNoHienTai.Text = "Tổng nợ hiện tại: " + docgia.TongNoHienTai.ToString();

            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            NgayMuon = dateNgayMuon.Value.Date;
            labelHanTra.Text =  NgayMuon.AddDays((int)thamso.SoNgayMuonToiDa).ToShortDateString();

        }
        private DateTime NgayTra;
        private DateTime NgayMuon;

        private void butSave_Click(object sender, EventArgs e)
        {
            NgayTra = dateNgayTra.Value.Date;
            NgayMuon = dateNgayMuon.Value.Date;
            if(NgayTra < NgayMuon)
            {
                ErrorDia.Show("Ngày trả không hợp lệ");
                return;
            }
            if(NgayMuon > DateTime.Now)
            {
                ErrorDia.Show("Ngày mượn không hợp lệ");
                return;
            }
            DOCGIA docgia = BUSDocGia.Instance.GetDocGia(Convert.ToInt32(comboDocGia.SelectedValue));
            CUONSACH cuonsach = BUSCuonSach.Instance.GetCuonSach(Convert.ToInt32(comboCuonSach.SelectedValue));
            string error = BUSPhieuMuonTra.Instance.AddPhieuMuonTra(cuonsach.MaCuonSach, docgia.MaDocGia, NgayMuon);
            if(error !="")
            {
                ErrorDia.Show(error);
                return;
            }
            SuccDia.Show("Thêm phiếu mượn thành công");
        }

        private void comboCuonSach_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            CUONSACH cuonsach = BUSCuonSach.Instance.GetCuonSach(Convert.ToInt32(comboCuonSach.SelectedValue));
            labelTenCS.Text = "Tên: "+cuonsach.SACH.TUASACH.TenTuaSach;
            labelTheLoai.Text = "Thể loại: " + cuonsach.SACH.TUASACH.THELOAI.TenTheLoai;
        }
        private void comboDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            DOCGIA docgia = BUSDocGia.Instance.GetDocGia(Convert.ToInt32(comboDocGia.SelectedValue));
            labelHoTen.Text = "Họ tên: "+ docgia.TenDocGia;
            labelTongNoHienTai.Text = "Tổng nợ hiện tại: "+docgia.TongNoHienTai.ToString();
        }

        private void dateNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            NgayMuon = dateNgayMuon.Value.Date;
            labelHanTra.Text =NgayMuon.AddDays((int)thamso.SoNgayMuonToiDa).ToShortDateString();
        }

        private void dateNgayTra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateNgayMuon_ValueChanged_1(object sender, EventArgs e)
        {
            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            NgayMuon = dateNgayMuon.Value.Date;
            labelHanTra.Text =NgayMuon.AddDays((int)thamso.SoNgayMuonToiDa).ToShortDateString();
        }

        private void butSave_Click_1(object sender, EventArgs e)
        {
            NgayTra = dateNgayTra.Value.Date;
            NgayMuon = dateNgayMuon.Value.Date;
            if (NgayTra < NgayMuon)
            {
                ErrorDia.Show("Ngày trả không hợp lệ");
                return;
            }
            if (NgayMuon > DateTime.Now)
            {
                ErrorDia.Show("Ngày mượn không hợp lệ");
                return;
            }
            DOCGIA docgia = BUSDocGia.Instance.GetDocGia(Convert.ToInt32(comboDocGia.SelectedValue));
            CUONSACH cuonsach = BUSCuonSach.Instance.GetCuonSach(Convert.ToInt32(comboCuonSach.SelectedValue));
            string error = BUSPhieuMuonTra.Instance.AddPhieuMuonTra(cuonsach.MaCuonSach, docgia.MaDocGia, NgayMuon);
            if (error != "")
            {
                ErrorDia.Show(error);
                return;
            }
            SuccDia.Show("Thêm phiếu mượn thành công");
        }
    }
}