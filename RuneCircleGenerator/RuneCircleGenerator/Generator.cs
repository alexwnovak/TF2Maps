using System;
using System.Drawing;

namespace RuneCircleGenerator
{
   public class Generator : IDisposable
   {
      private const int _textureSize = 1024;
      private const int _symbolCount = 24;
      private static readonly float _penWidth = _textureSize * 0.016f;
      private static readonly float _fontSize = _textureSize * 0.065f;

      private static Color _greenColor = Color.FromArgb( 255, 156, 255, 134 );
      private SolidBrush _transparentBrush = new SolidBrush( Color.Transparent );
      private Pen _greenPen = new Pen( _greenColor, _penWidth );
      private SolidBrush _greenBrush = new SolidBrush( _greenColor );
      
      public Image GenerateRuneCircle()
      {
         var bitmap = new Bitmap( _textureSize, _textureSize );

         using ( var g = Graphics.FromImage( bitmap ) )
         {
            FillWithTransparency( g );

            RenderRings( g );

            RenderSymbols( g );
         }

         return bitmap;
      }

      private void RenderSymbols( Graphics g )
      {
         float radius = _textureSize / 2 * 0.84f;
         float centerX = _textureSize / 2;
         float centerY = _textureSize / 2;

         using ( var font = new Font( "Segoe UI", _fontSize ) )
         {
            char character = 'Z';

            for ( int index = 0; index < _symbolCount; index++ )
            {
               float arc = 360f / _symbolCount;
               float theta = AsRadians( arc * index );
               var characterSize = MeasureCharacter( g, font, character );

               float x = centerX + (float) Math.Cos( theta ) * radius - characterSize.Width / 2;
               float y = centerY + (float) Math.Sin( theta ) * radius - characterSize.Height / 2;

               g.DrawString( character.ToString(), font, _greenBrush, x, y );
            }
         }
      }

      private float AsRadians( float theta )
         => theta * (float) Math.PI / 180f;

      private SizeF MeasureCharacter( Graphics g, Font font, char c )
         => g.MeasureString( c.ToString(), font );
      
      private void RenderRings( Graphics g )
      {
         float outerMargin = _textureSize * 0.02f;
         float innerMargin = _textureSize * 0.14f;

         g.DrawEllipse( _greenPen, outerMargin, outerMargin, _textureSize - outerMargin * 2, _textureSize - outerMargin * 2 );
         g.DrawEllipse( _greenPen, innerMargin, innerMargin, _textureSize - innerMargin * 2, _textureSize - innerMargin * 2 );
      }

      private void FillWithTransparency( Graphics g )
         => g.FillRectangle( _transparentBrush, 0, 0, _textureSize, _textureSize );

      #region IDisposable members

      public void Dispose()
      {
         Dispose( true );
         GC.SuppressFinalize( this );
      }

      private void Dispose( bool disposing )
      {
         if ( disposing )
         {
            _transparentBrush?.Dispose();
            _greenPen?.Dispose();
            _greenBrush?.Dispose();
         }
      }

      #endregion
   }
}
