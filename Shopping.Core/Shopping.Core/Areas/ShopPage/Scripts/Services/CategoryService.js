(function () {
    'use strict'
    angular.module('app')
        .service("CategoryService", CategoryService);
    CategoryService.$inject = ['$http'];
    function CategoryService($http) {
        var vm = this;
        $http.post('api/Category/getCategories').then(function (response) {
            vm.categories = response.data.data;
        });
    }
})();