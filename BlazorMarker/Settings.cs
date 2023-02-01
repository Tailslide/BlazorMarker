using BlazorMarker.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorMarker
{
    public class Settings
    {
        [JsonConverter(typeof(EnumArrayConverter<MarkerType>))]
        [JsonPropertyName("availableMarkerTypes")]
        public MarkerType[] AvailableMarkerTypes { get; set; } = new MarkerType[] { 
            MarkerType.FrameMarker, 
            MarkerType.FreehandMarker, 
            MarkerType.ArrowMarker,
            MarkerType.TextMarker,
            MarkerType.EllipseMarker,
            MarkerType.HighlightMarker,
            MarkerType.CalloutMarker
        };

        [JsonPropertyName("renderAtNaturalSize")]
        public bool RenderAtNaturalSize { get; set; } = false;


        [JsonPropertyName("renderHeight")]
        public int? RenderHeight { get; set; } = null;

        [JsonPropertyName("renderWidth")]
        public int? RenderWidth { get; set; } = null;

        [JsonPropertyName("renderImageQuality")]
        public float? RenderImageQuality { get; set; } = 0.5F;

        [JsonPropertyName("renderImageType")]
        public string RenderImageType { get; set; } = "image/png";


        [JsonPropertyName("renderMarkersOnly")]
        public bool RenderMarkersOnly { get; set; } = false;

        [JsonPropertyName("targetRootId")]
        public string TargetRootId { get; set; }

        [JsonPropertyName("defaultSettings")]
        public DefaultSettings DefaultSettings { get; set; } = new DefaultSettings();
    }
}
