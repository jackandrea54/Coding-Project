/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author ADMIN
 */
public class MyString implements IString {

    @Override
    public int f1(String str) {
        int count = 0;
        String[] arr = str.split("\\s");
        for (String x : arr) {
            for (int i = 0; i < x.length(); i++) {
                char curChar = x.charAt(i);
                if (Character.isDigit(curChar)) {
                    int curNum = Integer.parseInt("" + curChar);
                    if (curNum % 2 != 0) {
                        count++;
                        break;
                    }
                }
            }
        }
        return count;
    }

    @Override
    public String f2(String str) {
        String s = null;
        String[] arr = str.split("\\s");
        for (String x : arr) {
            StringBuilder xBuff = new StringBuilder(x);
            xBuff.reverse();
            if (x.equalsIgnoreCase(xBuff.toString())) {
                s = str.replaceFirst(x, "XX");
            }
        }
        return s;
    }

}
