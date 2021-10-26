using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

        string Password; //ebben a strinben fog tárolódni a jelszó

        public PWGenPage()
        {
            InitializeComponent();
        }

        private void btGenerate_Clicked(object sender, EventArgs e)
        {
            //Password = GeneratePassword.getPassword(pckLength);
            //GeneratePassword osztály/getpassword függvény (paraméter egy int ami a jsz. hossza)

            edPassword.Text = "Hello World!";

        }

        private void btCopy_Command(object sender, EventArgs e)
        {
            //ed.Password mezőt kellene vágólapra másolni
        }
    }
}