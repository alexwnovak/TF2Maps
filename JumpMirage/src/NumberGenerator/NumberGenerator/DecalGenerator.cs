using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace NumberGenerator
{
   public class DecalGenerator
   {
      private const int _decalSize = 256;

      public Image Create( string text )
      {
         var bitmap = (Bitmap) Image.FromFile( "Stone08Small.png" );

         using ( var g = Graphics.FromImage( bitmap ) )
         {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            using ( var textureBitmap = Image.FromFile( "Stone11Small.png" ) )
            {
               var textureBrush = new TextureBrush( textureBitmap );

               using ( var font = new Font( "Book Antiqua", 84 ) )
               {
                  var textSize = g.MeasureString( text, font );

                  float x = ( _decalSize - textSize.Width ) / 2;
                  float y = ( _decalSize - textSize.Height ) / 2;

                  g.DrawString( text, font, textureBrush, x, y );
               }
            }
         }

         return bitmap;
      }
   }
}
