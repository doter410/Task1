using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Task1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {   
        public Page2()
      {
            InitializeComponent();
           


        }
        
       /* public class List
        {
            public string Text;
            public List(string List)
            {
                Text = List;
            }

        }
        List text = new List()
        {

        };
        */



        private async void Button_click3(object sender, EventArgs e)
            {
                
                App.Current.MainPage = new
                NavigationPage(new MainPage { Title=editor.Text  });
            }
       



}

    
}

