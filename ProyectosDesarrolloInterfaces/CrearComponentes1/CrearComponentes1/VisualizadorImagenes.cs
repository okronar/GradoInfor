using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearComponentes1
{
    public partial class VisualizadorImagenes : Panel
    {

        //clase de tipo controlador para representar imagenes picturebox
        PictureBox pictureBox;
        public VisualizadorImagenes()
        {
            InitializeComponent();
            pictureBox = new PictureBox();
            this.Controls.Add(pictureBox);
        }

        //metadatos para usar el visualizador de imagenes

        //[Category("Custom")]
        //[Browsable(true)]
        //[Description("set path to image")]
        //[Editor(typeof(System.Windows.Forms.Design.WindowsFormsComponentEditor),typeof(System.Drawing.Design.UITypeEditor))]

        public VisualizadorImagenes(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
