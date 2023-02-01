import * as markerjs2 from 'markerjs2';

var markerArea=undefined;
var ElementId = undefined;

export function initializeArea(dotNetHelper, elementId, settings) {
    ElementId = elementId;
    markerArea = new markerjs2.MarkerArea(document.getElementById(ElementId));
    markerArea.settings = settings.defaultSettings;
    markerArea.availableMarkerTypes = settings.availableMarkerTypes;
    markerArea.renderAtNaturalSize = settings.renderAtNaturalSize;
    if (settings.renderHeight !== undefined && settings.renderHeight != null)
        markerArea.renderHeight = settings.renderHeight;
    if (settings.renderWidth !== undefined && settings.renderWidth != null)
        markerArea.renderWidth = settings.renderWidth;
    if (settings.renderImageQuality !== undefined && settings.renderImageQuality != null)
        markerArea.renderImageQuality = settings.renderImageQuality;
    markerArea.renderImageType = settings.renderImageType;
    markerArea.renderMarkersOnly = settings.renderMarkersOnly;

    if (settings.targetRootId !== undefined && settings.targetRootId !== "" && settings.targetRootId !== null)
        markerArea.targetRoot = document.getElementById(settings.targetRootId);
    //console.log(markerArea.ALL_MARKER_TYPES);
    // register an event listener for when user clicks OK/save in the marker.js UI
    markerArea.addRenderEventListener(dataUrl => {
        // we are setting the markup result to replace our original image on the page
        // but you can set a different image or upload it to your server        
        document.getElementById(ElementId).src = dataUrl;
        dotNetHelper.invokeMethodAsync('JSCallBackUserSaved', ElementId)
            .then(data => {
                //console.log(data);
            });
    });
}

export function show() {
    if (markerArea !== undefined) markerArea.show();
}