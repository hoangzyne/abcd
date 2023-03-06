// See https://aka.ms/new-console-template for more information
using DuAnMoi.Model;
using DuAnMoi.Repository;




var db = new AppDBContext();
Repository<Category> repositoryCategory = new Repository<Category>(db);

//await repositoryCategory.Create(new Category { Name = "Moba"});
//await repositoryCategory.Create(new Category { Name = "RPG" });
//await repositoryCategory.Create(new Category { Name = "Music" });
//await repositoryCategory.Create(new Category { Name = "FPS" });

Repository<Customer> repositoryCustomer = new Repository<Customer>(db);
await repositoryCustomer.Create(new Customer
{
    FirstName = "Dung",
    LastName = "Nguyen"
});
await repositoryCustomer.Create(new Customer
{
    FirstName = "Tèo",
    LastName = "Trần Văn"
});

Console.WriteLine("Created: 2 Customer");