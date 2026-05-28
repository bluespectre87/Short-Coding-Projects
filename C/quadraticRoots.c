#include <stdio.h>
#include <math.h>

int main(int argc, char **argv)
{
	int a,b,c;
	double root1, root2;
	long double squareroot, bsquared,fourAC;
	
	printf("Enter a:\n");
	scanf("%d", &a);
	printf("Enter b:\n");
	scanf("%d", &b);
	printf("Enter c:\n");
	scanf("%d", &c);
	
	bsquared = b*b;
	fourAC = 4*a*c;
	squareroot = bsquared - fourAC;
	printf("%Lf", squareroot);
	 
	if(squareroot > 0)
	{
		squareroot = sqrt(squareroot);		
		root1 = (((-1) * b) + squareroot) / (2 * a);
		root2 = (((-1) * b) - squareroot) / (2 * a);
		printf("root 1: %f, root2 %f\n",root1, root2);
	}
	else
		printf("No solution\n");
	
	return 0;
	
}
