def minTiles(n, m): 
	# base case, when area is 0. 
	if n == 0 or m == 0: 
		return 0

	# If n and m both are even, calculate 
	# tiles for n/2 x m/2 
	# Halfing both dimensions doesn't 
	# change the number of tiles 
	elif n%2 == 0 and m%2 == 0: 
		return minTiles(int(n/2), int(m/2)) 

	# If n is even and m is odd 
	# Use a row of 1x1 tiles 
	elif n % 2 == 0 and m % 2 == 1: 
		return (n + minTiles(int(n/2), int(m/2))) 

	# If n is odd and m is even 
	# Use a column of 1x1 tiles 
	elif n % 2 == 1 and m % 2 == 0: 
		return (m + minTiles(int(n/2), int(m/2))) 

	# If n and m are odd add 
	# row + column number of tiles 
	else: 
		return (n + m - 1 + minTiles(int(n/2), int(m/2))) 

n = 5
m = 6
print (minTiles(n, m)) 

