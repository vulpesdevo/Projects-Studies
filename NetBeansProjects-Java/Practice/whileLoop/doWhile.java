package whileLoop;

public class doWhile {

  public static void main(String[] args) {
    String user[] = { "Mark", "Francis", "Galan" };
    int i = 0;
    int e = 1;
    do {
      System.out.println(e + ". " + user[i]);
      i++;
      e++;
    } while (i < user.length);
  }
}
