var rpApp = angular.module('rpApp', ['ngRoute', 'ngAnimate']);

rpApp.config(function ($routeProvider) {
    $routeProvider
    .when('/Home',
    {
        controller: 'HomeController',
        templateUrl: 'Angular/Partials/home.html'
    })
         .when('/Books',
    {
        controller: 'BooksController',
        templateUrl: 'Angular/Partials/books.html'
    })
         .when('/MyShelf',
    {
        controller: 'ShelfController',
        templateUrl: 'Angular/Partials/myshelf.html'
    })
        .when('/MyGroups',
    {
        controller: 'GroupsController',
        templateUrl: 'Angular/Partials/mygroups.html'
    })
         .when('/About',
    {
        controller: 'AboutController',
        templateUrl: 'Angular/Partials/about.html'
    })
        .when('/SignUp',
    {
        controller: 'SignUpController',
        templateUrl: 'Angular/Partials/signup.html'
    })
        .when('/SignIn',
    {
        controller: 'SignInController',
        templateUrl: 'Angular/Partials/signin.html'
    })

    .otherwise({ redirectTo: '/Home' });
});
