/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package arraylistdemo;

import java.util.HashMap;
import java.util.Iterator;

/**
 *
 * @author ADMIN
 */
public class HashMapDemo {
    public static void main(String[] args) {
        HashMap h = new HashMap();
        h.put("Lão Hạc", "Nam Cao");
        h.put("Mắt Biếc", "Nguyễn Nhật Ánh");
        h.put("B12", "Lép tôn xtooi");
        System.out.println(h);
        h.put("Mắt Biếc", "Nhật Ánh");
        System.out.println(h); // Không trùng lặp key, nếu trùng key thì sửa lại value
                               // Nếu không trùng key thì add thêm
        h.remove("B12");
        System.out.println(h);
        Iterator itor = h.keySet().iterator();
        while (itor.hasNext()) {
            String key = (String) itor.next();
            String value = (String) h.get(key);
            System.out.println(key + ": " + value);
            
        }
    }
}
