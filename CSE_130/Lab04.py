import math
# 1. Name:
#      -Grant Jones-
# 2. Assignment Name:
#      Lab 04: Monopoly
# 3. Assignment Description:
#      -This program is meant to determine if a player can place a hotel on Pennsylvania Avenue in a game of Monopoly-
# 4. What was the hardest part? Be as specific as possible.
#      -My hardest difficulty was creating a plan/flow and using it. I had a flowchart made, but after several hours of working on my 
#        code, I realized that the flowchart did not work, and neither did the code. I had to restart the entire code without a plan, 
#        which made the project take more than twice as long.
# 5. How long did it take for you to complete the assignment?
#      -8+ hours. I was unable to finish the program, even with the gracious extension to midnight. I'm going to be seeking tutoring help this next week to close the gap between my current skill level and the assigments ahead.-
        

def TestingPrint(pac_ave, nc_ave, penn_ave): # TESTING
    print(pac_ave)
    print(nc_ave)
    print(penn_ave)

def BuyHouses(prop):
    """Takes number value of houses on a property, sees how many houses are available
    for purchase, checks funds, buys houses, sees how many hotels are available for purchase, buys hotel."""

    house_number = int(input("\nHow many houses are available for purchase? ")) # Number of houses available.
    houses_needed = 4 - prop # Number of houses needed.
    if house_number < 1:
        print("There are not enough houses for purchase at this time.")
    elif house_number >= 1:
        cash = int(input("How much cash do you have to spend? $"))
        purchaseable = cash/200 
        purchaseable = math.floor(purchaseable) # Sets how many houses we can purchase. But how many do we need?
        print(f"Purchaseable: {purchaseable}") # TESTING

        if cash < 200:

            print("You do not have enough cash to purchase a house at this time.")

        elif cash >= 200:

            print(f"pre-purchase: {cash}") # TESTING

            if purchaseable > houses_needed:

                budget = houses_needed # Sets number of houses we will buy.
                cash = cash - (200 * budget)
                # print(budget) # TESTING
                print(f"cash: {cash}") # TESTING

            elif purchaseable == houses_needed:
                
                budget = purchaseable # Sets number of houses we will buy.
                cash = cash - purchaseable
                print(purchaseable) # TESTING

            elif purchaseable < houses_needed:

                budget = houses_needed - purchaseable # Sets number of houses we will buy.
                print(budget) # TESTING
                cash = cash - budget
                print(f"cash: {cash}")
                print(budget) # TESTING
            
            new_prop_value = budget + prop # Buying Houses

            if new_prop_value == 4:
                BuyHotel(cash)
                # hotel_number = int(input("\nHow many hotels are available for purchase? "))

                # if hotel_number >= 1:

                #     if cash >= 200:

                #         print(f"pre-hotel ${cash}") # TESTING
                #         cash = cash - 200
                #         new_prop_value = 5 # Buying Hotel(s)
                #         print(f"post-hotel ${cash}")
                #         return new_prop_value # Says it can have a hotel
                        

                #     if cash < 200:

                #         print(cash) # TESTING
                #         print("You do not have sufficient funds to purchase a hotel at this time.")

                # else: 
                #     print("There are not enough hotels for purchase at this time.")

def BuyOneHouse(prop, houses_available, cash):
    """Purchases one house for a property, then checks if a hotel is purchaseable."""

    # houses_available = int(input("\nHow many houses are available for purchase? ")) # Number of houses available.
    if houses_available < 1:
        print("There are not enough houses for purchase at this time.")
    elif houses_available >= 1:
        # cash = int(input("How much cash do you have to spend? $"))
        if cash < 200:
            ("You do not have sufficient funds to purchase a house at this time.")
        elif cash >= 200:
            cash = cash - 200
            prop = prop + 1

        if prop == 5:
            BuyHotel(cash)
        else:
            return prop

def BuyHotel(cash_balance):
    hotel_number = int(input("\nHow many hotels are available for purchase? "))

    if hotel_number >= 1:

        if cash_balance >= 200:

            print(f"pre-hotel ${cash_balance}") # TESTING
            new_prop_value = 5 # Buying Hotel(s)
            # print(f"post-hotel ${cash}")
            return new_prop_value # Says it has a hotel
            
        if cash_balance < 200:

            print(cash_balance) # TESTING
            print("You do not have sufficient funds to purchase a hotel at this time.")
    else: 
        print("There are not enough hotels for purchase at this time.")

