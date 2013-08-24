rpApp.controller('SignInController', function ($scope, $location, accessFactory, $rootScope) {
    $scope.submit = function () {
        var user = new accessFactory({
            UserName: $scope.user.username,
            Password: $scope.user.password
        });

        var res = user.$signin();

        res.then(function (result) {
            $rootScope.CurrentUser = result;
            $location.path('/Home');
        });
    };
});


