using System;
using Fritz.Common;
using System.Reflection;

namespace testAttribute
{
    [Cheered(100, "Venkat Ram Movva", 2018, 12, 10)]
    class Program
    {
        [Cheered(100, "Fritz", 2018, 12, 10)]
        private int X;
        [Cheered(100, "Venkat Ram", 2018, 12, 10)]
        static void Main(string[] args)
        {
           
            Type t = typeof(Program);
             
            CheeredAttribute attrOnClass = (CheeredAttribute) Attribute.GetCustomAttribute(typeof(Program), typeof(CheeredAttribute));
            Console.WriteLine($"{attrOnClass.Name} cheered {attrOnClass.Bits} on {attrOnClass.CheeredOn}");
            MemberInfo[] methodsInfo = t.GetMembers(BindingFlags.Public | BindingFlags.NonPublic |
                              BindingFlags.Static | BindingFlags.Instance);
            for(int j =0; j< methodsInfo.Length; j++){
                CheeredAttribute attrOnMethods = (CheeredAttribute) Attribute.GetCustomAttribute(methodsInfo[j], typeof(CheeredAttribute));
                if(attrOnMethods != null)
                    Console.WriteLine($"{attrOnMethods.Name} cheered {attrOnMethods.Bits} on {attrOnMethods.CheeredOn}");
            }
        }
    }
}
