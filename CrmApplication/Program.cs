// See https://aka.ms/new-console-template for more information
using CrmApplication.DataTranfer;
using CrmApplication.Model;
using CrmApplication.Service;






//Console.WriteLine("Give the id");
//string? code;
//code = Console.ReadLine();
//int id = 0;
//if (code != null)
//  id = int.Parse(code);

//Console.WriteLine("Give the name");
//string? name;
//name = Console.ReadLine();

//Console.WriteLine("Give the balance");
//string? balanceAsString;
//balanceAsString = Console.ReadLine();
//decimal balance = 0m;
//if (balanceAsString != null)
//    balance = decimal.Parse(balanceAsString);

//Console.WriteLine("Give the Address");
//string? Address;
//Address = Console.ReadLine();

var id = 45;
var name = "Pantelis";
var balance = 0;
var address = "Athens";

var customer = new Customer()
{
    Id = id,
    Name = name,
    Balance = balance,
    Address = address
};


Console.WriteLine(customer);

ICustomerService customerService = new CustomerServiceArray();
customerService.Add(customer);
customerService.Add(customer);


List<Customer> list = customerService.View();
foreach(Customer c in list){
    Console.WriteLine(c.Name);
}


var customerStructure = new CustomerStructure {Name = "George", Address="Lamia" };


var person = new Person();
 