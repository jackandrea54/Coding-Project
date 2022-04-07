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
character["Gold"]+=50
character["Backpack"].append("FlintStone")
character["Pocket"]=["MonsterDex","Flashlight"]
for k,v in character.items():
    print(k,v)