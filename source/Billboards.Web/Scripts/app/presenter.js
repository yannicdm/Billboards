/// <reference path="../lib/jquery-1.9.1.js" />
/// <reference path="../lib/jquery-1.9.1.intellisense.js" />
/// <reference path="../lib/jquery.activity-indicator-1.0.0.js" />


define('presenter', ['jquery', 'activity-indicator'],
    function ($) {
        var
        toggleActivity = function (show) {
            $('#busyindicator').activity(show);
        }
        return { toggleActivity: toggleActivity };
    });