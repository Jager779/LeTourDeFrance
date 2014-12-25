angular.module('ltdf').controller('ltdfDashboardController', [
    '$scope', '$http',
    function($scope, $http) {
        $scope.model = {};
        $scope.model.riders = ridersFromServer();
        
        
        function ridersFromServer() {
            $http.get('api/riders')
                .success(function(data) {
                    debugger;
                    console.log('yay');
                })
                .error(function(data) {
                    debugger;
                    console.log('nay');
                });
        };
    }
]);