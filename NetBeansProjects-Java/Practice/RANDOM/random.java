package RANDOM;

import java.util.*;

public class random {
    public static void main(String[] args) {
        Random random = new Random();
        int e = random.nextInt(3) + 1;
        System.out.print(e);
    }
}
