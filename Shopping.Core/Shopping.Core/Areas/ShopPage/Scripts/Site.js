
(function () {
    angular.module('app', ['ngRoute', 'ejangular'])
        .config(config) //Routing
        .run(run); // global Run function()


    config.$inject = ['$routeProvider', '$locationProvider'];

    function config($routeProvider, $locationProvider) {
        $routeProvider
            .when('/ShopPage', {
                // :variable to pass in path, ex. "/students/:studentId"
                templateUrl: 'Areas/ShopPage/Partials/home.html',
                controller: 'HomeController',
                controllerAs: "vm"
            })
            //....
            .otherwise({
                redirectTo: '/'
            });
        $locationProvider.html5Mode(true);
        $locationProvider.hashPrefix('!');
    }
    run.$inject = ['$rootScope', '$location'];
    function run($rootScope, $location) {

    }


})();