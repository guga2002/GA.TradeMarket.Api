using System.ComponentModel.DataAnnotations;

namespace GA.TradeMarket.Application.Models
{
    public class ReturnRequestModel:AbstractModel
    {
        public long OrderId { get; set; }

        public DateTime RequestDate { get; set; }

        [StringLength(200,ErrorMessage ="Reasone is not  enought or it is  big enought",MinimumLength =3)]
        public string Reason { get; set; }


        [StringLength(200, ErrorMessage = "Status is not  enought or it is  big enought", MinimumLength = 3)]
        public string Status { get; set; }

        public virtual OrderModel Order { get; set; }
    }
}
