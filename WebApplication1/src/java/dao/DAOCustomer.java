/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package dao;

/**
 *
 * @author ADMIN
 */
import entity.Customer;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;
import model.DBConnect;

public class DAOCustomer extends DBConnect {

    public int AddCustomer(Customer cus) {
        int n = 0;
        String sql = "USE [SE1704]\n"
                + "INSERT INTO [Customer]\n"
                + "           ([cid]\n"
                + "           ,[cname]\n"
                + "           ,[username]\n"
                + "           ,[password]\n"
                + "           ,[address]\n"
                + "           ,[phone]\n"
                + "           ,[status])\n"
                + "     VALUES ('" + cus.getCid() + "','" + cus.getCname() + "','"
                + cus.getUsername() + "','" + cus.getPassword() + "','"
                + cus.getAddress() + "','" + cus.getPhone() + "'," + cus.getStatus() + ")";

        try {
            //Tao lenh
            Statement state = conn.createStatement();
            //Chay lenh va nhan ket qua
            n = state.executeUpdate(sql);
        } catch (SQLException ex) {
            Logger.getLogger(DAOCustomer.class.getName()).log(Level.SEVERE, null, ex);
        }
        return n;
    }

    public int addCustomerByPre(Customer cus) {
        int n = 0;
        String sql = "USE [SE1704]\n"
                + "INSERT INTO [Customer]\n"
                + "           ([cid]\n"
                + "           ,[cname]\n"
                + "           ,[username]\n"
                + "           ,[password]\n"
                + "           ,[address]\n"
                + "           ,[phone]\n"
                + "           ,[status])\n"
                + "     VALUES (?,?,?,?,?,?,?)";
        try {
            PreparedStatement pre = conn.prepareStatement(sql);
            //set parameter
            pre.setString(1, cus.getCid());
            pre.setString(2, cus.getCname());
            pre.setString(3, cus.getUsername());
            pre.setString(4, cus.getPassword());
            pre.setString(5, cus.getAddress());
            pre.setString(6, cus.getPhone());
            pre.setInt(7, cus.getStatus());
//            pre.setDataType(index?,value);
//            dataType is dataType of field
//            index of ? start 1
        } catch (SQLException ex) {
            Logger.getLogger(DAOCustomer.class.getName()).log(Level.SEVERE, null, ex);
        }
        return n;
    }

    public static void main(String[] args) {
        DAOCustomer dao = new DAOCustomer();
        int n = dao.AddCustomer(new Customer("C02", "John", "abc", "1234567", "SG",
                "09423434", 0));
        if (n > 0) {
            System.out.println("inserted");
        }
    }
}
