class Duck:
    def __init__(self, weight, age, name):
        self.weight = weight
        self.age = age
        self.name = name
        self.start = 0

    def walk(self):
        self.start += 1
    
    def run(self):
        self.walk()
        self.walk()
        self.walk()


duck1 = Duck(weight= 1, age = 2, name = "donald")
duck2 = Duck(weight= 3, age = 1, name = "mickey")


print(duck1.name)
print(duck2.name)


class VNDuck(Duck):
    def __init__(self, weight, age, name):
        
        Duck.__init__(self, weight = weight, age = age, name = name)
        self.length = 5
    
    def walk(self):
        self.start += 2

vn_duck = VNDuck(weight= 3, age = 2, name ="vnDuck")
print(vn_duck.start)
vn_duck.walk()
print(vn_duck.start)
vn_duck.run()
print(vn_duck.start)