/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exceptiondemo_1;

import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class ExceptionDemo_1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        try{
            int n = 10;
            int[] arr = {1, 2, 3, 4, 5};
            for (int i = 0; i < n;i++){
                System.out.println(arr[i]); // Out of size's array
            }
        } catch (Exception e){ //general exception
            System.out.println("Index vuot qua kich thuoc mang");
//            e.printStackTrace();           
        }
        finally{
            System.out.println("Outside try catch");
        }
        
        // Catch Exceptions: Using try catch to input an integer (10<=n<=50)
        Scanner in = new Scanner(System.in);  
        int n = 0;
        do{
            try {
                System.out.println("Enter a whole number: ");
                n = Integer.parseInt(in.nextLine());  
            } catch (Exception e) {
                System.out.println("Required integer!");
            }
        } while(n < 10 || n > 50);
        
        
        
    }
    
}
