(function () {
    'use strict';
    angular.module('app')
        .controller("PdfChooserController", PdfChooserController);
    PdfChooserController.$inject = ['PdflistService'];
    function PdfChooserController(PdflistService) {
        var vm = this;
        vm.PdflistService = PdflistService;
    }
})();