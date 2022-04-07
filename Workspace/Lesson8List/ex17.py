import random
items = input("Give me sth: ")
shuffled = list(items)
random.shuffle(shuffled)
for i in range (0, len(items)):
    print(shuffled[i].upper())