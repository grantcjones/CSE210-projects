# Take .csv file formatted (timestamp, temperature(C), humidity(%)).
# Create dictionary and convert temperature(C) to temperature(F).
# Generate and draw graph displaying temperature and humidity trend
#   over time.

from draw2d import \
    start_drawing, draw_line, draw_rectangle, finish_drawing
import csv

def main():
    """Opens THR and iterates through each line to convert C to F
    and grapgh Temperature(Tp) & Humidity(H) over Time(T)"""

    print(f"Time, Temp, Humidity")

    created_dict = read_dict("Temp_Humid_Readings.csv")
    
    modified_dict = convert_c_to_f(created_dict)

    draw_graph(modified_dict)

def read_dict(filename, key_column_index=0):
    """Reads the contents of a csv file into a dictionary.
    
    Parameters
    filename: csv file to pull info from
    key_column_index: The index of each line in the csv file
    to use as a key.
    """
    try:
        with open (filename, "rt") as csv_file:
            reader = csv.reader(csv_file)
            next(reader)
        
            dict = {}

            for line in reader:
                key = line[key_column_index]
                my_list = [line[1], line[2]]
                dict[key] = my_list
    except FileNotFoundError:
        print(f"Error, '{filename}' not found or does not exist.")
    
    return dict



def convert_c_to_f(dictionary):
    """Read the contents of a dictionary, converts Celsius
    to Fahrenheit, and converts items into usable values.

    Parameter(s)
        dictionary: A dictionary formatted as (timestamp, 
        temperature(C), humidity(%)).
    Return: a compound dictionary that contains
        the contents of the csv file with the temperature
        readings in celcius.
    """
    try:
        for line in dictionary:
            key = dictionary[line]


            celsius = key[0]
            celsius = celsius.removesuffix(".00")
            celsius = int(celsius)

            humidity = key[1]
            humidity = humidity.removesuffix(".00")
            humidity = int(humidity)

            fahrenheit = round((celsius * 1.8) + 32)
            # print(key, fahrenheit, humidity)

            key[0] = fahrenheit
            key[1] = humidity
    except FileNotFoundError:
        print("File not found.")
    
    return dictionary

def draw_graph(dictionary):
    """Reads a dictionary and presents the information
    in a graphical interface.
    
    Parameter(s):
    dictionary: A compound dictionary that contains temperature and 
    humidity readings over time."""

    width = len(dictionary)

    canvas = start_drawing("Showing Window AC effectiveness: Temp (defF) and Humidtiy (%) V.S. Time", width, height=600)
    draw_rectangle(canvas, 0, 0, width, 600, fill="black")


    x_coord = 0
    for line in dictionary:
        key = dictionary[line]

        temp0 = key[0]
        hum0 = key[1]

        x_coord = x_coord + 1

        
        draw_line(canvas, x_coord, temp0, x_coord +1, temp0, fill="red")

        draw_line(canvas, x_coord, hum0, x_coord +1, hum0, fill="blue")


    finish_drawing(canvas)



if __name__ == "__main__":
    main()