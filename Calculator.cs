 class Program
    {
        static void Main(string[] args)
        {
			Console.Title = "Aplikasi kalkulator";

            Console.WriteLine("Pilih menu kalkulator :");
            Console.WriteLine("1.Penambahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Perkalian");
            Console.WriteLine("4.Pembagian\n");

            Console.WriteLine("Pilihan menu(Masukkan nomor) :");
            int menu = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Masukkan angka a =");
            int a = int.Parse(Console.ReadLine()); // deklarasi variabel nilai pertama
            Console.WriteLine("\n");

            Console.WriteLine("Masukkan angka b =");
            int b = Convert.ToInt32(Console.ReadLine());  // deklarasi variabel nilai kedua
            Console.WriteLine("\n");

            if (menu == 1)
            {
                Console.WriteLine("\n\nHasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }

            else if(menu == 2)
            {
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if(menu == 3)
            {
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if(menu == 4)
            {
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("System error");
            }

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
		
		static int Penambahan(int a, int b)
        {
            return a + b;
        }
        
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        
        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
	}