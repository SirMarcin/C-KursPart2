using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek.BL
{
    public class Adres
    {
        #region constructors
        public Adres()
        {
                
        }
        public Adres(int adresId)
        {
            AdresId = adresId;
        }
        #endregion

        #region properties
        public int AdresId { get; private set; }
        public string AdresTyp { get; set; }
        public string Ulica { get; set; }
        public string Miasto { get; set; }
        public string KodPocztowy { get; set; }
        public string Kraj { get; set; }
        #endregion
    }
}
