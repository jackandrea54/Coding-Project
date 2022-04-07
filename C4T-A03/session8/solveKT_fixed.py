def print_solution(board):
    for i in range(n):
        for j in range(n):
            print(board[i][j], end=' ')
        print()

def solveKT():
    # Initialization of Board matrix  
    board = [
        [-1, -1, -1, -1, -1, -1],
        [-1, -1, -1, -1, -1, -1],
        [-1, -1, -1, -1, -1, -1],
        [-1, -1, -1, -1, -1, -1],
        [-1, -1, -1, -1, -1, -1],
        [-1, -1, -1, -1, -1, -1],
        [-1, -1, -1, -1, -1, -1],
    ]

    # move_x and move_y define next move of Knight.  
    # move_x is for next value of x coordinate  
    # move_y is for next value of y coordinate 
    move_x = [2, 1, -1, -2, -2, -1, 1, 2]
    move_y = [1, 2, 2, 1, -1, -2, -2, -1]

    # First place of Knight 
    board[0][0] = 0

    # Step counter for knight's position 
    pos = 1

    # Checking if solution exists or not  
    if not solveKT_util(board, 0, 0, move_x, move_y, pos):
        print("Solution does not exist")
    else:
        print_solution(board)

def solveKT_util(board, curr_x, curr_y, move_x, move_y, pos):
    if (pos == n ** 2):
        return True
    
    #Try all next moves from the  current coordinate x,y
    for i in range(8):
        new_x = curr_x + move_x[i]
        new_y = curr_y + move_y[i]
        if is_safe(new_x, new_y, board):
            board[new_x][new_y] = pos
            if solveKT_util(board, new_x, new_y, move_x, move_y, pos+1) :
                return True
            
            # Backtracking
            board[new_x][new_y] = -1
    return False

def is_safe(new_x, new_y, board):
    if new_x >= 0 and new_y >= 0 and new_x < n and new_y < n and board[new_x][new_y] == -1:
        return True
    return False

n = 4

solveKT()