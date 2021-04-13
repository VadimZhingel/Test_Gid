using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;
using TSM = Tekla.Structures.Model;
using Tekla.Structures.Model.UI;

namespace DimensionAndSection
{
    public partial class Form1 : Form
    {
        Model teklaModel = new Model();
        public Form1()
        {
            InitializeComponent();
        }

        private void distance_Click(object sender, EventArgs e)
        {
            Picker picker = new Picker();
            Part part = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_OBJECT) as Part;
            Beam beam = part as Beam;
            if (beam != null)
            {
                var currentPlane = SetPlaneAndReturnOriginal(beam);
                //cs_net_lib.UI.DrawPlane(beam.GetCoordinateSystem(), new TSM.UI.Color(0.5, 1, 1),
                //    new TSM.UI.Color(1, 0.5, 1), "Вася");
                Point px = new Point(-beam.EndPoint.X + beam.StartPoint.X, beam.EndPoint.Y - beam.StartPoint.Y,
                beam.EndPoint.Z - beam.StartPoint.Z);
                Vector vZ;

                vZ = new Vector(-px.Y, px.X, px.Z);

                var localPlane = new TransformationPlane(beam.EndPoint, new Vector(px), vZ);

                CoordinateSystem localCoor = new CoordinateSystem(beam.EndPoint, new Vector(px), vZ);

                cs_net_lib.UI.DrawPlane(beam.GetCoordinateSystem());
                cs_net_lib.UI.DrawPlane(localCoor);
                teklaModel.GetWorkPlaneHandler().SetCurrentTransformationPlane(currentPlane);

            }
            ContourPlate plate = part as ContourPlate;
            if (plate != null)
            {
                //cs_net_lib.UI.DrawPlane(beam.GetCoordinateSystem(), new TSM.UI.Color(0.5, 1, 1),
                //    new TSM.UI.Color(1, 0.5, 1), "Вася");
                cs_net_lib.UI.DrawPlane(plate.GetCoordinateSystem());
            }
            string tesGid = null;
        }
        private TransformationPlane SetPlaneAndReturnOriginal(Beam aBeam)
        {
            var result = teklaModel.GetWorkPlaneHandler().GetCurrentTransformationPlane();
            teklaModel.GetWorkPlaneHandler().SetCurrentTransformationPlane(new TransformationPlane(aBeam.GetCoordinateSystem()));
            return result;
        }

    }


}

    

