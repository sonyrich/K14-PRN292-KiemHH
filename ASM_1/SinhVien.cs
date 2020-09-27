using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_1
{
    public class SinhVien
    {
        private string mMaSv;
        private string mHoTen;
        private DateTime mNgaySinh;
        private string mDiaChi;
        private string mDienThoai;

        public SinhVien()
        {
            
        }

        public SinhVien(string MaSv, string HoTen, DateTime NgaySinh, 
            string DiaChi, string DienThoai)
        {
            this.mMaSv = MaSv;
            this.mHoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.mDiaChi = DiaChi;
            this.mDienThoai = DienThoai;
        }
 
        public string MaSv
        {
            get { return mMaSv ; }
            set { mMaSv = value; }
        }

        public string HoTen
        {
            get { return mHoTen; }
            set { mHoTen = value; }
        }
        public DateTime NgaySinh
        {
            get { return mNgaySinh; }
            set { mNgaySinh = value; }
        }

        public string DiaChi
        {
            get { return mDiaChi; }
            set { mDiaChi = value; }
        }

        public string DienThoai
        {
            get { return DienThoai; }
            set { mDienThoai = value; }
        }

        public void XuatThongTin()
        {
            Console.WriteLine("MaSV: {0}\n" +
                              "Ho Ten: {1}\n" +
                              "Ngay Sinh: {2}\n" +
                              "Dia Chi {3}\n" +
                              "Dien Thoai: {4}",
                              mMaSv,mHoTen,mNgaySinh,mDiaChi,mDienThoai);
        }
    }
}
