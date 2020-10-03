class DiscountRate
{
    double serviceDiscountPremium = 0.2;
    double serviceDiscountGold = 0.15;
    double serviceDiscountSilver = 0.1;
    double productDiscountPremium = 0.1;
    double productDiscountGold = 0.1;
    double productDiscountSilver = 0.1;
    public double getServiceDiscount(string type)
    {
        if(type.ToUpper().Equals("PREMIUM")) return serviceDiscountPremium;
        else if(type.ToUpper().Equals("GOLD")) return serviceDiscountGold;
        else if(type.ToUpper().Equals("SILVER")) return serviceDiscountSilver;
        else return 0;
    }
    public double getProductDiscount(string type)
    {
        if(type.ToUpper().Equals("PREMIUM")) return productDiscountPremium;
        else if(type.ToUpper().Equals("GOLD")) return productDiscountGold;
        else if(type.ToUpper().Equals("SILVER")) return productDiscountSilver;
        else return 0;
    }
}