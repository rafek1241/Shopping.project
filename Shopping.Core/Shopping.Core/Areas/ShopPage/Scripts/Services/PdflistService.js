(function () {
    'use strict';
    angular.module('app')
        .service("PdflistService", PdflistService);
    PdflistService.$inject = ['$rootScope', '$http'];
    function PdflistService($rootScope, $http) {
        var vm = this;
        //vm.serviceApi = "http://js.syncfusion.com/ejservices/api/PdfViewer";
        vm.pdfViewer = {
            serviceUrl: "api/pdfs/getpdfs"
        };
        vm.listOfPdfs = {
            data: [{ filename: "Pdf A", path: "1" },
            { filename: "Pdf B", path: "2" },
            { filename: "Pdf C", path: "3" },
            { filename: "Pdf D", path: "4" },
            { filename: "Pdf E", path: "5" }],
            fields: {
                "text": "filename"
            }
        };
        vm.currentlySelectedPdf = 0;
        vm.selectNewPdf = function (value) {
            console.info("Hooray, passed once!");
            var pdfViewerInstance = $('#pdfviewer').data('ejPdfViewer');
            pdfViewerInstance.load(vm.listOfPdfs.data[value].path + ".pdf");
        };
        $rootScope.PdflistService = this;
        $rootScope.$watch("PdflistService.currentlySelectedPdf", function (newValue, oldValue, scope) {
            if (newValue !== oldValue) {
                vm.selectNewPdf(newValue);
            }
        }, true);
    }
})();