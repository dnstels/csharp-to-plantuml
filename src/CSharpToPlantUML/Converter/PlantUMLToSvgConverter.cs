using System;
using System.Net.Http;
using System.Threading.Tasks;
using CSharpToPlantUML.Extention;
using Iternity.PlantUML;

namespace CSharpToPlantUML.Converter
{
    public static class PlantUMLToSvgConverter
    {
        private static readonly HttpClient HttpClient = new HttpClient();

        public static async Task<string> GetSvgContent(string plantUmlSource)
        {
            try
            {
                var plantUmlURL = @"http://192.168.56.104:8080/uml/";
                var planUml = PlantUMLUrl.Create();
                planUml.WithBaseUrl(plantUmlURL);
                //return planUml.ToSVG(plantUmlSource);
                //return await HttpClient.GetStringAsync(PlantUMLUrl.SVG(plantUmlSource));
                return await HttpClient.GetStringAsync(planUml.ToSVG(plantUmlSource));

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}