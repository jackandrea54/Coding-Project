#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(){
	int i, a=65, b =90;
	srand(time(NULL));
	printf("%c",rand()%(b-a+1)+a);	
	printf("%c-",rand() % (b-a+1) +a );	// Cac so ngau nhin tu 65-90
	for(i = 0;i<3;i++){
		printf("%d",rand() % 10);	// Cac so ngau nhin tu 0-9
	}	
	printf("\n");
	
	
	// for (i = 0; i < 10; i++)
    //     printf("%c ", rand() % 10 + '0'); // int + char -> int
	return 0;
}
