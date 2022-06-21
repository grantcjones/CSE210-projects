# v is the volume in liters,
# π is the constant PI, which is the ratio of the circumference of a circle divided by its diameter (use math.pi),
# w is the width of the tire in millimeters,
# a is the aspect ratio of the tire, and
# d is the diameter of the wheel in inches.
from datetime import date
import math

d_t = date.today()

pi = math.pi
w = float(input("Enter the width of the tire in mm: "))
a = float(input("Enter the aspect ratio of the tire: "))
d = float(input("Enter the diameter of the wheel: "))

v = (((pi * (w**2)) * a) * ((w * a) + (2540 * d))) / (10000000000)

print(f"\nThe approximate volume is {v:.2f} liters\n")

d_t = str(d_t)
w = (f"{w:.0f}")
a = (f"{a:.0f}")
d = (f"{d:.0f}")

with open("volumes.txt", mode="a") as f:
    f.write(f"{d_t}, {w}, {a}, {d}, {v:.2f}\n")
