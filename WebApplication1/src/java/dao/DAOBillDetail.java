/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package dao;

import entity.BillDetail;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;
import model.DBConnect;

/**
 *
 * @author ADMIN
 */
public class DAOBillDetail extends DBConnect {

    public int AddBillDetail(BillDetail billDe) {
        int n = 0;
        String sql = "USE [SE1704]\n"
                + "INSERT INTO [BillDetail]\n"
                + "           ([bid]\n"
                + "           ,[pid]\n"
                + "           ,[buyQuantity]\n"
                + "           ,[buyPrice]\n"
                + "           ,[subtotal])\n"
                + "     VALUES\n"
                + "           ('"+billDe.getBid()+"'\n"
                + "           ,'"+billDe.getPid()+"'\n"
                + "           ,"+billDe.getBuyQuantity()+"\n"
                + "           ,"+billDe.getBuyPrice()+"\n"
                + "           ,"+billDe.getSubtotal()+")";
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
        DAOBillDetail dao = new DAOBillDetail();
        int n = dao.AddBillDetail(new BillDetail("B01", "P01", 2, 120000, 240000));
        if (n > 0) {
            System.out.println("inserted");
        }
    }

}
