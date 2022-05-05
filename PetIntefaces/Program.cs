using PetIntefaces;

var fred = new Boxer();
var roxy = new Bully();
var beans = new Mut();

IDog[] dogs = { fred, roxy, beans };

foreach(var dog in dogs) {
    Console.WriteLine($"Name {dog.Name}, color is {dog.Color} and is {(dog.IsLarge ? "large" : "small")}" +
                        $" and makes the sound {dog.Bark()}");
}