highscores = [75,85,60,98,99,100]
highscores.sort(reverse=True)
print("High Scores")
for i in range(5):
    print(i+1,highscores[i],sep='. ')
new = int(input("Your score: "))
highscores.append(new)
highscores.sort(reverse=True)
print("NEW High scores")  
for i in range(5):
    print(i+1,highscores[i],sep='. ')  