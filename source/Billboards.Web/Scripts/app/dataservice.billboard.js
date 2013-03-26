define('dataservice.billboard',
    ['amplify'],
    function (amplify) {
        var init = function () {

            amplify.request.define('billboards', 'ajax', {
                url: '/api/billboards',
                dataType: 'json',
                type: 'GET'
                //cache: true
                //cache: 60000 // 1 minute
                //cache: 'persist'
            });

        //    amplify.request.define('billboard', 'ajax', {
        //        url: '/api/billboards/{id}',
        //        dataType: 'json',
        //        type: 'GET'
        //        //cache: true
        //        //cache: 60000 // 1 minute
        //        //cache: 'persist'
        //    });

        //    amplify.request.define('billboardsUpdate', 'ajax', {
        //        url: '/api/billboards',
        //        dataType: 'json',
        //        type: 'PUT',
        //        contentType: 'application/json; charset=utf-8'
        //    });
        //},

            getBillboards = function (callbacks) {
                return amplify.request({
                    resourceId: 'billboards',
                    success: callbacks.success,
                    error: callbacks.error
                });
            };

        //getBillboard = function (callbacks, id) {
        //    return amplify.request({
        //        resourceId: 'billboard',
        //        data: { id: id },
        //        success: callbacks.success,
        //        error: callbacks.error
        //    });
        //},

        // updateBillboards = function (callbacks, id) {
        //     return amplify.request({
        //         resourceId: 'billboardsUpdate',
        //         data: data,
        //         success: callbacks.success,
        //         error: callbacks.error
        //     });
        };
        
        init();
        return {
            getBillboards: getBillboards
           // getBillboard: getBillboard
        };

        });