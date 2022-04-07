#include <stdio.h>
#include <ctype.h>

void toUpper(char s[]){
	int i;
	for(i=0;s[i]!='\0';i++)
		printf("%c",toupper(s[i]));
}

int main(){
	char s[100];
	printf("Enter a string: ");
	scanf("%[^\n]",s);
	toUpper(s);
		
}
