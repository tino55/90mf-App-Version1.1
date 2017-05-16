using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _90mfApp
{
    class FA
    {
        //league class variables
        private string faName;
        private int minrep;
        private int maxrep;
        private int minprize;
        private int maxprize;
        private int members;


        //fa constructor
        //ORDER: FaName, min, max, members
        public FA(string theFAName, int theMinRep, int theMaxRep, int theMinPrize, int theMaxPrize, int theMembers)
        {
            faName = theFAName;
            minrep = theMinRep;
            maxrep = theMaxRep;
            minprize = theMinPrize;
            maxprize = theMaxPrize;
            members = theMembers;
        }


        //getters

        public string getFAName()
        {
            return faName;
        }

        public int getMinrep()
        {
            return minrep;
        }

        public int getMaxrep()
        {
            return maxrep;
        }

        public int getMinPrize()
        {
            return minprize;
        }

        public int getMaxPrize()
        {
            return maxprize;
        }

        public int getMembers()
        {
            return members;
        }



        //setters
        public void setFAName(string inFAName)
        {
            faName = inFAName;
        }

        public void setMinRep(int inMinRep)
        {
            minrep = inMinRep;
        }

        public void setMaxRep(int inMaxRep)
        {
            maxrep = inMaxRep;
        }

        public void setMinPrize(int inMinPrize)
        {
            minprize = inMinPrize;
        }

        public void setMaxPrize(int inMaxPrize)
        {
            maxprize = inMaxPrize;
        }

        public void setMembers(int inMembers)
        {
            members = inMembers;
        }


    } //end of FA class
}
