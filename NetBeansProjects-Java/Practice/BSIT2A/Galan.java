package BSIT2A;

import java.util.*;

public class Galan {
  public static void main(String[] args) {
    Scanner scGalan = new Scanner(System.in);

    String fnGalan, addGalan, contactGalan, preGalan, midGalan, finGalan; // String Var
    double subgrdGalan, sumGalan; // Double Var

    // Getting the Students informations
    System.out.print("Enter Student's name : ");
    fnGalan = scGalan.nextLine();
    System.out.print("Enter Address : ");
    addGalan = scGalan.nextLine();
    System.out.print("Enter contact : ");
    contactGalan = scGalan.nextLine();

    // Getting the Students Grades
    System.out.print("\n*** Enter your grades below ***");
    System.out.print("\n\nEnter prelim grade : ");
    preGalan = scGalan.nextLine();
    System.out.print("Enter midterm grade : ");
    midGalan = scGalan.nextLine();
    System.out.print("Enter finals grade : ");
    finGalan = scGalan.nextLine();

    // Showing the output of inputed informations ang grades
    System.out.print("\n\n>>> About Student <<<");
    System.out
        .print("\nStudent's name : " + fnGalan + "\nAddress : " + addGalan + "\nContact : " + contactGalan + "\n");

    /***** Converter *****/
    double pGalan = Double.parseDouble(preGalan);
    double mGalan = Double.parseDouble(midGalan);
    double fGalan = Double.parseDouble(finGalan);

    // Showing the results
    System.out.print("\n\n>>> Grades of the Student <<<");
    pGalan = pGalan * .33;
    System.out.print("\nPrelim : " + pGalan);
    mGalan = mGalan * .33;
    System.out.print("\nMidterm : " + mGalan);
    fGalan = fGalan * .34;
    System.out.print("\nFinals : " + fGalan);
    sumGalan = pGalan + mGalan + fGalan; // formula to get the sum of pre, mid ,finals
    subgrdGalan = sumGalan / 3; // formula to get the average
    System.out.print("\n\nSubject Grade : " + subgrdGalan);
  }
}