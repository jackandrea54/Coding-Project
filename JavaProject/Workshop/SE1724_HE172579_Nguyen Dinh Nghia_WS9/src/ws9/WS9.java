/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ws9;

import java.util.Collection;
import java.util.Collections;
import java.util.HashSet;
import java.util.Iterator;
import java.util.TreeSet;

/**
 *
 * @author ADMIN
 */
public class WS9 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        TreeSet<DictionaryWord> dict = new TreeSet<>();
        dict.add(new DictionaryWord("bank robber", "Steals mone from a bank"));
        dict.add(new DictionaryWord("burglar", "Breaks into a home to steal things"));
        dict.add(new DictionaryWord("forger", "Makes an illegal copy of something"));
        dict.add(new DictionaryWord("hacker", "Breaks into a computer system"));
        dict.add(new DictionaryWord("hijacker", "Takes control of an airplane"));
        dict.add(new DictionaryWord("kidnapper", "Holds someone for ransom money"));
        dict.add(new DictionaryWord("mugger", "Attacks and steals money from someone"));
        dict.add(new DictionaryWord("murderer", "Kills another person"));
        dict.add(new DictionaryWord("bank robber", "Steals mone from a bank"));
        Iterator iter = dict.iterator();
        int count = 0;
        while (iter.hasNext()) {
            ((DictionaryWord)(iter.next())).showWord(count++);
            
        }
    }
    
}
