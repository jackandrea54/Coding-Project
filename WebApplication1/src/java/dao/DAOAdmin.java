/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package dao;

import entity.Admin;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;
import model.DBConnect;

/**
 *
 * @author ADMIN
 */
public class DAOAdmin extends DBConnect{
    public int AddAdmin(Admin admin){
        int n = 0;
        String sql = "USE [SE1704]\n" +
                    "INSERT INTO [admin]\n" +
                    "       VALUES\n" +
                    "           ('"+admin.getAdmin()+"',\n" +
                    "           '"+admin.getPassword()+"')";
                
                
        Statement state;
        try {
            state = conn.createStatement();
            n = state.executeUpdate(sql);
        } catch (SQLException ex) {
            Logger.getLogger(DAOBill.class.getName()).log(Level.SEVERE, null, ex);
        }
        return n;
    }
    
    public static void main(String[] args) {
        DAOAdmin dao = new DAOAdmin();
        int n = dao.AddAdmin(new Admin("dinhnghia","dinhnghia1708"));
        if (n > 0) {
            System.out.println("inserted");
        }
    }
    
}
