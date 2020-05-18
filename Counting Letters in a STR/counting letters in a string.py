myStr = "Writethestatementsrequiredtoupdatethearraywhenaletterhasbeenread"
myStr = myStr.upper()
ch = ""
ltrArr = [0 for i in range(26)]
count = index = 0

# option 1
for count in range(len(myStr)):
    ch = myStr[count]
    index = ord(ch) - 65
    ltrArr[index] = ltrArr[index] + 1

for count in range(26):
    print(ltrArr[count])

#option 2
for i in range(65, 91):
    print(myStr.count(chr(i)))