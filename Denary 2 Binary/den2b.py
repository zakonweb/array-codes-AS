from random import randint

RT = [False for i in range(50)]
Counter = 0


for i in range(50):
    index = randint(0,50)
    while not RT[index]:
        counter += 1  # Counter = Counter + 1
        index = randint(0,50)
    RT[index] = True

print("Number of times counter worked is =", Counter)