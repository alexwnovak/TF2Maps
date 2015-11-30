using System.Windows.Forms;

namespace RuneCircleGenerator
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
      }

      private void MainForm_Load( object sender, System.EventArgs e )
      {
         using ( var generator = new Generator() )
         {
            BackgroundImage = generator.GenerateRuneCircle();
         }
      }
   }
}
