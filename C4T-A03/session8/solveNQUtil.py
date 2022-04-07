def solveNQT():
    # Initialization of Board matrix  
    board = [
        [-1, -1, -1, -1, -1],
        [-1, -1, -1, -1, -1],
        [-1, -1, -1, -1, -1],
        [-1, -1, -1, -1, -1],
        [-1, -1, -1, -1, -1],
        [-1, -1, -1, -1, -1],
    ]
    # move_x and move_y define next move of Queen. 
    move_x = [0, 0, 0, 0, 1, 2, 3, 4, 0, 0, 0, 0, -1, -2, -3, -4, 1, 2, 3, 4, -1, -2, -3, -4]
    move_y = [1, 2, 3, 4, 0, 0, 0, 0, -1, -2, -3, -4, 0, 0, 0, 0, 1, 2, 3, 4, -1, -2, -3, -4]

    # First place of Queen
    board[0][0] = 0

    # Checking if solution exists or not  
    if not solveNQT_util(board, 0, 0, move_x, move_y):
        print("Solution does not exist")
    else:
        print(board)

def solveNQT_util(board, curr_x, curr_y, move_x, move_y):
    #Try all next moves from the  current coordinate x,y
    for i in range(28):
        new_x = curr_x + move_x[i]
        new_y = curr_y + move_y[i]
        if is_safe(new_x, new_y, move_x, move_y, board):
            board[new_x][new_y] = "Q"
            if solveNQT_util(board, new_x, new_y, move_x, move_y) is True:
                return True
            # Backtracking
            board[new_x][new_y] = -1
        return False

def is_safe(new_x, new_y, move_x, move_y, board):
    curr_x = new_x
    curr_y = new_y
    for i in range(0,5):
        if board[new_x][i] == "Q" or board[i][new_y] == "Q":
            return False
    
    for j in range(10,28):
        new_x = curr_x + move_x[j]
        new_y = curr_y + move_y[j]
        if new_x > -1 and new_x < n and new_y > -1 and new_y < n and board[new_x][new_y] == "Q":
            return False
    return True

n = 5
solveNQT()