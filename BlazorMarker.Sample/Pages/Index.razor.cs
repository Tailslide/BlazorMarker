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

        public string Message { get; set; }

        protected override Task OnInitializedAsync()
        {
            BlazorMarker.UserSaved += BlazorMarker_UserSaved;
            return base.OnInitializedAsync();
        }

        private void BlazorMarker_UserSaved(object sender, UserSavedEventArgs e)
        {
           
            Message += "User Saved Element Id " + e.ElementId;
            Console.WriteLine(Message);
            StateHasChanged();
        }

        public async Task TestClick()
        {
            var settings = new Settings()
            {
                AvailableMarkerTypes = new MarkerType[] { MarkerType.FreehandMarker, MarkerType.CalloutMarker, MarkerType.EllipseMarker },
                RenderImageType = "image/jpeg",
                RenderImageQuality = 0.5F  
            };
            settings.DefaultSettings.DisplayMode = DisplayMode.Inline;

            await BlazorMarker.InitializeArea("testmarker", settings);
            await BlazorMarker.Show();
        }
    }
}
