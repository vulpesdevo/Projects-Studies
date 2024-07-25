package whileLoop;

import java.util.Scanner;

public class whileLoop02 {

  public static void main(String[] args) {
    // to read
    Scanner scan = new Scanner(System.in);

    // Variables
    String ans;
    String guess;
    int i = 0;
    int lives = 5;

    // Project
    while (lives > i) {
      System.out.print("What is my Favorite Animal : ");
      ans = scan.nextLine();
      if (ans.equalsIgnoreCase("Fox")) {
        System.out.print(
            "\n>>> Your lives is " +
                lives +
                "\nYou want to guess again?\n  Y or N :\n");
        guess = scan.nextLine();
        if (guess.equalsIgnoreCase("Y")) {
          continue;
        } else {
          break;
        }
      } else {
        lives--;
        System.out.print("\nYour answer is incorrect please try again\n");
        System.out.print(">>> Your lives is " + lives + " <<<\n");
        continue;
      }
    }
    if (lives > i) {
      System.out.print("\nCongratiolations You WON!!");
    } else {
      System.out.print("\nYou run out of lives\n >>> YOU LOST !! <<<");
    }
  }
}
