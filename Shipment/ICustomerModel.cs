namespace Shipment
{
    public interface ICustomerModel
    {
        string Address { get; set; }
        string City { get; set; }
        string EmailAdress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
    }
}