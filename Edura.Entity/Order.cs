using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Edura.Entity
{
    public class Order
    {
        public Order()
        {
            OrderLines = new List<OrderLine>();
        }

        public int OrderId { get; set; }

        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public DateTime orderDate { get; set; }
        public EnumOrderState OrderState { get; set; }

        public string Username { get; set; }
        public string AdresTanimi { get; set; }
        public string Adres { get; set; }
        public string Sheher { get; set; }
        public string Kuce { get; set; }
        public string Telefon { get; set; }

        public List<OrderLine> OrderLines { get; set; }
    }

    public enum EnumOrderState
    {
        [Display(Name = "Onay Bekleniyor")]
        Waiting,

        [Display(Name = "Tamamlandi")]
        Completed
    }
}
