using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÆblerPærerGenerics
{
    public class Æbler : IComparable <Æbler>
    {
        public string Navn { get; set; }
        public decimal Pris { get; set; }
        public int Lager { get; set; }



        public override bool Equals(object obj)
        {
            Æbler æble = obj as Æbler;

            if (this.Navn == æble.Navn && this.Lager == æble.Lager && this.Pris == æble.Pris)

                return true;

            else if (!(obj is Æbler) || obj == null)

                return false;

            else
                return false;
        }

        public override int GetHashCode()
        {
            return this.Navn.GetHashCode() ^ this.Pris.GetHashCode() ^ this.Lager.GetHashCode();
        }

        public int CompareTo(Æbler other)
        {
            if (this.Pris < other.Pris)
                return -1;
            else if (this.Pris == other.Pris)
                return 0;
            else
                return 1;
            
            //throw new NotImplementedException();
        }
    }

}
