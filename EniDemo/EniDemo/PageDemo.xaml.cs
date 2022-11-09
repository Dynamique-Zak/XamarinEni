using EniDemo.Model;
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

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDemo : ContentPage
    {

        ObservableCollection<Person> Datas;

        List<Person> PersonList;

        public PageDemo()
        {
            InitializeComponent();

            PersonList = new List<Person>
            {
                new Person { Firstname = "Corentin", Lastname = "DARKSASUKE" },
                new Person { Firstname = "Isaac", Lastname = "Steak Layout" },
                new Person { Firstname = "Julien", Lastname = "Le Fou" },
            };


            Datas = new ObservableCollection<Person>(PersonList);

            ListViewPerson.ItemsSource = Datas;
        }

        private void ModifierClick(object sender, EventArgs e)
        {
            Console.WriteLine(sender);

            // Datas.Add(new Person { Firstname = "Lilian", Lastname = "Test" })
            Datas[1].Firstname = "Chien Chien";

            // Modifier une ligne = Forcer la mise à jour/ou manipulation de l'adresse mémoire d'un element du tableau
            Datas[1] = Datas[1];
        }

        async private void TestListviewClick(object sender, EventArgs e)
        {
            /*
            Console.WriteLine(sender);

            Datas.Add(new Person { Name = "Bruno" });
            */
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