using System;
using System.Collections.Generic;
using System.Text;

namespace EniDemo.DAO
{
    public class DAOManager
    {
        static List<DAOBase> Daos = new List<DAOBase>();

        public static T GetDAOByClass<T>() where T : new() {
            // Je vais voir si la DAO à déjà été instancié
            foreach (DAOBase dao in Daos)
            {
                if (dao.GetType() == typeof (T))
                {
                    return (T)Convert.ChangeType(dao, typeof(T));
                }
            }

            T newDAO = new T();
            DAOBase DaoInstance = newDAO as DAOBase;
            Daos.Add(DaoInstance);

            return newDAO;
        }
    }
}
