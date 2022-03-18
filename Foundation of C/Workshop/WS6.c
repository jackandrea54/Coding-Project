#include <stdio.h>

int validISBN(int C[11]){
	long long input;
	int i,j,T;
	printf("ISBN (0 to quit): ");
	scanf("%ld",&input);
	if(input == 0) return 0;
	
	C[10] = input%10;
	input /= 10;
	for(i = 9, j = 2; i > 0; i--){
		C[i] = (input%10) * j;
		input /= 10;
		j++;
	}
	T = 0;
	for(i=1;i<11;i++){
		T+= C[i];
	}
	if(T%11 == 0) printf("This is a valid ISBN.\n");
	else printf("This is not a valid ISBN.\n");
	
	return 1;
}

int main(){	
	int C[11],check;
	printf("ISBN Validator\n==============\n");
	do{
		check = validISBN(C);
	}while(check != 0);
	printf("Have a nice day!");
	return 0;
}
