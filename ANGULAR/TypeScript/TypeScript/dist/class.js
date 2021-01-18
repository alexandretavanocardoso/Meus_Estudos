var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Space = /** @class */ (function () {
    function Space(propulsor) {
        this.propulsor = propulsor;
    }
    // Método
    Space.prototype.jump = function () {
        console.log("" + this.propulsor);
    };
    return Space;
}());
// Instanciando a classe
var ship = new Space('hyper');
ship.jump();
// herdando da classe "extends" e implementado interface "implements"
var milennium = /** @class */ (function (_super) {
    __extends(milennium, _super);
    function milennium() {
        var _this = _super.call(this, 'hyper') // chamando a variavel base
         || this;
        _this.cargoContainer = 2;
        return _this;
    }
    // Sobre escrevendo o método
    milennium.prototype.jump = function () {
        if (Math.random() >= 0.5) {
            _super.prototype.jump.call(this);
        }
        else {
            console.log('falhou');
        }
    };
    return milennium;
}(Space));
// Instanciando a classe
var falcon = new milennium();
falcon.jump();
var good = function (ship) { return ship.cargoContainer > 2; };
console.log("" + (good(falcon) ? 'yes' : 'no'));
