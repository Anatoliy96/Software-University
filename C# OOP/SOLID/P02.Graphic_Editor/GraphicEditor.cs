using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Graphic_Editor
{
    public class GraphicEditor
    {
        private List<IShape> shapes;

        public GraphicEditor()
        {
            shapes = new List<IShape>()
            {
                new Circle(),
                new Rectangle(),
                new Square(),
                new Triangle()
            };
        }

        public void DrawShape()
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
