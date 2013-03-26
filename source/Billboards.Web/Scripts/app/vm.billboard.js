define('vm.billboard',
    ['ko', 'datacontext', 'config', 'router', 'sort'],
    function (ko, datacontext, config, router, sort) {

        var
            currentBillboardId = ko.observable(),
            logger = config.logger,

            billboard = ko.observable(),

            canEditBillboard = ko.computed(function () {
                return false;
            }),

            isDirty = ko.computed(function () {
                if (canEditBillboard()) {
                    return billboard().dirtyFlag().isDirty();
                }
                return false;
            }),

            isValid = ko.computed(function () {
                return (canEditBillboard() ? validationErrors == 0 : true);
            }),

            activate = function (routeData, callback) {
                messenger.publish.viewModelActivated({ canLeaveCallback: canLeave });
                currentBillboardId = routeData.id;
                getBillboard(callback);
            },

            canLeave = function () {
                return !isDirty && isValid;
            },

            getBillboard = function (completeCallback, forceRefresh) {
                var callback = function () {
                    if (completeCallback) { completeCallback(); }
                    validationErrors = ko.validation.group(billboard());
                };

                datacontext.billboards.getBillboardById(
                    currentBillboardId, {
                        success: function () {
                            billboard(x);
                            callback;
                        },
                        error: callback
                    },
                    forceRefresh
                    );
            },

            saveCmd = ko.asyncCommand({
                execute: function (complete) {
                    if (canEditBillboard()) {
                        $.when(datacontext.billboards.updateData(billboard()))
                        .always(complete);
                        return;
                    }
                },
                canExecute: function (isExecuting) {
                    return !isExecuting && isDirty() && isValid();
                }
            }),

            cancelCmd = ko.asyncCommand({
                execute: function (complete) {
                    var callback = function () {
                        complete();
                        logger.success(config.toasts.retreivedData);
                    };
                },
                canExecute:function(isExecuting){
                    return !isExecuting() && isDirty();
                }
            }),

            tmplName = function () {
                return canEditBillboard() ? 'billboard.edit' : 'billboard.view';
            }


        return {
            activate: activate,
            cancelCmd: cancelCmd,
            canEditBillboard: canEditBillboard,
            canLeave: canLeave,
            isDirty: isDirty,
            isValid: isValid,
            billboard: billboard,
            tmplName: tmplName
        };


    });
