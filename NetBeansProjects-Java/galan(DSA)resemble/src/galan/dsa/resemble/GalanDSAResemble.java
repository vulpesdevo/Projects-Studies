package galan.dsa.resemble;

import java.util.*;

public class GalanDSAResemble {

    public static void main(String[] Galan) {

        Scanner scGalan = new Scanner(System.in);
        double tokmGalan, tomileGalan, tosqrmGalan;
        float numGalan;

        String numberGalan,
                fnGalan, mnGalan, lnGalan,
                schGalan, genGalan, contGalan,
                addGalan, subGalan, courseGalan,
                nationGalan;
        print("Enter Firstname : ");
        fnGalan = scGalan.nextLine();
        print("Enter Middlename : ");
        mnGalan = scGalan.nextLine();
        print("Enter Lastname : ");
        lnGalan = scGalan.nextLine();
        print("Enter School : ");
        schGalan = scGalan.nextLine();
        print("Enter Gender : ");
        genGalan = scGalan.nextLine();
        print("Enter Contact : ");
        contGalan = scGalan.nextLine();
        print("Enter Address : ");
        addGalan = scGalan.nextLine();
        print("Enter Subject : ");
        subGalan = scGalan.nextLine();
        print("Enter Course : ");
        courseGalan = scGalan.nextLine();
        print("Enter Nationality : ");
        nationGalan = scGalan.nextLine();
        print("\nName : " + fnGalan + " " + mnGalan + " " + lnGalan
                + "\nSchool : " + schGalan
                + "\nGender : " + genGalan
                + "\nContact : " + contGalan
                + "\nAddress : " + addGalan
                + "\nSubject : " + subGalan
                + "\nCourse : " + courseGalan
                + "\nNationality : " + nationGalan);
        print("\nEnter number to compute : ");
        numberGalan = scGalan.nextLine();
        numGalan = Float.parseFloat(numberGalan);

        print("\nEnter dividend : ");
        double diviGalan = scGalan.nextDouble();
        print("Enter Divisor : ");
        double dGalan = scGalan.nextDouble();
        double OPgalan = diviGalan / dGalan;

        if (OPgalan == 0) {
            print(">>> Valid <<<");
            tokmGalan = numGalan * 1.609344;
            tomileGalan = numGalan / 1609.344;
            tosqrmGalan = numGalan * 10000;
            print("\nKilometer : " + tokmGalan + "\nMiles : " + tomileGalan + "\nSquaremeter : " + tosqrmGalan);

        } else {
            print(">>> Invalid <<<");
        }

    }

    //to shorten the "System.out.print()"
    static void print(String SOP) {
        System.out.print(SOP);
    }
}
