define('utils',
    ['underscore', 'moment'],
function (_, moment) {

    mapMemoToArray = function (items) {
        var underlyingArray = [];
        for (var prop in items) {
            if (items.hasOwnProperty(prop)) {
                underlyingArray.push(items[prop]);
            }
        }
        return underlyingArray;
    },
      hasProperties = function (obj) {
          for (var prop in obj) {
              if (obj.hasOwnProperty(prop)) {
                  return true;
              }
          }
          return false;
      }


    return {
        mapMemoToArray: mapMemoToArray,
        hasProperties: hasProperties
    };

});