
define('dataservice.lookup',
    ['amplify'],
   function (amplify) {
       var
           init = function () {
               amplify.request.define('lookups', 'ajax', {
                   url: '/api/lookups/all',
                   dataType: 'json',
                   type: 'GET'
                   //cache
               }),

               amplify.request.define('adresses', 'ajax', {
                   url: '/api/lookups/addresses',
                   dataType: 'json',
                   type: 'GET'
                   //cache
               }),


                amplify.request.define('adress', 'ajax', {
                    url: '/api/lookups/addresses/{id}',
                    dataType: 'json',
                    type: 'GET'
                    //cache
                });
           },

           getLookups = function (callbacks) {
               return amplify.request({
                   resourceId: 'lookups',
                   success: callbacks.success,
                   error: callbacks.error
               });
           },

           getAddresses = function (callbacks) {
               return amplify.request({
                   resourceId: 'addresses',
                   success: callbacks.success,
                   error: callbacks.error
               });
           },

           getAddress = function (callbacks, id) {
               return amplify.request({
                   resourceId: 'address',
                   data:{id:id},
                   success: callbacks.success,
                   error: callbacks.error
               });
           };

       init();

       return {
           getLookups: getLookups,
           getAddresses: getAddresses,
           getAddress: getAddress
       };
   });