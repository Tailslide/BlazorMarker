using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMarker.Services
{
    public class BlazorMarkerService
    {
		private IJSRuntime _jsRuntime;

		public BlazorMarkerService(IJSRuntime jSRuntime)
		{
			_jsRuntime = jSRuntime;
		}

		public async Task InitializeArea(string elementId)
		{
			await _jsRuntime.InvokeVoidAsync("BlazorMarker.InitializeArea", elementId);
		}
		public async Task Show()
		{
			await _jsRuntime.InvokeVoidAsync("BlazorMarker.Show");
		}
	}
}
