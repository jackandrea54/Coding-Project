/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package dao;

import entity.Bill;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;
import model.DBConnect;

/**
 *
 * @author ADMIN
 */
public class DAOBill extends DBConnect{
    public int AddBill(Bill bill){
        int n = 0;
        String sql = "USE [SE1704]\n" +
                    "INSERT INTO [Bill]\n" +
                    "           ([bid]\n" +
                    "           ,[recAddress]\n" +
                    "           ,[recPhone]\n" +
                    "           ,[note]\n" +
                    "           ,[totalMoney]\n" +
                    "           ,[status]\n" +
                    "           ,[cid])\n" +
                    "     VALUES\n" +
                    "           ('"+bill.getBid()+"'\n" +
                    "           ,'"+bill.getRecAddress()+"'\n" +
                    "           ,'"+bill.getRecPhone()+"'\n" +
                    "           ,'"+bill.getNote()+"'\n" +
                    "           ,'"+bill.getTotalMoney()+"'\n" +
                    "           ,'"+bill.getStatus()+"'\n" +
                    "           ,'"+bill.getCid()+"')";
        
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
        DAOBill dao = new DAOBill();
        int n = dao.AddBill(new Bill("B01","HaNoi","035296","Very rich",100020.2,0,"C02"));
        if (n > 0) {
            System.out.println("inserted");
        }
    }
}
