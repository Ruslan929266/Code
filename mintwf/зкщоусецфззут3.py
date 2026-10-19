from os import path
import math
import turtle
t = turtle.Turtle()
t.speed(5)

t.penup()
t.left(90)
t.forward(100)
t.left(90)
t.forward(100)
t.pendown()

t.color("black")
t.left(90)
t.forward(200)
t.circle(150, 90)
x,y = t.position()
print(x,y)