using BlazorMarker.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMarker.Sample.Pages
{
    public partial class Index
    {
        [Inject]
        public BlazorMarkerService BlazorMarker { get; set; }

        public async Task TestClick()
        {
            await BlazorMarker.InitializeArea("testmarker");
            await BlazorMarker.Show();
        }
    }
}
