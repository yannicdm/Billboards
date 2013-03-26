define('vm',
    [   'vm.address',
        'vm.addresses',
        'vm.billboard',
        'vm.billboards',
        'vm.shell'
    ],
    function (address, addresses, billboard, billboards,shell) {
        return {
            address: address,
            addresses: addresses,
            billboard: billboard,
            billboards: billboards,
            shell : shell
        };
    });