using System;
class Visit
{
    Customer customer;
    DateTime date;
    double serviceExpence, productExpence;
    public Visit(string name, DateTime date)
    {
        customer = new Customer(name);
        this.date = date;
    }
    public string getName()
    {
        return customer.getName();
    }
    public double getServiceExpence()
    {
        return serviceExpence;
    }
    public double getProductExpence()
    {
        return productExpence;
    }
    public void setServiceExpence(double serviceExpence)
    {
        this.serviceExpence = serviceExpence;
    }
    public void setProductExpence(double productExpence)
    {
        this.productExpence = productExpence;
    }
    public double getTotalExpence()
    {
        return productExpence+serviceExpence;
    }
    public override string ToString()
    {
        return base.ToString();
    }
}