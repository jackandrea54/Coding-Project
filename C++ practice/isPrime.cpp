#include <iostream>
#include <math.h>
#include <vector>
#include <algorithm>
using namespace std;

vector<int> primeNum; //De chua cac so nguyen to
int ar[5];//De chua cac chu so 

//Kiem tra xem so co phai so nguyen to khong
bool isPrime(int firstNum,int secNum){
	int testNum=0;
	int ar_clone[5];
	//Clone mot array khac
	for(int i =0;i<5;i++){
		ar_clone[i]=ar[i];
	}
	//Swap 2 chu so trong array
	int temp;
	temp = ar_clone[firstNum];
	ar_clone[firstNum]= ar_clone[secNum];
	ar_clone[secNum]=temp;
	//Ghep cac chu so trong array vao thanh mot so la testNum 
	for(int i =0 ;i < 5; i++){
		testNum+= ar_clone[i]*pow(10,i);
 	}
 	//Kiem tra lai testNum co 5 chu so khong
	if(testNum <10000){
		return false;
		}
	else{
	 	//Kiem tra testNum co phai la prime khong
	    if (testNum % 2 == 0 || testNum % 3 == 0){
	    	return false;
		}
	    for (int i = 5; i * i <= testNum; i = i + 6){
	    	if (testNum % i == 0 || testNum % (i + 2) == 0){
	    		return false;
			}
		}
	    //Cho so prime vao mot vector
	  	primeNum.push_back(testNum);
	    return true;	
	}
}

//Nhap so N va kiem tra dieu kien
int nhapN(){
	int n;
	cout << "Nhap mot so N gom 5 chu so: ";
	cin >> n;
	
	do{
		if(n >10000 && n <99999){
			break;
		}
		else{
			cout << "Nhap lai so N"<<endl;
			n = nhapN();
		}
	}
	while( n < 10000 || n > 99999);
	
	return n;
}

int main(){
	int n= nhapN();
	//Tach n ra cac chu so de cho vao array
	for(int i = 0;i <5;i++){
		ar[i] = n%10;
		if(n>=10){
			n = n/10;
		}
		else if(n<10 && n>0){
			break;
			
		}
	}	
	
	for(int i = 0;i < 5;i++){
		for(int j = i; j < 5; j++ ){
			isPrime(i,j);
		}
	}
	//Print out result
	if(primeNum.size() == 0){
		cout << "Impossible"<<endl;
	}
	else{
		cout<<"Prime Num is: " << *min_element(primeNum.begin(), primeNum.end()) <<endl;
	}
	
	return 0;
}
