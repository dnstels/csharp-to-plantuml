using CSharpToPlantUML.Extention;
using Iternity.PlantUML;

namespace CSharpToPlantUML.Converter
{
    public static class PlantUMLToImageUrlConverter
    {
        public static string GetImageUrl(string plantUmlSource)
        {
            var plantUmlURL = @"http://192.168.56.104:8080";
            var planUml = PlantUMLUrl.Create();
            planUml.WithBaseUrl(plantUmlURL);
            return planUml.ToPNG(plantUmlSource);
            //return PlantUMLUrl.PNG(plantUmlSource);
        }
    }
}