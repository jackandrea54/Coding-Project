
import java.util.Arrays;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author ADMIN
 */
public class GenericArray <T> {
    public T get( int i, T[] ar){
        return ar[i];
    }
    public static <T> void output(T[] ar){
        for(T x: ar ) System.out.print(x + ", ");
        System.out.println();
//        System.out.println(ar instanceof T[]); //Generic khong dung cho instanceof duoc
    }
    public static <T> void sort(T[] ar){
        Arrays.sort(ar);
    }
}
