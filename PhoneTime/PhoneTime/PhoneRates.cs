using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneTime
{
    public class PhoneRates
    {
        private int _firstMin;
        private int _mins2_10;
        private int _min11;

        public int FirstMin{ get => _firstMin ; set => _firstMin = value; }
        public int Mins2_10 { get => _mins2_10; set => _mins2_10 = value; }
        public int Min11 { get => _min11; set => _min11 = value; }

        public PhoneRates(int firstMin, int mins2To10, int mins11)
        {
            this._firstMin = firstMin;
            this._mins2_10 = mins2To10;
            this._min11 = mins11;
        }
    }
}
