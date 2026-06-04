using UnityEngine;

namespace Common
{
    public static class EditorAudioPreview
    {
        private static System.Type _AudioUtilType;

        private static System.Type AudioUtilType
        {
            get => _AudioUtilType ?? (_AudioUtilType = GetAudioUtilType());
        }

        public static void Play(AudioClip clip, int startSample = 0, bool loop = false)
        {
            var method = AudioUtilType.GetMethod(
                "PlayPreviewClip",
                UBinding.PublicStatic,
                typeof(AudioClip), typeof(int), typeof(bool)
            );
            method.Invoke(null, clip, startSample, loop);
        }

        public static bool IsPlaying()
        {
            var method = AudioUtilType.GetMethod(
                "IsPreviewClipPlaying",
                UBinding.PublicStatic
            );
            return (bool)method.Invoke(null);
        }

#if UNITY_EDITOR
        [UnityEditor.MenuItem("Window/Audio/Stop Preview Clips", false)]
#endif
        public static void StopAll()
        {
            var method = AudioUtilType.GetMethod(
                "StopAllPreviewClips",
                UBinding.PublicStatic
            );
            method.Invoke(null);
        }

        private static System.Type GetAudioUtilType()
        {
#if UNITY_EDITOR
            var assembly = typeof(UnityEditor.AudioImporter).Assembly;
            return assembly.GetType("UnityEditor.AudioUtil");
#else
            return null;
#endif
        }
    }
}