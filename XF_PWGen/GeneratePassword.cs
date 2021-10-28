using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XF_PWGen
{
    internal class GeneratePassword
    {
      
        public string value;

        public GeneratePassword() //konstruktor
        {
                    
        }

        public  void getcheckBoxes(string symbols, string numbers, string lower, string upper)
            //ez a metódus fűzi össze a felhasználó által megadott lehetőségeket
        {
            value = symbols+numbers+lower+upper;
        }

         public string getPassword(int length) //https://stackoverflow.com/questions/54991/generating-random-passwords
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