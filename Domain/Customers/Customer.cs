using Domain.Primitives;
using Domain.ValueObjects;

namespace Domain.Customers;

public sealed class Customer : AggregateRoot
{

    public Customer(CustomerId id, string name, string description, string ubication,PhoneNumber phoneNumber, Address address, bool active)
    {
        Id = id;
        Name = name;
        Description = description;
        Ubication = ubication;
        Address = address;
        Active = active;
        Phonenumber =phoneNumber;

    }

    private Customer(){}


    public CustomerId Id{ get; private set; }
    public string Name{ get; private set; } = string.Empty;
    public string Description{ get; private set; }= string.Empty;

    public string Ubication{ get; private set; }= string.Empty;

    public Address Address{ get; private set; }
    public PhoneNumber Phonenumber{ get; private set; }
    public bool Active{ get;  set; }

}