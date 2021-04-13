using System.Collections;
using Tekla.Structures.Catalogs;
using Tekla.Structures.Model;

namespace DimensionAndSection
{
    class DimensionsAndSections
    {
        
    }

    public partial class Form1
    {
        private static double GetProfileParameter(string aProfileName, int aNo)
        {
            CatalogHandler catalogHandler = new CatalogHandler();
            double result = -1.0;
            if (catalogHandler.GetConnectionStatus())
            {
                try
                {
                    LibraryProfileItem libraryProfile = new LibraryProfileItem();
                    libraryProfile.Select(aProfileName);
                    ArrayList Parameters = libraryProfile.aProfileItemParameters;
                    ProfileItemParameter parameter = (ProfileItemParameter)Parameters[aNo];
                    result = parameter.Value;
                }
                catch
                {
                    try
                    {
                        ParametricProfileItem parametricProfile = new ParametricProfileItem();
                        parametricProfile.Select(aProfileName);
                        ArrayList Parameters = parametricProfile.aProfileItemParameters;
                        ProfileItemParameter parameter = (ProfileItemParameter)Parameters[aNo];
                        result = parameter.Value;
                    }
                    catch { }
                }
            }
            return result;
        }

        private double GetH(ContourPlate contourPlate)
        {
            return GetProfileParameter(contourPlate.Profile.ProfileString, 0);
        }
        private double GetH(Beam beam)
        {
            return GetProfileParameter(beam.Profile.ProfileString, 0);
        }
        private double GetW(ContourPlate contourPlate)
        {
            return GetProfileParameter(contourPlate.Profile.ProfileString, 1);
        }
        private double GetT(ContourPlate contourPlate)
        {
            return GetProfileParameter(contourPlate.Profile.ProfileString, 2);
        }

        #region Мусор
        //View viewMain = new View(teklaDrawing.GetSheet(), CoordinateSystem, CoordinateSystem,
        //    new AABB(new Point(200, 200, 300), new Point(100, 100, 100)));

        //TSG.CoordinateSystem result = new TSG.CoordinateSystem();
        //result.Origin = new TSG.Point(new Point(viewMain.ViewCoordinateSystem.Origin.X-20d, viewMain.ViewCoordinateSystem.Origin.Y-20d,
        //   viewMain.ViewCoordinateSystem.Origin.Z-20d));
        //result.AxisX = new TSG.Vector(viewMain.ViewCoordinateSystem.AxisX)*-1;
        //result.AxisY = new TSG.Vector(viewMain.ViewCoordinateSystem.AxisY);

        //viewMain.ViewCoordinateSystem = result;
        #endregion

    }
}
