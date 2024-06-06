namespace GA.TradeMarket.Application.StaticFIles
{
    public static  class ErrorKeys
    {
        public const string BadRequest = " Bad request, Server do not give good response";
        public const string UnsuccesfullInsert = "Insert was not succesfull";
        public const string UnsucessfullUpdate = "Update was not succesfully";
        public const string NotFound = "Not Found any relate Entities";
        public const string NoOrder = "No order exist";
        public const string NoCustommer = "Custumer no  exist";
        public const string InternalServerError = " there  was internall error";
        public const string DateValidation = "Datetime format is  not right, YOu arer under age  10 year is allowed!";
        public const string mapped = "Mapped  not was succesfully";
        public const string General = " General Exception while send request";
        public const string NoBonus = "No bonuses  exist!";
        public const string NoCoupon = "No coupons  exist!";
        public const string ArgumentNull = " Argument is null , please check";
        public const string NoCategory = " Product Category is null";
        public const string NoProduct = "No Such Product Exist in DB!";
    }
}
