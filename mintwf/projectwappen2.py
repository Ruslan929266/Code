import turtle

t = turtle.Turtle()
t.speed(1)
t.width(3)

# Функция для рисования щита (контур)
def draw_shield():
    t.penup()
    t.goto(0, 200)
    t.pendown()
    t.begin_fill()
    t.color("black", "white")
    
    t.goto(150, 200)
    t.goto(180, 100)
    t.goto(150, -150)
    t.goto(0, -250)
    t.goto(-150, -150)
    t.goto(-180, 100)
    t.goto(-150, 200)
    t.goto(0, 200)
    
    t.end_fill()

# Левая синяя часть
def draw_left():
    t.penup()
    t.goto(-150, 200)
    t.pendown()
    t.begin_fill()
    t.color("black", "blue")
    
    t.goto(0, 200)
    t.goto(0, -250)
    t.goto(-150, -150)
    t.goto(-180, 100)
    t.goto(-150, 200)
    
    t.end_fill()

# Правая красная часть
def draw_right():
    t.penup()
    t.goto(0, 200)
    t.pendown()
    t.begin_fill()
    t.color("black", "red")
    
    t.goto(150, 200)
    t.goto(180, 100)
    t.goto(150, -150)
    t.goto(0, -250)
    t.goto(0, 200)
    
    t.end_fill()

# Белая волнистая линия (упрощённо)
def draw_wave():
    t.penup()
    t.goto(0, 200)
    t.pendown()
    t.color("white")
    t.width(20)
    
    for i in range(10):
        t.right(10)
        t.forward(30)
        t.left(20)
        t.forward(30)
        t.right(10)

    t.width(3)

# Звезда
def draw_star(x, y, size=20):
    t.penup()
    t.goto(x, y)
    t.pendown()
    t.color("white")
    t.begin_fill()
    
    for _ in range(5):
        t.forward(size)
        t.right(144)
    
    t.end_fill()


draw_shield()
draw_left()
draw_right()
draw_wave()


draw_star(-80, 100)
draw_star(-80, 30)
draw_star(-80, -40)

turtle.done()