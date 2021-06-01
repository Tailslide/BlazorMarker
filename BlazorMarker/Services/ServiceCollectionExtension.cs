using Microsoft.Extensions.DependencyInjection;

namespace BlazorMarker.Services
{
	public static class ServiceCollectionExtension
	{
		public static IServiceCollection AddBlazorMarker(this IServiceCollection services)
			=> services.AddScoped<BlazorMarkerService>();
	}
}
