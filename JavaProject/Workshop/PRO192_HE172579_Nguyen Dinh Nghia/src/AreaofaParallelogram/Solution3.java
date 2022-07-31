/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package AreaofaParallelogram;

import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;
/**
 *
 * @author ADMIN
 */
public class Solution3{
    static int B;
    static int H; 
    static boolean flag = check();
    static boolean check() {
        Scanner input = new Scanner(System.in);
        B = input.nextInt();
        H = input.nextInt();
        if (B <= 0 || H <=0) {
            System.out.println("java.lang.Exception: Breadth and height must be positive");
            return false;
        }
        return true;
    }
    
    public static void main(String[] args){
		if(flag){
			int area=B*H;
			System.out.print(area);
		}
		
	}//end of main
}
