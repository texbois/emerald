using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Windows.Forms;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(VisualLine.DebuggerSide),
    typeof(VisualizerObjectSource),
    Target = typeof(System.String),
    Description = "Hello folks!")]

namespace VisualLine
{
    public class DebuggerSide : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            object arrayObj = objectProvider.GetObject();
            if (!arrayObj.GetType().IsArray || arrayObj.GetType().GetElementType() != typeof(double))
            {
                MessageBox.Show("Expected an array of kind: double[ , 2]", "Wasted!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double[,] a = (double[,])arrayObj;
 
            //double[,] array = Array.ConvertAll<object[], double[]>((object[,])arrayObj, xs => Array.ConvertAll<object, double>(xs, x => (double)x));
            using (var form = new LineForm())
            {
                form.SetData(a);
                windowService.ShowDialog(form);
            }
        }

        public static void Test(object o)
        {
            VisualizerDevelopmentHost vdh = new VisualizerDevelopmentHost(o, typeof(DebuggerSide));
            vdh.ShowVisualizer();
        }

    }
}
