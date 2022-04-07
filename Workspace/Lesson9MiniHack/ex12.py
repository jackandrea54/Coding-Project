city = ["ST","BD","BTL","CG","DD","HBT"]
popu = [150300,247100,333300,266800,420900,318000]
max = popu[0]
min = popu[0]
for i in range(len(popu)):
    if max < popu[i]:
        max = popu[i]
for i in range(len(popu)):
    if min > popu[i]:
        min = popu[i]
maxpos = popu.index(max)        
minpos = popu.index(min)
print("Highest population:",max,"Country:",city[maxpos])
print("Lowest population:",min,"Country:",city[minpos])