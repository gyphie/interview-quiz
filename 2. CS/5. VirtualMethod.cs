using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz
{
	class VirtualMethod
	{
		/*
		 * Demonstrate an understanding of inheritance and method behavior.
		 *
		 * See support/Shapes.cs for the class implementations.
		 *
		 * Each "Part" method instantiates Shape (or sub) classes and then calls its WhatAmI() method which returns a string.
		 *
		 * To complete the quiz write the output of the method call after the "// Outputs: comment". Do so without executing the code.
		 *
		 */

		public void Part1()
		{
			Circle circle = new Circle();
			circle.WhatAmI(); // Outputs:

			Square square = new Square();
			square.WhatAmI(); // Outputs:

			Green green = new Green();
			green.WhatAmI(); // Outputs:
		}

		public void Part2() {
			Shape shape1 = ShapeFactory.Create("circle");
			shape1.WhatAmI(); // Outputs:

			Shape shape2 = ShapeFactory.Create("square");
			shape2.WhatAmI(); // Outputs:

			Shape shape3 = ShapeFactory.Create("green");
			shape3.WhatAmI(); // Outputs:
		}

		public void Part3()
		{
			List<Shape> shapes = new List<Shape>();
			shapes.Add(new Circle());
			shapes.Add(new Square());
			shapes.Add(new Green());

			foreach (var shape in shapes)
			{
				shape.WhatAmI();
			}

			// Outputs:
			//
			//
			//
			//
		}


	}



}
