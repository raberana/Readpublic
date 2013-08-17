var rpWebApp = angular.module('rpWebApp', []);

rpWebApp.config(function ($routeProvider) {
    $routeProvider
    .when('/Home',
    {
        controller: 'HomeController',
        templateUrl: 'Angular/Partials/home.html'
    })
         .when('/Books',
    {
        controller: 'HomeController',
        templateUrl: 'Angular/Partials/browsebooks.html'
    })
         .when('/MyShelf',
    {
        controller: 'HomeController',
        templateUrl: 'Angular/Partials/shelve.html'
    })
         .when('/About',
    {
        controller: 'HomeController',
        templateUrl: 'Angular/Partials/about.html'
    })

    .otherwise({ redirectTo: '/Home' });
});
