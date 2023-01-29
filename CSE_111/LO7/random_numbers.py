import random
 
def main():
    numbers = [16.2, 75.1, 52.3]
 
    print(f' numbers {numbers}')
 
    append_random_numbers(numbers)
 
    print(f' numbers {numbers}')
    append_random_numbers(numbers,2)
    print(f' numbers {numbers}')
 
def append_random_numbers(numbers_list, quantity=1):
    ''''This will have 2 parameters, numbers_list and quantity
        Also has a default value of 1    
    '''
 
    for _ in range(quantity):
        temp_var = random.uniform(0,100) 
        numbers_list.append(round(temp_var,1))


 
if __name__ == "__main__":
    main()