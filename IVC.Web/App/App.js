var App = angular.module('IVCApp', ['ngRoute']);

var AgendaController;

App.controller("AgendaController", function ($scope, $http) {
    $scope.Get = function () {
        debugger;
        $http.get("/Api/Agenda/Get").then(function (object) {
            debugger;
            $scope.Agendas = object.data;
        }, function () {
            alert('Erro');
        });
    }
    AgendaController = $scope;
});




App.run(function ($rootScope) {
    $rootScope.$on("$includeContentLoaded", function (event, templateName) {

        //OnLoad do Header
        if (templateName = 'Views/Header.html') {
            //$('.dropdown-button').click(function (e) { $('.dropdown-content').css('width', 'auto'); });
            $('.button-collapse').sideNav();
            $('.dropdown-button').dropdown();
            $('.parallax').parallax();
        }

    })
});

