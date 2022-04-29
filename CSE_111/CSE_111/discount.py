from datetime import datetime

date_time = datetime.now()

week_day = date_time.weekday()

subtotal = float(input("What is your subtotal?: "))

if week_day != 1 or 2:
    
    sales_tax = subtotal * .06

    total = subtotal + sales_tax
else:
    if subtotal > 50:
        discount = subtotal * .1

        print(discount)

        subtotal = subtotal - discount

        sales_tax = subtotal * .06

        total = subtotal + sales_tax
    

print(f"{sales_tax:.2f}")
print(f"{total:.2f}")