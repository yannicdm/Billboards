define('datacontext',
    ['jquery', 'underscore', 'ko', 'model', 'model.mapper', 'dataservice', 'config', 'utils'],
    function ($, _, ko, model, modelmapper, dataservice, config, utils) {
       
        var
            logger = config.logger,

            itemsToArray = function (items, observableArray) {
                // Maps the memo to an observableArray, 
                // then returns the observableArray
               
                if (!observableArray) return;

                // Create an array from the memo object
                var underlyingArray = utils.mapMemoToArray(items);
                //logger.info('Fetched, filtered and sorted ' + underlyingArray.length + ' records');

                observableArray(underlyingArray);
            },

            mapToContext = function (dtoList, items, results, mapper) {
                // Loop through the raw dto list and populate a dictionary of the items
                items = _.reduce(dtoList, function (memo, dto) {
                    var id = mapper.getDtoId(dto);
                    var existingItem = items[id];
                    memo[id] = mapper.fromDto(dto, existingItem);
                    return memo;
                }, {});
                itemsToArray(items, results);
                //logger.success('received with ' + dtoList.length + ' elements');
                return items;
            },

            EntitySet = function (getFunction, mapper, Nullo, updateFunction) {
               
                var items = {},
                // returns the model item produced by merging dto into context
                mapDtoToContext = function (dto) {
                    var id = mapper.getDtoId(dto);
                    var existingItem = items[id];
                    items[id] = mapper.fromDto(dto, existingItem);
                    return items[id];
                },
                add = function (newObj) {
                    items[newObj.id()] = newObj;
                },
                removeById = function (id) {
                    delete items[id];
                },
                getLocalById = function (id) {
                    // This is the only place we set to NULLO
                    return !!id && !!items[id] ? items[id] : nullo;
                },
                getAllLocal = function () {
                    return utils.mapMemoToArray(items);
                },
                getData = function (options) {
                    // TODO IMPLEMENTATION
                   
                    return $.Deferred(function (def) {
                        var results = options && options.results;
                        // If the internal items object doesnt exist, 
                        // or it exists but has no properties, 
                        // or we force a refresh
                     
                        if (!items || !utils.hasProperties(items)) {
                            getFunction({
                                
                                success: function (dtoList) {
                                   items = mapToContext(dtoList, items, results, mapper);
                                    def.resolve(results);
                                   
                                },
                                error: function (response) {
                                    logger.error(config.toasts.errorGettingData);
                                    def.reject();
                                }
                            });
                        } else {
                            itemsToArray(items, results);
                            def.resolve(results);
                       }
                    }).promise();
                },
                updateData = function (entity, callbacks) {
                    // TODO IMPLEMENTATION
                    return undefined;
                };
              
                return {
                    mapDtoToContext: mapDtoToContext,
                    add: add,
                    getAllLocal: getAllLocal,
                    getLocalById: getLocalById,
                    getData: getData,
                    removeById: removeById,
                    updateData: updateData
                };
            },

                //----------------------------------
            // Repositories
            //
            // Pass: 
            //  dataservice's 'get' method
            //  model mapper
            //----------------------------------

            billboards = new EntitySet(dataservice.billboard.getBillboards, modelmapper.billboard, model.Billboard.Nullo);
        addresses = new EntitySet(dataservice.lookup.getAddresses, modelmapper.address, model.Address.Nullo);

        var datacontext = {
            billboards: billboards,
            addresses: addresses
        };

        // We did this so we can access the datacontext during its construction
        model.setDataContext(datacontext);
        

        //var test = dataservice.billboard.getBillboards({
        //    succes: function (dtoList) {
        //        logger.succes(config.toasts.retreivedData)
        //    },
        //    error: function (response) {
        //        logger.error(config.toasts.errorGettingData);
               
        //    }
        //});



        return datacontext;
    });