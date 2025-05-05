using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YilanOyunu.UI.Models
{
    public class OyunKaydi
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }

        public int Skor { get; set; }
        public OyunSeviyesi Seviye { get; set; }

        public DateTime OynamaTarihi { get; set; }
    }
}
