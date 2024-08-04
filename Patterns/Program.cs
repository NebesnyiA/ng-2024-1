using Patterns.Builder;
using Patterns.Builder.Interfaces;
using Patterns.Factory.FactoryMethod;
using Patterns.Strategy;
using Patterns.Strategy.Implementations;
using Patterns.Strategy.Iterface;

// example of stratagy using

IPaymentStrategy st = new CreditCardPayment();

Director dir = new Director(st);

dir.ProceedPayment(300);

dir.ChangePaymentWay(new PayPalPayment());
dir.ProceedPayment(150);

// example of fabric method using

Creator carCreator = new CarCreator();

var car = carCreator.FactoryMethod();

// example of builder with director

IHouseBuilder houseBuilder = new HouseBuilder();
var builderDirector = new HouseDirector(houseBuilder);

var usualHouse = builderDirector.ConstructSimpleHouse();
var expensiveHouse = builderDirector.ConstractExpensiveHouse();