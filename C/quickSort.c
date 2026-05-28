#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[])
{
	int numItems, *list,i,pivotPos,leftPos,rightPos,temp;
	
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
	
	pivotPos = (numItems / 2)-1;
	leftPos = 0;
	rightPos = numItems-1;
	while(leftPos != pivotPos && rightPos != pivotPos)
	{
		if(list[leftPos] < list[pivotPos]){
			leftPos ++;
		}
		if(list[leftPos] >= list[pivotPos] && list[rightPos] > list[pivotPos]){
			rightPos --;
		}
	
		if(list[leftPos] >= list[pivotPos] && list[rightPos] <= list[pivotPos])
		{
			temp = list[leftPos];
			list[leftPos] = list[rightPos];
			list[rightPos] = temp;
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
