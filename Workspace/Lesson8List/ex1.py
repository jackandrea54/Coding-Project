items = ["Cơm", "Phở"]

print(*items,sep =", ")
new = input("Món mới: ")
items.append(new)
print(*items,sep=', ')