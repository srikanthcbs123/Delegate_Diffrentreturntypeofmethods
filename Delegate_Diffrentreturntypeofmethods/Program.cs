using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Diffrentreturntypeofmethods
{
    //---Void methods deleagte declartion----
    public delegate void Delegate_Void_Diffrentreturnmethods1(int a, int b);
    public delegate void Delegate_Void_Diffrentreturnmethods2(int a, int b, int c);
    public delegate void Delegate_Void_Diffrentreturnmethods3(int a, int b, int c, int d);
    //---Int methods deleagte declartion----
    public delegate int Delegate_Int_Diffrentreturnmethods1(int salary);
    public delegate int Delegate_Int_Diffrentreturnmethods2(int salary, int hikepercentage);
    public delegate int Delegate_Int_Diffrentreturnmethods3(int salary, int hikepercentage, int bonus);
    //---Double methods deleagte declartion----
    public delegate double Delegate_double_Diffrentreturnmethods1(int salary);
    public delegate double Delegate_double_Diffrentreturnmethods2(int salary, int hikepercentage);
    public delegate double Delegate_double_Diffrentreturnmethods3(int salary, int hikepercentage, int bonus);
    //---String methods deleagte declartion----
    public delegate string Delegate_string_Diffrentreturnmethods1(string dipslayData);
    public delegate string Delegate_string_Diffrentreturnmethods2(string firstName, String lastName);
    public delegate string Delegate_string_Diffrentreturnmethods3(string collegaename, int collegecode);


    internal class Program
    {
        static void Main(string[] args)
        {
            //create the objects for the classes
            doubletypemethods doubletypemethods = new doubletypemethods();
            inttypemethods inttypemethods = new inttypemethods();
            StringtypeMethods stringtypeMethods = new StringtypeMethods();
            VoidtypeMethods voidtypeMethods = new VoidtypeMethods();

            //create the refrence variable for delegate refrences.
            //it will call the 2 arguments void method
            Delegate_Void_Diffrentreturnmethods1 v1;
            v1 = voidtypeMethods.Add;
            v1 += voidtypeMethods.subtract;

            Delegate_Void_Diffrentreturnmethods2 v2;
            v2 = voidtypeMethods.Multiply;

            Delegate_Void_Diffrentreturnmethods3 v3;
            v3 = voidtypeMethods.Division;

            //calling the methods by using delegate refrence
            v1(10, 20);
            v2(10, 20, 30);
            v3(100, 200, 300, 400);

            //----------------------------------------
            //-------------------

            Delegate_Int_Diffrentreturnmethods1 I1;
            I1 = inttypemethods.MyFirstYearSalary;
            Delegate_Int_Diffrentreturnmethods2 I2;
            I2 = inttypemethods.SecondYearSalary;

            Delegate_Int_Diffrentreturnmethods3 I3;
            I3 = inttypemethods.ThirdYearSalary;

            //calling the methods by using delegate refrence
            int result1 = I1(10);
            int result2 = I2(10, 20);
            int result3 = I3(100, 200, 300);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            //------------------------------------

            Delegate_double_Diffrentreturnmethods1 d1;
            d1 = doubletypemethods.MyFirstYearSalary_double;

            Delegate_double_Diffrentreturnmethods2 d2;
            d2 = doubletypemethods.SecondYearSalary_double;

            Delegate_double_Diffrentreturnmethods3 d3;
            d3 = doubletypemethods.ThirdYearSalary_double;

            //calling the methods by using delegate refrence
            double dresult1 = d1(10);
            double dresult2 = d2(10, 20);
            double dresult3 = d3(100, 200, 300);

            Console.WriteLine(dresult1);
            Console.WriteLine(dresult2);
            Console.WriteLine(dresult3);
            //----------------------------------------

            Delegate_string_Diffrentreturnmethods1 s1;
            s1 = stringtypeMethods.dipslayData;
            Delegate_string_Diffrentreturnmethods2 s2;
            s2 = stringtypeMethods.displayEmployeeData;
            Delegate_string_Diffrentreturnmethods3 s3;
            s3 = stringtypeMethods.Dispalycollegaedata;

            //calling the methods by using delegate refrence
            string strResult1 = s1("Hello");
            string strResult2 = s2("Sachin", "tendulkar");
            string strResult3 = s3("Jntu colleage", 67456);


            Console.WriteLine(strResult1);
            Console.WriteLine(strResult2);
            Console.WriteLine(strResult3);


            Console.ReadKey();
        }
    }
}
