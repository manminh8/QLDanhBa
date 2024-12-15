﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDanhBa
{
    public class CNhom
    {
        private string m_tenNhom;
        private List<CDanhBa> m_dsDanhBa; //Danh sach danh ba
        public string Tennhom { get => m_tenNhom; set => m_tenNhom = value; }
        public List<CDanhBa> DsDanhBa { get;set; }

        public CNhom(string tennhom)
        {
            Tennhom = tennhom;
            m_dsDanhBa = new List<CDanhBa>();
        }
        public List<CDanhBa> getDSDBNhom() { return m_dsDanhBa; }

        public void ThemDanhBa(CDanhBa danhBa)
        {
            if (danhBa != null && !m_dsDanhBa.Contains(danhBa))
            {
                m_dsDanhBa.Add(danhBa);
            }
        }
        public bool xoaDanhBa(string sdt)
        {
            CDanhBa db = new CDanhBa();
            if (db.Sdt == sdt)
            {
                if (db != null)
                {
                    m_dsDanhBa.Remove(db);
                    return true;
                }
            }
            return false;
        }
    }

}