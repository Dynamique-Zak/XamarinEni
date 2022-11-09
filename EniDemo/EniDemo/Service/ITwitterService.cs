using EniDemo.Model;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace EniDemo.Service
{
    public interface ITwitterService
    {
        bool authenticate(String Identifiant, String Password);

        List<Tweet> getTweets(String Identifiant);
    }
}
