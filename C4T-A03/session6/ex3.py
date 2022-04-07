def partition(array, start, end):
    pivot = array[start]

    i = start + 1
    j = end
    while True:
        while i <= j and array[i] <= pivot:
            i += 1
        while i <= j and array[j] >= pivot:
            j -= 1
        if j >= i:
            array[i], array[j] = array[j], array[i]
        else:
            break
    array[start], array[j] = array[j], array[start]    
    return j


def quick_sort(array, start, end):
    if start >= end:
        return

    p = partition(array, start, end)
    quick_sort(array, start, p-1)
    quick_sort(array, p+1, end)


array = [6, 4, 2, 1, 9, 7, 8, 3, 5]
start = 0
end = len(array) - 1
quick_sort(array, start, end)
print(array)



