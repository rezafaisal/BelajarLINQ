//using DataAccess.MySQL;
using DataAccess.SQLServer;

var db = new northwindContext();

Customer c = new Customer();
c.CustomerId = "LC";
c.CompanyName = "Learning Center";
db.Customers.Add(c);
db.SaveChanges();

var query = from s in db.Customers select s;

foreach (var item in query)
{
    Console.WriteLine(item.CompanyName);
}