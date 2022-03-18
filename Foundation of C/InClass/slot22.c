#include <stdio.h>
#include <string.h>

int main(){
	char s[31];
	scanf("%[abcd]s",&s);
	scanf("%[^abcd]s",&s);
	scanf("%[0-9]s",&s);
	scanf("%[0-9A-Za-z]s",&s);
	printf("%s",s);
	
}
