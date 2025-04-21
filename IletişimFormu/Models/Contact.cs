using System.ComponentModel.DataAnnotations;

namespace IletişimFormu.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email alanı zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir email adresi girin.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mesaj alanı zorunludur.")]
        [StringLength(500, ErrorMessage = "Mesaj 500 karakteri geçemez.")]
        public string Message { get; set; }
    }
}
