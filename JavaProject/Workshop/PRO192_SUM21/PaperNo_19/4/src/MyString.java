/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author ADMIN
 */
public class MyString implements IString{

    @Override
    public int f1(String str) {
        int count = 0;
        String[] arr = str.split("\\s");
        for (String string : arr) {
            if (string.matches(".*[mnMN]$")) {
                count++;
            }
        }
        return count;
    }

    @Override
    public String f2(String str) {
        int longestStr = 0;
        String[] arr = str.split("\\s");
        for (int i = 1; i < arr.length; i++) {
            if(arr[i].length() > arr[longestStr].length())  longestStr = i;
        }
        
        StringBuilder strRev = new StringBuilder(arr[longestStr]);
        arr[longestStr] = strRev.reverse().toString();
        String newStr = "";
        for (String string : arr) {
            newStr += string + " ";
        }
        return newStr;
    }
    
}
