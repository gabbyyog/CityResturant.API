using System;

namespace CityResturant.Domain.Entities;

public class Address
{
    public int Id { get; set; }
    public string Street { get; set; } = default!;
    public string PostalCode { get; set; } = default!;

}
