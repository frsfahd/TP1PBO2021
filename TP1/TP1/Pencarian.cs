using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Pencarian
    {
        string jenisBarang;
        string harga;

        public Pencarian(string harga, string jenisBarang)
        {
            this.jenisBarang = jenisBarang;
            this.harga = harga;
        }
        public Pencarian() { }

        public void set_jenisBarang(string jenisBarang)
        {
            this.jenisBarang = jenisBarang;
        }
        public string get_jenisBarang()
        {
            return this.jenisBarang;
        }
        public void set_harga(string harga)
        {
            this.harga = harga;
        }
        public string get_harga()
        {
            return this.harga;
        }

    }
}
