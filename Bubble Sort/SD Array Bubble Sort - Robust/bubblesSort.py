def bubbleSort(array, length):
    isSorted = True
    i = 0
    j = 0
    temp = 0
    for i in range(length-1, 0, -1):   #FOR i = 9 TO 0 step -1
        isSorted = True
        for j in range(i):
            if array[j] > array[j+1]:
                temp = array[j]
                array[j] = array[j+1]
                array[j+1] = temp
                isSorted = False
        if isSorted == True: break

array = [0 for i in range(10)]
count = 0
for count in range(10):
    array[count] = int(input("Enter vlaue " + str(count) + ": "))

bubbleSort(array, 10)

for x in array:
    print(x)
