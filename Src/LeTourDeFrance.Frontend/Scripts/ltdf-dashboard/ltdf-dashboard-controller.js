angular.module('ltdf').controller('ltdfDashboardController', [
    '$scope', '$http',
    function($scope, $http) {
        $scope.model = {};
        
        
        (function ridersFromServer() {
             $http.get('http://localhost/LeTourDeFrance.Backend/api/riders')
                .then(function (data) {
                     $scope.model.riders = data.data;
                   console.log('yay');
                   console.log(data);
                },
                function(data) {
                    console.log('nay');
                }
                );
        }());

        (function stagesFromServer() {
            $http.get('http://localhost/LeTourDeFrance.Backend/api/stages').
                then(function(data) {
                        $scope.model.stages = data.data;
                        console.log('yay');
                        console.log(data);
                    },
                    function(data) {
                        console.log('nay');
                    });
        }());
    }
]);