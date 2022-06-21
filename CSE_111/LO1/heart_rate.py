"""
When you physically exercise to strengthen your heart, you
should maintain your heart rate within a range for at least 20
minutes. To find that range, subtract your age from 220. This
difference is your maximum heart rate per minute. Your heart
simply will not beat faster than this maximum (220 - age).
When exercising to strengthen your heart, you should keep your
heart rate between 65% and 85% of your heart's maximum rate.
"""


user_age = int(input("Please enter your age in years: "))

max_rate = 220 - user_age

ideal_max = int(.85 * max_rate)

ideal_min = int(.65 * max_rate)

print(f"When you exercise to strengthen your heart, you should \nkeep your heart rate bewteen {ideal_min} and {ideal_max} \nbeats per minute.")