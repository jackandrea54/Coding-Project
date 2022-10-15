package bo;


import constant.Regex;
import entity.student;
import java.io.File;
import java.io.RandomAccessFile;
import utils.Validator;

/**
 *
 * @author thangnv
 */
public class readfile {

    public static void readfile(String fname, listStudent p, int pos, String Class) throws Exception {
        File f = new File(fname);
        if (!f.isFile()) {
            return;
        }
        RandomAccessFile fr = new RandomAccessFile(fname, "r");
        String s;
        if(!p.isEmpty()){
            p.clear();
        }
        //Read all class
        if(Class.equals("all")){
            while ((s = fr.readLine()) != null) {
                String arr[] = s.split("; ");

                p.addTail(new student(
                        arr[0], arr[1], arr[2], Double.parseDouble(arr[3]),
                        Double.parseDouble(arr[4]), Double.parseDouble(arr[5]),
                        Double.parseDouble(arr[6]), Double.parseDouble(arr[7]))
                );
            }
        }else{ //Read a specific class
            while ((s = fr.readLine()) != null) {
                if (s.matches("^.*; " + Class + ".*$")) {
                    String arr[] = s.split("; ");
                    p.addTail(new student(
                            arr[0], arr[1], arr[2], Double.parseDouble(arr[3]),
                            Double.parseDouble(arr[4]), Double.parseDouble(arr[5]),
                            Double.parseDouble(arr[6]), Double.parseDouble(arr[7]))
                    );
                }
            }
        }
        
        //Add them sinh vien vao head hoac tail
        String inputName = Validator.getString("Please enter your name: ",
                                                "Wrong name format, please re-enter your name!", 
                                                Regex.NAME_FORM);
        String inputClass;
        if (Class.equals("all")) {
            inputClass = Validator.getString("Please enter your class: ",
                                                "Wrong class format, please re-enter using this format: SE**** ", 
                                                Regex.CLASS_FORM);
        }
        else{
            inputClass = Class;
        }
        String rollNum = Validator.getString("Please enter your rollnumber: ",
                                                "Wrong Rollnumber format, please re-enter using this format: HE/HA/HS******", 
                                                Regex.ID_FORM);
        double Pt1 = Validator.getDouble(0.0, 10.0,
                                        "Please enter your Progess Test 1 mark:",
                                        "Please re-enter your mark within range [" + 0.0 + "," + 10.0 + "]",
                                        "Wrong format, float number format allowed only");
        double Pt2 = Validator.getDouble(0.0, 10.0,
                                        "Please enter your Progess Test 2 mark:",
                                        "Please re-enter your mark within range [" + 0.0 + "," + 10.0 + "]",
                                        "Wrong format, float number format allowed only");;
        double As1 = Validator.getDouble(0.0, 10.0,
                                        "Please enter your Assignment 1 mark:",
                                        "Please re-enter your mark within range [" + 0.0 + "," + 10.0 + "]",
                                        "Wrong format, float number format allowed only");;
        double As2 = Validator.getDouble(0.0, 10.0,
                                        "Please enter your Assignment 2 mark:",
                                        "Please re-enter your mark within range [" + 0.0 + "," + 10.0 + "]",
                                        "Wrong format, float number format allowed only");;
        double AT = Validator.getDouble(0.0, 100.0,
                                        "Please enter your AT mark:",
                                        "Please re-enter your mark within range [" + 0.0 + "," + 100.0 + "]",
                                        "Wrong format, float number format allowed only");;
        if (pos == 0) {
            p.addHead(new student(inputName, rollNum, inputClass,  Pt1, Pt2, As1, As2, AT));
        }
        else{
            p.addTail(new student(inputName, rollNum, inputClass,  Pt1, Pt2, As1, As2, AT));
        }
    }

}
