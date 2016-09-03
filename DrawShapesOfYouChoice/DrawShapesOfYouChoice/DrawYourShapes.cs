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
                        case 1:
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






                    }
                }
                else
                {
                    logger.Error("Invalid Choice");
                    goto tryAgain;
                }


               
                
            }
            catch(Exception ae)
            {
                logger.Error(ae.Message);
            }
        }
    }
}
