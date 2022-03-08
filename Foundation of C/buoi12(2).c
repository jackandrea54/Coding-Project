#include <stdio.h>

void clear(){
	while(getchar() != '\n');
}

double get_input()
{
    char after;
    int rc,check =1;
    double num;
    while(check == 1){
    	printf("Enter an input: ");
	    rc = scanf("%lf%c",&num,&after);
	    if(rc == 1){
	    	printf("No input accepted!\n\n");
			clear();
		}
//		else if(c != '.'){
//			printf("False, please use decimal point!\n\n");
//			clear();
//		}
		else if(after != '\n'){
			printf("Trailing characters!\n\n");
			clear();
		}
		else check = 0;
	}
	
}

int main()
{
    get_input();
	return 0;
}
