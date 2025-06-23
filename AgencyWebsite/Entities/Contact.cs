using System.ComponentModel.DataAnnotations;

namespace AgencyWebsite.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }



        [Required(ErrorMessage = "İsim soyisim alanı zorunludur.")]
        public string? Namesurname { get; set; }

        [Required(ErrorMessage = "Email alanı zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta giriniz.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Telefon numarası zorunludur.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Mesaj alanı boş bırakılamaz.")]
        public string? Message { get; set; }
    }
}
