using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;  // Column özniteliğini kullanabilmek için

namespace KodlamaDunyasi.Models
{
    [Table("Ürünler")]  // Veritabanındaki tablo adıyla eşleşmesini sağlıyoruz
    public class Urun
    {
        [Key]
        [Column("ÜrünID")]  // Veritabanındaki sütun adıyla eşleşmesini sağlıyoruz
        public int UrunID { get; set; }

        [Column("Açıklama")]  // Veritabanındaki sütun adıyla eşleşmesini sağlıyoruz
        public string Aciklama { get; set; }

        [Column("SatıcıID")]  // Veritabanındaki sütun adıyla eşleşmesini sağlıyoruz
        public int SaticiID { get; set; }

        [Required]
        public string Ad { get; set; }

        [Required]
        public decimal Fiyat { get; set; }

        [Required]
        public int Stok { get; set; }

        public int KategoriID { get; set; }
    }
}