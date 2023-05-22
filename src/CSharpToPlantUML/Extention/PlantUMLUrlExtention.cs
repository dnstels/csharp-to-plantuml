using Iternity.PlantUML;

namespace CSharpToPlantUML.Extention
{
    static public class PlantUMLUrlExtention
    {
        public static string ToSVG(this PlantUMLUrl plantUML, string content)
        {
            return plantUML
                .WithUmlContent(content)
                .SvgStyle()
                .ToString();
        }

        public static string ToPNG(this PlantUMLUrl plantUML, string content)
        {
            return plantUML
                .WithUmlContent(content)
                .PngStyle()
                .ToString();
        }
    }
}
