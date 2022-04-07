color = ["red","blue","green"]
print(*color,sep=',')
new = input("New color: ")
color.append(new)
print(*color,sep=', ')