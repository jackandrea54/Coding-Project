#include <stdio.h>

int main(){
	char s[100], s1[100];
	printf("Enter the first string: ");
//  %s only reads until the first whitespace character, stores the null byte ,leave the rest in buffer
//	scanf("%s", s); 
//   %[^\n} reads until the newline (\n), stores the null byte , leave the newline in buffer
	scanf("%[^\n]", s);
		
	printf("Enter the second string: ");
	scanf("%*c %[^\n]", s1);
	
	printf("\n%s\n%s", s, s1);
	
	return 0;
}	

