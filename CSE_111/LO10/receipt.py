import csv
from datetime import datetime



def main():
    """Creates a reciept based on the items in request.csv"""

    now = datetime.now()
    date_time = now.strftime("%a %b  %d %I:%M:%S %Y")
    weekday = now.strftime("%a")

    print("Huckleberry Farms")

    try:
        products_dict = read_dict("products.csv")
        # print(products_dict)
        print("\nRequested items.")

        line = []

    
        with open("request.csv", mode='rt') as request_file:
            reader = csv.reader(request_file)
            next(reader)

            count = 0
            subtotal = 0

            for line in reader:
                key = line[0]
                item = products_dict[key]
                print(f'{item[1]}: {line[1]} @ {item[2]}')

                quantity = int(line[1])
                count = count + quantity

                cost = float(item[2]) * int(line[1])
                subtotal = subtotal + cost

            if (weekday == "Tue") or (weekday == "Wed"):
                discount = subtotal * .1
            else:
                discount = 0

            sales_tax = subtotal * .06
            total = subtotal + sales_tax - discount

            print(f"\nItem count {count}")
            print(f"Subtotal: {subtotal:.2f}")
            print(f"Sales Tax: {sales_tax:.2f}")
            print(f"Total: {total:.2f}\n")
            print("Thank you, come again!")
            print(f"{date_time}")
    except FileNotFoundError:
        print(f"\nError: missing file\n[Errno 2] No such file or directory: 'product.csv'")
    except PermissionError:
        print(f"\nError: Higher clearance required.")
    except KeyError:
        print(f"\nError: Unknown product ID in the request.csv file\n{line[0]}")
    



def read_dict(filename, key_column_index = 0):
    """Read the contents of a CSV file into a compound
    dictionary and return the dictionary.

    Parameters
        filename: the name of the CSV file to read.
        key_column_index: the index of the column
            to use as the keys in the dictionary.
    Return: a compound dictionary that contains
        the contents of the CSV file.
    """
    with open (filename, "rt") as csv_file:
        reader = csv.reader(csv_file)
        next(reader)
        
        dict = {}

        for line in reader:
            key = line[key_column_index]
            # It took me way too long to think to create a list
            # to put into dict[key]. If I had thought of that when
            # I got to this point, I would have been able to 
            # turn this in on time.
            my_list = [line[0], line[1], line[2]]
            dict[key] = my_list
    print(dict)

    return dict


if __name__ == "__main__":
    main()

