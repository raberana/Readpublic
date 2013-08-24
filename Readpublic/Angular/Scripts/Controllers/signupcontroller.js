rpApp.controller('SignUpController', function ($scope, $location, accessFactory) {


    $scope.submit = function () {
        var user = new accessFactory({
            UserName: $scope.user.username,
            Password: $scope.user.password,
            Email: $scope.user.email,
            FirstName: $scope.user.firstname,
            LastName: $scope.user.lastname,
            MiddleName: $scope.user.middlename,
        });

        var res = user.$signup();

        res.then(function (result) {
            alert(result);
            alert(angular.toJson(result));
            $location.path('/Home');
        });
    };



});