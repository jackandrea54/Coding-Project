/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package FileDemo;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.Date;
import java.util.StringTokenizer;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author ADMIN
 */
public class FileDemo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        BufferedReader reader = null;
        try {
            // TODO code application logic here
            File f = new File("f_test.txt"); //File phai o ngang hang voi thu muc src
            File f2 = new File("D:\\Coding Project\\JavaProject\\Session10-IO\\FileDemo\\src\\FileDemo\\f2_test.txt"); //Duong dan tuyet doi
            File f3 = new File("src\\FileDemo\\f2_test.txt"); //Duong dan tuyet doi
            
//            System.out.println("Absolute path: " + f.getAbsolutePath());
//            System.out.println("Ten File: "+ f.getName());
//            System.out.println("Parents: " + f.getParent());
//            System.out.println("Ten file tuyet doi: "+f.getAbsoluteFile());
//            System.out.println("Ngay cap nhat cuoi cung: " + new Date(f.lastModified()) );
//            System.out.println("Kich thuoc: " + f.length() + " bytes");
            //Doc file
            reader = new BufferedReader(new FileReader(f));
            String line = reader.readLine();
            while (line != null) {                
//                System.out.println(line);
//               String[] strs = line.split(","); Cach 1: return 1 cai array string 
                StringTokenizer stk = new StringTokenizer(line, ","); //Cach 2
                String id = stk.nextToken().trim();
                String fullname = stk.nextToken().trim();
                String age = stk.nextToken().trim(); //Trim de loai bo dau cach o dau va cuoi string
                System.out.println("ID: " + id + ", Name: " + fullname + ", Age: "+age);
                line = reader.readLine();
            }
            
            //Doc Folder
            File f4 = new File("src\\TestFolder");
            String[] L = f4.list();
            System.out.println("Noi dung thu muc "+ f4.getName() + ":");
            for (int i = 0; i < L.length; i++) {
                System.out.println(L[i]);
            }

           
            
            
            
        } catch (FileNotFoundException ex) {
            Logger.getLogger(FileDemo.class.getName()).log(Level.SEVERE, null, ex);
        } catch (IOException ex) {
            Logger.getLogger(FileDemo.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            try {
                reader.close();
            } catch (IOException ex) {
                Logger.getLogger(FileDemo.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
       
    }
    
}
