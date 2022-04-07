alist1 = []
while True:
    x = int(input("Enter your number in first list:"))
    check = input("Do you want to continue (Yes/No): ")
    checkconfirm = check.lower()
    
    alist1.append(x)
    if checkconfirm == "no":
        break
alist2 = []
while True:
    y = int(input("Enter your number in second list:"))
    check = input("Do you want to continue (Yes/No): ")
    checkconfirm = check.lower()
    
    alist2.append(y)
    if checkconfirm == "no":
        break

alist3 = []
for i in range(len(alist1)):
    if alist1[i] % 2 != 0:
        alist3.append(alist1[i])

for j in range(len(alist2)):
    if alist2[j] % 2 == 0:
        alist3.append(alist2[j])

alist3.sort(reverse=True)
print("Dãy số là:",*alist3)