rpApp.controller('HomeController', function ($scope, $location, userFactory, $rootScope) {
    alert(angular.toJson($rootScope.CurrentUser));

    if (angular.isUndefined($rootScope.CurrentUser))
    { $scope.user = "GUEST"; }
    else
    { $scope.user = $rootScope.CurrentUser.FirstName; }
});