for i in range (4):
    for j in range(4):
        if i==2 and j==1:
            print("P",end=" ")
        elif i==2 and j==3:
            print("E",end=" ")
        elif i==1 and j==2:
            print("K",end=" ")
        else:
            print("-",end=" ")
    print("")
player={
    "x": 1,
    "y": 2,
}
key={
    "x": 2,
    "y": 1,
}
exit={
    "x": 3,
    "y": 2,
}
cond = 0
while True:
    for i in range (4):
            for j in range(4):
                if i==player["y"] and j==player["x"]:
                    print("P",end=" ")
                elif i==exit["y"] and j==exit["x"]:
                    print("E",end=" ")
                elif i==key["y"] and j==key["x"]:
                    print("K",end=" ")
                else:
                    print("-",end=" ")
            print("")
    move=input("What is your move: ")
    if move == "A":
        player["x"]=player["x"]-1
        if player["y"]==key["y"] and player["x"]==key["x"]:
            key["y"]="-"
            key["x"]="-"
            print("You have found the key")
            cond = 1
        if player["y"]== exit["y"] and player["x"]==exit["x"]:
            if cond == 0:
                print("You cant exit yet")
                player["x"]= player["x"]+1
            if cond == 1:
                print("You have escaped")
        
            print("")
    if move == "D":
        player["x"]=player["x"]+1
        if player["y"]==key["y"] and player["x"]==key["x"]:
            key["y"]="-"
            key["x"]="-"
            print("You have found the key")
            cond = 1
        if player["y"]== exit["y"] and player["x"]==exit["x"]:
            if cond == 0:
                print("You cant exit yet")
                player["x"]= player["x"]-1
            if cond == 1:
                print("You have escaped")
        
    if move == "W":
        player["y"]=player["y"]-1
        if player["y"]==key["y"] and player["x"]==key["x"]:
            key["y"]="-"
            key["x"]="-"
            print("You have found the key")
            cond = 1
        if player["y"]== exit["y"] and player["x"]==exit["x"]:
            if cond == 0:
                print("You cant exit yet")
                player["y"]= player["y"]+1
            if cond == 1:
                print("You have escaped")
        
    if move == "S":
        player["y"]=player["y"]+1
    if player["y"]==key["y"] and player["x"]==key["x"]:
        key["y"]="-"
        key["x"]="-"
        print("You have found the key")
        cond = 1
    if player["y"]== exit["y"] and player["x"]==exit["x"]:
        if cond == 0:
            print("You cant exit yet")
            player["y"]= player["y"]-1
        if cond == 1:
            print("You have escaped")
    if player["y"] == -1:
        print("You are blocked by a wall")
        player["y"]=player["y"]+1
    if player["y"] == 4:
        print("You are blocked by a wall")
        player["y"]=player["y"]-1
    if player["x"] == -1:
        print("You are blocked by a wall")
        player["x"]=player["x"]+1
    if player["x"] == 4:
        print("You are blocked by a wall")
        player["x"]=player["x"]-1

    




    