using System;
using System.Windows.Forms;

namespace DecalGenerator
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
      }

      private void MainForm_Load( object sender, EventArgs e )
      {
         BackgroundImage = DecalGenerator.Create( 10 );

         // Save this wherever you want!
         // Use it to create more decals!
         BackgroundImage.Save( "Decal_Number10.png" );
      }
   }
}
