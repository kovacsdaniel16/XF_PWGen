using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;


namespace XF_PWGen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PWGenPage : ContentPage
    {
        //Edit >> edPassword
        //ListPicker >> pckLength
        //CheckBox Symbols >> cbSymbols
        //CbeckBox Numbers >> cbNumbers
        //CheckBox LowerCase >> cbLower
        //CheckBox UpperCase >> cbUpper
        //CheckBox Exclude >> cbExcl

        public string valid; //ebben a strinben fog tárolódni a jelszó
        int x; //a picker indexe
        public string szam; //a pickerben tárolt szám
        //public List<string> valid;



        public PWGenPage()
        {
            InitializeComponent();
        }

        private void btGenerate_Clicked(object sender, EventArgs e)
        {
            //Password = GeneratePassword.getPassword(pckLength);
            //GeneratePassword osztály/getpassword függvény (paraméter egy int ami a jsz. hossza)
            //////////////////////////////////////////////////////
            /* Picker numberPicker = (Picker) sender;
             index = numberPicker.SelectedIndex;
             picker = new int[index];*/ //zsákutca

             x = pckLength.SelectedIndex; //int x--> a picker-ben lévő int[] indexe DE!! ha nincs kitöltve -1


            if (x != -1) szam = pckLength.Items[x]; //ha nincs kiválasztva szám, -1-et kapunk, így logikai vizsálat kell végezni

            else
            {
                DisplayAlert("Error!", "Please select a number!", "Ok");
                return;
            }

            ////////////////////////////////////////////////////////
            GeneratePassword pg = new GeneratePassword(Convert.ToInt32(szam));
            ////////////////////////////////////////////////////////////////
            if (cbNumbers.IsChecked)
            {
                valid = pg.numb;
            }
            
            if (cbLower.IsChecked)
            {
                valid += pg.lower;
            }
            if (cbUpper.IsChecked)
            {
                valid += pg.upper;
            }
            if (cbSymbols.IsChecked)
            {
                valid += pg.spec;
            }

            /*   if (cbExcl.IsChecked)
               {
                   char[] seged = valid.ToCharArray();
                   foreach (char karakter in seged)
                   {
                       if (karakter==)
                       {

                       }
                   }
               } */


            edPassword.Text = pg.getPassword(Convert.ToInt32(szam));

        }

        private void btCopy_Command(object sender, EventArgs e) //kész
        {
            //ed.Password mezőt kellene vágólapra másolni

            if (!string.IsNullOrEmpty(edPassword.Text))
            {
                Clipboard.SetTextAsync(edPassword.Text);

                DisplayAlert("Accept", "Password: '"+edPassword.Text+"' is copied to Clipboard!", "Ok");

            }
            else DisplayAlert("Error", "Password field is empty", "Ok");

          


        }

       /* private void pckLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            string szam = pckLength.Items[x];
            DisplayAlert(szam, "Selected Item", "Ok");
        }
       */
    }
}