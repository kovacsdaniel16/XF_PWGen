using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XF_PWGen
{
    internal class GeneratePassword
    {
        public int length; //hány karakter a jelszó
        public string[] password; //string tömb a jelszó tárolására
        public string numb; //int tömb a számok tárolására
        public string lower; //...kisbetűk
        public string upper; //...nagybetűk
        public string spec; //....spec karakterek
       // public string exc; //...esetlegesen nem kívánt karakterek

       

        public GeneratePassword(int length)
        {
            PWGenPage pgw = new PWGenPage();

            this.length = length;
            length = Convert.ToInt32(pgw.szam);
           
            
            password = new string[length];

            numb = "0123456789";

            lower = "abcdefghijklmnopqrstuvwxyz";

            upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            spec = "@#$%_-{}[]()/'~,;:.*";

            //exc = "{}[]()/'~,;:.";
        }

         public  string getPassword(int length)
        {
            // throw new NotImplementedException();

            PWGenPage pgw = new PWGenPage();



            string valid = "asdfghjkléqwertzuioíyxcvbn";

            StringBuilder res = new StringBuilder();

            Random rnd = new Random();

            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();

        }


    }
}