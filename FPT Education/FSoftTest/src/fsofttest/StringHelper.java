/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package fsofttest;

import java.math.BigInteger;

/**
 *
 * @author ADMIN
 */
public class StringHelper {

    String value;

    public StringHelper() {
    }

    public StringHelper(String value) {
        this.value = value;
    }

    public String Concat(String str) {
        if (value == null) {
            return str;
        }
        if (str == null) {
            return value;
        }

        return value + str;
    }

    public String SubString(int indexStr, int indexEnd) {
        if (value == null) {
            throw new NullPointerException();
        }
        if (indexStr < 0) {
            throw new StringIndexOutOfBoundsException(indexStr);
        }
        if (indexEnd >= value.length()) {
            throw new StringIndexOutOfBoundsException(indexEnd);
        }
        if (indexEnd - indexStr < 0) {
            throw new StringIndexOutOfBoundsException();
        }
        char s[] = new char[value.length()];
        char newStr[] = new char[indexEnd - indexStr + 1];
        for (int i = 0; i <= indexEnd - indexStr; i++) {
            newStr[i] = s[indexStr + i];
        }
        return new String(newStr);
    }

    public boolean Distinct(String str) {
        if (value == null || str == null) {
            throw new NullPointerException();
        }

        if (value.length() != str.length()) {
            return true;
        }
        char valueStr[] = value.toCharArray();
        char strArr[] = str.toCharArray();
        for (int i = 0; i < valueStr.length; i++) {
            if (valueStr[i] == strArr[i]) {
                return false;
            }
        }

        return true;
    }

    public boolean Contains(String str) {
        if (value == null || str == null) {
            throw new NullPointerException();
        }
        if (value.length() < str.length()) {
            return false;
        }
        char valueStr[] = value.toCharArray();
        char strArr[] = str.toCharArray();
        boolean flag = false;
        for (int i = 0; i < value.length() - str.length() && flag == false; i++) {
            if (valueStr[i] == strArr[0]) {
                flag = true;
                for (int j = 0; j < strArr.length && flag == true; j++) {
                    if (valueStr[j + i] != strArr[j]) {
                        flag = false;
                    }
                }
            }
        }

        return flag;
    }

    public static void printNumsNotInArray(int arr[]) {
        int temp[] = new int[101];
        for (int i : arr) {
            temp[i] = i;
        }
        System.out.println("Missing numbers are: ");
        for (int i = 1; i <= 100; i++) {
            if (temp[i] == 0) {
                System.out.print(i + " ");
            }
        }
    }

    public static void main(String[] args) {
        int arr[] = {1, 2, 4};
        sumOfFibonacciNumSmallerThan1000();
    }

    //Please implement a method to list all the numbers smaller than 1000 in Fibonacci sequence (0, 1, 1, 2, 3, 5, 8, 13 …...) then output the sum of these number.
    public static int sumOfFibonacciNumSmallerThan1000() {
        int sum = 0;
        int a = 0;
        int b = 1;
        int c = 0;
        System.out.print("(");
        while (true) {
            if(a < 1000){
                System.out.print(a + ", ");
            }
            c = a + b;
            a = b;
            b = c;
            if (c > 1000) {
                break;
            }
            sum += c;
        }
        System.out.print(a + ")");
        
        return sum;
    }

}
