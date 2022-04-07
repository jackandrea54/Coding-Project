# NGUYỄN ĐÌNH NGHĨA

# Bai 1
# def bai1(Tong, n):
#     if n<10:
#         Tong+= n
#         return Tong
#     else:
#         sodu = n%10
#         Tong+= sodu + bai1(Tong, n//10)

#     return Tong
#n = int(input("Nhap vao mot so N: "))
#Tong = 0
#Tong =bai1(Tong, n)
#print("Tong cua cac chu so trong N la: ")


# Bai 2
#n = int(input("Nhap so N:"))
#Tong = 0
#i = 0
# def bai2(Tong, n, i):
#     if i == n:
#         return i
#     elif i<n:
#         Tong = i + bai2(Tong, n, i+1)

        
        
#     return Tong
#tong = bai2(Tong, n, i)
#print(" tổng n số tự nhiên đầu tiên la:",tong)


# Bai 3
# n = int(input("Nhập một số thập phân: "))
# numprint=[]
# def bai3(n):
#     so_nguyen = n//2
#     so_du = n%2
#     numprint.append(so_du)
#     if so_nguyen == 0 and so_du == 1:
#         return 
#     else:
#         bai3(so_nguyen)
# bai3(n)
# print("So nhi phan la:")
# for i in range(len(numprint)-1,-1,-1):
#     print(numprint[i], end='')


# Bai 4
# def bai4():
#     maze = [ [1, 0, 0, 0], 
#              [1, 1, 0, 1], 
#              [0, 1, 0, 0], 
#              [1, 1, 1, 1] ]
#     # Moves
#     move_x = [0, 1, 0, -1]
#     move_y = [1, 0, -1, 0]

#     # First location
#     maze[0][0] = 2

#     if not solvebai4(maze, 0, 0, move_x, move_y):
#         print("Solution does not exist")
#     else:
#         for i in range(4):
#             print(maze[i])
#             print

# def xy_move(pos_x, pos_y, move_x, move_y, board):
#     for i in range (4):
#         new_x = pos_x + move_x[i]
#         new_y = pos_y + move_y[i]
#         if new_x != -1 and new_x != 4 and new_y != -1 and new_y != 4 and board[new_x][new_y] != 0:
#             return new_x, new_y
#     return False, False
    
# def solvebai4(maze, pos_x, pos_y, move_x, move_y):
#     if pos_x == 3 and pos_y == 3:
#         return True
#     else:
#         new_x, new_y = xy_move(pos_x, pos_y, move_x, move_y, maze)
#         if pos_x is not False and pos_y is not False :
#             maze[new_x][new_y] = 2
#             if solvebai4(maze, new_x, new_y, move_x, move_y) is True:
#                 return True
#             #Backtracking
#             maze[new_x][new_y] = 1
#             return False
#         else: 
#             return False
# bai4()


# Bai 5(Not finished)

# pos_x = int(input("Nhap vao toa do x:"))
# pos_y = int(input("Nhap vao toa do y:"))
# des_x = int(input("Nhap vao diem den x:"))
# des_y = int(input("Nhap vao diem den y:"))


# def solvebai5():
#     if bai5(pos_x, pos_y, des_x, des_y) is False:
#         print("There is no solution")
#     else:
#         print("There is a solution")

# def bai5(pos_x, pos_y, des_x, des_y):
#     if pos_x == des_x and pos_y == des_y:
#         return True
#     else:
#         pre_x = pos_x
#         pre_y = pos_y
#         new_x, new_y = xy_move(pos_x, pos_y, des_x, des_y)
#         if pos_x is not False and pos_y is not False :
#             if bai5(new_x, new_y, des_x, des_y) is True:
#                 return True
#             #Backtracking
#             pos_x = pre_x
#             pos_y = pre_y 
#             print   
#         return False

# def xy_move(pos_x, pos_y, des_x, des_y):
#     move_x =[0, pos_y]
#     move_y =[pos_x, 0]
#     for i in range (2):
#         new_x = pos_x + move_x[i]
#         new_y = pos_y + move_y[i]
#         if new_x <= des_x and new_y<= des_y:
#             return new_x, new_y
#     return False, False

# solvebai5()

#Bai 6(Not finished)
pos = 0
n = int(input("Cho vao so n: "))
def bai6(pos, n):
    if n< 0:
        for i in range(0,n-1,-1):
            pos+= i
            if pos == n:
                print("So step la:",i)
                return
            elif pos < n:
                pos = pos - n 
                if bai6(pos, n):
                    return

    if n > 0:
        for i in range(n+1):
            pos+= i
            if pos == n:
                print("So step la:",i)
                return
            elif pos > n:
                print(pos)
                pos = n - pos
                if bai6(pos, n):
                    return
bai6(pos, n)


