city = ["ST","BD","BTL","CG","DD","HBT"]
popu = [150300,247100,333300,266800,420900,318000]
area = [117.43,9.224,43.35,12.04,9.96,10.09]
densum = 0
for i in range(len(popu)):
    dens = popu[i]/area[i]
    densum+=dens 
print("Density:",densum/len(city))    