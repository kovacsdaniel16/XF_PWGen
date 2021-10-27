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

        public string valid; //ebben a strinben fog tárolódni a jelszó karakterkészlete
        int x; //a pickerben tárolt számok indexe
        public string szam; //a pickerben tárolt szám(string formában?)
        



        public PWGenPage()
        {
            InitializeComponent();
        }

        private void btGenerate_Clicked(object sender, EventArgs e) //kész
        {
            /*

             x = pckLength.SelectedIndex; //int x--> a picker-ben lévő int[] indexe DE!! ha nincs kitöltve -1


            if (x != -1) szam = pckLength.Items[x]; //ha nincs kiválasztva szám, -1-et kapunk, így logikai vizsálat kell végezni

            else
            {
                DisplayAlert("Error!", "Please select a number!", "Ok");
                return;
            }
            */ // ez a kód átkerült egy másik metódusba (pckLength_SelectedIndexChanged)


            ////////////////////////////////////////////////////////
            GeneratePassword pg = new GeneratePassword(Convert.ToInt32(szam)); //Ha megnyomom a GENERATE gombot: 1 meghívom a GeneratePassword osztályt
            
           

           /*!!!!!!->kimenet*/ edPassword.Text = pg.getPassword(Convert.ToInt32(szam),valid); //az edPassword mezőbe betöltöm a generált jelszót.

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

        private void pckLength_SelectedIndexChanged(object sender, EventArgs e) //kész
         {
            x = pckLength.SelectedIndex; //int x--> a picker-ben lévő int[] indexe DE!! ha nincs kitöltve -1


             if (x != -1) szam = pckLength.Items[x]; //ha nincs kiválasztva szám, -1-et kapunk, így logikai vizsálat kell végezni

             else
             {
                 DisplayAlert("Error!", "Please select a number!", "Ok");
                 return;
             }
         }

        private void cbSymbols_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (cbSymbols.IsChecked)

                valid = "@#$%_-{}[]()/'~,;:.*";
            else return;
            
            
        }

        private void cbNumbers_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (cbNumbers.IsChecked)

                valid += "0123456789";
            else return;
        }
    }
}