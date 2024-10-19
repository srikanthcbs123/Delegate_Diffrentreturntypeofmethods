using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Diffrentreturntypeofmethods
{
    internal class StringtypeMethods
    {
        public string dipslayData(string dipslayData)
        {
            return dipslayData;
        }
        public string displayEmployeeData(string firstName,String lastName)
        {
            return firstName + lastName;
        }
        public string Dispalycollegaedata(string collegaename,int collegecode)
        {
            string collegeCode=Convert.ToString(collegecode);
            StringBuilder obj = new StringBuilder();
            obj.Append(collegaename);
            obj.Append('-');
            obj.Append(collegecode);
            string result = obj.ToString();
            return result;
        }
    }
}
