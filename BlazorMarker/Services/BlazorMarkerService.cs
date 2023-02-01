using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorMarker.Services
{
    public class BlazorMarkerService
    {
		private IJSRuntime _jsRuntime;
		private DotNetObjectReference<BlazorMarkerService> objRef;
		public delegate void UserSavedEventHandler(object sender, UserSavedEventArgs e);

		public BlazorMarkerService(IJSRuntime jSRuntime)
		{
			_jsRuntime = jSRuntime;
			objRef = DotNetObjectReference.Create(this);
		}

		public async Task InitializeArea(string elementId, Settings settings = null)
		{
			if (settings == null) settings = new Settings();
            //if (markerprops == null) markerprops = new MarkerAreaProperties();
            //await _jsRuntime.InvokeVoidAsync("BlazorMarker.LogVar", markerprops);

            //await _jsRuntime.InvokeVoidAsync("BlazorMarker.InitializeArea", elementId);
            await _jsRuntime.InvokeVoidAsync("BlazorMarker.InitializeArea", objRef, elementId, settings );
		}

		public async Task Show()
		{
			await _jsRuntime.InvokeVoidAsync("BlazorMarker.Show");
		}

		public event UserSavedEventHandler UserSaved;



		[JSInvokable]
		public Task<bool> JSCallBackUserSaved(string elementId)
		{
			UserSaved?.Invoke(this, new UserSavedEventArgs() { ElementId = elementId });
			return Task.FromResult(true);
		}

	}
}
