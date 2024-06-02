namespace GA.TradeMarket.Application.Models.RequestModels
{
    public class CustomerReqModel
    {
        public string id { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public int DiscountValue { get; set; }
        public decimal ReceiptSum { get; set; }
    }
}
