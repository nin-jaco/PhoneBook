(function (app) {
    var contactListController = function ($scope, contactService) {
       
        contactService
            .getAll()
            .success(function (data) {
                $scope.contacts = data;
            });

        $scope.create = function () {
            $scope.edit = {
                contact: {
                    FirstName: "",
                    LastName: "",
                    Mobile: "",
                    WorkTelephone: "",
                    DateCreated: new Date(),
                    DateModified: new Date()
                }
            };
        };


        var removeContactById = function (id) {
            for (var i = 0; i < $scope.contacts.length; i++) {
                if ($scope.contacts[i].Id === id) {
                    $scope.contacts.splice(i, 1);
                    break;
                }
            }
        };

        $scope.delete = function (contact) {
            contactService.delete(contact.Id)
                .success(function () {
                removeContactById(contact.Id);
            });
        }; 
        
    };
    app.controller("contactListController", contactListController);
}(angular.module("phoneBook")));
