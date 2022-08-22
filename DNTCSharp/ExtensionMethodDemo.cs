using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNTCSharp
{
    public class ExtensionMethodDemo
    {
        
    }
    public static class ExtensionMethods
    {
        public static bool SubstringPresent(this string str,string substring)
        {
            return str.Contains(substring);
        }
        public static string Reverse(this string str)
        {


            // Reverse using for loop
    //Convert input string to char array and loop through  
            char[] stringArray = str.ToCharArray();

            string reverse = string.Empty;

            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                reverse += stringArray[i];
            }
            if (str.Length <= 1) return str;
            else return Reverse(str.Substring(1)) + str[0];
        }
        }
    
}
