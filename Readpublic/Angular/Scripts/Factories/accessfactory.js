rpApp.factory('accessFactory', function ($resource) {
    var url = 'http://localhost:44786/api/user/:action';

    return $resource(url,
              {}, //parameters default
              {
                  signin: { method: "POST", params: { action: "authenticateuser" } },
                  signup: { method: "POST", params: { action: "adduser" } }
              });
});
