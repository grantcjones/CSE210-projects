# # 

# import random
 
# def main():
#     numbers = [16.2, 75.1, 52.3]
 
#     print(f' numbers {numbers}')
 
#     append_random_numbers(numbers)
 
#     print(f' numbers {numbers}')
#     append_random_numbers(numbers,2)
#     print(f' numbers {numbers}')
 
# def append_random_numbers(numbers_list, quantity=1):
#     ''''This will have 2 parameters, numbers_list and quantity
#         Also has a default value of 1    
#     '''
 
#     for _ in range(quantity):
#         temp_var = random.uniform(0,100) 
#         numbers_list.append(round(temp_var,1))


 
# if __name__ == "__main__":
#     main()

    for _ in marriages_dict:

        marriage = marriages_dict[_]
        husband_key = marriage[0]
        wife_key = marriage[1]
        wedding_year = marriage[2]
        
        for _ in people_dict:

            ppl_info = people_dict[_]
            pers_name = ppl_info[0]
            pers_dob = ppl_info[2]

            if husband_key == pers_name:
                husband_age = wedding_year - pers_dob

            if wife_key == pers_name:
                wife_age = wedding_year - pers_dob

            print(f"Husband: {pers_name}, {husband_age} years old")
            print(wedding_year)
            print(f"Wife: {pers_name}, {wife_age} years old")
