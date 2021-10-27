using System;
using Xamarin.Forms;

namespace XF_PWGen
{
    internal class GeneratePassword
    {
        public int length; //hány karakter a jelszó
        public string[] password; //string tömb a jelszó tárolására
        public int[] numb; //int tömb a számok tárolására
        public char[] lower; //...kisbetűk
        public char[] upper; //...nagybetűk
        public char[] spec; //....spec karakterek
        public char[] exc; //...esetlegesen nem kívánt karakterek

        public GeneratePassword(int length)
        {
            this.length = length;
           
            
            password = new string[length];

            numb = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            lower = new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };

            upper = new char[lower.Length];
            for (int i = 0; i < lower.Length; i++)
            {
                upper[i] = Char.ToUpper(lower[i]);
            }

            spec = new char[] { '@','#','$','%','_','-',',','*', '{','}','[' ,']' , '(',')', '/', '~',';', ':', '.'};

            exc = new char[] { '{', '}', '[', ']', '(', ')', '/', '~', ';', ':', '.' };
        }

        internal static string getPassword()
        {
            throw new NotImplementedException();
        }


    }
}