using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    //example 1
    
    public class AssemblyOneClassI
    {
        protected internal int ID = 999;
    }
    public class AssemblyOneClassII
    {
       
        public void Test()
        {
            AssemblyOneClassI instance = new AssemblyOneClassI();
            // Can access inetrnal member ID, AssemblyOneClassII and AssemblyOneClassI
            // are present in the same assembly            
            Console.WriteLine(instance.ID);
        }
    }

    //example 2

    //Class is marked internal. This class is available only within AssemblyOne
    internal class AssemblyOneClass
    {
        public void Print()
        {
            Console.WriteLine("Hello");
        }
    }


}

