using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Diffrentreturntypeofmethods
{
    public class doubletypemethods
    {
        public double MyFirstYearSalary_double(int salary)
        {
            return salary;
        }
        public double SecondYearSalary_double(int salary, int hikepercentage)
        {
            return salary + hikepercentage;
        }
        public double ThirdYearSalary_double(int salary, int hikepercentage, int bonus)
        {
            return salary + hikepercentage + bonus;
        }
    }
}
