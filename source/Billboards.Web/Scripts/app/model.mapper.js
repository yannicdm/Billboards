define('model.mapper',
    ['model'],
    function (model) {
        var
           billboard = {
               getDtoId: function (dto) { return dto.id; },
               fromDto: function (dto, item) {
                   item = item || new model.Billboard().id(dto.id);
                   item.addressId(dto.addressId);
                   item.fid(dto.fid);
                   item.displayName(dto.displayName);
                   item.coordinates(dto.coordinates);
                   item.longitude(dto.longitude);
                   item.lattitude(dto.lattitude);
                   item.type(dto.type);
                   return item;
               }
           },

           address = {
               getDtoId: function (dto) { return dto.id; },
               fromDto: function (dto, item) {
                   item = item || new model.Address().id(dto.id);
                   item.addressLine(dto.addressLine);
                   item.adminDistrict(dto.adminDistrict);
                   item.countryRegion(dto.countryRegion);
                   item.locality(dto.locality);
                   item.postalCode(dto.postalCode);
                   item.formattedAddress(dto.formattedAddress);
                   return item;
               }

           };

        return {
            billboard: billboard,
            address:address
        };
    });