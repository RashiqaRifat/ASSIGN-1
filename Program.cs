// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ProductLibrary;

Product proObj = new Product() { proID = 1, proName = "Mobile", proPrice = 5000, proRating = 4};
//calling method
Console.WriteLine($"ProductId::{proObj.proID}\t ProductName::{proObj.proName}\t ProductPrice{proObj.proPrice}\t ProductRating::{proObj.proPrice}");
Console.WriteLine("Enter the Product Name::");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
string proname=Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
Console.WriteLine("Enter the Product Rating");
#pragma warning disable CS8604 // Possible null reference argument for parameter 's' in 'float float.Parse(string s)'.
int pR = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument for parameter 's' in 'float float.Parse(string s)'.
#pragma warning disable CS1503 // Argument 2: cannot convert from 'float' to 'int'
Console.WriteLine(proObj.ProductSearch(proname ,pR ));
#pragma warning restore CS1503 // Argument 2: cannot convert from 'float' to 'int'

