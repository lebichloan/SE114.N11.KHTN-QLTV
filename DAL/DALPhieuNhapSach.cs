﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPhieuNhapSach
    {
        private static DALPhieuNhapSach instance;

        public static DALPhieuNhapSach Instance 
        { 
            get
            {
                if (instance == null) instance = new DALPhieuNhapSach();
                return instance;
            }
            set => instance = value; 
        }

        public List<PHIEUNHAPSACH> GetAllPhieuNhapSach()
        {
            return QLTVDb.Instance.PHIEUNHAPSACHes.ToList();
        }

        public PHIEUNHAPSACH GetPhieuById (int id)
        {
            return QLTVDb.Instance.PHIEUNHAPSACHes.Find(id);
        }

        public List<PHIEUNHAPSACH> FindPhieuByNgayNhap(int? ngay, int? thang, int? nam)
        {
            List<PHIEUNHAPSACH> res = GetAllPhieuNhapSach();
            if (ngay != null) res = res.Where(p => p.NgayNhap.Value.Day == ngay).ToList();
            if (thang != null) res = res.Where(p => p.NgayNhap.Value.Month == thang).ToList();
            if (nam != null) res = res.Where(p => p.NgayNhap.Value.Year == nam).ToList();
            return res;
        }

        public bool AddPhieuNhap (DateTime ngayNhap)
        {
            try
            {
                var phieu = new PHIEUNHAPSACH
                {
                    NgayNhap = ngayNhap,
                    TongTien = 0
                };

                QLTVDb.Instance.PHIEUNHAPSACHes.Add(phieu);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool UpdPhieuNhap(int id, DateTime? ngayNhap, int? tongTien)
        {
            try
            {
                PHIEUNHAPSACH phieu = QLTVDb.Instance.PHIEUNHAPSACHes.Find(id);
                if (phieu == null) return false;
                if (ngayNhap != null) phieu.NgayNhap = ngayNhap;
                if (tongTien != null) phieu.TongTien = tongTien;
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool DelPhieuNhap(int id)
        {
            try
            {
                PHIEUNHAPSACH phieu = QLTVDb.Instance.PHIEUNHAPSACHes.Find(id);
                if (phieu == null) return false;
                QLTVDb.Instance.PHIEUNHAPSACHes.Remove(phieu);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
    }
}