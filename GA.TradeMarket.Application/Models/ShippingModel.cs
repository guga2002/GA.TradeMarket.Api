using System.ComponentModel.DataAnnotations;

namespace GA.TradeMarket.Application.Models
{
    public class ShippingModel:AbstractModel
    {
        public long OrderId { get; set; }

        [StringLength(30,MinimumLength =4,ErrorMessage ="Tracking number is not  right")]
        public string TrackingNumber { get; set; }


        [StringLength(20,MinimumLength =3,ErrorMessage ="Please inicialize carrier correctly")]
        public string Carrier { get; set; }


        public DateTime ShippingDate { get; set; }

        public string Status { get; set; }

        public virtual OrderModel Order { get; set; }
    }
}
