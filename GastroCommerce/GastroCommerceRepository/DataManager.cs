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
        private DataLayerDataContext DB { get; set; }

        public DataManager()
        {
            if (!String.IsNullOrEmpty(ConnectionString))
            {
                this.DB = new DataLayerDataContext(ConnectionString);
            }
            else
            {
                this.DB = new DataLayerDataContext();
            }
        }

        }
    }
}
