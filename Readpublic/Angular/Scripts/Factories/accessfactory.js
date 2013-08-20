rpApp.factory('accessFactory', function ($resource) {

    var User = $resource('http://localhost:61195/user/:action/:id',
              { action: "@action", id: "@id" }, //parameters default
              {
                  SignIn: { method: "POST", params: { action: "authenticateuser" } },
                  SignUp: { method: "POST", params: { action: "adduser" } }
              });


    return factory;
});
