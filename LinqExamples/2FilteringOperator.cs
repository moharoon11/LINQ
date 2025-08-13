

namespace LINQ.LinqExamples;

using System;

using System.Collections.Generic;
using LINQ.Models;

public class FilteringOperator
{

    record Product(string name, decimal price);


    /*
    Filtering Operators	Description
    Where	-> Returns values from the collection based on a predicate function.
    OfType	-> Returns values from the collection based on a specified type. However, it will depend on their ability to cast to a specified type.
    */

    public static void WhereFilter()
    {

        var products = new List<Product>
        {
            new("Laptop", 1500),
            new("Evofox Deathray Keyboard", 1200),
            new("Mouse", 25),
            new("Keyboard", 75),
            new("Monitor", 300)
        };


        // Method Syntax
        var result = products.Where(p => p.price >= 300 && p.price <= 1200);

        foreach (var item in result)
        {
            Console.WriteLine($"{item.name} - {item.price}");
        }

        // Query Syntax

        var queryResult = from accesories in products
                          where accesories.price >= 400 & accesories.price <= 1200
                          select accesories;

        foreach (var item in queryResult)
        {
            Console.WriteLine($"Product Details = {item.name} - {item.price}");
        }
    }

    public static void WhereWithIndexFilter()
    {

        var products = new List<Product>
        {
            new("Laptop", 1500),
            new("Evofox Deathray Keyboard", 1200),
            new("Mouse", 25),
            new("Keyboard", 75),
            new("Monitor", 300)
        };

        // Method Syntax
        var evenIndexResult = products.Where((accesories, index) =>
        {
            if (index % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        });

        foreach (var item in evenIndexResult)
        {
            Console.WriteLine($"Indexed Where = {item.name} - {item.price}");
        }

        var evenIndexResult1 = products.Where((accesories, index) => index % 2 == 1);

        foreach (var item in evenIndexResult)
        {
            Console.WriteLine($"Indexed Where = {item.name} - {item.price}");
        }

        // Query Syntax
        var QueryEvenIndexResult = from indexed in products.Select((product, index) => new { product, index })
                                   where indexed.index % 2 == 0
                                   select indexed.product;

        foreach (var item in QueryEvenIndexResult)
        {
            Console.WriteLine($"Query Indexed Where = {item.name} - {item.price}");
        }

    }

    public static void OFTypeFilter()
    {

        var mixedList = new List<object> { "Hello", 123, 45.6, "World", 789, false, true };

        var intResult = mixedList.OfType<int>();

        foreach (var item in intResult)
        {
            Console.WriteLine(item);
        }

        var exampleList = new List<object> { "apple", 42, "banana", 3.14, "cherry" };

        var upperCaseWordsResult = exampleList.OfType<string>().Select(word => word.ToUpper());

        foreach (var item in upperCaseWordsResult)
        {
            Console.WriteLine(item);
        }

        var result = mixedList.OfType<int>().Where(num => num > 46);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

        var boolResult = mixedList.OfType<bool>().Where(flag => flag == true);

        foreach (var item in boolResult)
        {
            Console.WriteLine(item);
        }

        // QuerySyntax
        var queryResult = from item in mixedList.OfType<int>()
                          where item > 100
                          select item;

       foreach (var item in queryResult)
        {
            Console.WriteLine(item);
        }
                              
        

    }

}