namespace Storium.Domain.Users
{
    public record Address(
        string Country,
        string City,
        string Street,
        string Fulladdress,
        string PostalCode);

}
