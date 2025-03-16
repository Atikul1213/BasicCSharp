// See https://aka.ms/new-console-template for more information
using Tuples;

Console.WriteLine("Hello, World!");

var tupleExample = new TupleExample();

var values = new List<double> { 1.0, 2.0, 3.0, 4.0, 5.0 };

var result = tupleExample.Calculate(values);

Console.WriteLine($"There are {result.Item1} values and their sum is {result.Item2}");


// New way of returning multiple values

var result1 = tupleExample.Calculate1(values);
Console.WriteLine($"There are {result.Item1} values and their sum is {result.Item2}");


// Get Employee Details

(string name, double salary, string company, string designation) = tupleExample.GetEmployeeDetails(1);

Console.WriteLine($"Name: {name}  salary: {salary} Company: {company} designation: {designation}");