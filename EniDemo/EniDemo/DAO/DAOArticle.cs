using System;
using System.Collections.Generic;
using System.Text;

namespace EniDemo.DAO
{
    public class DAOArticle : DAOBase
    {
        public List<String> GetArticles()
        {
            return new List<String>
            {
                "Isaac",
                "Julien"
            };
        }
    }
}
