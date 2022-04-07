import pyglet
import datetime
time = datetime.datetime.now()
print(time.hour)
print(time.minute)

while True:
    time = datetime.datetime.now()
    if time.hour == 17 and time.minute == 6: 
        music = pyglet.resource.media('3243.wav')
        music.play()
        break

pyglet.app.run()