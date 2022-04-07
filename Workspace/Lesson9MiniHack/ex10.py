numbs = input("Give me numbers: ")
numb = numbs.split(",")
items = []
for i in range(len(numb)):
    if int(numb[i])%2==0:
        items.append(numb[i])
print("All even numbers: ",end="")
print(*items,sep=', ')        
