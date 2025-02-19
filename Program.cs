using System.Collections.Generic;
using Demo;

namespace session3_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var proudct = ListGenerator.ProductList;
            var customer = ListGenerator.CustomerList;
            string[] _words = File.ReadAllLines("dictionary_english.txt");

            #region  Partitioning Operators
            #region 1   
            //var result = customer.Where(c => c.City == " Washington").Take(3).ToList();
            //var result =  from c in customer 
            //              where c.City== "Washington" 
            //              .Take(3) 
            //              select c;

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}\n");
            //}

            #endregion
            #region 2
            //var result = customer.Where(c => c.City == " Washington").Skip(2).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}\n");
            //}
            #endregion
            #region 3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((number, index) => number > index).ToList();
            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region 4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile(n => n %3!=0).ToList() ;


            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion
            #region 5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile((num, index) => num >= index).ToList();
            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #endregion
            #region  Quantifiers
            #region 1
            //var result = _words.Contains("ei");
            //Console.WriteLine(result);
            #endregion
            #region 2
            //var result =  proudct.GroupBy(p=>p.Category).Where(p=>p.Any(p=>p.UnitsInStock==0)).ToList();


            //foreach (var item in result)
            //{
            //    Console.WriteLine($"_________________type of category:{item.Key}_______");
            //    foreach (var ite in item)
            //    {
            //        Console.WriteLine($"{ite.ProductID}:{ite.ProductName}");
            //    }
            //}


            #endregion
            #region 3
            //var result = proudct.GroupBy(p => p.Category).Where(p => p.Any(p => p.UnitsInStock > 0)).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"_________________type of category:{item.Key}_______");
            //    foreach (var ite in item)
            //    {
            //        Console.WriteLine($"{ite.ProductID}:{ite.ProductName}");
            //    }
            //}
            #endregion
            #endregion
            #region Grouping Operators
            #region 1
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result =numbers.GroupBy(num=>num%5).ToList();
            //foreach (var grpup in result) 
            //{ 
            //    Console.WriteLine( $" number with a remainder of :{grpup.Key} when divide by 5");
            //    foreach (var grpup2 in grpup) 
            //    {
            //        Console.WriteLine(grpup2);
            //    }

            //}

            #endregion
            #region 2
            //var result= _words.GroupBy(word=> word.First()).ToList();
            //foreach (var grpup in result)
            //{
            //    Console.WriteLine($" number with a remainder of :{grpup.Key} ");
            //    foreach (var grpup2 in grpup)
            //    {
            //        Console.WriteLine(grpup2);
            //    }

            //}
            #endregion
            #region 3
            //String[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            //var result = Arr.GroupBy(arr => arr.Contains(""));

            //foreach (var grpup in result)
            //{
            //    Console.WriteLine($" number with a remainder of :{grpup.Key} ");
            //    foreach (var grpup2 in grpup)
            //    {
            //        Console.WriteLine(grpup2);
            //    }
            //}
            #endregion
            #endregion

        }
    }
}
