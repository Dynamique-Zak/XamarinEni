using System;
using System.Collections.Generic;
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
        public PageDemo()
        {
            InitializeComponent();
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