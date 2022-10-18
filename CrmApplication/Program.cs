//// See https://aka.ms/new-console-template for more information


//LINQ  =>  is for querying, not for updating the data

using CrmApplication.Model;
using CrmApplication.Repository;
using CrmApplication.Service;
using System.Reflection;

var aProduct = new Product { Id = 2, Name = "snack" };
var aProduct2 = new Product { Id = 4, Name = "snack2" };


///
var products = new List<Product>();

products.Add(aProduct);
products.Add(aProduct);
products.Add(aProduct2);
products.Add(aProduct2);

//select, filter

//return custom 
var someProduct1 = products.Select(x => new { x.Id }  ).ToList();


// returns one row 
try 
{ 
    var someProduct = products.Select(x => x).Where(x => x.Id == 1).First();
    var someProduct3 = products.Where(x => x.Id == 1).First();
}
catch(Exception c)
{
    Console.WriteLine(c.Message);
}

var someProductP = products.Where(x => x.Id == 1).FirstOrDefault();


if (someProductP == null)
    Console.WriteLine("not Found");

// returns many rows

var someProducts = products.Where(x => x.Id == 1).ToArray();

//paging and sorting
int pageNumber = 5;
int pageSize = 20;

var sortedPage = products
    .Skip((pageNumber-1)*pageSize)
    .Take(pageSize)
    .OrderBy(product => product.Name)
   .ThenBy(product => product.Id)   
    .ToList();
 
 
//aggregation
//returns List
var groupBy = products
            .GroupBy(p => p.Name).ToList();

//returns scalar
var sumId = products.Sum(p => p.Id);


// returns a list
var result = products
   .GroupBy(p => p.Name)
   .Select(cl => new  
   {
      Name = cl.Select(x => x.Name).FirstOrDefault(),
      TotalInt = cl.Sum(c => c.Id),
   }).ToList();


result.ForEach(r => Console.WriteLine($"{r.Name}  {r.TotalInt}"));

//sort
var sortedProducts = products.OrderBy(x => x.Id).ToList();



//combine results
// join, except, substract










////Console.WriteLine("Give the id");
////string? code;
////code = Console.ReadLine();
////int id = 0;
////if (code != null)
////  id = int.Parse(code);

////Console.WriteLine("Give the name");
////string? name;
////name = Console.ReadLine();

////Console.WriteLine("Give the balance");
////string? balanceAsString;
////balanceAsString = Console.ReadLine();
////decimal balance = 0m;
////if (balanceAsString != null)
////    balance = decimal.Parse(balanceAsString);

////Console.WriteLine("Give the Address");
////string? Address;
////Address = Console.ReadLine();

//var id = 45;
//var name = "Pantelis";
//var balance = 0;
//var address = "Athens";

//var customer = new Customer()
//{
//    Id = id,
//    Name = name,
//    Balance = balance,
//    Address = address
//};


//Console.WriteLine(customer);

//ICustomerService customerService = new CustomerServiceArray();
//customerService.Add(customer);
//customerService.Add(customer);


//List<Customer> list = customerService.View();
//foreach(Customer c in list){
//    Console.WriteLine(c.Name);
//}


//var customerStructure = new CustomerStructure {Name = "George", Address="Lamia" };


////var person = new Person();


//////////////////////////////////////
//ICalculation calculation = new Calculation();

//ResponseData<decimal> responseData = calculation.Operation(1, 0);
//Console.WriteLine($"Description ={responseData.Description} returnData = {responseData.Data}" );




var _bookList  = new List<Book>();
var _memberList = new List<Member>();
var _lendingList = new List<Lending>();

var _bookRepo = new BookRepository(_bookList );
var _memberRepo = new MemberRepository(_memberList);
var _lendingRepo = new LendingRepository(_lendingList);

var libraryService = new LibraryService(_bookRepo,_memberRepo, _lendingRepo );


var member = new Member {  Name = "Dimitris" };
var book = new Book { Author = "Hemingway", Title = "The man and the sea" };


libraryService.AddMember(member);
libraryService.AddBook(book);
libraryService.LendBook(1, 1);

 

 