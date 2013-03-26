define('model',
    [
    'model.billboard','model.address'
    ],
    function (billboard,address) {
        var
            model = {
                Billboard: billboard,
                Address : address
            };
        model.setDataContext = function (dc) {
            // Model's that have navigation properties 
            // need a reference to the datacontext.
            model.Billboard.datacontext(dc);
            model.Address.datacontext(dc);
        };
        return model;
    });