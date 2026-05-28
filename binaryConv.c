#include <stdio.h>
#include <stdlib.h>

int binConverter(int num){
	if(num == 0)
		return 0;
	else
		return (num % 2 + 10 * binConverter(num/2));
}
int main(int argc, char *argv[])
{
	int num;
	
	printf("Enter number under 256 to convert to binary ");
	scanf("%d",&num);
	printf("\n");
	
	while(num > 255)
	{
		printf("Invalid number, please enter a number under 256\n");
		scanf("%d",&num);
	}
	
	printf("binary representation: %d\n",binConverter(num));
	
	return 0;
}
