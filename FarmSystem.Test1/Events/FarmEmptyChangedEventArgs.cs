using FarmSystem.Test1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1.Events
{
    /// <summary>
    /// Custom EventArgs class for passing list of the released animals
    /// </summary>
    public class FarmEmptyChangedEventArgs : EventArgs
    {
        public Queue<Animal> AnimalsReleased { get; set; }

        public FarmEmptyChangedEventArgs(Queue<Animal> animalsReleased)
        {
            AnimalsReleased = animalsReleased;
        }
    }
}
