angular.module('ltdf').directive('ltdfDashboard', [
    function () {
        return {
            restrict: 'AE',
            controller: 'ltdfDashboardController',
            templateUrl: '/Scripts/ltdf-dashboard/ltdf-dashboard.html'
        };

    }
]);