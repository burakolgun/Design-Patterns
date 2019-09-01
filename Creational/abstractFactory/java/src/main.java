import animal.Animal;
import color.Color;
import factory.AbstractFactory;
import factory.FactoryProvider;

public class main {

    public static void main(String[] args) {
        System.out.println("Hello World!");

        AbstractFactory abstractFactory;

        abstractFactory = FactoryProvider.getFactory("animal");
        Animal dog = (Animal) abstractFactory.create("Dog");

        abstractFactory = FactoryProvider.getFactory("color");
        Color green = (Color) abstractFactory.create("Green");

        System.out.println(green.getColor());
        System.out.println(dog.getAnimal());
        System.out.println(dog.makeSound());
    }
}
