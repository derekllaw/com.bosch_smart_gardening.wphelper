var WpHelper = {
    ToUpper: function (successCallback, errorCallback, strInput) {
        cordova.exec(successCallback, errorCallback, "WpHelper", "ToUpper", [strInput]);
    }
}

module.exports = WpHelper;
