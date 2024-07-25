package forLoops;

public class iterateForloop {

  public static void main(String[] args) {
    //iterating Array
    String[] fruits = { "Apple", "Mango", "Orange", "Guava" };

    //for loop
    //for (initialization; conditon; operation){ Do something }

    for (int i = 0; i < fruits.length; i++) {
      System.out.println(i + " >>> " + fruits[i]);
      if (fruits[i].equalsIgnoreCase("Orange")) {
        System.out.print("We've found a/an " + fruits[i]);
        break;
      }
    }
  }
}
