a = [1,3,4,16,32,8,64,4,128,2,256,32]
sum = []
check = False   
for i in range(len(a)):
    for j in range(len(a)):
        if a[i]*a[j] == 256:
            if i != j:
                if a[i] + a[j] not in sum:
                    sum.append(a[i] + a[j])
                    print(f'{a[i]} và {a[j]} tại vị trí {i} và {j} có tích bằng 256')
                    print(sum)
                else:
                    continue
                # if len(sum) != 0:
                #     print(a[i],a[j])
                #     if a[i]+a[j] in sum:
                #             check = True
                #     if a[i]+a[j] not in sum:                
                #         print("{} và {} ở vị trí {} và {} có tích bằng 256".format(a[i],a[j],i+1,j+1))
                #         sumIJ = a[i]+a[j]
                #         sum.append(sumIJ)

                

                # elif len(sum) == 0:
                #     print("{} và {} ở vị trí {} và {} có tích bằng 256".format(a[i],a[j],i+1,j+1))
                #     sumIJ = a[i]+a[j]
                #     sum.append(sumIJ)