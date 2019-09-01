package factory;

import color.Color;
import color.Blue;
import color.Green;

public class ColorFactory implements AbstractFactory<Color> {

    @Override
    public Color create(String color) {
        if("Blue".equalsIgnoreCase(color)) {
            return new Blue();
        } else if ("Green".equalsIgnoreCase(color)) {
            return new Green();
        }

        return null;
    }
}
