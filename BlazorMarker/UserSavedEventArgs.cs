using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMarker
{
    public class UserSavedEventArgs : EventArgs
    {
        public string ElementId { get; set; }
    }
}
