class Timer:
    def __init__(self, hour, minute, second):
        self.hour = hour
        self.minute = minute
        self.second = second

    def tick(self):
        self.second += 1
        if self.second == 60:
            self.minute += 1
            self.second = 0
        if self.minute == 60:
            self.hour +=1
            self.minute = 0

    def reset(self):
        self.second = 0
        self.minute = 0
        self.hour = 0

timer = Timer(0, 0, 0)

for i in range(1214):
    timer.tick()

print(timer.hour, timer.minute, timer.second)
