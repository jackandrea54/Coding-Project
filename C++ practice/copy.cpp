#include <string.h>
#include <iostream>
using namespace std;
int main() {
	char a[100] ;
    string d;
    char c[4] = {'s','h','o','p'};
    char b[100]= "qua tao "; //chuoi b sau khi duoc them vao khong duoc vuot qua kich thuoc cua chuoi(o day la 20) de tranh bi tran bo nho
    
    cout << "nhap vao a: ";
    cin.getline(a,100); // dung de lay ca chuoi ky tu sau dau cach (dung cho char) 
    
    cout << "d: ";
    getline(cin, d); // dung de la chuoi ky tu sau dau cach (dung cho string)
    cout <<"d la: "<< d <<endl;
    
    strcat(b,a);
    cout << "Chuoi a: " << a << "\n";
    cout << "Chuoi b: " << b<< "\n";
    cout << strlen(b);
}
