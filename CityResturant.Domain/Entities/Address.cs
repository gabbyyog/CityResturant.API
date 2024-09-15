using System;

namespace CityResturant.Domain.Entities;

public class Address
{
    public string City { get; set; } = default!;
    public string Street { get; set; } = default!;
    public string PostalCode { get; set; } = default!;

}
