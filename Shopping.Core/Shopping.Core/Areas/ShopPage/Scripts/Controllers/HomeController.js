(function () {
    'use strict';
    angular.module('app')
        .controller("HomeController", HomeController);
    HomeController.$inject = ['CategoryService','ProductService'];
    function HomeController(CategoryService, ProductService) {
        var vm = this;
        vm.CategoryService = CategoryService;
        vm.ProductService = ProductService;

    }
})();