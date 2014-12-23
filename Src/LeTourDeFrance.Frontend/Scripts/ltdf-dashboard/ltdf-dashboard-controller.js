angular.module('ltdf').controller('ltdfDashboardController', [
    '$scope', '$http',
    function($scope, $http) {
        $scope.model = {};
        $scope.model.riders = [
            { name: 'Fabio Cancellera', team: 'Trek Factyory Racing (TFR)' },
            { name: 'Jens Voigt', team: 'Trek Factyory Racing (TFR)' }
        ];
    }
]);