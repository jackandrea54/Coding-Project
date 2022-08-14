/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package testquiz;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;

/**
 *
 * @author ADMIN
 */
class A{
    int x = 2;
    public void amed(){
        System.out.println("A");
    }
}
class b extends A{
    int x = 3;
    public void amed2(){
        System.out.println("B");
    }
}

public class TestQuiz {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args){
        A a2 = new b();
        System.out.println(a2.x);
        String s = "Hi";
        s+= 'c';
    }
}
