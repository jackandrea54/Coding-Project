#include <stdio.h>
#include <string.h>

int main(){
	char str[31], copy[21] = "HELLO VIETNAM";
	int i,len;
	printf("Enter a string : ");
	scanf("%30[^\n]%*c",str);
	len = strlen(str);
	
	strcpy(copy,str);
	printf("Conpy contains: %s\n",copy);
	
}
