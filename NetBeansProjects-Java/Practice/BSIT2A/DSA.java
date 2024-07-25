package BSIT2A;

import javax.swing.*;

public class DSA {
    public static void main(String[] args) {
        String inputGalan = JOptionPane.showInputDialog(null,
                "\nSelect loop: \n1.Forloop\n2.Whileloop\n3.DoWhileloop\n4.Exit\n----------------------------\nEnter Looping : ");
        switch (Integer.parseInt(inputGalan)) {
            case 1 -> {
                String inIntGalan = JOptionPane.showInputDialog(null, "Enter Loop Iteration : ");
                int toIntGalan = Integer.parseInt(inIntGalan);
                for (int i = 1; i <= toIntGalan; i++) {
                    JOptionPane.showMessageDialog(null, "For Loop :" + i);
                }
                break;
            }
            case 2 -> {
                String inIntGalan = JOptionPane.showInputDialog(null, "Enter Loop Iteration : ");
                int toIntGalan = Integer.parseInt(inIntGalan);
                int i = 1;
                while (i <= toIntGalan) {
                    JOptionPane.showMessageDialog(null, "While Loop :" + i);
                    i++;
                }
                break;
            }
            case 3 -> {
                String inIntGalan = JOptionPane.showInputDialog(null, "Enter Loop Iteration : ");
                int toIntGalan = Integer.parseInt(inIntGalan);
                int i = 1;
                do {
                    JOptionPane.showMessageDialog(null, "Do While Loop :" + i);
                    i++;
                } while (i <= toIntGalan);
                break;
            }
            default -> {
                System.exit(0);
            }
        }
    }
}
