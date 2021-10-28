using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XF_PWGen
{
    internal class GeneratePassword
    {
       
       /* public string numb; //string tömb a számok tárolására
        public string lower; //...kisbetűk
        public string upper; //...nagybetűk
        public string spec; //....spec karakterek */

        public string value;

       

        public GeneratePassword() //konstruktor
        {
          
           /* numb = "0123456789";

            lower = "abcdefghijklmnopqrstuvwxyz";

            upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            spec = "@#$%_-{}[]()/'~,;:.*";

            //exc = "{}[]()/'~,;:.";
            /* PWGenPage pgw = new PWGenPage();

             if (pgw.CbSymbols.IsChecked)
             {
                 value = spec;
             }
            */
        }

        public  void getcheckBoxes(string symbols, string numbers, string lower, string upper)
        {
            value = symbols+numbers+lower+upper;
        }

         public string getPassword(int length)
        {
          
            if (!string.IsNullOrEmpty(value))
            {

                StringBuilder res = new StringBuilder();

                Random rnd = new Random();

                while (0 < length--)
                {
                    res.Append(value[rnd.Next(value.Length)]);
                }
                return res.ToString();
            }
            else return null;
           
        }


    }
}