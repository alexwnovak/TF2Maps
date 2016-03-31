using System.Drawing.Imaging;
using System.Windows.Forms;

namespace NumberGenerator
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();

         var decalGenerator = new DecalGenerator();

         for ( int index = 1; index <= 15; index++ )
         {
            var image = decalGenerator.Create( index.ToString() );
            image.Save( index + ".bmp", ImageFormat.Bmp );
         }
      }
   }
}
