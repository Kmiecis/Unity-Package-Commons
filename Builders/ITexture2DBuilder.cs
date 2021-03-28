using UnityEngine;

namespace Common
{
    public interface ITexture2DBuilder
    {
        void Overwrite(Texture2D texture);
        Texture2D Build();
    }
}