angular.module('ltdf').service('ltdfDashboardService', [
    '$http',
    function($http) {
        var urlBase = 'http://localhost/LeTourDeFrance.Backend/api/';

        this.getStages = function() {
            return $http.get(urlBase + 'stages');
        };

        this.getRiders = function() {
            return $http.get(urlBase + 'riders');
        };
    }
]);