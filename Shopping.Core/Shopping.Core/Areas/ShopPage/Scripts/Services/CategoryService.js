(function () {
    'use strict';
    angular.module('app')
        .service("CategoryService", CategoryService);
    CategoryService.$inject = ['$http'];
    function CategoryService($http) {
        var vm = this;
        $http.post('api/Categories/getCategories').then(function (response) {
            vm.categoriesData = response.data.data;
            vm.categoriesWidget = {
                dataSource: ej.DataManager(vm.categoriesData),
                id: "id",
                parentId: "pid",
                text: "name",
                hasChild: "hasChild",
                expanded: "expanded"
            };

            vm.showCategories = true;
        });
    }
})();