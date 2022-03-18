#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int intRandom(int min, int max){
	return min + rand()%(max-min+1);
}

int main(){
	int total, x,y,count;
	srand(time(NULL));
	printf(" Ball lottery\n===============\n");
	do{ 
	 	printf("Total sought: ");
		scanf("%d",&total);
	}while (total<2 || total >20);
	count = 1;
	do{  
	   x= intRandom(1,10);
	   y= intRandom(1,10);
	   printf("Result of picks %d and %d: %d + %d\n",count,count+1, x, y);
	   count+=2;
	}while (x+y != total);
	printf("You got your total in %d picks", count-1);
	return 0;

}
