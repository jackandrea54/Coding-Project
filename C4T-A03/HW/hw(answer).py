nums =[16, 2 , 4, 2, 128, ]64, 16, 7, 1, 64, 32, 16, 32, 16, 5, 8]

dictionary = {}
for index, item in enumerate(nums):
    number = item
    nums[index] = 0
    for index1, item1 in enumerate(nums):
        if number * item1 == 256:
            nums[index1] = 0
            dictionary[numb] = [number, index, item1, index1]

for value in dictionary.values():
    print('result: {} -vi tri{} and {}-vi tri {}'.format())