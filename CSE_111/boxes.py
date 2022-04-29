import math

number_items = int(input("Please enter the number of manufactured items: "))

per_box = int(input("Please enter the number of items to be packed per box: "))

result = math.ceil( number_items / per_box )

print()

print(f"For {number_items} items, packing {per_box} items in each box, you will need {result} boxes.")

print()