#include <math.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/*Function to calculate rectangle and square area*/
int rs_area(int width, int height) { return width * height; }

/*Function to calculate triangle area*/
int t_area(int base, int height) { return 0.5 * base * height; }

/*Function to calculte circle area*/
int c_area(int radius) { return 3.14 * pow(radius, 2); }

/*int argc = count of num arguments provided through command line, char **argv = 2d array storing the args
in this approach the user will need to know how many arguments to provide and give them when they call the code to run. 
To implement this as a standalone project with a user interface prompt:
int main() {
    int dim1, dim2, dim3;
    char shape[20];   // allocate memory for the string
    int area;

    printf("Type your 3 dimensions and a shape: \n");

    scanf("%d %d %d %19s", &dim1, &dim2, &dim3, shape);

    if (strcmp(shape, "square") == 0 || strcmp(shape, "rectangle") == 0) {
        area = rs_area(dim1, dim2);
    }
    else if (strcmp(shape, "triangle") == 0) {
        area = t_area(dim1, dim2);
    }
    else if (strcmp(shape, "circle") == 0) {
        area = c_area(dim1);
    }
    else {
        printf("invalid input\n");
        return 1;
    }

    printf("Area is: %d\n", area);
    return 0;
}*/
int main(int argc, char **argv) {
  /*Declaring variables to hold shape dimensions and area*/
  int dim1, area;
  int dim2 = 1;
  int dim3 = 1;

  /* checks if the number of arguments fed into the program is less than 3 */
  if (argc < 3) {
    printf("invalid input\n");
    return 1;
  }

  dim1 = strtol(argv[2], NULL, 10);

  /*get shape from command line arguments*/
  if (strcmp(argv[1], "square") == 0 || strcmp(argv[1], "rectangle") == 0) {
    dim2 = strtol(argv[3], NULL, 10);
    area = rs_area(dim1, dim2);
  } 
  else if (strcmp(argv[1], "triangle") == 0) {
    dim2 = strtol(argv[3], NULL, 10);
    area = t_area(dim1, dim2);
  } 
  else if (strcmp(argv[1], "circle") == 0) {
    area = c_area(dim1);
  } 
  else {
    printf("invalid input\n");
    return 1;
  }

  printf("Area is: %d\n", area);
  return 0;
}