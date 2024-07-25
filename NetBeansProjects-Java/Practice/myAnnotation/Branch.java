package myAnnotation;

import javax.swing.*;
import java.lang.reflect.*;

public class Branch {

    @ann(name = "Mark Francis Galan ")
    public void myName() {
        print("my Annotation ");
    }

    public static void main(String[] args) throws Exception {
        Branch n = new Branch();
        Method na = n.getClass().getMethod("myName");

        ann nam = na.getAnnotation(ann.class);
        print("My name is : " + nam.name());

    }

    static void print(String print) {
        System.out.print(print);
    }
}
