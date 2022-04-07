a = [1,3,4,16,32,8,64,4,128,2,256,32]
sum = []
  
for i in range(len(a)):
    for j in range(len(a)):  
        if a[i]*a[j] == 256:
            if i != j:
                if len(sum) != 0:
                    check = False 
                    for x in range(len(sum)):
                        if a[i] + a[j] == sum[x]:
                            check = True
                    if check == False:                
                        print("{} và {} ở vị trí {} và {} có tích bằng 256".format(a[i],a[j],i+1,j+1))
                        sumIJ = a[i]+a[j]
                        sum.append(sumIJ)

                else:
                    print("{} và {} ở vị trí {} và {} có tích bằng 256".format(a[i],a[j],i+1,j+1))
                    sumIJ = a[i]+a[j]
                    sum.append(sumIJ)