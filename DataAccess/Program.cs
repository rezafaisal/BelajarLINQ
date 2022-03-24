using DataAccess.SQLServer;

var db = new northwindContext();
var query = from s in db.Customers select s;

foreach (var item in query)
{
    Console.WriteLine(item.CompanyName);
}