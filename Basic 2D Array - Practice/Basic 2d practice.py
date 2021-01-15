# Declaration and Initialisation of An Array
marks = [[0 for j in range(10)] for i in range(5)]

# Populate
# For row in range(5)
# For col in range(10)
# marks[row][col] = int(input())


# Process
for row in range(5):
    for col in range(10):
        marks[row][col] = row * col

# Output
for row in range(5):
    for col in range(10):
        print(marks[row][col], end=" ")
    print()
