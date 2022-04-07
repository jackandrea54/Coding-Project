items = input("Give me items: ")
print(items)
item = items.split(",")
for i in range (len(item)):
    print(item[i])