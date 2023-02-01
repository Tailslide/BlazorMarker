using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMarker
{
    public enum DisplayMode
    {
        [Description("inline")] Inline,
        [Description("popup")] Popup
    }
}
