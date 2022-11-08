using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EniDemo
{
    public class Person
    {
        public String Name { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDemo : ContentPage
    {

        ObservableCollection<Person> Datas;

        public PageDemo()
        {
            InitializeComponent();

            List<Person> PersonList = new List<Person>
            {
                new Person { Name = "Corentin" },
                new Person { Name = "Isaac" },
                new Person { Name = "Julien" },
            };


            Datas = new ObservableCollection<Person>(PersonList);

            MyListView.ItemsSource = Datas;
        }

        

        private void ModifierClick(object sender, EventArgs e)
        {
            Console.WriteLine(sender);

            Datas[1].Name = "Chien Chien";

            Datas[1] = Datas[1];
        }

        private void TestListviewClick(object sender, EventArgs e)
        {
            Console.WriteLine(sender);

            Datas.Add(new Person { Name = "Bruno" });
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            Console.WriteLine(sender);

            
            // Faire du code quand c'est ImageButton
            if (sender.GetType() == typeof(ImageButton))
            {
                ImageButton ImageButton = (ImageButton)sender;
                /*
                String filename = ImageButton.Source.ToString();
                ImageButton.Source = (filename.Equals("File: pencil.png")) ? "test.jpg": "pencil.png";
                */

                // Récupérer images dans le projet mutualisé/commun/.Net Standard
                ImageButton.Source = ImageSource.FromResource("EniDemo.Assets.retweet.png");
            }

            // Faire tel code quand c'est button
            if (sender.GetType() == typeof(Button))
            {
                Button Button = (Button)sender;
                Button.Text = "Test";
            }
        }
    }
}