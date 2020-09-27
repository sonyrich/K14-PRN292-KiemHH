using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace ASM_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stay = true;

            List<SinhVien> ListSinhVien = new List<SinhVien>();
            
            while (stay)
            {
                Console.WriteLine("---menu---");
                Console.WriteLine("1.Xem danh sach sinh vien");
                Console.WriteLine("2.Them sinh vien");
                Console.WriteLine("3.Tim sinh vien");
                Console.WriteLine("4.Cap nhat thong tin sinh vien");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ManageSinhVien.ListSinhVien(ListSinhVien);
                        break;
                    case "2":
                        ManageSinhVien.AddSinhVien(ListSinhVien);
                        break;
                    case "3":
                        ManageSinhVien.SearchSinhVien(ListSinhVien);
                        break;
                    case "4":
                        ManageSinhVien.UpdateSVInfo(ListSinhVien);
                        break;
                    case "5":
                        Console.WriteLine("bye!");
                        stay = false;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
        }
    }
}
