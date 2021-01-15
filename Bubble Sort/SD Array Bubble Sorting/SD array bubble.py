c = 0

# Initialisation an array
NUM = [0 for i in range(5)]

# Populate an array
for i in range(5):
    x = int(input("Enter Value." + str(i) + " :"))
    NUM[i] = x

# Bubble sort
for j in range(4, 0, -1):
    alreadySorted = True
    for i in range(j):
        if NUM[i] > NUM[i+1]:
            c = c + 1
            x = NUM[i]
            NUM[i] = NUM[i+1]
            NUM[i+1] = x
            alreadySorted = False
    if alreadySorted: break

# Output an array
print("Sorted array values.")
for i in range(5):
    print(NUM[i])

print("loop counts were =", c)