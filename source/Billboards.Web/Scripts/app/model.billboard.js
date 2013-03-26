/// <reference path="../lib/knockout-2.1.0.debug.js" />
define('model.billboard', ['ko', 'config'],
    function (ko, config)
    {
        var
            _dc = null,

            settings = {

            },
            Billboard = function () {
                var self = this;
                self.id = ko.observable();
                self.fid = ko.observable();
                self.displayName = ko.observable();
                self.coordinates = ko.observable();
                self.longitude = ko.observable();
                self.lattitude = ko.observable();
                self.type = ko.observable();
                self.addressId = ko.observable();
                self.isNullo = false;
                return self;
            };

        Billboard.Nullo = new Billboard().id(0).displayName('Not a billboard');
        Billboard.Nullo.isNullo = true;

        Billboard.datacontext = function (dc) {
            if (dc) { _dc = dc; }
            return _dc;
        }

        return Billboard;

    });