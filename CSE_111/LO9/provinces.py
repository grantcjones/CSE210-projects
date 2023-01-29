from cgitb import text
from dataclasses import replace
from distutils.command.clean import clean
from re import A

# Open File as text file
with open("provinces.txt", mode = "rt") as text_file:
    text_list = []

    for line in text_file:
        clean_line = line.strip()

        text_list.append(clean_line)
    

    # Assigning values to variables
    a = text_list[0]
    b = text_list[-1]


    # Removing first and last values
    text_list.remove(a)
    text_list.pop()

    for i in range(0, len(text_list)):
        if text_list[i] == "AB":
            text_list[i] = "Alberta"
        e = text_list.count("Alberta")


    print(text_list)
    print(f"Alberta occurs {e} times in the modified list.")
