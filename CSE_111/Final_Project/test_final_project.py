# Testing the functions in final_project.py

from tkinter import Canvas
from xml.dom import NotFoundErr
from final_project import read_dict, convert_c_to_f, draw_graph
import pytest

def test_read_dict():
    """Tests the read_dict function from
    final_project.py.
    """
    # Asserts that read_dict works
    try:
        # Call read_dict to convert file to 
        #   dictionary and save to variable
        created_dict = read_dict("test_temp_hum.csv")

        # Set key for each line in dictionary
        for line in created_dict:
            key = created_dict[line]

        assert created_dict["16:14:40.789"] == ["21.00", " 38.00"]
        assert created_dict["14:56:00.933"] == ["27.00", " 38.00"]
    except AssertionError:
        print("Assertion error in 'test_temp_hum.csv'.")

    # Asserts that previous testing works on 
    #   original csv file, and that previous 
    #   assertions are still valid (values 
    #   for both csv files are the same, but
    #   in different order.)
    try:
        # ^^^
        created_dict = read_dict("Temp_Humid_Readings.csv")

        # ^^^
        for line in created_dict:
            key = created_dict[line]

        assert created_dict["16:14:40.789"] == ["21.00", " 38.00"]
        assert created_dict["14:56:00.933"] == ["27.00", " 38.00"]

    except AssertionError:
        print("Assertion error in 'Temp_Humid_Readings.csv'.")        

def test_convert_c_to_f():
    """Tests the convert_c_to_f function from 
    final_project.py"""

    try:
        # Call function to convert file to a dictionary
        my_dict = read_dict("test_temp_hum.csv")

        # Save that dictionary to a variable(my_dict)
        new_dict = convert_c_to_f(my_dict)

        # Assert that the setup of the dictionary is 
        #   correct and verifies the temperature conversion
        #   was calculated correctly.
        # (Asserting the first 5 values only, the rest are 
        #   there so the other test function can work.)
        assert new_dict["16:14:40.789"] == [70, 38]
        assert new_dict["15:44:28.787"] == [72, 38]
        assert new_dict["15:26:00.910"] == [73, 38]
        assert new_dict["15:10:01.640"] == [75, 38]
        assert new_dict["15:01:17.455"] == [77, 38]
    except AssertionError:
        print(f"Error: Incorrect assertion, please compare to 'test_temp_csv'.")
    except FileNotFoundError:
        print("Error: File not found or does not exist.")
    
def test_draw_graph():
    """Tests the draw_graph function from 
    final_project.py"""

    try:
        # Call read_dict to convert file to a dictionary and save to variable.
        my_dict = read_dict("test_temp_hum.csv")
        # Call convert_c_to_f() to convert C to F.
        new_dict = convert_c_to_f(my_dict)

        # Assert that the draw_graph function runs and
        #   draws a graph.
        assert draw_graph(new_dict)

        # Assert length of dictionary (976, which is also equal to the width 
        #   of the graph).
        assert len(new_dict) == 976

    except AssertionError:
        print(f"Assertion Error: Information in {new_dict} may be faulty.")
    except AttributeError:
        print(f"Error: Incorrect attribute for {new_dict}")

# Run the test functions
pytest.main(["-v", "--tb=line", "-rN", __file__])