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
public class StringBufferDemo {
    public static void main(String[] args) { //String buffer is slower than String Builder but safer due to THREADSAFE
        StringBuffer sBuf = new StringBuffer("01234567");
        System.out.println(sBuf);
        sBuf.append(" LMAO")
            .append(" ABC")
            .append(" " + "DEF");
        System.out.println(sBuf);
        sBuf.insert(4, " YO MAMA IS FAT! ");
        System.out.println(sBuf);
        sBuf.reverse();
        System.out.println(sBuf);
        
        sBuf.reverse();
        sBuf.delete(4, 21);
        System.out.println(sBuf);
        int pos = sBuf.lastIndexOf("AB");
        System.out.println("Position: "+pos);
    }
}
