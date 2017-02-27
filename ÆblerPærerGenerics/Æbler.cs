using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÆblerPærerGenerics
{
    public class Æbler
    {
        public string Navn { get; set; }
        public decimal Pris { get; set; }
        public int Lager { get; set; }



        public override bool Equals(object obj)
        {
            Æbler æble = obj as Æbler;

            if (this.Navn == æble.Navn && this.Lager == æble.Lager && this.Pris == æble.Pris)

                return true;

            else

                return false;
        }

        public override int GetHashCode()
        {
            return this.Navn.GetHashCode() ^ this.Pris.GetHashCode() ^ this.Lager.GetHashCode();
        }
    }

}
