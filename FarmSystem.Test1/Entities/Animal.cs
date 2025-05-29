using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1.Entities
{
    public abstract class Animal : Entity
    {
        #region PROPERTIES
        private int _noOfLegs;

        public int NoOfLegs
        {
            get { return _noOfLegs; }
            set { _noOfLegs = value; }
        }
        #endregion

        #region METHODS
        public abstract void Talk();

        public abstract void Run();

        #endregion
    }
}
