
package ws3;

public class Student {
    private String name;
    private String studentId;
    private String birthDate;
    private String address;
    private String major;
    private double gpa;

    public Student() {  
        this("Nguyen Van A");
    }    

    public Student(String name) {
        this(name, "HE170000");
    }
    
    
    public Student(String name, String studentId) {
        this(name, studentId, "01-01-2003");
    }

    public Student(String name, String studentId, String birthDate) {
        this(name, studentId, birthDate, "Ha Noi");
    }
    
    public Student(String name, String studentId, String birthDate, String address) {
        this(name, studentId, birthDate, address, "SE");
    }
    
    public Student(String name, String studentId, String birthDate, String address, String major) {
        this(name, studentId, birthDate, address, major, 8.9);
    }
    
    public Student(String name, String studentId, String birthDate, String address, String major, double gpa) {
        this.name = name;
        this.studentId = studentId;
        this.birthDate = birthDate;
        this.address = address;
        this.major = major;
        this.gpa = gpa;
    }
    
    
    
    public String getName() {
        return name;
    }

//    public void setName(String name) {
//        this.name = name;
//    }

    public String getStudentId() {
        return studentId;
    }

//    public void setStudentId(String studentId) {
//        this.studentId = studentId;
//    }

    public String getBirthDate() {
        return birthDate;
    }

//    public void setBirthDate(String birthDate) {
//        this.birthDate = birthDate;
//    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getMajor() {
        return major;
    }

    public void setMajor(String major) {
        this.major = major;
    }

    public double getGpa() {
        return gpa;
    }

    public void setGpa(double gpa) {
        this.gpa = gpa;
    }
    public void printAllAttributes(){
        System.out.printf("Student name: %s\n",this.name);
        System.out.printf("\tID: %s\n",this.studentId);
        System.out.printf("\tBirthdate: %s\n",this.birthDate);
        System.out.printf("\tAddress: %s\n",this.address);
        System.out.printf("\tMajor: %s\n",this.major);
        System.out.printf("\tGPA: %.1f\n",this.gpa);
    }
    
}

class Main2{
    public static void main(String[] args) {
        Student stu1;
        stu1 = new Student("Nghia","HE172579","17-08-2003","142 Quan Nhan","Software Engineering",9.5);
        stu1.printAllAttributes();
        Student stu2 = new Student("To Quang Nam", "HE173167");
        stu2.printAllAttributes();
    }
}
