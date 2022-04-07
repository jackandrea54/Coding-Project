a=[1,4,5,2,6,9]
min=a[0]
def numbmin(min):
    for i in range(len(a)):
        if min > a[i]:
            min = a[i]
    return min
min= numbmin(min)
print("Min la {}".format(min))