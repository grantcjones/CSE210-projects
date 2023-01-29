# 1. Name:
#      -Grant Jones-
# 2. Assignment Name:
#      Lab 02: Authentication
# 3. Assignment Description:
#      -This program takes user input for a username and password, compares those inputs to a json file, and if the username and password match the correct information in the file, outputs a message stating that the user is authorized, and states they are not if their information was incorrect.-
# 4. What was the hardest part? Be as specific as possible.
#      -To be honest, the most difficult thing to do was to keep the recoding part under a minute. I ended up just doing all of them then recording the result.-
# 5. How long did it take for you to complete the assignment?
#      -1hr 22min-

import json

# Opening json and converting to library
with open('Lab02.json', 'r') as f:
    data = json.load(f)

# Creating Username List
user_list = []
for i in data['username']:
    user_list.append(i)

# Creating Password List
pass_list = []
for i in data['password']:
    pass_list.append(i)

# Prompting for Username and Password
un_input = input('Username: ')
pass_input = input('Password: ')

# Searching for inputs in Unsername List
if un_input in user_list:
    user = True
    user_id = user_list.index(un_input)
else: user = False

# Searching for inputs in Password List
if pass_input in pass_list:
    password = True
    pass_id = pass_list.index(pass_input)
else: password = False

# Passing logic for verification
if (user == True) and (password == True) and (user_id == pass_id):
    print('You are authenticated!')
else: print('You are not authorized to use the system.')
