using System;
using CityResturant.Domain.Entities;
using CityResturant.Infrastructure.DataBContext;

namespace CityResturant.Infrastructure.Seeders;

internal class ResturantSeeder
{
    public async Task Seed(ApplicationDbContext dbContext)
    {
        if(await dbContext.Database.CanConnectAsync())
        {
            if(!dbContext.Resturants.Any())
            {
                var resturants = GetResturants();
                await dbContext.Resturants.AddRangeAsync();
                await dbContext.SaveChangesAsync();
            
            }
        }
    }

    private IEnumerable<Resturant> GetResturants()
    {
        List<Resturant> resturants =[
            new()
            {
                Name = "Chicken Republic",
                Description = "It is a fast food in Nigeria and they sell the best food",
                HasDelivery = true,
                ContactEmail = "Chickenrep@gmail.com",
                Dishes = [
                    new()
                    {
                        Name = "Chicken wing",
                        Price= 200.00M
                    }
                ],
                Address = new()
                {
                    City = "Lagos",
                    Street = "Surulere",
                    PostalCode = "CVB 13 10"
                }
            },
            new()
            {
                Name = "KFC",
                Description = "It is a fast food in Nigeria and they sell the best fries and chiken",
                HasDelivery = true,
                ContactEmail = "KFCng@gmail.com",
                Dishes = [
                    new()
                    {
                        Name = "Burger",
                        Price= 120.00M
                    }
                ],
                Address = new()
                {
                    City = "Lagos",
                    Street = "Ikeja",
                    PostalCode = "ASD 1Q 10"
                }

            },
            new()
            {
                Name = "Mr Biggs",
                Description = "First and old fast food with quality food",
                HasDelivery = false,
                ContactEmail = "biggsng@gmail.com",
                Dishes = [
                    new()
                    {
                        Name = "Meat pie",
                        Price= 180.00M
                    }
                ],
                Address = new()
                {
                    City = "Lagos",
                    Street = "Ijesha",
                    PostalCode = "AfD 1p 10"
                }

            }
        ];
        return resturants;
    }
}
