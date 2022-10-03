package utils;


import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author ADMIN
 */
public class Validator {

    /**
     * input a number integer
     *
     * @param min                       minimum limit value
     * @param max                       maximum limit value
     * @param messageInfo               display when user input
     * @param messageErrorOutOfRange    display when user input out of range
     * @param messageErrorInvalidNumber display when user input an invalid number
     * @return the integer value
     */
    public static int getInteger(
            int min,
            int max,
            String messageInfo,
            String messageErrorOutOfRange,
            String messageErrorInvalidNumber) {
        Scanner scanner = new Scanner(System.in);
        int number;
        while (true) {
            try {
                System.out.println(messageInfo);
                number = Integer.parseInt(scanner.nextLine());
                if (number >= min && number <= max) {
                    return number;
                }
                System.out.println(messageErrorOutOfRange);
            } catch (NumberFormatException e) {
                System.out.println(messageErrorInvalidNumber);
            }
        }
    }
    
    /**
     * input a number double
     *
     * @param min                       minimum limit value
     * @param max                       maximum limit value
     * @param messageInfo               display when user input
     * @param messageErrorOutOfRange    display when user input out of range
     * @param messageErrorInvalidNumber display when user input an invalid number
     * @return the integer value
     */
    public static double getDouble(
            double min,
            double max,
            String messageInfo,
            String messageErrorOutOfRange,
            String messageErrorInvalidNumber) {
        Scanner scanner = new Scanner(System.in);
        double number;
        while (true) {
            try {
                System.out.println(messageInfo);
                number = Double.parseDouble(scanner.nextLine());
                if (number >= min && number <= max) {
                    return number;
                }
                System.out.println(messageErrorOutOfRange);
            } catch (NumberFormatException e) {
                System.out.println(messageErrorInvalidNumber);
            }
        }
    }
    /**
     * Get a string with provided form
     * 
     * @param messageInfo               is message info of String want to input
     * @param messageErrorInvalidString is error if input is invalid String
     * @param REGEX                     is String to valid input
     * @return a String with exact form
     */
    public static String getString(String messageInfo,
            String messageErrorInvalidString,
            final String REGEX) {
        Scanner scanner = new Scanner(System.in);
        do {
            try {
                System.out.print(messageInfo);
                String inputString = scanner.nextLine().trim();
                if (inputString.matches(REGEX)){
                    return inputString;
                }
                System.out.println(messageErrorInvalidString);
            } catch (Exception e) {
                System.out.println(messageErrorInvalidString);
            }
        } while (true);
    }
}
