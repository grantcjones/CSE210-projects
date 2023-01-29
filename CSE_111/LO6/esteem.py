import re

def main():
    """"""

    print("This program is an implementation of the Rosenberg \nSelf-Esteem Scale. This program will show you ten \nstatements that you could possibly apply to yourself.\nPlease rate how much you agree with each of the\nstatements by responding with one of these four letters:\nstatements by responding with one of these four letters:\n\nD means you strongly disagree with the statement.\nd means you disagree with the statement.\na means you agree with the statement.\nA means you strongly agree with the statement.\n")


    a = input("I feel that I am a person of worth, at least on an equal plane with others. \nEnter D, d, a, or A: ")
    b = input("I feel that I have a number of good qualities. \nEnter D, d, a, or A:")
    c = input("All in all, I am inclined to feel that I am a failure."
    " Enter D, d, a, or A: ")
    d = input("I am able to do things as well as most other people."
    " Enter D, d, a, or A: ")
    e = input("I feel I do not have much to be proud of."
    " Enter D, d, a, or A: ")
    f = input("I take a positive attitude toward myself."
    " Enter D, d, a, or A: ")
    g = input("On the whole, I am satisfied with myself."
    " Enter D, d, a, or A: ")
    h = input("I wish I could have more respect for myself."
    " Enter D, d, a, or A: ")
    i = input("I certainly feel useless at times."
    " Enter D, d, a, or A: ")
    j = input("At times I think I am no good at all."
    " Enter D, d, a, or A: ")

    a = compute_positive_self_esteem(a, b, d, f, g)

    b = compute_negative_self_esteem(c, e, h, i, j)

    result = a + b

    print(f"\nYour score is {result} \nA score below 15 may indicate problematic low self-esteem.")

def convert_positive_response_to_int(response):
    """Converts user input to positve questions 
    from str to int.
    
    response: str to be converted to int"""

    # Converting str to int
    if response == "D":
        response = 0
    elif response == "d":
        response = 1
    elif response == "a":
        response = 2
    elif response == "A":
        response = 3
    
    return response

def compute_positive_self_esteem(r1, r2, r4, r6, r7):
    """Adds and returns the sum of the user's response to
    the positve questions.
    
    Parameters
    r_: The responses to positive questions"""

    # Converting responses from str to int
    v1 = convert_positive_response_to_int(r1)
    v2 = convert_positive_response_to_int(r2)
    v3 = convert_positive_response_to_int(r4)
    v4 = convert_positive_response_to_int(r6)
    v5 = convert_positive_response_to_int(r7)

    # Adding and returning the responses to positive questions
    positve = v1 + v2 + v3 + v4 + v5

    return positve

def convert_negative_response_to_int(response):
    """Converts user input to negative questions 
    from str to int"""

    # Converting str to int
    if response == "D":
        response = 3
    elif response == "d":
        response = 2
    elif response == "a":
        response = 1
    elif response == "A":
        response = 0
    
    return response

def compute_negative_self_esteem(r3, r5, r8, r9, r10):
    """Adds and returns the sum of the user's response to
    negative questions."""

    # Converting str to int
    v1 = convert_negative_response_to_int(r3)
    v2 = convert_negative_response_to_int(r5)
    v3 = convert_negative_response_to_int(r8)
    v4 = convert_negative_response_to_int(r9)
    v5 = convert_negative_response_to_int(r10)
    
    # Adding and returning sum
    negative = v1 + v2 + v3 + v4 + v5

    return negative


main()