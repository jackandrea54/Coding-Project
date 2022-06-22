/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package numbers;

import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class ScannerDemo {
    public static void main(String[] args) {
        Scanner sc = new Scanner("Hello tat ca moi nguoi");
        while(sc.hasNext()){
            System.out.println(sc.next());
        }
        
        String s = "abc 123 3.14 -23";
        sc = new Scanner(s);
        System.out.println(sc.next());
        System.out.println(sc.nextInt());
        System.out.println(sc.nextDouble());
        System.out.println(sc.nextInt());
        
        //chuẩn hóa chuỗi, chỉ chứa các câu đúng chính tả, mỗi từ cách nhau 1 dấu space)
        String s1 = new String("a  ,,,,bc");
        s1 = s1.replaceAll("[ ,]", "");
        System.out.println("s1 = "+s1);
        
        Scanner sc1 = new Scanner("Xin     chao,,, tat ca   cac ban,,,!");
        String pattern = "[\\s,]+"; // s: space,  +: >= 1 occurence
        sc1.useDelimiter(pattern);
        String st_result = "";
        while(sc1.hasNext()){
            st_result += sc1.next() + " ";
        }
        System.out.println("st_result = "+st_result);
    }
}
