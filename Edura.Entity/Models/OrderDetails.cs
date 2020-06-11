using System.ComponentModel.DataAnnotations;

namespace Edura.Entity.Models
{
    public class OrderDetails
    {
        [Required(ErrorMessage = "Zehmet olmasa,bir adres tanimi daxil edin.")]
        public string AdresTanimi { get; set; }

        [Required(ErrorMessage = "Zehmet olmasa,bir adres daxil edin.")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Zehmet olmasa,bir Sheher daxil edin.")]
        public string Sheher { get; set; }

        [Required(ErrorMessage = "Zehmet olmasa,bir Kuce daxil edin.")]
        public string Kuce { get; set; }

        [Required(ErrorMessage = "Zehmet olmasa,bir Telefon daxil edin.")]
        public string Telefon { get; set; }
    }
}
