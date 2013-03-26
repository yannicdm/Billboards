define('model.mapper',
    ['model'],
    function (model) {
        
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
        };
        return {
            billboard: billboard
        };
    });