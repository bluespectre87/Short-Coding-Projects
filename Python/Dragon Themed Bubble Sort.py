def bubbleSort(arr):
    n = len(arr)
 
    # Traverse through all array elements
    for i in range(n-1):
    # range(n) also work but outer loop will repeat one time more than needed.
 
        # Last i elements are already in place
        for j in range(0, n-i-1):
 
            # traverse the array from 0 to n-i-1
            # Swap if the element found is greater
            # than the next element
            if arr[j] > arr[j + 1] :
                arr[j], arr[j + 1] = arr[j + 1], arr[j]
num_Heads = input('Enter number of dragons heads: ')
num_Kinights = input('How many knights ')

if num_Heads > num_Kinights:
    print('Loowater is doomed! ')
else:
    #variable definiton
    head_Diameter = []
    knight_Height = []
    coin_Total = 0
    knights_Valid = True

    for i in range(num_Heads):
        holder = input('Enter head diameter: ')
        head_Diameter.append(holder)
    bubbleSort(head_Diameter)
    head_Diameter.reverse()

    for i in range(num_Kinights):
        holder = input('Enter knight height: ')
        knight_Height.append(holder)
    bubbleSort(knight_Height)
    knight_Height.reverse

    counter = 0
    while counter != num_Heads:
        if knight_Height[counter] >= head_Diameter[counter] and knights_Valid == True:
            coin_Total += knight_Height[counter]
        else:
            knights_Valid == False
        counter += 1
    
    if knights_Valid == False:
        print('Loo water is doomed')
    else:
        print('loo water can be saved, number of gold coins required = ', coin_Total)
        