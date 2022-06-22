/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package numbers;

/**
 *
 * @author ADMIN
 */
public class Strings {
    public static void main(String[] args) {
        String s1 = "abc";
        char c = s1.charAt(1);
        int x = s1.compareTo("cba"); //gọi "cba" là s2
        // So sánh theo thứ tự từ điển
        // Nếu s1 > s2: x > 0
        // Nếu s1 = s2: x = 0
        // Nếu s1 < s2: x < 0
        System.out.println("x = "+x);
        
        // So sánh ko phân biệt chữ thường, chữ hoa
        int result = "ABC".compareToIgnoreCase("abC");
        System.out.println("result = "+result);
        
        String s = "hello world";
        
        System.out.println("sub: "+ s.substring(2));
        System.out.println("sub2: "+ s.substring(2,5)); // lay vi tri tu 2,3,4
        
        System.out.println(s.concat("..")); // Add ".." to the end of the string
        System.out.println("Does s contain 'he': " + s.contains("he"));
        
        
    }
}
