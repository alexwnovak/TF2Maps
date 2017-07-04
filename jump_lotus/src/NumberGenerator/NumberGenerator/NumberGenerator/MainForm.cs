using System.Windows.Forms;

namespace NumberGenerator
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();

         const int jumpCount = 12;

         for ( int index = 1; index <= jumpCount; index++ )
         {
            var image = NumberDecalGenerator.Draw( index, 12 );

            string fileName = $@"C:\Temp\JumpLotus\Number{index.ToString( "D2" )}.png";
            image.Save( fileName );
         }
      }
   }
}
