using System;
class Customer
{
    string name;
    Boolean member = false;
    string memberType;
    public Customer(string name)
    {
        this.name = name;
    }
    public string getName()
    {
        return name;
    }
    public Boolean isMember()
    {
        return member;
    }
    public void setMember(Boolean member)
    {
        this.member = member;
    }
    public void setMemberType(string type)
    {
        memberType = type;
    }
    public string getMemberType()
    {
        return memberType;
    }
    public override string ToString()
    {
        return base.ToString();
    }
}