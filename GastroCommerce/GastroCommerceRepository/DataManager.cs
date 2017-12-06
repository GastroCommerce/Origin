using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCommerceRepository
{
    public class DataManager
    {
        public static string ConnectionString { get; set; }
        private DataLayerDataContext DataBase { get; set; }

        public DataManager()
        {
            if (!String.IsNullOrEmpty(ConnectionString))
            {
                this.DataBase = new DataLayerDataContext(ConnectionString);
            }
            else
            {
                this.DataBase = new DataLayerDataContext();
            }
        }

        
    }
}
