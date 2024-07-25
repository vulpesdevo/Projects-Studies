package arrayBasics;

import java.util.ArrayList;

public class array1 {

  public static void main(String[] args) {
    ArrayList<String> list = new ArrayList<String>();
    list.add("Mark");
    list.add("Bob");
    list.add("lee");

    /******* Array With Value ******/
    String names[] = { "Mark", "Bob", "lee" };
    System.out.println(names[1]);

    /******* Assigning Array Element *******/
    names[0] = "Mark";
    names[1] = "Bob";
    System.out.println(names[0]);
    System.out.println(names[1]);

    /******** Array Without Value *****/
    String names2[] = new String[2];

    /****** ADD value   *******/
    names2[0] = "Mark";
    names2[1] = "Bob";
    names2[2] = "Lee";
  }
}
