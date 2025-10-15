using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    int num2 = Convert.ToInt32(Console.ReadLine());
            //    try
            //    {
            //        int result = num1 / num2;
            //        Console.WriteLine(result);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.ToString());
            //    }
            //    finally { 
            //        Console.WriteLine("Executed");
            //    }
            //}

            //try
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(num);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (OverflowException e) {
            //    Console.WriteLine(e.Message);
            //} finally {
            //    Console.WriteLine("Completed");
            //}

            //int salary = Convert.ToInt32(Console.ReadLine());
            //try
            //{
            //    if (salary < 0)
            //    {
            //        throw new Exception("Salary can not be negative");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your Salary"+ salary);
            //    }
            //}
            //catch (Exception ex) { 
            //    Console.WriteLine(ex.ToString());
            //}
            //Console.WriteLine("Salary Handled");




            //int balance = Convert.ToInt32(Console.ReadLine());
            //int withdraw = Convert.ToInt32(Console.ReadLine());
            //try
            //{
            //    int bal = balance - withdraw;
            //    if (bal < 0)
            //    {
            //        throw new Exception("Insufficient Balance");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your balance: "+ bal);
            //    }
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}



            try
            {
                int marks = Convert.ToInt32(Console.ReadLine());
                if (marks < 0 || marks > 100)
                {
                    throw new Exception("InvalidMarks");
                }
                else
                {
                    Console.WriteLine("Marks: "+ marks);
                }
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
