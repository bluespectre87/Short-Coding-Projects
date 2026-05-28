#include <stdio.h>
#include <stdlib.h>

int main(int argc, char **argv)
{
	int num_elements,num;
	int *elements,i,j;
	int repeat = 0;
	
	/*get number of elements */
	printf("Enter number of elements:\n");
	scanf("%d",&num_elements);
	
	/*assign dynamic memory and check that it has allocated ok*/
	if(!(elements = (int *)calloc(num_elements, sizeof(int))))
	{
		printf("Insufficient memory available\n");
		return 1;
	}
	
	/*get values */
	for(i=0;i<num_elements;i++)
	{
		printf("Enter number:\n");
		scanf("%d",&num);
		elements[i] = num;
	}
	
	/*looks for unique elements*/
	printf("Unique elements: ");
	for(i = 0;i < num_elements; i++)
	{
		repeat = 0;
		for(j = 0; j < num_elements; j++)
		{
			if(elements[i] == elements[j] && i != j)
				repeat = 1;
		}
		
		if(repeat != 1)
			printf("%d ",elements[i]);
	}
	printf("\n");
	
	/*free's dynamic memory */
	free(elements);
	return 0;
}
