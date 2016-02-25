/*
* srcCityId-dstCityId-weight-typeId
*/
function deformatJson(jsonData) {
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
    if (jsonData.weight) {
        jsonArray.push(jsonData.weight);
    } else {
        jsonArray.push('0');
    }
    if (jsonData.typeId) {
        jsonArray.push(jsonData.typeId);
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
/*
* srcCityId-dstCityId-weight-typeId
*/
function formatJSON(bitMap) {
    var jsonObj = {};
    var paramArray = bitmap.split('-');
    if (paramArray.length != 4) {
        return jsonObj;
    }
    if (paramArray[0] != '0') {
        jsonObj.srcCityId = paramArray[0];
    }
    if (paramArray[1] != '0') {
        jsonObj.dstCityId = paramArray[1];
    }
    if (paramArray[2] != '0') {
        jsonObj.weight = paramArray[2];
    }
    if (paramArray[3] != '0') {
        jsonObj.typeId = paramArray[3];
    }
    return jsonObj;
}