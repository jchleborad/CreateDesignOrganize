class ShoppingCartController {
    constructor($scope, $http, ngCart) {
        ngCart.setTaxRate(7.5);
        ngCart.setShipping(2.99);
    }
}
angular.module('myApp').controller('myCtrl', ShoppingCartController);






//class ShoppingCartController {
//    constructor() {
//    }
//}