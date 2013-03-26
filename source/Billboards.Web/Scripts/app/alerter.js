/// <reference path="../lib/jquery-1.9.1.intellisense.js" />
/// <reference path="../lib/jquery-1.9.1.js" />

define('alerter', ['jquery', 'dataservice'],
function ($,dataservice) {
    var
        name = 'Yannic',
        showMessage = function () {
            var msg = dataservice.getMessage();
            //alert(msg + ', ' + name);
            $('#messagebox').text(msg + ', ' + name);
        };
    return {
        showMessage: showMessage
    };

});