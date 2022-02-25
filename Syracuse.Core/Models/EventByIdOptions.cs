using System;
using System.Collections.Generic;
using System.Text;

namespace Syracuse.Mobitheque.Core.Models
{
    public class EventByIdOptions
    {
        public EventByIdOptions( long id)
        {
            this.id = id;
        }

        public long id { get; set; }
    }
}
