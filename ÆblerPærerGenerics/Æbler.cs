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
        }

        private class sortLagerDescendingHelper : IComparer <Æbler>
        {
            public int Compare(Æbler x, Æbler y)
            {
                if (x.Lager > y.Lager)
                    return 1;
                else if (x.Lager == y.Lager)
                    return 0;
                else
                    return -1;
            }
        }
        public static IComparer<Æbler> sortLagerDescending()
        {
            return new sortLagerDescendingHelper();
        }

        private class sortPrisDecendingHelper : IComparer<Æbler>
        {
            int IComparer<Æbler>.Compare(Æbler x, Æbler y)
            {
                if (x.Pris > y.Pris)
                    return 1;
                else if (x.Pris == y.Pris)
                    return 0;
                else
                    return -1;
            }
        }
        public static IComparer<Æbler> sortPrisDecending()
        {
            return (IComparer<Æbler>)new sortPrisDecendingHelper();
        }

        private class sortPrisAcendingHelper : IComparer<Æbler>
        {
            int IComparer<Æbler>.Compare(Æbler x, Æbler y)
            {
                if (x.Pris > y.Pris)
                    return -1 ;
                else if (x.Pris == y.Pris)
                    return 0;
                else
                    return 1;
            }
        }
        public static IComparer<Æbler> sortPrisAcending()
        {
            return (IComparer<Æbler>)new sortPrisAcendingHelper();
        }

        public override string ToString()
        {
            return $" Navn {this.Navn } Pris {this.Pris} LagerBeholdning {this.Lager}";
        }
    }

}
