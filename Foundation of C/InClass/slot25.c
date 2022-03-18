#include <stdio.h>
#include <string.h>


//Doi cac ki tu thanh chu hoa
void upper(char s[]){
	strupr(s);
	printf("%s\n",s);
}

void daonguoc(char s[]){
	char temp[100];
	int i;
	int len = strlen(s);
	for(i=len-1;i>=0;i--)
	{
		temp[len-1-i] = s[i];
	}
	temp[len] = '\0';
	printf("%s",temp);
	
}
void layhoten(char ho[],char hoten[]){
	int i = 0;
	scanf("%[^\n]%*c",hoten);
	while(hoten[i] != ' '){
		ho[i] = hoten[i];
		i++;
	}
	ho[i] = '\0';
	printf("Ho la : %s",ho);
}
int main(){
	char s[100],ho[20],hoten[50];
	
	layhoten(ho,hoten);
}
