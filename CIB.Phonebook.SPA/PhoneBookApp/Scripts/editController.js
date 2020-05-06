(function (app) {
    var editController = function ($scope, contactService) {

        $scope.contacts = [];

        var updateContact = function () {
            contactService.update($scope.edit.contact)
                .success(function () {
                    angular.extend($scope.contact, $scope.edit.contact);
                    $scope.edit.contact = null;
                });
        };

        var createContact = function () {
            contactService.create($scope.edit.contact)
                .success(function () {
                    $scope.contacts.push($scope.edit.contact);
                    $scope.edit.contact = null;
                });
        };

        $scope.isEditable = function () {
            return $scope.edit && $scope.edit.contact;
        };

        $scope.cancel = function () {
            $scope.edit.contact = null;
        };

        $scope.save = function () {
            if ($scope.edit.contact.Id) {
                updateContact();
            } else {
                createContact();
            }
        };
        
    };
    app.controller("editController", editController);
}(angular.module("phoneBook")));