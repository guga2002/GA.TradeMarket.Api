using System.ComponentModel.DataAnnotations;

namespace GA.TradeMarket.Application.Models
{
    public class ReviewModel:AbstractModel
    {
        public long ProductId { get; set; }

        public long CustomerId { get; set; }

        [StringLength(200,MinimumLength =3,ErrorMessage ="The  Review is not   correct in length")]
        public string ReviewText { get; set; }

        [Range(0,10,ErrorMessage ="ranting must be  between  0-10")]
        public int Rating { get; set; }

        public DateTime ReviewDate { get; set; }

        public virtual ProductModel Product { get; set; }

        public virtual CustomerModel Customer { get; set; }
    }
}
