lines=[
    ["-","-","-","-"],
    ["-","-","K","-"],
    ["-","P","-","E"],
    ["-","-","-","-"],
]
for i in range(0,4):
    print(*lines[i])
x = 1
y = 2
while True:
    move = input("What is your move: ")
    if move == "W":
        lines[y][x]="-"
        y-=1
        if y==-1:
            print("You cant continue")
            y+=1
        else:
            lines[y][x]="P"
            for i in range(0,4):
                print(*lines[i])
    if move == "A":
        lines[y][x]="-"
        x-=1
        lines[y][x]="P"
        for i in range(0,4):
            print(*lines[i])
    if move == "S":
        lines[y][x]="-"
        y+=1
        lines[y][x]="P"
        for i in range(0,4):
            print(*lines[i])
    if move == "D":
        lines[y][x]="-"
        x+=1
        lines[y][x]="P"
        for i in range(0,4):
            print(*lines[i])


