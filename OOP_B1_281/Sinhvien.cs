using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_B1_281
{
    internal class Sinhvien
    {
        public string Msv;
        public string HoTen;
        public int Tuoi;
        public Sinhvien() { } 

        public Sinhvien(string Msv, string HoTen, int Tuoi)
        {
            this.Msv = Msv;
            this.HoTen = HoTen;
            this.Tuoi = Tuoi;
        }
        public void NhapSV()
        {
            Console.Write("Nhập Mã sinh viên: ");
            Msv = Console.ReadLine();
            Console.Write("Nhập Họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập Tuổi: ");
            Tuoi = int.Parse(Console.ReadLine());
        }

        public void DisplaySV()
        {
            Console.WriteLine("Mã sinh viên: {0} | Họ tên: {1} | Tuổi: {2}", Msv, HoTen, Tuoi);
        }
    }
}

