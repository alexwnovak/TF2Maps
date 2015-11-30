using System.Drawing;

namespace RuneCircleGenerator
{
   public static class Generator
   {
      private const int _textureSize = 1024;

      public static Image GenerateRuneCircle()
      {
         var bitmap = new Bitmap( _textureSize, _textureSize );

         using ( var g = Graphics.FromImage( bitmap ) )
         {
         }

         return bitmap;
      } 
   }
}