def Swap(prop1, prop2, prop_name):
    houses_purchased = prop1 + prop2
    cost = (houses_purchased * 200)
    print(f"Swap {prop_name} hotel with Pennsylvania's 4 houses.")
    print(f"This will cost $[{cost}].\n    Purchase 1 hotel and [{houses_purchased}] house(s).\n    Put 1 hotel on Pennsylvania and return any houses to the bank.Put [number of houses] house(s) on {prop_name}.")


def Main():

    prop_ownership = input("Do you own all the green properties? (y/n) ")
    if prop_ownership.lower() == "y":

        pac_ave = int(input("What is on Pacific Avenue? "))

        nc_ave = int(input("What is on North Carolina Avenue? "))

        penn_ave = int(input("What is on Pennsylvania Avenue? "))

        if (pac_ave < 5) and (nc_ave < 5) and (penn_ave < 5): # Output _ 000 Buy a bunch of houses
            houses_available = int(input("\nHow many houses are available for purchase? ")) # Number of houses available.
            cash = int(input("How much cash do you have to spend? $"))

            while penn_ave < 5:

                if pac_ave < (nc_ave and penn_ave):
                    pac_ave  = BuyOneHouse(pac_ave, houses_available, cash)
                elif nc_ave < (pac_ave and penn_ave):
                    nc_ave = BuyOneHouse(nc_ave, houses_available, cash)
                else:
                    penn_ave = BuyOneHouse(penn_ave, houses_available, cash)
            print("This will cost $[price].\n    Purchase 1 hotel and [number of houses] house(s).\n    Put 1 hotel on Pennsylvania and return any houses to the bank.\n    Put [number of houses] house(s) on North Carolina.\n    Put [number of houses] house(s) on Pacific.")

        if  (penn_ave == 5): # 001
            print("You cannot put a hotel on the propterty if it already has one.")

        elif (pac_ave < 5) and (nc_ave == 5) and (penn_ave < 5): # Output _ 010 Type Alpha End up swapping NC with Penn?
            houses_available = int(input("\nHow many houses are available for purchase? ")) # Number of houses available.
            cash = int(input("How much cash do you have to spend? $"))

            print("Output 010")
            if pac_ave < penn_ave:
                BuyOneHouse(pac_ave, houses_available, cash)
            elif penn_ave < pac_ave:
                BuyOneHouse(penn_ave, houses_available, cash)
            if penn_ave == 5:
                print("This will cost $[price].Purchase 1 hotel and [number of houses] house(s).Put 1 hotel on Pennsylvania and return any houses to the bank.Put [number of houses] house(s) on Pacific.")
            elif pac_ave == 5:
                Swap(penn_ave, pac_ave, "Pacific")
        # 011

        elif (pac_ave == 5) and (nc_ave < 5) and (penn_ave < 5): # Output _ 100 Type Alpha End up swapping Pac Ave with Penn?
            print("Output 100")
            houses_available = int(input("\nHow many houses are available for purchase? ")) # Number of houses available.
            cash = int(input("How much cash do you have to spend? $"))

            if nc_ave < penn_ave:
                BuyOneHouse(nc_ave, houses_available, cash)
            elif penn_ave < nc_ave:
                BuyOneHouse(penn_ave, houses_available, cash)
            if penn_ave == 5:
                print(f"This will cost $[price].Purchase 1 hotel and [number of houses] house(s).Put 1 hotel on Pennsylvania and return any houses to the bank.Put [number of houses] house(s) on North Carolina.")
            elif nc_ave == 5:
                Swap(penn_ave, nc_ave, "North Carolina")


        if (pac_ave == 5) and (nc_ave == 5) and (penn_ave < 5): # Output _110 Penn should have > 1 houses in this scenario
            purchase_d = BuyHouses(penn_ave)

            if purchase_d == 5:
                houses_purchased = 4 - penn_ave
                houses_cost = (houses_purchased * 200)

                print(f"This will cost $[{houses_cost}].\n    Purchase 1 hotel and {houses_purchased} house(s).\n    Put 1 hotel on Pennsylvania and return any houses to the bank.")
            else:
                print("There are not enough houses for purchase at this time.")
    elif prop_ownership.lower("n"):

        print("You cannot purchase a hotel until you own all the properties of a given color group.")

if __name__ == "__main__":
    Main()

