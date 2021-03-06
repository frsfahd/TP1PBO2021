using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Barang
    {
        string jenisBarang;
        int harga;
        string namaBarang;
        string gambar;

        public Barang(string jenisBarang, int harga, string namaBarang, string gambar)
        {
            this.jenisBarang = jenisBarang;
            this.harga = harga;
            this.namaBarang = namaBarang;
            this.gambar = gambar;
        }

        public Barang() { }

        public void set_jenisBarang(string jenisBarang)
        {
            this.jenisBarang = jenisBarang;
        }
        public string get_jenisBarang()
        {
            return this.jenisBarang;
        }
        public void set_harga(int harga)
        {
            this.harga = harga;
        }
        public int get_harga()
        {
            return this.harga;
        }
        public void set_gambar(string gambar)
        {
            this.gambar = gambar;
        }
        public string get_gambar()
        {
            return this.gambar;
        }
        public void set_namaBarang(string namaBarang)
        {
            this.namaBarang = namaBarang;
        }
        public string get_namaBarang()
        {
            return this.namaBarang;
        }

    }
}
