using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1.Events
{
    public class FarmEmptyChangedEvent
    {
        #region EVENTS
        //signature for the event (return datatype and arguments)
        public delegate void FarmEmptyChangedHandler(object sender, FarmEmptyChangedEventArgs args);

        //event for notifying when animals are released from the farm
        public event FarmEmptyChangedHandler FarmEmptyChanged;

        #endregion

        /// <summary>
        /// Subscribe to the event
        /// </summary>
        /// <param name="callback"></param>
        public void Subscribe(FarmEmptyChangedHandler callback)
        {
            this.FarmEmptyChanged += callback;
        }

        /// <summary>
        /// Raise the event when all animals have left the farm
        /// </summary>
        /// <param name="args">AnimalsReleasedChangedEventArgs containing the animals released</param>
        public void OnFarmEmptyChanged(object sender, FarmEmptyChangedEventArgs args)
        {
            this.FarmEmptyChanged?.Invoke(sender, args);
        }

    }
}
