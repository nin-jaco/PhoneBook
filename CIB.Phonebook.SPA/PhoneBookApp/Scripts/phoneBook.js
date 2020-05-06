(function () {

    var app = angular.module("phoneBook", ["ngRoute"]);

    var config = function ($routeProvider) {
        $routeProvider
            .when("/list",
                { templateUrl: "list.html", controller: "contactListController" })
            .when("/details/:id",
            { templateUrl: "details.html", controller: "detailsController" })
            .otherwise(
            { redirectTo: "list", controller: "contactListController" });
    };

    app.config(config);
    app.constant("contactApiUrl", "../../api/contacts/");
}());

