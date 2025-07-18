using System.Collections.Generic;
using UnityEngine;

namespace Common
{
    public static class RendererExtensions
    {
        public static void SetSharedMaterials(this Renderer self, List<Material> materials)
        {
            self.sharedMaterials = materials.ToArray();
        }

        public static void AppendSharedMaterial(this Renderer self, Material material)
        {
            var materials = new List<Material>();
            self.GetSharedMaterials(materials);
            materials.Add(material);
            self.SetSharedMaterials(materials);
        }

        public static void RemoveSharedMaterial(this Renderer self, Material material)
        {
            var materials = new List<Material>();
            self.GetSharedMaterials(materials);
            materials.Remove(material);
            self.SetSharedMaterials(materials);
        }
    }
}