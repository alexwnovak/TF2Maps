using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

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
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

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
            for ( int index = 0; index < _symbolCount; index++ )
            {
               char character = 'Z';
               float arc = 360f / _symbolCount;
               float thetaDegrees = arc * index;
               float thetaRadians = AsRadians( thetaDegrees );

               var characterSize = MeasureCharacter( g, font, character );
               var centerPoint = new PointF( centerX - characterSize.Width / 2, centerY - characterSize.Height / 2 );

               float x = centerX + (float) Math.Cos( thetaRadians ) * radius;
               float y = centerY + (float) Math.Sin( thetaRadians ) * radius;

               g.TranslateTransform( x, y );
               g.RotateTransform( thetaDegrees + 90 );

               g.TranslateTransform( -x, -y );
               g.TranslateTransform( -( characterSize.Width / 2 ), -( characterSize.Height / 2 ) );

               g.DrawString( character.ToString(), font, _greenBrush, x, y );
               g.ResetTransform();
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
