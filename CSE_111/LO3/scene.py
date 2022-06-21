# Import the functions from the Draw 2-D library
# so that they can be used in this program.
from draw2d import \
    start_drawing, draw_line, draw_oval, draw_arc, \
    draw_rectangle, draw_vertical_gradient, draw_circle_with_vert_grad, draw_polygon, draw_text, finish_drawing


def main():
    # Width and height of the scene in pixels
    scene_width = 800
    scene_height = 500

    # Call the start_drawing function in the draw2d.py
    # library which will open a window and create a canvas.
    canvas = start_drawing("Scene", scene_width, scene_height)

    # Call your drawing functions such
    # as draw_sky and draw_ground here.


    draw_sky(canvas, x0=0, y0=0, color0=[0, 0, 0], x1=scene_width, y1=scene_height, color1=[0, 0, 100])
    draw_cloud0(canvas, x0=280, y0=260)    
    draw_cloud0(canvas, x0=250, y0=300)
    draw_cloud1(canvas, x0=200, y0=300)
    draw_moon(canvas, center_x=150, center_y=200)
    draw_mountain0(canvas, bottom_left_x=350)
    draw_mountain0(canvas, bottom_left_x=325)
    draw_mountain2(canvas, bottom_left_x=250)
    draw_mountain2(canvas, bottom_left_x=390)
    draw_mountain1(canvas, bottom_left_x=275)
    draw_mountain1(canvas, bottom_left_x=300)
    draw_mountain2(canvas, bottom_left_x=425)
    draw_ground(canvas, 0, 0, color0=[150, 80, 80], x1=scene_width, y1=100, color1=[50, 50, 50])

    #  # Remove quote on draw_grid() to veiw numbered grid on canvas
    # draw_grid(canvas, scene_width, scene_height, 50)

    # Call the finish_drawing function
    # in the draw2d.py library.
    finish_drawing(canvas)


# Define your functions such as
# draw_sky and draw_ground here.


def draw_grid(canvas, width, height, interval):
    """Creates a grid of lines to help place objects on 
    specific places on the canvas"""


    # Draw the grid's vertical lines
    for x in range(interval, width, interval):
        label_y = 15
        draw_line(canvas, x, 0, x, height, fill="white")
        draw_text(canvas, x, label_y, f"{x}", fill="white")

    # Draw the grid's horizontal lines
    for y in range(interval, height, interval):
        label_x = 15
        draw_line(canvas, 0, y, width, y, fill="white")
        draw_text(canvas, label_x, y, f"{y}", fill="white")


def draw_sky(canvas, x0, y0, color0, x1, y1, color1):
    """Draws the sky for the background"""

    # Drawing the sky with a color gradient
    draw_vertical_gradient(canvas, x0, y0, color0, x1, y1, color1)
    
def draw_cloud0(canvas, x0, y0):
    """Draws the first cloud and its highlight."""
    
    # Drawing cloud0 highlight
    draw_oval(canvas, x0=x0-5, y0=y0-5, x1=x0+240, y1=y0+76, width=0, fill="light gray")
    # Drawing cloud0
    draw_oval(canvas, x0, y0, x1=x0+245, y1=y0+80, width=0, fill="gray")
    
def draw_cloud1(canvas, x0, y0):
    """Draws the second cloud and its highlight"""

    # Drawing cloud1 highlight
    draw_oval(canvas, x0=x0-5, y0=y0-5, x1=x0+100, y1=y0+48, width=0, outline="light gray", fill="light gray")
    # Drawing cloud2
    draw_oval(canvas, x0, y0, x1=x0+100, y1=y0+50, width=0, fill="gray")

def draw_moon(canvas, center_x, center_y):
    """Draws a 'small moon' on top of the sky."""

    # Drawing the "Moon" with a gradient
    draw_circle_with_vert_grad(canvas, center_x, center_y, radius=50, color_center=[50, 50, 50], color_edge=[200, 200, 200])
    # Drawing the "Crater" on the "Moon"
    draw_circle_with_vert_grad(canvas, center_x=center_x+12, center_y=center_y+20, radius=15, color_center=[40, 40, 40], color_edge=[45, 45, 45])
    # "That's no moon. -Ben Kenobi"
    draw_line(canvas, x0=center_x-50, y0=center_y, x1=center_x+50, y1=center_y, fill="black")


def draw_ground(canvas, x0, y0, color0, x1, y1, color1):
    """Draws the ground."""
    
    # Draw ground with a gradient
    draw_vertical_gradient(canvas, x0, y0, color0, x1, y1, color1)

def draw_mountain0(canvas, bottom_left_x): 
    """Draws the 1st mountain."""

    # Draw mountain0
    draw_polygon(canvas, bottom_left_x, y0=100, x1=bottom_left_x+75, y1=275, x2=bottom_left_x+150, y2=100, fill="gray")

def draw_mountain1(canvas, bottom_left_x):
    """Draws the 2nd mountain."""

    # Draw mountain1
    draw_polygon(canvas, bottom_left_x, y0=100, x1=bottom_left_x+75, y1=250, x2=bottom_left_x+150, y2=100, fill = "gray")

def draw_mountain2(canvas, bottom_left_x):
    """Draws the 3rd mountain."""

    # Draw mountain2
    draw_polygon(canvas, bottom_left_x, y0=100, x1=bottom_left_x+38, y1=180, x2=bottom_left_x+75, y2=100, fill="gray")

# Call the main function so that
# this program will start executing.
main()