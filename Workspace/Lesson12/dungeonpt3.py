player={
    "x": 1,
    "y": 3,
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
checked = False
while True:
    for i in range (4):
            for j in range(4):
                if i==player["y"] and j==player["x"]:
                    print("P",end=" ")
                elif i==exit["y"] and j==exit["x"]:
                    print("E",end=" ")
                elif i==key["y"] and j==key["x"]:
                    if checked == False:
                        print("K",end=" ")
                else:
                    print("-",end=" ")
            print("")
    move=input("What is your move: ")
    if move == "A":
        player["x"]=player["x"]-1
       
    if move == "D":
        player["x"]=player["x"]+1

    if move == "W":
        player["y"]=player["y"]-1
        
    if move == "S":
        player["y"]=player["y"]+1
    if checked == False:
        if player["x"]==key["x"] and player["y"]==key["y"]:
            checked = True
            if checked == True:
                print("Picked key!!")
    if player["x"]==exit["x"] and player["y"]==exit["y"]:
        if checked == True:
            print("You Win")
        if checked == False:
            print("You havent found the key")
            if move == "W":
                player["y"]=player["y"]+1
            if move == "S":
                player["y"]=player["y"]-1
            if move == "A":
                player["x"]=player["x"]+1
            if move == "D":
                player["x"]=player["x"]-1
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