using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ManeBellum.Core.Util;

namespace ManeBellum.Core.Data
{
    /// <summary>
    /// a starbase in space, used to supply fleets, construction and defence
    /// </summary>
    public class Starbase : SolarSystemObject
    {
        public Operation StartPoint { get; set; }

        /// <summary>
        /// The fleets based at this base
        /// </summary>
        public SortedObservableCollection<Fleet> Fleets { get { return fleetsList; } }

        public SortedObservableCollection<Fleet> fleetsList = new SortedObservableCollection<Fleet>();
    }
}
