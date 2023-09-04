namespace LINQ
  
{using System;
 using System.Linq;
    using System.Security.Cryptography;
    using System.Xml.Schema;

    internal class Program
    {
        static void Main(string[] args)
        {
            //task1

            //var List = new List<int>  { 1, 2, 3 , 4, 5 , 6, 7 ,8 ,9 ,};
            //var newList = List.Where(x=>x%2==0);
            //foreach(int x in newList)
            //{
            //    Console.WriteLine(x);
            //}




            //task2

            //var List = new List <int> { 1 , 4 ,6 , 5, -1 ,-13, 24 , 9 };
            //var listedInt = List.Where(x=>x>1&&x<12);
            //foreach(int x in listedInt)
            //{
            //    Console.WriteLine(x);
            //}




            //task3 

            //var listedInt = new List<int> {9,8,6,5};
            //for (int i = 0; i < listedInt.Count; i++)
            //{
            //    var res = listedInt[i] * listedInt[i];
            //    Console.WriteLine(res);
            //}




            //task4

            //var listedInt = new List<int>() { 1, 4, 7, 9, 3, 6, 3, 9, 8, 5, 2, 7, 1, 8, 4 };
            //var frequency = listedInt.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            //foreach (var item in frequency)
            //{
            //    Console.WriteLine($"Number {item.Key} apprears {item.Value} times");
            //}




            //task5

            //var listedString =  new List<string> { "a", "d", "c", "f", "j", "l", "m", "a" ,"c" ,"f", "m", "j" ,"r" ,"n" ,"a", "d", "g" };
            //var frequency = listedString.GroupBy(x=>x).ToDictionary(x=>x.Key, x=>x.Count());
            //foreach (var item in frequency)
            //{
            //    Console.WriteLine($"Character {item.Key}: {item.Value} times");
            //}




            //task6

            //var listedWeekDays = new List<string> {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            //foreach (var weekDay in listedWeekDays) { Console.WriteLine(weekDay); }




            //task7

            //task8

            //var listedString = new List<string> {"PARIS", "ITALY", "AMERICAN", "RUSSIAN", "CHINESE" };
            //var res = listedString.Where(x=>x.StartsWith("P")&& x.EndsWith("S"));
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"The city starting with P and ending with S is : {item}");
            //}




            //task9

            //var listedInt = new List<int> { 9, 17, 23, 31, 45, 59, 61, 65, 72, 74, 80, 85, 89, 91, 98 };
            //var res = listedInt.Where(x => x > 80).ToList();
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //task10

            //task11

            //task12

            //var listedString = new List<string> {"this", "IS", "STRING"};
            //var isUpperCase = listedString.Where(x=>x==x.ToUpper());
            //foreach(var x in isUpperCase)
            //{
            //    Console.WriteLine(x);
            //}




            //task13




            //task 14




            //task 15

            //var listedString = new List<string> { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };
            //var res = listedString.GroupBy(x=>x).ToDictionary(x=>x.Key, x =>x.Count());
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}




            //task16

            //task17

            //var listedString = new List<string> { };
            //listedString.Add("m");
            //listedString.Add("n");
            //listedString.Add("o");
            //listedString.Add("p");
            //listedString.Add("q");
            //Console.WriteLine("before");
            //foreach (var item in listedString)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("after");
            //listedString.Remove("o");
            //foreach (var item in listedString)
            //{
            //    Console.WriteLine(item);
            //}




            //task18

            //var listedString = new List<string> { };
            //listedString.Add("m");
            //listedString.Add("n");
            //listedString.Add("o");
            //listedString.Add("p");
            //listedString.Add("q");
            //Console.WriteLine("before");
            //foreach (var item in listedString)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("after");
            //listedString.Remove("p");
            //foreach (var item in listedString)
            //{
            //    Console.WriteLine(item);
            //}




            //task19

            //var listedString = new List<string> { };
            //listedString.Add("m");
            //listedString.Add("n");
            //listedString.Add("o");
            //listedString.Add("p");
            //listedString.Add("q");
            //Console.WriteLine("before");
            //foreach (var item in listedString)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("after");
            //listedString.Remove("q");
            //foreach (var item in listedString)
            //{
            //    Console.WriteLine(item);
            //}




            //task20

            //var listedString = new List<string> { };
            //listedString.Add("m");
            //listedString.Add("n");
            //listedString.Add("o");
            //listedString.Add("p");
            //listedString.Add("q");
            //listedString.RemoveAt(3);
            //foreach (var item in listedString)
            //{
            //    Console.WriteLine(item);
            //}




            //task21

            //var listedString = new List<string> { };
            //listedString.Add("m");
            //listedString.Add("n");
            //listedString.Add("o");
            //listedString.Add("p");
            //listedString.Add("q");
            //listedString.RemoveRange(1,3);
            //foreach (var item in listedString)
            //{
            //    Console.WriteLine(item);
            //}

            


            //task22

            //task23

            //task24

            //task25

            //task26

            //task27

            //task28

            var listedString = new List<string> { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            listedString.OrderBy(x=>x.Length).ThenBy(x => x);
            foreach (var item in listedString)
            {
                Console.WriteLine(item);
            }




















































        }
    }
}