package arrayBasics;
import java.util.*;

public class array2DAndNestedArray {
  public static void main(String[] args) {
    Scanner  sc = new Scanner(System.in);
    String user[][] = {
      {"Mark", "mark123"},
      {"Francis", "france"},
      {"John", "john123"},
      {"Bea","bea123"}
    };

    //ForLoop 2D Arrays
    for(int row = 0; row < user.length; row++){
      for(int col = 0; col < user[row].length; col++){
        System.out.println(user[row][col]);
      }
      System.out.println();
    }

    //ForEach Loop 2D Array
    for( String i[]: user){
      for(String e: i){
        System.out.println(e);
      }
      System.out.println();
    }
    
  }
  
}
