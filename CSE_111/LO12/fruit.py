def main():
    # Create and print a list named fruit.
    fruit_list = ["pear", "banana", "apple", "mango"]
    print(f"original: {fruit_list}")

    fruit_list.reverse()
    print(f"reversed: {fruit_list}")

    fruit_list.append("orange")
    print(f"append orange: {fruit_list}")

    insert_index = fruit_list.index("apple")
    fruit_list.insert(insert_index, "cherry")
    print(f"insert cherry: {fruit_list}")

    fruit_list.remove("banana")
    print(f"remomve banana {fruit_list}")

    popped_element = fruit_list.pop()
    print(f"pop {popped_element}: {popped_element}")
    print(fruit_list)

    fruit_list.sort()
    print(f"sorted: {fruit_list}")

    fruit_list.clear()
    print(f"cleared: {fruit_list}")

if __name__ == "__main__":
    main()
    