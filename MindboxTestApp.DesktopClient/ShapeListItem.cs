using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestApp.DesktopClient
{
    public record ShapeListItem(ShapeType Value, string Label)
    {
        public override string ToString()
        {
            return Label;
        }
    }
}
