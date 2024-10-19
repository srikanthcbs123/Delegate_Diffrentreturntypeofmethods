using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Diffrentreturntypeofmethods
{
    internal class inttypemethods
    {
        public int MyFirstYearSalary(int salary)
        {
            return salary;
        }
        public int SecondYearSalary(int salary,int hikepercentage)
        {
            return salary + hikepercentage;
        }
        public int ThirdYearSalary(int salary, int hikepercentage, int bonus)
        {
            return salary + hikepercentage+bonus;
        }
    }
}
