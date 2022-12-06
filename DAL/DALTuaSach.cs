﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTuaSach
    {
        private static DALTuaSach instance;

        public static DALTuaSach Instance
        {
            get
            {
                if (instance == null) instance = new DALTuaSach();
                return instance;
            }
            set => instance = value;
        }

        public List<TUASACH> GetAllTuaSach()
        {
            return QLTVDb.Instance.TUASACHes.ToList();
        }

        /// <summary>
        /// Get TUASACH by Id
        /// </summary>
        /// <param name="maTuaSach"></param>
        /// <returns></returns>
        public TUASACH GetTuaSach(string maTuaSach)
        {
            return QLTVDb.Instance.TUASACHes.Find(maTuaSach);
        }

        /// <summary>
        /// Find TUASACHs by filter
        /// </summary>
        /// <param name="tenTuaSach"></param>
        /// <param name="theloai"></param>
        /// <param name="tacgias"></param>
        /// <returns></returns>
        public List<TUASACH> FindTuaSach(string tenTuaSach, THELOAI theloai, List<TACGIA> tacgias)
        {
            List<TUASACH> res = QLTVDb.Instance.TUASACHes.ToList();
            if (tenTuaSach != null) res = res.Where(t => t.TenTuaSach == tenTuaSach).Select(t => t).ToList();
            if (theloai != null) res = res.Where(t => t.THELOAI == theloai).Select(t => t).ToList();
            if (tacgias != null) 
                foreach(var tacgia in tacgias)
                    res = res.Where(t => t.TACGIAs.Contains(tacgia)).Select(t => t).ToList();
            return res;
        }

        public bool AddTuaSach (string tenTuaSach, THELOAI theLoai, List<TACGIA> dsTacGia)
        {
            try
            {
                TUASACH tuaSach = new TUASACH
                {
                    TenTuaSach = tenTuaSach,
                    MaTheLoai = theLoai.MaTheLoai,
                    THELOAI = theLoai,
                    TACGIAs = dsTacGia
                };
                QLTVDb.Instance.TUASACHes.Add(tuaSach);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdTuaSach(string maTuaSach, string tenTuaSach, THELOAI theLoai, List<TACGIA> dsTacGia)
        {
            try
            {
                TUASACH tuaSach = QLTVDb.Instance.TUASACHes.Find(maTuaSach);
                if (tuaSach == null) return false;
                if (tenTuaSach != null) tuaSach.TenTuaSach = tenTuaSach;
                if (theLoai != null)
                {
                    tuaSach.MaTheLoai = theLoai.MaTheLoai;
                    tuaSach.THELOAI = theLoai;
                }
                if (dsTacGia != null) tuaSach.TACGIAs = dsTacGia;
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// Deleting a TUASACH also delete all SACH belonging to it
        /// </summary>
        /// <param name="maTuaSach"></param>
        /// <returns></returns>
        public bool DelTuaSach(string maTuaSach)
        {
            try
            {
                TUASACH tuaSach = QLTVDb.Instance.TUASACHes.Find(maTuaSach);
                if (tuaSach == null) return false;
                List<SACH> dsSach = DALSach.Instance.FindSach(tuaSach, null, null);
                foreach (var sach in dsSach)
                {
                    DALSach.Instance.DelSach(sach.MaSach);
                }
                QLTVDb.Instance.TUASACHes.Remove(tuaSach);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}