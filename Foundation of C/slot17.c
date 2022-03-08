#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(){
	int i,times,pos=0,neg=0,num;
	
	printf("Nhap so len tung dong xu: ");
	scanf("%d",&times);
	srand(time(NULL));
	for(i=0;i<times;i++){
		num= rand()%2;
		if(num==0) pos+=1;
		else neg +=1;
	}
	printf("% mat sap la: %f%%\n",(float)pos/(pos+neg));
	printf("% mat ngua la: %f%%\n",(float)neg/(pos+neg));
	return 0;
}
