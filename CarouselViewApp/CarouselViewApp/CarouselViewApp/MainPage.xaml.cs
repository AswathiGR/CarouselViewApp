using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;


namespace CarouselViewApp
{
    public class MainPage
    {
       

        private ObservableCollection<Class1> place;


        // Learn more about making custom code visible in the Xamarin.Forms previewer
        // by visiting https://aka.ms/xamarinforms-previewer
        [DesignTimeVisible(false)]
        public class MainPage : ContentPage
    {
        public class MainPage()
        {
   
            place = new ObservableCollection<Class1>();
            place.Add(new Class1 { Title = "Asian Paradise Flycatcher", ImagePath = "Asian-Paradise-Flycatcher.jpg" });
            place.Add(new Class1 { Title = "Sarus Crane", ImagePath = "Sarus-Crane.jpg" });
            place.Add(new Class1 { Title = "Himalayan Monal", ImagePath = "Himalayan-Monal.jpg" });
           
            //InitializeComponent();
        }
    }
}
