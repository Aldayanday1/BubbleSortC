using System;

namespace Bubble_Sort
{
    class Program
    {
        //Deklarasi array int dengan ukuran 20
        private int[] aldi = new int[20];

        // Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        // Fungsi / Method untuk menerima masukan
        public void read()
        {
            // Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemn pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen. \n");

            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");

            // Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 50 + 10 + 20 + 20 - 2 * 15) + "> ");
                string s1 = Console.ReadLine();
                aldi[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("------------------------------------");
            for (int MF = 0; MF < n; MF++)
            {
                Console.WriteLine(aldi[MF]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) // For n - 1 passes
            {
                // Pada pass i, bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int MF = 0; MF < n - i; MF++)
                {
                    if (aldi[MF] > aldi[MF + 1]) // Jika elemen tidak dalam urutan yang benar
                    {
                        //Tukar elemen
                        int temp;
                        temp = aldi[MF];
                        aldi[MF + 1] = aldi[MF];
                        aldi[MF] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // Creating the object of the BubbleSort class
            Program myList = new Program();

            // Pemanggilan fungsi untuk menerima elemen array
            myList.read();
            // Pemanggilan fungsi untuk mengurutkan array
            myList.BubbleSortArray();
            // Pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            // Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();

        }
   
    }
}