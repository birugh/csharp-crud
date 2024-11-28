using System;

namespace calculator_volume_area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userChoice;
            do
            {
                Console.WriteLine("===========================");
                Console.WriteLine(" APLIKASI LUAS DAN VOLUME ");
                Console.WriteLine("===========================");
                Console.WriteLine("Silahkan masukan pilihan anda:");
                Console.WriteLine("1. Luas Bidang");
                Console.WriteLine("2. Volume Bangun");
                Console.WriteLine("===========================");
                Console.Write("Pilihan Anda\n> ");

                int pilihan = Convert.ToInt32(Console.ReadLine());

                if (pilihan == 1)
                {
                    Console.WriteLine("===========================");
                    Console.WriteLine(" LUAS BIDANG ");
                    Console.WriteLine("1. Persegi Panjang");
                    Console.WriteLine("2. Persegi");
                    Console.WriteLine("3. Segitiga");
                    Console.WriteLine("4. Trapesium");
                    Console.WriteLine("===========================");
                    Console.Write("Pilihan Anda\n> ");

                    int pilihanLuas = Convert.ToInt32(Console.ReadLine());

                    switch (pilihanLuas)
                    {
                        case 1:
                            Console.Write("Masukkan panjang: ");
                            double panjang = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukkan lebar: ");
                            double lebar = Convert.ToDouble(Console.ReadLine());
                            LuasBangun persegiPanjang = new LuasPersegiPanjang(panjang, lebar);
                            persegiPanjang.Hitung();
                            break;

                        case 2:
                            Console.Write("Masukkan sisi: ");
                            double sisi = Convert.ToDouble(Console.ReadLine());
                            LuasBangun persegi = new LuasPersegi(sisi);
                            persegi.Hitung();
                            break;

                        case 3:
                            Console.Write("Masukkan alas: ");
                            double alas = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukkan tinggi: ");
                            double tinggi = Convert.ToDouble(Console.ReadLine());
                            LuasBangun segitiga = new LuasSegitiga(alas, tinggi);
                            segitiga.Hitung();
                            break;

                        case 4:
                            Console.Write("Masukkan sisi atas: ");
                            double sisiAtas = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukkan sisi bawah: ");
                            double sisiBawah = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukkan tinggi: ");
                            tinggi = Convert.ToDouble(Console.ReadLine());
                            LuasBangun trapesium = new LuasTrapesium(sisiAtas, sisiBawah, tinggi);
                            trapesium.Hitung();
                            break;

                        default:
                            Console.WriteLine("Pilihan tidak valid.");
                            break;
                    }
                }

                else if (pilihan == 2)
                {
                    Console.WriteLine("===========================");
                    Console.WriteLine(" VOLUME BANGUN ");
                    Console.WriteLine("1. Volume Balok");
                    Console.WriteLine("2. Volume Kubus");
                    Console.WriteLine("3. Volume Limas");
                    Console.WriteLine("4. Volume Tabung");
                    Console.WriteLine("===========================");
                    Console.Write("Pilihan Anda\n> ");

                    int pilihanVolume = Convert.ToInt32(Console.ReadLine());

                    switch (pilihanVolume)
                    {
                        case 1:
                            Console.Write("Masukkan panjang: ");
                            double panjang = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukkan lebar: ");
                            double lebar = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukkan tinggi: ");
                            double tinggi = Convert.ToDouble(Console.ReadLine());
                            VolumeBangun balok = new VolumeBalok(panjang, lebar, tinggi);
                            balok.Hitung();
                            break;

                        case 2:
                            Console.Write("Masukkan sisi: ");
                            double sisi = Convert.ToDouble(Console.ReadLine());
                            VolumeBangun kubus = new VolumeKubus(sisi);
                            kubus.Hitung();
                            break;

                        case 3:
                            Console.Write("Masukkan luas alas: ");
                            double luasAlas = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukkan tinggi: ");
                            tinggi = Convert.ToDouble(Console.ReadLine());
                            VolumeBangun limas = new VolumeLimas(luasAlas, tinggi);
                            limas.Hitung();
                            break;

                        case 4:
                            Console.Write("Masukkan jari-jari: ");
                            double jariJari = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukkan tinggi: ");
                            tinggi = Convert.ToDouble(Console.ReadLine());
                            VolumeBangun tabung = new VolumeTabung(jariJari, tinggi);
                            tabung.Hitung();
                            break;

                        default:
                            Console.WriteLine("Pilihan tidak valid.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid.");
                }

                Console.WriteLine("\nApakah anda ingin mengulang? (Y/N)");
                userChoice = Console.ReadLine().ToLower();
                if (userChoice == "y")
                    Console.Clear();

            } while (userChoice != "n");

            Console.WriteLine("Terimakasih telah mencoba!\nby Biru");
            Console.ReadLine();
        }
    }

    public class LuasBangun
    {
        protected double hasil;

        public virtual void Hitung()
        {
            Console.WriteLine("Menghitung Luas Bangun");
        }
    }

    public class VolumeBangun
    {
        protected internal double hasil;

        public virtual void Hitung()
        {
            Console.WriteLine("Menghitung Volume Bangun");
        }
    }

    public class LuasPersegiPanjang : LuasBangun
    {
        private double panjang, lebar;

        public LuasPersegiPanjang(double p, double l)
        {
            panjang = p;
            lebar = l;
        }

        public override void Hitung()
        {
            hasil = panjang * lebar;
            Console.WriteLine($"Luas Persegi Panjang = {hasil}");
        }
    }

    public class LuasPersegi : LuasBangun
    {
        private double sisi;

        public LuasPersegi(double s)
        {
            sisi = s;
        }

        public override void Hitung()
        {
            hasil = sisi * sisi;
            Console.WriteLine($"Luas Persegi = {hasil}");
        }
    }

    public class LuasSegitiga : LuasBangun
    {
        private double alas, tinggi;

        public LuasSegitiga(double a, double t)
        {
            alas = a;
            tinggi = t;
        }

        public override void Hitung()
        {
            hasil = 0.5 * alas * tinggi;
            Console.WriteLine($"Luas Segitiga = {hasil}");
        }
    }

    public class LuasTrapesium : LuasBangun
    {
        private double sisiAtas, sisiBawah, tinggi;

        public LuasTrapesium(double a, double b, double t)
        {
            sisiAtas = a;
            sisiBawah = b;
            tinggi = t;
        }

        public override void Hitung()
        {
            hasil = ((sisiAtas + sisiBawah) * tinggi) / 2;
            Console.WriteLine($"Luas Trapesium = {hasil}");
        }
    }

    public class VolumeBalok : VolumeBangun
    {
        private double panjang, lebar, tinggi;

        public VolumeBalok(double p, double l, double t)
        {
            panjang = p;
            lebar = l;
            tinggi = t;
        }

        public override void Hitung()
        {
            hasil = panjang * lebar * tinggi;
            Console.WriteLine($"Volume Balok = {hasil}");
        }
    }

    public class VolumeKubus : VolumeBangun
    {
        private double sisi;

        public VolumeKubus(double s)
        {
            sisi = s;
        }

        public override void Hitung()
        {
            hasil = sisi * sisi * sisi;
            Console.WriteLine($"Volume Kubus = {hasil}");
        }
    }

    public class VolumeLimas : VolumeBangun
    {
        private double luasAlas, tinggi;

        public VolumeLimas(double a, double t)
        {
            luasAlas = a;
            tinggi = t;
        }

        public override void Hitung()
        {
            hasil = 0.3 * luasAlas * tinggi;
            Console.WriteLine($"Volume Limas = {hasil}");
        }
    }
    public class VolumeTabung : VolumeBangun
    {
        private double jariJari, tinggi;

        public VolumeTabung(double a, double t)
        {
            jariJari = a;
            tinggi = t;
        }

        public override void Hitung()
        {
            hasil = 3.14 * jariJari * jariJari * tinggi;
            Console.WriteLine($"Volume Tabung = {hasil}");
        }
    }
}
