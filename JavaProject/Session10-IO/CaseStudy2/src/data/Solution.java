/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package data;

/**
 *
 * @author ADMIN
 */
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        
        Scanner sc=new Scanner(System.in);
        String A=sc.next();
        StringBuilder B = new StringBuilder(A);
        /* Enter your code here. Print output to STDOUT. */
        B.reverse();
        if(A.equals(B.toString())){
            System.out.println("YES");
        }
        else System.out.println("NO");
        
    }
}
