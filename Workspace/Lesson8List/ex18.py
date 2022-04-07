from random import randint
import random
items = "democracy,communism,enthusiasm,innovation"
item = items.split(",")
x = randint(0,len(item)-1)
random_word = item[x]
truth = item[x]
shuffled = list(random_word)
random.shuffle(shuffled)
for i in range (0, len(random_word)):
    print(shuffled[i])
y=input("What is the word: ")
if y in truth:
    print("Correct")
else:
    print("Incorrect")
    print("The true word is: ",truth)    
