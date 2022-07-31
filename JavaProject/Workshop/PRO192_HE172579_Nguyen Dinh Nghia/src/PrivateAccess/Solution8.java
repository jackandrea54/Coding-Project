/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PrivateAccess;

/**
 *
 * @author ADMIN
 */
import PrivateAccess.Solution8.Private;
import java.io.*;
import java.lang.reflect.*;
import java.util.*;
import java.util.regex.*;

public class Solution8 {

    public static void main(String[] args) throws Exception {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int num = Integer.parseInt(br.readLine().trim());
        Object o;
        o = new Solution8();
        Solution8.Private o2;
        o2 = ((Solution8)o).new Private();
        System.out.println(num +" is "+o2.powerof2(num));
                
        
        
        
        System.out.println("An instance of class: " + o.getClass().getSimpleName() + " has been created");
    }//end of main

    class Private {

        private String powerof2(int num) {
            return ((num & num - 1) == 0) ? "power of 2" : "not a power of 2";
        }
    }//end of Privtate
}//end of solution
