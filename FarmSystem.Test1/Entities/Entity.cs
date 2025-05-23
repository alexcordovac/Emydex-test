using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1.Entities
{
    public abstract class Entity
    {
        public Entity()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        #region PROPERTIES
        private string _id;
        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }
        #endregion

    }
}
