import * as markerjs2 from 'markerjs2';

var markerArea=undefined;
var ElementId = undefined;

export function initializeArea(elementId) {
    ElementId = elementId;
    markerArea = new markerjs2.MarkerArea(document.getElementById(ElementId));

    // register an event listener for when user clicks OK/save in the marker.js UI
    markerArea.addRenderEventListener(dataUrl => {
        // we are setting the markup result to replace our original image on the page
        // but you can set a different image or upload it to your server
        document.getElementById(ElementId).src = dataUrl;
    });
}

export function show() {
    if (markerArea !== undefined) markerArea.show();
}