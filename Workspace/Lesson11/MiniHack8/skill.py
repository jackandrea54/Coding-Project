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
for i in range(len(skill)):
    for k,v in skill[i].items():
        print(k,v)