package factory;

public class FactoryProvider {
    public static AbstractFactory getFactory(String choice) {
        if ("animal".equalsIgnoreCase(choice)) {
            return new AnimalFactory();
        }

        if ("color".equalsIgnoreCase(choice)) {
            return new ColorFactory();
        }

        return null;
    }
}
