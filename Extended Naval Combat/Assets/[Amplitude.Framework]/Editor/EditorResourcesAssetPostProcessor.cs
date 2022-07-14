// <copyright file="EditorResourcesAssetPostProcessor.cs" company="AMPLITUDE Studios">Copyright AMPLITUDE Studios. All rights reserved.</copyright>

namespace Amplitude.Framework.Editor
{
    internal class EditorResourcesAssetPostProcessor : UnityEditor.AssetPostprocessor
    {
        protected virtual void OnPreprocessTexture()
        {
            //// ../Assets/[Amplitude.Framework]/Editor/EditorResources/Icons/*

            if (this.assetPath.Contains("Assets/[Amplitude.Framework]/Editor/EditorResources/Icons/"))
            {
                UnityEditor.TextureImporter textureImporter = (UnityEditor.TextureImporter)this.assetImporter;

                textureImporter.alphaIsTransparency = true;
                textureImporter.filterMode = UnityEngine.FilterMode.Bilinear;
                textureImporter.mipmapEnabled = false;
                textureImporter.maxTextureSize = 64;
                textureImporter.npotScale = UnityEditor.TextureImporterNPOTScale.None;
                textureImporter.textureCompression = UnityEditor.TextureImporterCompression.Compressed;
                textureImporter.textureType = UnityEditor.TextureImporterType.GUI;
                textureImporter.wrapMode = UnityEngine.TextureWrapMode.Clamp;
            }
        }
    }
}
