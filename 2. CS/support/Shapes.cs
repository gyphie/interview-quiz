using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz
{
	static class ShapeFactory
	{
		public static Shape Create(string shapeType)
		{
			switch (shapeType)
			{
				case "circle":
					return new Circle();
				case "square":
					return new Square();
				case "green":
					return new Green();
				default:
					throw new ArgumentException("Unsupported shape", "shapeType");
			}
		}
	}

	abstract class Shape
	{
		public virtual string WhatAmI()
		{
			return "I am shapeless";
		}
	}

	class Square : Shape
	{
		public override string WhatAmI()
		{
			return "Square";
		}
	}

	class Green : Shape
	{
		public new string WhatAmI()
		{
			return "I'm not a shape!";
		}
	}

	class Circle : Shape
	{
		public override string WhatAmI()
		{
			return "Circle";
		}
	}


}
