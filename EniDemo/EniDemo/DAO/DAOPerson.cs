using System;
using System.Collections.Generic;
using System.Text;

namespace EniDemo.DAO
{
    public class DAOPerson : DAOBase
    {
        public List<String> GetPersonIds()
        {
            return new List<String>
            {
                "Isaac",
                "Julien"
            };
        }
    }
}
