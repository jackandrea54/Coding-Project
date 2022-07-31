import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        
        if(n%2 != 0) System.out.println("Weird");
        if(n%2 == 0){
            if(n <=5) System.out.println("Not Weird");
            else if(n <= 20) System.out.println("Weird");
            else System.out.println("Not Weird");
        }   
        
    }
}