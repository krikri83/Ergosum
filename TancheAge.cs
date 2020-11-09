using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ergosum
{
    public class TrancheAge
    {
        private int code;
        private int ageMin;
        private int ageMax;
        public TrancheAge(int code, int agemini, int agemaxi)
        {
            this.code = code;
            this.ageMax = agemaxi;
            this.ageMin = agemini;
        }
        public int getCode() { return this.code; }
        public int getAgeMin() { return this.ageMin; }
        public int getAgeMaxi() { return this.ageMax; }
    }
}
