/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package oop;

/**
 *
 * @author ADMIN
 */
public class Student extends Person{
    protected int id;
    
    //Constructor
    public void setData(int idInput, String fullnameString, String birthdayString, String addressString){
        id = idInput;
        fullname = fullnameString;
        birthday = birthdayString;
        address = addressString;
    }
    
    
    
}
