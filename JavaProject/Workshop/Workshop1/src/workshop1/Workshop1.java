/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package workshop1;

/**
 *
 * @author ADMIN
 */
public class Workshop1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // CAU A
        for (int i = 2; i <= 10; i++) {
            if (i % 2 == 0) {
                System.out.printf("%d ", i);
            }
        }
        System.out.printf("\n");

        // CAU B
        boolean flag = true;

        int i = 2;
        while (flag) {
            if (i == 11) {
                flag = false;
            } else {
                if (i % 2 == 0) {
                    System.out.printf("%d ", i);
                }
                i++;
            }
        }

    }

}
