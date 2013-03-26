define('model.address',
    ['ko','config'],
    function (ko,config) {
        var
            _dc = null,

            settings = {
            },

            Address = function () {
                var self = this;
                self.id = ko.observable();
                self.addressLind = ko.observable;
                self.adminDistrict = ko.observable;
                self.countryRegion = ko.observable;
                self.locality = ko.observable;
                self.postalCode = ko.observable;
                self.formattedAddress = ko.observable;
                self.isNullo = false;
                return self;
            };
        Address.Nullo = new Address().id(0);
        Address.Nullo.isNullo = true;

        Address.datacontext = function (dc) {
            if (dc) { _dc = dc; }
            return _dc;
        }

        return Address;
    });