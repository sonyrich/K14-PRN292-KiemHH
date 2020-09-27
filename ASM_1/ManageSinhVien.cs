using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_1
{
    class ManageSinhVien
    {
        public static void ListSinhVien(List<SinhVien> ListSinhVien)
        {
            Console.WriteLine("\n---list Sinh Vien---");
            foreach (var item in ListSinhVien)
            {
                if (item == null)
                {
                    Console.WriteLine("Nothing in the list!");
                }
                else
                {
                    item.XuatThongTin();
                }
            }
            Console.ReadLine();
        }

        public static void AddSinhVien(List<SinhVien> ListSinhVien)
        {
            DateTime NgaySinh;
            if (ListSinhVien.Count > 50)
            {
                Console.WriteLine("The List is full! Can't add more");
            }
            else
            {
                Console.WriteLine("\n---Add Sinh Vien---");
            NhapMaSV:
                Console.Write("Sinh Vien ID: ");
                string MaSv = Console.ReadLine();

                foreach (var item in ListSinhVien)
                {
                    if (MaSv.Equals(item.MaSv))
                    {
                        Console.WriteLine("SV ID have been existed. Try again!");
                        goto NhapMaSV;
                    }
                }

                Console.Write("Name: ");
                String HoTen = Console.ReadLine();

            NhapNgaySinh:
                Console.Write("Birthday: ");
                try
                {
                    NgaySinh = DateTime.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Must be input like: 1/1/2000");
                    goto NhapNgaySinh;
                }

                //NhapDiaChi
                Console.Write("Address: ");
                String DiaChi = Console.ReadLine();

                //NhapDienThoai
                Console.Write("Phone Number: ");
                String DienThoai = Console.ReadLine();

                ListSinhVien.Add(new SinhVien(MaSv, HoTen, NgaySinh, DiaChi, DienThoai));
            }
        }
        public static void SearchSinhVien(List<SinhVien> ListSinhVien)
        {
            bool check = false;
            Console.WriteLine("\n---Search Sinh Vien---");
            Console.Write("Input SV ID: ");
            string MaSV = Console.ReadLine();

            foreach (var item in ListSinhVien)
            {
                if (MaSV.Equals(item.MaSv))
                {
                    item.XuatThongTin();
                    check = true;
                }
            }

            if (!check)
            {
                Console.WriteLine("Sinh Vien ID didn't existed!");
            }
        }

        public static void UpdateSVInfo(List<SinhVien> ListSinhVien)
        {
            bool check = false;
            Console.WriteLine("\n---Update SV Info---");
            Console.Write("Input SV ID: ");
            string MaSV = Console.ReadLine();

            foreach (var item in ListSinhVien)
            {
                if (MaSV.Equals(item.MaSv))
                {
                    Console.Write("New Name:");
                    item.HoTen = Console.ReadLine();
                
                NhapNgaySinh:
                    Console.Write("Birthday: ");
                    try
                    {
                        item.NgaySinh = DateTime.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Must be input like: 1/1/2000");
                        goto NhapNgaySinh;
                    }

                    //NhapDiaChi
                    Console.Write("Address: ");
                    item.DiaChi = Console.ReadLine();

                    //NhapDienThoai
                    Console.Write("Phone Number: ");
                    item.DienThoai = Console.ReadLine();

                    check = true;

                    if (!check)
                    {
                        Console.WriteLine("Sinh Vien isn't existed!");
                    }
                }
            }
        }
    }
}
