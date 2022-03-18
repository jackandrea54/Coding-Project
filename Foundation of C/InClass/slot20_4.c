#include <stdio.h>
#include <string.h>

int main(){
	char s1[] = "abcdef";
	int i;
	printf("%ld\n", strlen(s1));
	for(i = 0;i<strlen(s1);i++)
		printf("%c",s1[i]);
		
	
	return 0;	
}
