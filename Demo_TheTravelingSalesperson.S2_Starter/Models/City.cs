using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_TheTravelingSalesperson
{
    public class City
    {
        #region Fields

        private string _cityVisited;
        private DateTime _dateArrive;

        #endregion

        #region Properties

        public string CityVisted
        {
            get { return _cityVisited; }
            set { _cityVisited = value; }
        }

        public DateTime DateArrive
        {
            get { return _dateArrive; }
            set { _dateArrive = value; }
        }

        #endregion

        #region Constructors

        #endregion

        #region Methods

        #endregion
    }
}
