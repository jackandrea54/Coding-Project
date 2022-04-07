numbs = input("Give me numbers, seperated: ")
numb = numbs.split()
sumup = 0
for i in range(len(numb)):
    sumup+=int(numb[i])
print("Sum of all numbers: ",sumup)    