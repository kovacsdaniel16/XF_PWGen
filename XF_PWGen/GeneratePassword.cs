using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XF_PWGen
{
    internal class GeneratePassword
    {
       // public int length; //hány karakter a jelszó (a pwg osztályból) nem kell, mert a másik osztályból veszi
       // public string[] password; //string tömb a jelszó tárolására
        public string numb; //string tömb a számok tárolására
        public string lower; //...kisbetűk
        public string upper; //...nagybetűk
        public string spec; //....spec karakterek

       

        public GeneratePassword(int length) //konstruktor
        {
            PWGenPage pgw = new PWGenPage(); //meghíjuk a pgw osztályt

            //this.length = length;
            //length = Convert.ToInt32(pgw.szam);
           
            
           // password = new string[length];

            numb = "0123456789";

            lower = "abcdefghijklmnopqrstuvwxyz";

            upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            spec = "@#$%_-{}[]()/'~,;:.*";

            //exc = "{}[]()/'~,;:.";
        }

         public string getPassword(int length, string valid)
        {
            // throw new NotImplementedException();

            PWGenPage pgw = new PWGenPage();




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