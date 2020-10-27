using ExClassesMetodosAbstratos.Entities.Enums;

namespace ExClassesMetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
