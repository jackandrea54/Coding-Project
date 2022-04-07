color = ["red","blue","green","teal"]
print("Our color list: ")
for i in range(0, len(color)):
    print(i+1,color[i],sep=". ")
dele = input("Item to delete: ")    
if dele.isdigit():
    color.pop(int(dele)-1)
    print("Our new color list: ")
    for i in range(0, len(color)):
        print(i+1,color[i],sep='. ')
if dele.isalpha():
    color.remove(dele)
    print("Our new color list: ")
    for i in range(0,len(color)):
        print(i+1,color[i],sep='. ')       