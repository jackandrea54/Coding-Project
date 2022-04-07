numbs = [2,5,129,84,-99]
items = []
for i in range(len(numbs)):
    if numbs[i]%2==0:
        items.append(numbs[i])
print("All even numbers: ",end="")
print(*items,sep=', ')       