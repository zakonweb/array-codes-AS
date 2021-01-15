# Initialisation
namesArr = ["" for i in range(5)]
isFound = False

# Populate
for a in range(5):
    sName = input("Enter Name:"+ str(a+1)+ " ")
    namesArr[a] = sName

# Output All
for a in range(5):
    print(namesArr[a])

# linear or simple searching()
sName = input("Enter Name to search for: ")
for a in range(5):
    if namesArr[a] == sName:
        print(a)
        isFound = True

if isFound == False:
    print("Name was not found.")