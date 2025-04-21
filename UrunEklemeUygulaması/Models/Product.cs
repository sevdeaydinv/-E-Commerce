using System.ComponentModel.DataAnnotations;

namespace UrunEklemeUygulaması.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Ürün adı zorunludur.")]
        [StringLength(100, ErrorMessage = "Ürün adı en fazla 100 karakter olabilir.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Fiyat zorunludur.")]
        [Range(0.01, 100000, ErrorMessage = "Fiyat 0.01 ile 100000 arasında olmalıdır.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Stok adedi zorunludur.")]
        [Range(0, 10000, ErrorMessage = "Stok 0 ile 10000 arasında olmalıdır.")]
        public int Stock { get; set; }

        [StringLength(300, ErrorMessage = "Açıklama en fazla 300 karakter olabilir.")]
        public string Description { get; set; }
    }
}