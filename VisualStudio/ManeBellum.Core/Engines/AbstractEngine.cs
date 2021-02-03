using ManeBellum.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManeBellum.Core.Engines
{
    public abstract class AbstractEngine
    {
        public ManeBellumGame Game { get; set; }
    }
}
