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

        public string symbols; //ebben a strinben fog tárolódni a jelszó karakterkészlete
        public string numbers;
        public string upper;
        public string lower;
        int x; //a pickerben tárolt számok indexe
        public string szam; //a pickerben tárolt szám(string formában?)
        



        public PWGenPage()
        {
            InitializeComponent();
        }

        private void btGenerate_Clicked(object sender, EventArgs e) //kész
        {
           
            GeneratePassword pg = new GeneratePassword(); //Ha megnyomom a GENERATE gombot: 1 meghívom a GeneratePassword osztályt

            pg.getcheckBoxes(symbols,numbers,lower,upper);
            edPassword.Text = pg.getPassword(Convert.ToInt32(szam)); //az edPassword mezőbe betöltöm a generált jelszót.

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
            if (cbSymbols.IsChecked) symbols = "@#$%_-{}[]()/'~,;:.*";

            else symbols = null;
        }

        private void cbNumbers_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (cbNumbers.IsChecked) numbers = "0123456789";

            else numbers = null;
        }

        private void cbLower_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (cbLower.IsChecked) lower = "abcdefghijklmnoqrstuvwxyz";

            else lower = null;
        }

        private void cbUpper_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (cbUpper.IsChecked) symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            else symbols = null;
        }


        /*private void cbSymbols_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (CbSymbols.IsChecked)

                valid = "@#$%_-{}[]()/'~,;:.*";

            else return;    
            CbSymbols
            
        }

        private void cbNumbers_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (cbNumbers.IsChecked)

                valid += "0123456789";

            else return;
        }
        */
    }
}