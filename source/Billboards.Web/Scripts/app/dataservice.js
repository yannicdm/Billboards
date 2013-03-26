define('dataservice',
    ['dataservice.billboard', 'dataservice.lookup'],
 function (billboard,lookup) {
     
     return {
         billboard: billboard,
         lookup:lookup
     };
 });