import math

def SetTriangleParametrs(numberOfTriangle):
    triangle = []
    print("Write side 'A' Length of " + str(numberOfTriangle) + "  triangle (number)\n->  ");
    triangle.append(float(input()))
    print("Write side 'B' Length of " + str(numberOfTriangle) + "  triangle (number)\n->  ");
    triangle.append(float(input()))
    print("Write side 'C' Length of " + str(numberOfTriangle) + "  triangle (number)\n->  ");
    triangle.append(float(input()))
    if triangle[0] + triangle[1] > triangle[2] and triangle[0] + triangle[2] > triangle[1] and triangle[1] + triangle[2] > triangle[0]:
        return triangle;
    else:
        print("This triangle doesn't exist")
        sys.exit()
        return null;

def FindSquare(triangle):
    semi_perimeter = float((triangle[0] + triangle[1] + triangle[2]) / 2);
    square = float(math.sqrt(semi_perimeter * (semi_perimeter - triangle[0]) * (semi_perimeter - triangle[1]) * (semi_perimeter - triangle[2])));
    return square;

def FindTheBiggest(triangle1, triangle2, triangle3):
    squareFirst = float(FindSquare(triangle1))
    squareSecond = float(FindSquare(triangle2))
    squareThird = float(FindSquare(triangle3))
    print("First Triangle square:  ")
    print("%.4f" % (squareFirst))
    print("Second Triangle square:  ")
    print("%.4f" % (squareSecond))
    print("Third Triangle square:  ")
    print("%.4f" % (squareThird))

    if squareFirst == squareSecond and squareFirst == squareThird:
        print("This three triangles have the same square\n")

    elif  squareFirst == squareSecond:
        if squareFirst > squareThird:
            print("Max Square have first and second triangle\n");
        else:
            print("Max Square has third triangle\n");

    elif squareFirst == squareThird:
        if squareFirst > squareSecond:
            print("Max Square have first and third triangle\n");
        else:
            print("Max Square has second triangle\n");

    elif squareSecond == squareThird:
        if squareSecond > squareFirst:
            print("Max Square have second and third triangle\n");
        else:
            print("Max Square has first triangle\n");

    elif squareFirst > squareSecond:
        if squareFirst > squareThird:
            print("Max Square has first triangle\n");
        else:
            print("Max Square has third triangle\n");

    else:
        if squareSecond > squareThird:
            print("Max Square has second triangle\n");
        else:
            print("Max Square has third triangle\n");



print("       /\\");
print("    A /  \\ B");
print("     /    \\");
print("    /______\\");
print("        C\n");

triangle1 = []
triangle1 = SetTriangleParametrs(1)
triangle2 = []
triangle2 = SetTriangleParametrs(2)
triangle3 = []
triangle3 = SetTriangleParametrs(3)

FindTheBiggest(triangle1, triangle2, triangle3)