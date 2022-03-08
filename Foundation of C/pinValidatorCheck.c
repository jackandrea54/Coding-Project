#include <stdio.h>

// Cong cac chu so roi tra ve tong
int congChuSo(int num){
	int result=0;
	result += num % 10;
	num = num/10;	
	if(num >= 10){
		result += congChuSo(num);
	} 
	else{
		result += num;
	}
	return result;
}

int congTong(int pinNum){
	int firstSet, i;
	int pinNumClone = pinNum / 10;
	int total = 0;
	// Chia phan
	for(i = 0; i <=7;i++){
		if(i%2 == 0){
			firstSet = pinNumClone%10;	
			pinNumClone = pinNumClone / 10;
			firstSet *= 2;
			total += congChuSo(firstSet);
		}
		else{
			if(pinNumClone > 10){
				total += pinNumClone%10;
				pinNumClone = pinNumClone / 10;
			}
			else{
				total += pinNumClone;
		
			}
		}
	}
	return total;
}

int layPin(){
	int pinNum;
	do{
		printf("SIN (0 to quit) : ");
		scanf("%d", &pinNum);
		if(pinNum > 99999999 && pinNum < 1000000000){
			break;
		}
		if(pinNum != 0 && pinNum <= 99999999 || pinNum >= 1000000000 ){
			printf("This is not a valid PIN \n");
		}
	}
	while(pinNum != 0);
	return pinNum;
}

int main(){
	int pinNum, total, difference,i;
	printf("SIN Validator \n");
	printf("================== \n");
	//Kiem tra
	int check = 0;
	do{
		pinNum = layPin();	
		int checkPin = pinNum % 10;
		if(pinNum == 0){
			break;
		}
		total = congTong(pinNum);

		// Kiem tra Difference
		for(i = 10;;i+=10){
			if(i-total < 10 && i-total >=0){				
				difference = i-total;
				break;
			}
		}
		
		if(difference == checkPin){
			printf("This is a valid PIN \n");
			check = 1;
		}
		else{
			printf("This is not a valid PIN, try again \n");
		}	
		
	}
	while(check != 1);
	
	
	
	
	return 0;
}
