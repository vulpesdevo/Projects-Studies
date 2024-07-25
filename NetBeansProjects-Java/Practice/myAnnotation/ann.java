package myAnnotation;

import java.lang.annotation.*;

import javax.swing.JOptionPane;

@Target(ElementType.METHOD)
@Retention(RetentionPolicy.RUNTIME)
public @interface ann {

    String name();

}
