from sense_hat import SenseHat
from time import sleep

sense = SenseHat()

r = [255, 0, 0]
o = [255, 127, 0]
y = [255, 255, 0]
g = [0, 255, 0]
b = [0, 0, 255]
i = [75, 0, 130]
v = [159, 0, 255]
e = [0, 0, 0]


while True:
    p = sense.get_pressure()
    if p > 1000 and p < 1002:
        low()
    elif p > 1002 and p < 1004:
        med()
    elif p > 1004 and p < 1020:
        high()
    else:
        sense.clear()


    def low():
        sense.set_pixel(0,3, r)
        sleep(0.05)
        sense.set_pixel(1,3, r)
        sleep(0.05)
        sense.set_pixel(2,2, r)
        sleep(0.05)
        sense.set_pixel(3,3, r)
        sleep(0.05)
        sense.set_pixel(4,3, r)
        sleep(0.05)
        sense.set_pixel(5,4, r)
        sleep(0.05)
        sense.set_pixel(6,3, r)
        sleep(0.05)
        sense.set_pixel(7,3, r)
        sleep(0.05)
        sense.clear()

    def med():
        sense.set_pixel(0,3, g)
        sleep(0.05)
        sense.set_pixel(1,3, g)
        sleep(0.05)
        sense.set_pixel(1,2, g)
        sleep(0.05)
        sense.set_pixel(2,1, g)
        sleep(0.05)
        sense.set_pixel(3,2, g)
        sleep(0.05)
        sense.set_pixel(3,3, g)
        sleep(0.05)
        sense.set_pixel(4,3, g)
        sleep(0.05)
        sense.set_pixel(4,4, g)
        sleep(0.05)
        sense.set_pixel(5,5, g)
        sleep(0.05)
        sense.set_pixel(6,4, g)
        sleep(0.05)
        sense.set_pixel(6,3, g)
        sleep(0.05)
        sense.set_pixel(7,3, g)
        sleep(0.05)
        sense.clear()

    def high():
        sense.set_pixel(0,3, r)
        sleep(0.05)
        sense.set_pixel(1,3, r)
        sleep(0.05)
        sense.set_pixel(1,2, r)
        sleep(0.05)
        sense.set_pixel(1,1, r)
        sleep(0.05)
        sense.set_pixel(2,0, r)
        sleep(0.05)
        sense.set_pixel(3,1, r)
        sleep(0.05)
        sense.set_pixel(3,2, r)
        sleep(0.05)
        sense.set_pixel(3,3, r)
        sleep(0.05)
        sense.set_pixel(4,3, r)
        sleep(0.05)
        sense.set_pixel(4,4, r)
        sleep(0.05)
        sense.set_pixel(4,5, r)
        sleep(0.05)
        sense.set_pixel(5,6, r)
        sleep(0.05)
        sense.set_pixel(6,5, r)
        sleep(0.05)
        sense.set_pixel(6,4, r)
        sleep(0.05)
        sense.set_pixel(6,3, r)
        sleep(0.05)
        sense.set_pixel(7,3, r)
        sleep(0.05)
        sense.clear()

