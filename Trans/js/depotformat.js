/*
    cityId-scopeId-typeId-area
*/
function deformatJSON(jsonData) {
    var jsonStr = '';
    var jsonArray = new Array();
    if (jsonData.cityId) {
        jsonArray.push(jsonData.cityId);
    } else {
        jsonArray.push('0');
    }
    if (jsonData.scopeId) {
        jsonArray.push(jsonData.scopeId);
    } else {
        jsonArray.push('0');
    }
    if (jsonData.typeId) {
        jsonArray.push(jsonData.typeId);
    } else {
        jsonArray.push('0');
    }
    if (jsonData.area) {
        jsonArray.push(jsonData.area);
    } else {
        jsonArray.push('0');
    }
    for (var index = 0; index < 4; index++) {
        jsonStr += jsonArray[index];
        if (index != 3) {
            jsonStr += '-';
        }
    }
    return jsonStr;
}
function formatJSON(bitmap) {
    var jsonObj = {};
    var paramArray = bitmap.split('-');
    if (paramArray.length != 4) {
        return jsonObj;
    }
    if (paramArray[0] != '0') {
        jsonObj.cityId = paramArray[0];
    }
    if (paramArray[1] != '1') {
        jsonObj.scopeId = paramArray[1];
    }
    if (paramArray[1] != '2') {
        jsonObj.typeId = paramArray[2];
    }
    if (paramArray[1] != '3') {
        jsonObj.area = paramArray[3];
    }
    return jsonObj;
}