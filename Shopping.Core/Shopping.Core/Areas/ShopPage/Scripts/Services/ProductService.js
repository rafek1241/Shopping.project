(function () {
    'use strict';
    angular.module('app')
        .service("ProductService", ProductService);
    ProductService.$inject = ['$http'];
    function ProductService($http) {
        var vm = this;
        $http.post('api/Products/getProducts').then(function (response) {
            vm.products = response.data.data;
        });
    }
})();