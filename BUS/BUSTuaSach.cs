﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    internal class BUSTuaSach
    {
        private static BUSTuaSach instance;
        public static BUSTuaSach Instance
        {
            get
            {
                if (instance == null) instance = new BUSTuaSach();
                return instance;
            }
            set => instance = value;
        }
        public List<TUASACH> GetAllTuaSach()
        {
            return DALTuaSach.Instance.GetAllTuaSach();
        }
        public TUASACH GetTuaSach(string MATUASACH)
        {
            return DALTuaSach.Instance.GetTuaSach(MATUASACH);
        }
        public List<TUASACH> FindTuaSach(string name, THELOAI theloai, List<TACGIA> tacgia)
        {
            return DALTuaSach.Instance.FindTuaSach(name,theloai,tacgia);
        }
        public string AddTuaSach(string name, THELOAI theloai, List<TACGIA> tacgia)
        {
            if (DALTuaSach.Instance.AddTuaSach(name, theloai, tacgia))
                return "";
            return "Không thể thêm tựa sách";
        }
        public string DelTuaSach(string matuasach)
        {
            TUASACH ts = DALTuaSach.Instance.GetTuaSach(matuasach);
            foreach(SACH sach in ts.SACHes)
            {
                foreach(CUONSACH cs in sach.CUONSACHes)
                {
                    if (cs.TinhTrang == 1)
                        return "Tựa sách còn sách đang được mượn. Không thể xoá";
                }
            }
            if (DALTuaSach.Instance.DelTuaSach(matuasach))
                return "";
            return "Không thể xoá tựa sách.";
        }
    }
}