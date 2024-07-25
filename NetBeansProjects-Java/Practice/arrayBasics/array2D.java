package arrayBasics;

public class array2D {
  public static void main(String[] args) {
    //datatype variable [][] = {{"",""},{"","",}};
    //datatype variable [][] = new datatype[rows][col];
    String names[][] ={  //String
      {"mark","bob"},
      {"lee","bea"},//<--rows
      {"bruno","lex"},
      {"brix","rico"},
      //   ^columns
    };
    System.out.print(names[0][1]); 

    int nums[][]={ //int
      {0,0},
      {0,0},
      {0,0},
      {0,0}
    };
  }
  
}
