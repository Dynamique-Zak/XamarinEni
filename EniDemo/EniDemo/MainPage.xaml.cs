using EniDemo.DAO;
using EniDemo.Model;
using EniDemo.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace EniDemo
{
    // Pojo
    public class FormResult
    {
        public bool Valid { get; set; }
        public List<String> ErrorMessages { get; set; }
    }

    public partial class MainPage : ContentPage
    {
        // Twitter service membre de la classe MainPage (donc du controller)
        // ITwitterService TwitterService;

        public MainPage()
        {
            InitializeComponent();
            
            // Instancier le service dans le constructeur
            // TwitterService = new TwitterServiceMock();

            SwitchTweetVisiblity(false);
        }

        /// <summary>
        /// Méthode pour contrôler la validité du formulaire
        /// </summary>
        /// <returns>Le resultat du formulaire</returns>
        public FormResult FormValidator()
        {
            // Resultat "valid" défaut
            FormResult Result = new FormResult { Valid = true, ErrorMessages = new List<String>() };

            // Si erreur sur le mdp
            if (PasswordEntry.Text == null || PasswordEntry.Text.ToString().Trim().Length < 6)
            {
                // resulat non valide
                Result.Valid = false;
                // ajouter un message d'erreur dans le résultat
                Result.ErrorMessages.Add("Veuillez entrer un mot de passe d'au moins 6 caractères");
            }

            // Si erreur sur l'email
            if (EmailEntry.Text == null || EmailEntry.Text.ToString().Trim().Length < 3)
            {
                // resulat non valide
                Result.Valid = false;
                // ajouter un message d'erreur dans le résultat
                Result.ErrorMessages.Add("Veuillez entrer un email d'au moins 3 caractères");
            }

            // Dans tout les cas retourner le résultat de la validation
            return Result;
        }

        /// <summary>
        /// Echanger la visibilité du Tweet
        /// Si le tweet est caché alors le formulaire est affiché
        /// Vise versa
        /// </summary>
        /// <param name="TweetIsVisible"></param>
        public void SwitchTweetVisiblity(bool TweetIsVisible)
        {
            // Switch la visibilité
            LoginDiv.IsVisible = !TweetIsVisible;
            ListViewTweets.IsVisible = TweetIsVisible;

            // Si true alors list view
            if (TweetIsVisible)
            {
                // Je récupère ma liste de tweets depuis mon service
                List<Tweet> Tweets = ServiceManager.GetServiceByClass<TwitterServiceMock>().getTweets("");

                // je instancie un Observable collection avec ma liste de tweet en entrée
                ObservableCollection<Tweet> TweetDatas = new ObservableCollection<Tweet>(Tweets);

                // J'associe mon observable collection ma source de données de ma liste view
                ListViewTweets.ItemsSource = TweetDatas;
            }
        }

        /// <summary>
        /// Lors du clique sur le bouton de connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginOnClick(object sender, EventArgs e)
        {
            // Préparer et contrôler la validité du formulaire
            FormResult Result = FormValidator();

            // Si contrôle surface
            if (Result.Valid)
            {
                // Version Simple
                // Contrôle métier - si couple de email/password correct 
                /*
                if (TwitterService.authenticate(this.EmailEntry.Text.ToString(), PasswordEntry.Text.ToString()))
                {
                    // Afficher le tweet
                    SwitchTweetVisiblity(true);
                }
                */
                // Version Generic
                // Contrôle métier - si couple de email/password correct 
                if (ServiceManager.GetServiceByClass<TwitterServiceMock>().authenticate(this.EmailEntry.Text.ToString(), PasswordEntry.Text.ToString())){
                    // Afficher le tweet
                    SwitchTweetVisiblity(true);
                }
                else
                {
                    LabelError.Text = "Couple email/mot de passe incorrect";
                }

            }
            // Sinon erreur
            else
            {
                // Cacher le tweet
                SwitchTweetVisiblity(false);

                // Préparer d'erreur concaténé
                String TmpOutput = "";
                // -- pour chaque erreur 
                foreach (String Error in Result.ErrorMessages) {
                    TmpOutput += "\n" + Error;
                }
                // Afficher le concaténé
                LabelError.Text = TmpOutput;
            }
        }
    }
}
