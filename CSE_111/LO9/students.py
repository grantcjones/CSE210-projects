import csv
KEY_COLUMN_INDEX = 0

def main():
    """"""

    user_input = input("Enter an I-Number: ")

    dict = read_dict("students.csv")

    try:
        print(dict[user_input])
    except KeyError:
        print("No such student.")


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

    with open (filename, "rt") as text_file:
        reader = csv.reader(text_file)
        next(reader)

        i_dict = {}

        for line in reader:
            i_number = line[key_column_index]
            i_dict[i_number] = line[1]
    
    return i_dict

if __name__ == "__main__":
    main()


