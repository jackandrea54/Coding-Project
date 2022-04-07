character={
    "Name": "Light",
    "Age": 17,
    "Strength": 8,
    "Defense": 10,
    "Health": 100,
    "Backpack": ["Shield","Bread Loaf"],
    "Gold": 100,
    "Level":2,
}
skill1={
    "Name":"Tackle",
    "Minimum level": 1,
    "Damage": 5,
    "Hit rate": 0.3,
}
skill2={
    "Name":"Quick Attack",
    "Minimum Level": 2,
    "Damage": 3,
    "Hit rate": 0.5,
}
skill3={
    "Name":"Strong kick",
    "Minimum Level": 4,
    "Damage": 9,
    "Hit rate": 0.2,
}
skill=[skill1,skill2,skill3]
print("An enemy has appeared. Choose your attack!")
for i in range(len(skill)):
    print(i+1,skill[i]["Name"],sep=". ")
choice=int(input("Your attack:"))
if choice == 1:
    print("You have done:",skill[0]["Damage"],"damage")
if choice == 2:
    print("You have done:",skill[1]["Damage"],"damage")
if choice == 3:
    print("Your level is not enough to execute this attack")        
