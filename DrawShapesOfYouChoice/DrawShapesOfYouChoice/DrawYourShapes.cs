using Entities;
using EntityFactory;
using OperationFactory;
using Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation;
using log4net;
using log4net.Config;
using System.Windows.Forms;
using System.Drawing;

namespace DrawShapesOfYouChoice
{
    class DrawYourShapes
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(DrawYourShapes));
        static void Main(string[] args)
        {
                tryAgain:
                Console.WriteLine("Enter you Choice !");
                Console.WriteLine("1. Line");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Circle");
                Console.WriteLine("4. Triangle");
            try
                {
                    XmlConfigurator.Configure();
                    int choice = 0;
                    bool validPointCoordinate = false;
                    bool validChoice = int.TryParse(Console.ReadLine(), out choice);

                    //IF choice is valid then draw the shape


                    if (validChoice)
                    {
                        switch (choice)
                        {
                            //Line
                            case 1:

                                //Point One
                                Line line = LineFactory.GetLine();
                                Console.WriteLine("Enter the coordinates of first point");

                                Console.WriteLine("Enter the positive x coordinate (number).");
                                xCoordinatePointOneLabel:
                                String xCoordinate = Console.ReadLine();
                                validPointCoordinate = NumberValidator.ValidateNumber(xCoordinate);
                                if (!validPointCoordinate)
                                {
                                    logger.Error("X coordinate of first point of the line is not valid !");
                                    goto xCoordinatePointOneLabel;
                                }
                                else
                                {
                                    line.pointOneXCoordinate = float.Parse(xCoordinate);
                                }

                                Console.WriteLine("Enter the positive y coordinate (number).");
                                yCoordinatePointOneLabel:
                                String yCoordinate = Console.ReadLine();
                                validPointCoordinate = NumberValidator.ValidateNumber(yCoordinate);
                                if (!validPointCoordinate)
                                {
                                    logger.Error("y coordinate of first point of the line is not valid !");
                                    goto yCoordinatePointOneLabel;
                                }
                                else
                                {
                                    line.pointOneYCoordinate = float.Parse(yCoordinate);
                                }

                                //Second One
                                Console.WriteLine("Enter the coordinates of second point");

                                Console.WriteLine("Enter the positive x coordinate (number).");
                                xCoordinatePointTwoLabel:
                                xCoordinate = Console.ReadLine();
                                validPointCoordinate = NumberValidator.ValidateNumber(xCoordinate);
                                if (!validPointCoordinate)
                                {
                                    logger.Error("X coordinate of second point is not valid !");
                                    goto xCoordinatePointTwoLabel;
                                }
                                else
                                {
                                    line.pointTwoXCoordinate = float.Parse(xCoordinate);
                                }

                                Console.WriteLine("Enter the positive y coordinate (number).");
                                yCoordinatePointTwoLabel:
                                yCoordinate = Console.ReadLine();
                                validPointCoordinate = NumberValidator.ValidateNumber(yCoordinate);
                                if (!validPointCoordinate)
                                {
                                    logger.Error("y coordinate of second point is not valid !");
                                    goto yCoordinatePointTwoLabel;
                                }
                                else
                                {
                                    line.pointTwoYCoordinate = float.Parse(yCoordinate);
                                }

                                ILineOperation lineOperation = LineOperationFactory.GetLineOperation();
                                lineOperation.Draw(line);
                                logger.Info("Line drawn Successfully");

                                break;


                            //Rectangle
                            case 2:
                                Application.ExitThread();
                                //Point One
                                RecTangle rectangle = RectangleFactory.GetRectangle();
                                Console.WriteLine("Enter the coordinates of first point");

                                Console.WriteLine("Enter the positive x coordinate (number).");
                                xCoordinateRectanglePointOneLabel:
                                String xCoordinateOfRectangle = Console.ReadLine();
                                validPointCoordinate = NumberValidator.ValidateNumber(xCoordinateOfRectangle);
                                if (!validPointCoordinate)
                                {
                                    logger.Error("X coordinate of first point of the rectangle is not valid !");
                                    goto xCoordinateRectanglePointOneLabel;
                                }
                                else
                                {
                                    rectangle.pointOneXCoordinate = float.Parse(xCoordinateOfRectangle);
                                }

                                Console.WriteLine("Enter the positive y coordinate (number).");
                                yCoordinateRectanglePointOneLabel:
                                String yCoordinateOfRectangle = Console.ReadLine();
                                validPointCoordinate = NumberValidator.ValidateNumber(yCoordinateOfRectangle);
                                if (!validPointCoordinate)
                                {
                                    logger.Error("y coordinate of first point of the rectangle is not valid !");
                                    goto yCoordinateRectanglePointOneLabel;
                                }
                                else
                                {
                                    rectangle.pointOneYCoordinate = float.Parse(yCoordinateOfRectangle);
                                }

                                //Second One
                                Console.WriteLine("Enter the coordinates of second point");

                                Console.WriteLine("Enter the positive x coordinate (number).");
                                xCoordinateRectanglePointTwoLabel:
                                xCoordinateOfRectangle = Console.ReadLine();
                                validPointCoordinate = NumberValidator.ValidateNumber(xCoordinateOfRectangle);
                                if (!validPointCoordinate)
                                {
                                    logger.Error("X coordinate of second point of the rectangle is not valid !");
                                    goto xCoordinateRectanglePointTwoLabel;
                                }
                                else
                                {
                                    rectangle.pointTwoXCoordinate = float.Parse(xCoordinateOfRectangle);
                                }

                                Console.WriteLine("Enter the positive y coordinate (number).");
                                yCoordinateRectanglePointTwoLabel:
                                yCoordinateOfRectangle = Console.ReadLine();
                                validPointCoordinate = NumberValidator.ValidateNumber(yCoordinateOfRectangle);
                                if (!validPointCoordinate)
                                {
                                    logger.Error("y coordinate of second point of the rectangle is not valid !");
                                    goto yCoordinateRectanglePointTwoLabel;
                                }
                                else
                                {
                                    rectangle.pointTwoYCoordinate = float.Parse(yCoordinateOfRectangle);
                                }

                                IRectangleOperation rectangleOperation = RectangleOperationFactory.GetRectangleOperation();
                                rectangleOperation.Draw(rectangle);
                                logger.Info("Reactangle drawn Successfully");

                                break;

                        case 3:

                            //Circle
                            Circle cirle = CircleFactory.GetCircle();
                            tryCircle:
                            float centreXCoordinate = 0;
                            float centreYCoordinate = 0;
                            float radiusOfCircle = 0;


                            //Centre of Circle
                            Console.WriteLine("Enter the X coordinate of Centre");
                            xCentreLabel:
                            string xCoordinateOfCentre = Console.ReadLine();
                            validPointCoordinate = NumberValidator.ValidateNumber(xCoordinateOfCentre);
                            if (!validPointCoordinate)
                            {
                                logger.Error("x coordinate of centre is not valid");
                                goto xCentreLabel;
                            }
                            else
                            {
                                centreXCoordinate = float.Parse(xCoordinateOfCentre);
                            }

                            Console.WriteLine("Enter the Y coordinate of Centre");
                            yCentreLabel:
                            string yCoordinateOfCentre = Console.ReadLine();
                            validPointCoordinate = NumberValidator.ValidateNumber(yCoordinateOfCentre);
                            if (!validPointCoordinate)
                            {
                                logger.Error("y coordinate of centre is not valid");
                                goto yCentreLabel;
                            }
                            else
                            {
                                centreYCoordinate = float.Parse(yCoordinateOfCentre);
                            }

                            //Radius
                            Console.WriteLine("Enter the radius of the circle.");
                            radiusLabel:
                            string radius = Console.ReadLine();
                            validPointCoordinate = NumberValidator.ValidateNumber(radius);
                            if (!validPointCoordinate)
                            {
                                logger.Error("radius of circle is not valid");
                                goto radiusLabel;
                            }
                            else
                            {
                                radiusOfCircle = float.Parse(radius);
                            }

                            if (!(radiusOfCircle <= Math.Min(centreXCoordinate, centreYCoordinate)))
                            {
                                logger.Error("radius should be less than or equal to the minimum of x and y coordinate of centre.");
                                goto tryCircle;
                            }
                            else
                            {

                                cirle.pointOneXCoordinate = centreXCoordinate - radiusOfCircle;
                                cirle.pointOneYCoordinate = centreYCoordinate - radiusOfCircle;
                                cirle.pointTwoXCoordinate = centreXCoordinate + radiusOfCircle;
                                cirle.pointTwoYCoordinate = centreYCoordinate + radiusOfCircle;
                                ICircleOperation circleOperation = CircleOperationFactory.GetCircleOperation();
                                circleOperation.Draw(cirle);
                                logger.Info("Circle drawn Successfully");
                            }
                            break;



                        case 4:

                            //Triangle
                            Triangle triangle = Trianglefactory.GetTriangle();

                            //First point 
                            Console.WriteLine("Enter the X coordinate of first point of the triangle");
                            xCoordinateTrianglePointOneLabel:
                            string xCoordinateOfPointOneOfTriangle = Console.ReadLine();
                            validPointCoordinate = NumberValidator.ValidateNumber(xCoordinateOfPointOneOfTriangle);
                            if(!validPointCoordinate)
                            {
                                logger.Error("X coordinate of first point of triangle is not valid");
                                goto xCoordinateTrianglePointOneLabel;
                            }

                 
                            Console.WriteLine("Enter the Y coordinate of first point of the triangle");
                            yCoordinateTrianglePointOneLabel:
                            string yCoordinateOfPointOneOfTriangle = Console.ReadLine();
                            validPointCoordinate = NumberValidator.ValidateNumber(yCoordinateOfPointOneOfTriangle);
                            if (!validPointCoordinate)
                            {
                                logger.Error("Y coordinate of first point of triangle is not valid");
                                goto yCoordinateTrianglePointOneLabel;
                            }

                            if(validPointCoordinate)
                            {
                                triangle.pointOne = new Point(int.Parse(xCoordinateOfPointOneOfTriangle),int.Parse(yCoordinateOfPointOneOfTriangle));
                            }



                            //Second point 
                            Console.WriteLine("Enter the X coordinate of second point of the triangle");
                            xCoordinateTrianglePointTwoLabel:
                            string xCoordinateOfPointTwoOfTriangle = Console.ReadLine();
                            validPointCoordinate = NumberValidator.ValidateNumber(xCoordinateOfPointTwoOfTriangle);
                            if (!validPointCoordinate)
                            {
                                logger.Error("X coordinate of second point of triangle is not valid");
                                goto xCoordinateTrianglePointTwoLabel;
                            }


                            Console.WriteLine("Enter the Y coordinate of second point of the triangle");
                            yCoordinateTrianglePointTwoLabel:
                            string yCoordinateOfPointTwoOfTriangle = Console.ReadLine();
                            validPointCoordinate = NumberValidator.ValidateNumber(yCoordinateOfPointTwoOfTriangle);
                            if (!validPointCoordinate)
                            {
                                logger.Error("Y coordinate of second point of triangle is not valid");
                                goto yCoordinateTrianglePointTwoLabel;
                            }

                            if (validPointCoordinate)
                            {
                                triangle.pointTwo = new Point(int.Parse(xCoordinateOfPointTwoOfTriangle), int.Parse(yCoordinateOfPointTwoOfTriangle));
                            }



                            //Three point 
                            Console.WriteLine("Enter the X coordinate of third point of the triangle");
                            xCoordinateTrianglePointThreeLabel:
                            string xCoordinateOfPointThreeOfTriangle = Console.ReadLine();
                            validPointCoordinate = NumberValidator.ValidateNumber(xCoordinateOfPointThreeOfTriangle);
                            if (!validPointCoordinate)
                            {
                                logger.Error("X coordinate of third point of triangle is not valid");
                                goto xCoordinateTrianglePointThreeLabel;
                            }


                            Console.WriteLine("Enter the Y coordinate of third point of the triangle");
                            yCoordinateTrianglePointThreeLabel:
                            string yCoordinateOfPointThreeOfTriangle = Console.ReadLine();
                            validPointCoordinate = NumberValidator.ValidateNumber(yCoordinateOfPointThreeOfTriangle);
                            if (!validPointCoordinate)
                            {
                                logger.Error("Y coordinate of third point of triangle is not valid");
                                goto yCoordinateTrianglePointThreeLabel;
                            }

                            if (validPointCoordinate)
                            {
                                triangle.pointThree = new Point(int.Parse(xCoordinateOfPointThreeOfTriangle), int.Parse(yCoordinateOfPointThreeOfTriangle));
                            }
                            
                            ITriangleOperation triangleOperation = TriangleOperationFactory.GetTriangleOperation();
                            triangleOperation.Draw(triangle);
                            logger.Info("Triangle drawn Successfully");
                            break;

                        }
                    }
                    else
                    {
                        logger.Error("Invalid Choice");
                        goto tryAgain;
                    }

                }

                catch (Exception ae)
                {
                    logger.Error(ae.Message);
                }
           
        }
    }
}
