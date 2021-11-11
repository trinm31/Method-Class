using System;

namespace Class_Method
{
    class Program
    {
        public static double BinhPhuong(double Number)
        {
            double result = Number * Number;
            return result;
        }
        public static string Cong(double a, double b)
        {
            string result = $"Tong hai so la: {a+b}";
            return result;
        }

        public static void XinChao()
        {
            Console.WriteLine("Hello cac ban");
        }

        public static int x = 1;
        public static double TheTich(double cao, double dai = 1, double rong = 1)
        {
            return cao * dai * rong * x;
        }

        public static string FullName(string ho, string ten, string tendem = "")
        {
            return ho + (tendem != "" ? " " + tendem : "") + " " + ten;
        }

        public static void OutExample(out int x)
        {
            x = 100;
        }
        
        public static void NonOutExample(int x)
        {
            x = 100;
        }

        public static int giaithua(int a)
        {
            if (a==1)
            {
                return 1;
            }

            return a * giaithua(a - 1);
        }
        
        
        static void Main(string[] args)
        {
            // ------------------- Method ---------------------
            //1. Khai báo phương thức
            // <Access modifier> <return type> <Name-method>(<parameters>){}
            
            //2. Gọi phương thức
            // double Number = 5;
            // double bp = BinhPhuong(Number);
            // double bp2 = BinhPhuong(4);
            // string Tong = Cong(10, Number);
            // Console.WriteLine("Binh phuong la: " + bp);
            //3. Tham số trong phương thức
            // XinChao();
            // XinChao();
            // XinChao();
            // XinChao();

            //4. Tham số có giá trị mặc định
            //double tt = TheTich(1, 4);
            
            //5. Truyền tham số với tên

            //string fullname = FullName("Vo", "Minh Thu");
            // string fullname = FullName(ten: "Tri", ho: "Nguyen");
            // Console.WriteLine(fullname);
            //6. Tham chiếu và tham trị

            // int a=0;
            // NonOutExample(a);
            // Console.WriteLine("Non out example" + a);
            // OutExample(out a);
            // Console.WriteLine("out example" + a);
            
            //7. Đệ quy
            //Console.WriteLine(giaithua(6));
            
            // -------------------- Class --------------------------------

            Car Audi = new Car();
            Audi.numberofwheel = 4;
            Audi.color = "Vang";
            Audi.brand = "Audi";
            string horn = Audi.horn("beep");
            Console.WriteLine(horn);
            Car Mec = new Car();
            Mec.numberofwheel = 8;
            Mec.color = "black";
            Mec.brand = "Mec";
            string hornmec = Audi.horn("bec");
            Console.WriteLine(hornmec);
            
            Console.WriteLine($"Xe tu thuong hieu {Mec.brand} co mau {Mec.color} so banh la {Mec.numberofwheel}");

            Car rolls_royce = new Car(4, "rolls royce", "Hong canh sen");
            Console.WriteLine($"Xe tu thuong hieu {rolls_royce.brand} co mau {rolls_royce.color} so banh la {rolls_royce.numberofwheel}");
        }
    }
}