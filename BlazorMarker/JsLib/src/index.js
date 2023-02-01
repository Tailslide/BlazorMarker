import { initializeArea, show } from './blazor_markerjs2';

export function InitializeArea(elementId, settings, markerprops) {
    //const settingsnew = { "defaultColorSet": ["#EF4444", "#10B981", "#2563EB", "#FFFF00", "#7C3AED", "#F472B6", "#000000", "#FFFFFF"], "defaultColor": "#EF4444", "defaultColorsFollowCurrentColors": false, "defaultFillColor": "#EF4444", "defaultFontFamilies": ["Times, \u0022Times New Roman\u0022, serif", "Helvetica, Arial, sans-serif", "Courier, \u0022Courier New\u0022, monospace", "cursive", "fantasy"], "defaultFontFamily": "Helvetica, Arial, sans-serif", "defaultHighlightColor": "#FFFF00", "defaultHighlightOpacity": 0.5, "defaultOpacitySteps": [0.1, 0.25, 0.5, 0.75, 1], "defaultStrokeColor": "#FFFFFF", "defaultStrokeDasharray": "", "defaultStrokeDasharrays": ["", "3", "12 3", "9 6 3 6"], "defaultStrokeWidth": 3, "defaultStrokeWidths": [1, 2, 3, 5, 10], "displayMode": "popup", "newFreehandMarkerOnPointerUp": false, "popupMargin": 30 };
    return initializeArea(elementId, settings, markerprops);
}

export function LogVar(obj) {
    console.log("Debugging value:");
    console.log(obj);
}


export function Show() {
    return show();
}

