#include <stdio.h>
void clear(){
	while(getchar()!='\n');
}

void printCharacter(char c1,char c2){
	int i;
	if(c1<c2){
		c1 = c1 + c2;
		c2 = c1 - c2;
		c1 = c1 - c2;
	}
	for(i=c1;i>=c2;i--){
		printf("%c: %d, %xh\n",i,i,i);
	}
	printf("\n");
}

int validDate(int d,int m, int y){
	int maxd = 31;
	if ( d<1 || d>31 || m<1 || m>12) return 0;
	if( m==4 || m==6 || m==9 || m==11){
		maxd=30;
	} 
	else if (m==2) {
	            if ( y%400==0 || ( y%4 ==0 && y%100 !=0)){
	            	maxd=29;
				}
	            else{
				 	maxd=28;
				}
	       }
	return d<=maxd;
}

int main(){
	int choice,d,m,y;
	char c1,c2;
	do{
		printf("1- Processing date data\n");
		printf("2- Character data\n");
		printf("3- Quit\n");
		printf("Select an operation: ");
		scanf("%d",&choice);
		clear();
		switch(choice){
			
			case 1:
				printf("Nhap Ngay Thang Nam: ");
				scanf("%d %d %d",&d,&m,&y);								
				if(validDate(d,m,y)==1) printf("It is a date.\n\n");
				else printf("It is not a valid date\n\n");
				break;	
			case 2:
				printf("Nhap 2 chu cai: ");
				scanf("%c%c",&c1,&c2);
				printCharacter(c1,c2);
				break;	
		}
	}
	while(choice > 0 && choice < 3);

	return 0;
}

