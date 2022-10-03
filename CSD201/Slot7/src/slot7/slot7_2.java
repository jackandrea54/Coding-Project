/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package slot7;

/**
 *
 * @author ADMIN
 */
public class slot7_2 {

    public static void main(String[] args) {
        printFibonacci(45, 0, 1);
    }

    public static void printFibonacci(int count, int n1, int n2) {
        if (count == 1) {
            System.out.print(n1);
            return;
        } else {
            System.out.print(n1 + ", ");
            printFibonacci(count - 1, n2, n1 + n2);
        }
    }
}