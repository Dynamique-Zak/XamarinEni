using EniDemo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EniDemo.Service
{
    public class TwitterServiceMock : ServiceBase, ITwitterService
    {
        public bool authenticate(string Identifiant, string Password)
        {
            // Tester la validité du couple email/mot de passe
            return (Identifiant.Equals("julien@t1bis-canape.com") && Password.Equals("password"));
        }

        public List<Tweet> getTweets(string Identifiant)
        {
            // Retourner une liste de "Tweet" bouchonnée
            return new List<Tweet>
            {
                new Tweet { Identifiant = "test1", Message="Un example", Pseudo = "Wouaf"},
                new Tweet { Identifiant = "test2", Message="Un example 2", Pseudo = "Ouaf"},
                new Tweet { Identifiant = "test3", Message="Un example 3", Pseudo = "Toto"}
            };
        }
    }
}
