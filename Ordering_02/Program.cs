using DataAccess.MySQL;

var db = new northwindContext();
var query1 = from c in db.Customers 
             orderby c.CustomerId
             select c;

foreach (var item in query1)
{
    Console.WriteLine($"{item.CustomerId} {item.CompanyName}");
}
Console.WriteLine("=========================");

var query2 = from c in db.Customers
             orderby c.CustomerId descending
             select c;

foreach (var item in query2)
{
    Console.WriteLine($"{item.CustomerId} {item.CompanyName}");
}