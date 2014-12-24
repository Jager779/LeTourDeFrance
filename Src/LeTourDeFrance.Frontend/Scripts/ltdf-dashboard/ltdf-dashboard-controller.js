angular.module('ltdf').controller('ltdfDashboardController', [
    '$scope', '$http',
    function($scope, $http) {
        $scope.model = {};
        $scope.model.riders = riders;

        var riders = function() {
           var dataz =  $http.get('/Index/GetAllRiders', data)
                .success(function(data) {
                    debugger;
                    console.log('yay');
                })
                .error(function(data) {
                    debugger;
                    console.log('nay');
                });
            return dataz;
        }
    }
]);