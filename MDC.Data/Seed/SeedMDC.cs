using System;
using System.Linq;
using MDC.DAL.Context;
using MDC.Domain.Entities;
using MDC.Domain.Tools;

namespace MDC.DAL.Seed
{
    public class SeedMDC
    {
       
        public static void Initialize(ContextMDC db)
        {
  
            if (!db.Stories.Any())
            {
                db.Stories.AddRange(
                    new Store
                    {
                        Id = "50da39f1-cff0-496f-983b-339cb65596a1",
                        Name = "Informática"
                    },
                    new Store
                    {
                        Id = "549ccefc-252a-49e2-97cc-8e9422de36ed",
                        Name = "Eletrônicos"
                    }
                );
            }
            if (!db.Categories.Any())
            {
                db.Categories.AddRange(
                    new Category
                    {
                        Id = "1f5c9dce-c5dd-406c-802a-9f6a7f3e3223",
                        Name = "Celulares",
                        store = db.Stories.Find("50da39f1-cff0-496f-983b-339cb65596a1")
                    },
                    new Category
                    {
                        Id = "a8e05436-11dd-4cea-96c2-756cab929828",
                        Name = "TV",
                        store = db.Stories.Find("549ccefc-252a-49e2-97cc-8e9422de36ed")
                    }
                );
                db.SaveChanges();
            }

            if (!db.Products.Any())
            {
                db.Products.AddRange(
                    new Product
                    {
                        Id = GuidSqlite.getGuid(),
                        Name = "Samsung Galaxy S8 Plus 64GB",
                        Price =  3343,
                        Category = db.Categories.Find("1f5c9dce-c5dd-406c-802a-9f6a7f3e3223")
                    },
                    new Product
                    {
                        Id = GuidSqlite.getGuid(),
                        Name = "Smart TV 4K Ultra HD Samsung LED 65 polegadas UN65MU6100G",
                        Price = 5499,
                        Category = db.Categories.Find("a8e05436-11dd-4cea-96c2-756cab929828")
                    }

                );
                db.SaveChanges();
            }
            if (!db.Countries.Any())
            {
                db.Countries.AddRange(
                    new Country
                    {
                        Id = "576975a0-d02d-4a89-ac49-5ffee3732f8b",
                        Name = "Brasil",
                
                    },
                    new Country
                    {
                        Id = "e5ee1768-ee61-45d1-94b0-1dc6e89ed24c",
                        Name = "Argentina",

                    }

                );
                db.SaveChanges();
            }
            if (!db.States.Any())
            {
                db.States.AddRange(
                    new State
                    {
                        Id = "b9a72c69-a5dd-4111-8d7d-7b66e6311cbd",
                        Name = "Rio de Janeiro",
                        Country = db.Countries.Find("576975a0-d02d-4a89-ac49-5ffee3732f8b")

                    },
                    new State
                    {
                        Id = "acf06d94-40cf-499e-b418-60be9656fa11",
                        Name = "Buenos Aires",
                        Country = db.Countries.Find("e5ee1768-ee61-45d1-94b0-1dc6e89ed24c")

                    }

                );
                db.SaveChanges();
            }
            if (!db.Cities.Any())
            {
                db.Cities.AddRange(
                    new City
                    {
                        Id = GuidSqlite.getGuid(),
                        Name = "Cabo Frio",
                        State = db.States.Find("b9a72c69-a5dd-4111-8d7d-7b66e6311cbd")

                    },
                    new City
                    {
                        Id = GuidSqlite.getGuid(),
                        Name = "La Plata",
                        State = db.States.Find("acf06d94-40cf-499e-b418-60be9656fa11")

                    }

                );
                db.SaveChanges();
            }
        }
    }
}