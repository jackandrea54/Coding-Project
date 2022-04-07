quiz1={
        1 :1998,
        2 :2000,
        3 :2003,
        4 :1997,
}
quiz2={
        1 :"Ron",
        2 :"Luna",
        3 :"Harry",
        4 :"Malco",
}
quiz=[quiz1,quiz2]
score=0
for i in range (len(quiz)):
    if i == 0:
        print("When was Harry Potter first published?")
        for k,v in quiz[i].items():
            print(k,v,sep=". ")
        ans1 = input("Your answer:")
        if ans1 == "4":
            print("Hurray!")
            score+=1
        else:
            print("Incorrect :(")    
    if i == 1:
        print("What is the main character?")
        for k,v in quiz[i].items():
            print(k,v,sep=". ")
        ans2 = input("Your answer:")
        if ans2 == "3":
            print("Hurray!")
            score+=1
        else:
            print("Incorrect :(")   
print("Your total score:",score)
print("You have passed",score*100/2,"%", "of the quiz")
