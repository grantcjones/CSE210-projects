# v is the volume in liters,
# π is the constant PI, which is the ratio of the circumference of a circle divided by its diameter (use math.pi),
# w is the width of the tire in millimeters,
# a is the aspect ratio of the tire, and
# d is the diameter of the wheel in inches.

from datetime import datetime
import math
from os import write


pi = math.pi
w = float(input("Enter the width of the tire in mm: "))
a = float(input("Enter the aspect ratio of the tire: "))
d = float(input("Enter the diameter of the wheel: "))

v = (((pi * (w**2)) * a) * ((w * a) + (2540 * d))) / (10000000000)

print(f"The approximate volume is {v:.2f} liters")

date = datetime.now()

with open('volume.txt', 'a') as volume_file:

    print(f"Date: {date:%Y-%m-%d}\nTire Width (mm): {w}\nTire Aspect Ratio: {a}\nWheel Diameter (in): {d}\nTire Volume (liters): {v:.2f}", file=volume_file)
