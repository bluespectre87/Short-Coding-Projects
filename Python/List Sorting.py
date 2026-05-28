#Task 1:
"""
Create a function in Python that accepts two parameters. The first will be a list of numbers. The second parameter will be a 
string that can be one of the following values: asc, desc, and none. If the second parameter is “asc,” then the function should
return a list with the numbers in ascending order. If it’s “desc,” then the list should be in descending order, and if 
it’s “none,” it should return the original list unaltered.
"""
user_list = [] #list that will be completed by users
sort_type = "" #this will be the user entered input for the type of list sort they want to complete.
temp_var = 0 #temp variable to store stop over digures
num_changes = 1 #for every iteration of the list, if it is determined any 2 nums need to swap as not in order then incremented

# Get user input, split it, and convert to integers
user_list = list(map(int, input("Enter numbers separated by space: ").split()))

#getting the type of list sort from the user
print("Please advise the order you would like the list sorted in: asc, desc or none")
sort_type = input()
#validation to prevent user providing a random input
while sort_type.lower() != "asc" and sort_type.lower() != "desc" and sort_type.lower() != "none":
    print("Invalid input, please enter either asc, desc or none")
    sort_type = input()


if sort_type == "asc": #process working
    print("p1 triggered")
    while num_changes > 0:
        num_changes = 0
        for x in range(len(user_list)-1):
            if user_list[x] > user_list[x+1]:
                num_changes += 1
                temp_var = user_list[x+1]
                user_list[x+1] = user_list[x]
                user_list[x] = temp_var
        print(user_list)
elif sort_type == "desc": #process works
    print("p2 triggered")
    while num_changes > 0:
        num_changes = 0
        for x in range(len(user_list)-1):
            if user_list[x+1] > user_list[x]:
                num_changes += 1
                temp_var = user_list[x]
                user_list[x] = user_list[x+1]
                user_list[x+1] = temp_var
        print(user_list)   
else: #process working
    print("p3 triggered")
    print(user_list)  


