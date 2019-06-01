﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu
{
    class NhanVien
    {
        private string manv;
        private string tennv;
        private string diachi;
        private string macv;
        private DateTime ngaysinh;
        private string bangcap;
        private string gt;
        private string mapb;
        private string tongiao;
        private string dantoc;
        private string sdt;
        private string cmt;


        public string Manv
        {
            get
            {
                return manv;
            }

            set
            {
                manv = value;
            }
        }

        public string Tennv
        {
            get
            {
                return tennv;
            }

            set
            {
                tennv = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Macv
        {
            get
            {
                return macv;
            }

            set
            {
                macv = value;
            }
        }

        public DateTime Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Bangcap
        {
            get
            {
                return bangcap;
            }

            set
            {
                bangcap = value;
            }
        }

        public string Gt
        {
            get
            {
                return gt;
            }

            set
            {
                gt = value;
            }
        }

   

        public string Tongiao
        {
            get
            {
                return tongiao;
            }

            set
            {
                tongiao = value;
            }
        }

        public string Dantoc
        {
            get
            {
                return dantoc;
            }

            set
            {
                dantoc = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public string Cmt
        {
            get
            {
                return cmt;
            }

            set
            {
                cmt = value;
            }
        }

        public string Mapb
        {
            get
            {
                return mapb;
            }

            set
            {
                mapb = value;
            }
        }

        public NhanVien(string manv, string tennv, string bangcap, string gt, DateTime ngaysinh, string diachi , string mapb, string tongiao, string dantoc, string sdt, string cmt)
        {
            this.Manv = manv;
            this.Tennv = tennv;
            this.Bangcap = bangcap;
            this.Gt = gt;
            this.Ngaysinh = ngaysinh;
            this.Diachi = diachi;
            this.Mapb = mapb;
            this.Tongiao = tongiao;
            this.Dantoc = dantoc;
            this.Sdt = sdt;
            this.Cmt = cmt;
            
        }
    }
}
