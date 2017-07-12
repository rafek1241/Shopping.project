(function () {
    'use strict';
    angular.module('app')
        .controller("HomeController", HomeController);
    HomeController.$inject = ['CategoryService'];
    function HomeController(CategoryService) {
        var vm = this;
        vm.CategoryService = CategoryService;
    }
})();