import csv



def main():
    """"""

    products_dict = read_dict("products.csv")
    print(products_dict)
    print("\nRequested items.")

    line = []

    with open("request.csv", mode='rt') as request_file:
        reader = csv.reader(request_file)
        next(reader)
        for line in reader:
            key = line[0]
            item = products_dict[key]
            print(f'{item[1]}: {line[1]} @ {item[2]}')

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

