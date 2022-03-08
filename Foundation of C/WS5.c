#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

void clear(){
	while(getchar() != '\n');
}

int main() {
    int arr[100],input,maxIndex,i,pos;
    
    char choice;
    scanf("%d",&input);
    maxIndex = input;
    for(i=0;i<input;i++){
    	scanf("%d",&arr[i]);
	}
	int check = -1;
	clear();
	do{	
    	scanf("%c",&choice);

    	switch(choice){
    		case 'A':
    			scanf("%d",&input);
    			arr[maxIndex] = input;
    			maxIndex++;
    			break;
    		case 'D':
    			scanf("%d",&pos);
    			if(pos <= 0 || pos > maxIndex ){
    				check = 0;
				}
				else{
					for(i=pos-1; i< maxIndex; i++){
			            arr[i] = arr[i + 1];
			        }
			        maxIndex--;
				}
    			break;
    		case 'I':
    			scanf("%d",&input);
    			scanf("%d",&pos);
    			if(pos <= 0 || pos > maxIndex ){
    				check = 0;
				}
				else{
					for(i=maxIndex;i>=pos;i--){
    					arr[i]= arr[i-1];
					}
					arr[pos-1] = input;
					maxIndex++;
				}
    			break;
    		case 'E':
    			check = 1;
    			break;		
		}
	}while(check == -1);
	
	if(check == 1){
		for(i=0;i<maxIndex;i++){
			printf("%d ",arr[i]);
		}
	}else printf("error");

    /* Enter your code here. Read input from STDIN. Print output to STDOUT */    
    return 0;
}
