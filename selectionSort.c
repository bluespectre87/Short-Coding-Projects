#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[])
{
	int numItems,i,j,temp, *list;
	
	printf("enter number of items in list to be sorted:\n");
	scanf("%d",&numItems);
	
	if(!(list = (int *) calloc(numItems,sizeof(int))))
	{
		fprintf(stderr,"insufficient memory availiable\n");
		exit(1);
	}
	
	for(i=0;i<numItems;i++)
	{
		printf("Enter value:\n");
		scanf("%d",&list[i]);
	}
	
	for(i=0;i<numItems;i++)
	{
		for(j=0;j<numItems;j++)
		{
			if(list[j] < list[i]){
				temp = list[i];
				list[i] = list[j];
				list[j] = temp;
			}
		}
	}
	
	printf("sorted list: ");
	for(i=0;i<numItems;i++)
	{
		printf(", %d",list[i]);
	}
	printf("\n");
	return 0;
}
