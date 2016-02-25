/*
srcCityId-dstCityId-vanTypeId-trunkTypeId-length-weight
*/
function deformatJSON(jsonData) {
    var jsonStr = '';
    var jsonArray = new Array();
    if (jsonData.srcCityId) {
        jsonArray.push(jsonData.srcCityId);
    } else {
        jsonArray.push('0');
    }
    if (jsonData.dstCityId) {
        jsonArray.push(jsonData.dstCityId);
    } else {
        jsonArray.push('0');
    }
    if (jsonData.vanTypeId) {
        jsonArray.push(jsonData.vanTypeId);
    } else {
        jsonArray.push('0');
    }
    if (jsonData.trunkTypeId) {
        jsonArray.push(jsonData.trunkTypeId);
    } else {
        jsonArray.push('0');
    }
    if (jsonData.length) {
        jsonArray.push(jsonData.length);
    } else {
        jsonArray.push('0');
    }
    if (jsonData.weight) {
        jsonArray.push(jsonData.weight);
    } else {
        jsonArray.push('0');
    }
    for (var index = 0; index < 6; index++) {
        jsonStr += jsonArray[index];
        if (index != 5) {
            jsonStr += '-';
        }
    }
    return jsonStr;
}
/*
srcCityId-dstCityId-vanTypeId-trunkTypeId-length-weight
*/
function formatJSON(bitmap) {
    var jsonObj = {};
    var paramArray = bitmap.split('-');
    if (paramArray.length != 6) {
        return jsonObj;
    }
    if (paramArray[0] != '0') {
        jsonObj.srcCityId = paramArray[0];
    }
    if (paramArray[1] != '0') {
        jsonObj.dstCityId = paramArray[1];
    }
    if (paramArray[2] != '0') {
        jsonObj.vanTypeId = paramArray[2];
    }
    if (paramArray[3] != '0') {
        jsonObj.trunkTypeId = paramArray[3];
    }
    if (paramArray[4] != '0') {
        jsonObj.length = paramArray[4];
    }
    if (paramArray[5] != '0') {
        jsonObj.weight = paramArray[5];
    }
    return jsonObj;
}