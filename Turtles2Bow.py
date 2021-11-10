import turtle 
#importing sys
def draw_square(tut, width):
    tut.fillcolor('red')
    tut.begin_fill()
    for _ in range(4):
        tut.forward(width)
        tut.right(90)
    tut.end_fill()
    
def draw_rectengal(tut, width, height):
    tut.fillcolor('red')
    tut.begin_fill()
    for _ in range(4):
        tut.forward(height)
        tut.right(90)
        tut.forward(height *2)
        tut.right(90)
    tut.end_fill()
    
def draw_hexagon(tut,width, height):
    tut.fillcolor('yellow')
    tut.begin_fill()
    for _ in range(6):
        tut.forward(height)
        tut.right(-60)
    tut.end_fill()
    
def draw_triangle(tut, width, height):
    tut.fillcolor('blue')
    tut.begin_fill()
    for _ in range(3):
        tut.forward(width)
        tut.right(-60)
    tut.end_fill()

def draw_star(tut, width, height):
    tut.color('red','orange')
    tut.begin_fill()
    points = 1
    while points < 6:
        tut.forward(width)
        tut.left(144)
        points = points + 1
    tut.end_fill()
    
def draw_star2(tut, width, height):
    tut.color('white','yellow')
    tut.begin_fill()
    points = 1
    while points < 12:
        tut.forward(width)
        tut.left(164)
        points = points + 1
    tut.end_fill()


#Function For scaling background

#Function to make stars
#Function to make clouds

def main():
    '''
    Program starts here.
    '''
    try:
        width = int(input())
        height = int(input())

        pass
    except ValueError:
        print('Width and height must be positive integers.')
        return

    if width < 1 or height < 1:
        print('Width and height must be positive integers.')
        return

    tut = turtle.Turtle()
    scr = turtle.Screen()
    scr.setup(width, height)
    
    scr.bgcolor('black')
    draw_square(tut,80)
    tut.speed(0)
#To have the sys argument
    tut.pu()
    tut.goto(25,25)
    tut.pd()
    draw_rectengal(tut,300,100)
    tut.penup()
    tut.forward(35)
    tut.rt(35)
    tut.forward(120)
    tut.pendown()
    draw_square(tut, 100)
    tut.penup()
    tut.rt(90)
    tut.forward(50)
    tut.pendown()
    draw_hexagon(tut,200,100)
    tut.penup()
    tut.rt(90)
    tut.forward(150)
    tut.pendown()
    draw_triangle(tut, 200, 200)
    draw_triangle(tut, 100, 100)
    tut.rt(45)
    draw_hexagon(tut, 100, 200)
    tut.penup()
    tut.rt(45)
    tut.forward(300)
    tut.pendown()
    draw_star(tut, 250, 225)#
    tut.penup()
    tut.left(90)
    tut.forward(120)
    tut.pendown()
    draw_star2(tut, 225, 185)#
    tut.penup()
    tut.left(90)
    tut.forward(600)
    tut.pendown()
    draw_star2(tut, 225, 185)
    tut.penup()
    tut.left(90)
    tut.forward(120)
    tut.pendown()
    draw_star(tut, 250, 225)
    tut.penup()
    tut.left(35)
    tut.forward(720)
    tut.pendown()
    draw_star(tut, 300, 225)
    tut.penup()
    tut.left(90)
    tut.forward(100)
    tut.pendown()
    draw_star2(tut, 200, 200)
    #Background for atmosphere
    #Stars and clouds
    
    
    
    pass

if __name__ == "__main__":
    main() 