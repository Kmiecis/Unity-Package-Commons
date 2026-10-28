using UnityEngine;

namespace Common
{
    /// <summary> Previews audio clips in the editor; does nothing in player builds </summary>
    public static class EditorAudioPreview
    {
#if UNITY_EDITOR
        private static System.Type _AudioUtilType;

        private static System.Type AudioUtilType
        {
            get => _AudioUtilType ?? (_AudioUtilType = GetAudioUtilType());
        }
#endif

        public static void Play(AudioClip clip, int startSample = 0, bool loop = false)
        {
#if UNITY_EDITOR
            var method = AudioUtilType.GetMethod(
                "PlayPreviewClip",
                UBinding.PublicStatic,
                typeof(AudioClip), typeof(int), typeof(bool)
            );
            method.Invoke(null, clip, startSample, loop);
#endif
        }

        public static bool IsPlaying()
        {
#if UNITY_EDITOR
            var method = AudioUtilType.GetMethod(
                "IsPreviewClipPlaying",
                UBinding.PublicStatic
            );
            return (bool)method.Invoke(null);
#else
            return false;
#endif
        }

#if UNITY_EDITOR
        [UnityEditor.MenuItem("Window/Audio/Stop Preview Clips", false)]
#endif
        public static void StopAll()
        {
#if UNITY_EDITOR
            var method = AudioUtilType.GetMethod(
                "StopAllPreviewClips",
                UBinding.PublicStatic
            );
            method.Invoke(null);
#endif
        }

#if UNITY_EDITOR
        private static System.Type GetAudioUtilType()
        {
            var assembly = typeof(UnityEditor.AudioImporter).Assembly;
            return assembly.GetType("UnityEditor.AudioUtil");
        }
#endif
    }
}
