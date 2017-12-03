//import angular from 'angular';
//import uirouter from 'angular-ui-router';
//import { homecontoller } from './controllers/homecontroller'
//import { aboutcontroller } from './controllers/aboutcontroller';
//import { plannercontroller } from './controllers/plannercontroller';
//import { contactcontroller } from './controllers/contactController';

angular.module('myApp', ["ui.router"]).config(routing);

routing.$inject = ['$stateProvider', '$urlRouterProvider', '$locationProvider'];
function routing($stateProvider, $urlRouterProvider, $locationProvider) {
    $stateProvider
        .state('home', {
            url: '/',
            templateUrl: '/ngApp/views/home.html',
            controller: HomeController,
            controllerAs: 'controller'
        })
        .state('about', {
            url: '/about',
            templateUrl: '/ngApp/views/about.html',
            controller: AboutController,
            controllerAs: 'controller'
        })
        .state('contact', {
            url: '/contact',
            templateUrl: '/ngApp/views/contact.html',
            controller: ContactController,
            controllerAs: 'controller'
        })
        .state('planners', {
            url: '/planners',
            templateUrl: '/ngApp/views/planners.html',
            controller: PlannerController,
            controllerAs: 'controller'
        })
        .state('fitness', {
            url: '/fitness',
            templateUrl: '/ngApp/views/fitness.html',
            controller: FitnessController,
            controllerAs: 'controller'
        })
        .state('notFound', {
            url: '/notFound',
            templateUrl: '/ngApp/views/notFound.html'
        });
    $urlRouterProvider.otherwise('/notFound');
    $locationProvider.html5Mode(true);
}

//Disable right-click for images on page/site
function disableRightClick() {
    alert("SNAP!\n\nImages \u00A9Create, Design, Organize! unless purchased!");
    return false;
}

//Show warning message before leaving site
//window.onbeforeunload = function () {
//    return '';
//}