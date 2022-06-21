from cmath import pi
import math
pi = math.pi


def main():
    """"""
    # Can info
    name = ["#1 Picnic", "#1 Tall", "#2", "#2.5", "3 Cylinder", "#5", "#6Z", "#8Z short", "#10", "211", "#300", "#303"]
    radius = [6.83, 7.78, 8.73, 10.32, 10.79, 13.02, 5.40, 6.83, 15.72, 6.83, 7.62, 8.10]
    height = [10.16, 11.91, 11.59, 11.91, 17.78, 14.29, 8.89, 7.62, 17.78, 12.38, 11.27, 11.11]
    cost = [.28, .43, .45, .61, .86, .83, .22, .26, 1.53, .34, .38, .42]
    volume = []
    surface_area = []
    storage_efficiency = []

    for x in range(len(name)):
        volume.append(compute_volume(radius[x], height[x]))
        surface_area.append(compute_surface_area(pi, radius[x], height[x]))
        storage_efficiency.append(compute_efficiency(volume[x], surface_area[x]))
        print(f"{name[x]} {storage_efficiency[x]:.2f}")


# Define Functions
def compute_volume(radius, height):
    """Computes can volume"""
    volume = pi * (radius ** 2) * height
    return volume

def compute_surface_area(pi, radius, height):
    """Computes can surface area"""
    pi = math.pi
    surface_area = (2 * pi * radius) * (radius + height)
    return surface_area

def compute_efficiency(volume, surface_area):
    """Computes storage efficience"""
    storage_efficiency = (volume / surface_area)
    return storage_efficiency

# Call main() to run
main()
