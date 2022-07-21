/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package FileDemo;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author ADMIN
 */
public class FileWriteDemo {
    public static void main(String[] args) {
        try {
            FileWriter fw = new FileWriter("src\\FileDemo\\f2_test.txt");
            fw.write("Hello guys");
            fw.close();
        } catch (IOException ex) {
            Logger.getLogger(FileWriteDemo.class.getName()).log(Level.SEVERE, null, ex);
        }
        
        
       
    }
}
