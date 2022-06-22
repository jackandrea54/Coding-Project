/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package scannerdemo;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;
import java.util.logging.Logger;

/**
 *
 * @author ADMIN
 */
public class ScannerDemo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
//        File f = new File("src/scannerdemo/f1.txt");
//        try {
//            //su dung Scanner, truyen file vao, duyet text, in ra man hinh.
//            Scanner sc = new Scanner(f);
//            sc.useDelimiter("[[.],\\d]+");  // \d: toan bo cac ki tu số, +: cac kí tự bị lặp, \s: space
//            while (sc.hasNext()) {                
//                System.out.println(sc.next());
//            }
//            
//        } catch (FileNotFoundException ex) {
////            Logger.getLogger(ScannerDemo.class.getName()).log(Level.SEVERE, null, ex);
//        }
//        
        String s = "HE172579, Nguyen Dinh Nghia, Ha Noi, 2003";
        String[] arr = s.split(", ");
        for(String x : arr) System.out.println(x);
    }
    
}
