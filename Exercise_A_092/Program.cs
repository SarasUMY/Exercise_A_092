using System;

namespace Exercise
{
    class Program
    {
        //deklarasi array int dengan ukuran 31 dari 2 angka terakhir NIM + 10 + 20 + 20 - 2 * 15
        private int[] saras = new int[31];

        //deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        //fungsi untuk menerima masukan
        public void read()
        {
            //menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = int.Parse(s);
                if (n <= 31)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 31 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Masukkan elemen array");
            Console.WriteLine("-----------------------");

            //pengguna masukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                saras[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Elemen array yang telah tersusun");
            Console.WriteLine("--------------------------------");
            for (int BP = 0; BP < n; BP++)
            {
                Console.WriteLine(saras[BP]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) //untuk n-1 pass
            {
                //pada pass i, bandingkan n-i elemen pertama dengan elemen selanjutnya
                for (int BP = 0; BP < n - i; BP++)
                {
                    if (saras[i] < saras[BP + 1]) //jika elemen tidak dalam urutan yang benar
                    {
                        //tukar elemen
                        int temp;
                        temp = saras[BP];
                        saras[BP] = saras[BP + 1];
                        saras[BP + 1] = temp;
                    }
                    if (saras[i] < saras[BP])
                    {
                        //swap elemen
                        int temp;
                        temp = saras[BP];
                        saras[BP] = saras[i];
                    }
                }
            }
        }
    }
}