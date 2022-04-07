highscores = [75,85,60,98,99,100]
highscores.sort(reverse=True)
print(highscores)
for i in range(len(highscores)):
    print(i+1,highscores[i],sep='. ')
new = int(input("Your score: "))
highscores.append(new)
highscores.sort(reverse=True)
print("New High Scores")  
for i in range(len(highscores)):
    print(i+1,highscores[i],sep='. ')  