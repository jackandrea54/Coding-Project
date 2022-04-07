# solution for bài 6 not use recursive (RECOMMENDED)
def reachTarget(target):
    #Handling negative by symmetry
    target = abs(target)

    # Keep moving while sum is smaller or difference is odd

    sum = 0 
    step = 0
    while (sum < target or (sum - target) % 2 != 0) :
        step =  step + 1
        sum = sum +step

    return step



# solution for bài 6 dùng đệ quy
def steps(source, step, dest):
    #base cases
    if (abs(source) > (dest)):
        return 2 * abs(dest) - 1
    if (source == dest):
        return step

        # at each point we can go either way

    # if we go on positive side
    pos = steps( source + step + 1, step +1, dest)

    # if we go on negative side
    neg = steps(source - step - 1, step + 1, dest)

    # minium of both cases 
    return min(pos, neg)




# solution for bài 5
def isReachable(sx, sy, dx, dy):
    # base case
    if (sx > dx or sy > dy):
        return False

    # current point is equal to destination
    if (sx == dx and sy == dy):
        return True

    #check for other 2 possibilities
    return (isReachable(sx + sy, sy, dx, dy) or
            isReachable(sx, sx + sy, dx, dy))