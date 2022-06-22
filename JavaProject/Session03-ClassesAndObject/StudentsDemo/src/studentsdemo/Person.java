/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package studentsdemo;

/**
 *
 * @author ADMIN
 */
public class Person extends Object { //Neu khong extends gi thi se mac dinh la extend Object

    protected String fullname;
    protected String birthday;
    protected String address;
    
   
    public String getFullname() {
        return fullname;
    }

    public void setFullname(String fullname) {
        this.fullname = fullname;
    }

    public String getBirthday() {
        return birthday;
    }

    public void setBirthday(String birthday) {
        this.birthday = birthday;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    @Override
    public String toString() {
        return "Person{" + "fullname=" + fullname + ", birthday=" + birthday + ", address=" + address + '}';
    }

}
