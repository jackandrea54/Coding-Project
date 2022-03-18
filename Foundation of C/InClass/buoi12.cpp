#include <stdio.h>

void clear(){
	while(getchar() != '\n');
}

void get_input()
{
    char c,after;
    int num,rc,check =1;
    while(check == 1){
    	printf("Enter an input: ");
	    rc = scanf("%c%d%c",&c,&num,&after);
	    if(rc < 3){
	    	printf("No input accepted!\n\n");
			clear();
		}
		else if(c < 'A' || c > 'z'){
			printf("False, please use letter!\n\n");
			clear();
		}
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
