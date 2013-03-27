define('dataprimer',
    ['ko', 'datacontext', 'config'],
    function (ko, datacontext, config) {
        var
            logger = config.logger,

            fetch = function () {

                //alert('busy fetching the data');
                return $.Deferred(function (def) {

                    var data = {
                        billboards: ko.observable(),
                        adresses: ko.observable()
                    };

                    $.when(

                        datacontext.billboards.getData({ results: data.billboards }),
                        datacontext.addresses.getData({ results: data.adresses })
                        )

                    .pipe(function () {
                        logger.success('Fetched data for: '
                           + '<div>' + data.billboards().length + ' billboards </div>'
                           + '<div>' + data.adresses().length + ' adresses </div>'
                       );
                    })

                    .fail(function () { def.reject(); })

                    .done(function () { def.resolve(); })

                }).promise();
            };



        return { fetch: fetch };
    });