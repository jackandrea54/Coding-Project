def sokeotheotien(tien):
    keo = tien//2
    return keo

def sokeotuvokeothua(vokeothua):
    vokeo = vokeothua//3
    vokeothua = vokeo % 3
    if vokeo < 3:
        print(vokeo)
        return vokeo
    else:
        keo = vokeo + sokeotuvokeothua(vokeo+vokeothua)
        print(keo)
        return keo

def candy(keo):
    vokeo = keo
    vokeothua = vokeo % 3
    if vokeo < 3:
        return vokeo
    elif vokeo >= 3:
        print(keo + vokeo//3 + sokeotuvokeothua(vokeo//3+vokeothua))
        return keo + vokeo//3 + sokeotuvokeothua(vokeo//3+vokeothua)

tien = int(input("So tien:"))
keo1 = sokeotheotien(tien)
keo2 = candy(keo1)
print(keo2)
