/*
    parameters format: typeId-cityid-departureId-transporttypeid-dstcountyId
    parameters format:1-140800-2-1-1480801
    description: jsonData is a JSON object.
*/
function jsonFormatLine(jsonData) {
    var jstr = '';
    var jsonArray = new Array();
    
    if (jsonData.typeId) {
        jsonArray.push(jsonData.typeId);
    } else {
        jsonArray.push('0');
    }
    if (jsonData.cityId) {
        jsonArray.push(jsonData.cityId);
    } else {
        jsonArray.push('0');
    }
    if (jsonData.departureId) {
        jsonArray.push(jsonData.departureId);
    } else {
        jsonArray.push('0');
    }
    if (jsonData.dstCityId) {
        jsonArray.push(jsonData.dstCityId);
    }
    else {
        jsonArray.push('0');
    }
    for (var index = 0; index < 4; index++) {
        jstr += jsonArray[index];
        if (index != 3) {
            jstr += '-';
        }
    }
    return jstr;
}
/*
    parameters format: typeId-cityid-departureId-transporttypeid
    to JSON object.
*/
function deJsonFormatLine(data) {
    var jsonObj = {};
    var jsonArray = data.split('-');
    
    if (jsonArray.length != 4) {
        return jsonObj;
    }
    if (jsonArray[0] != '0') {
        jsonObj.typeId = jsonArray[0];
    }
    if (jsonArray[1] != '0') {
        jsonObj.cityId = jsonArray[1];
    }
    if (jsonArray[2] != '0') {
        jsonObj.departureId = jsonArray[2];
    }
    if (jsonArray[3] != '0') {
        jsonObj.dstCityId = jsonArray[3];
    }
    return jsonObj;
}