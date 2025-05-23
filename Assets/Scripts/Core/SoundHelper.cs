using UnityEngine;

/// <summary>
/// Central audio utility that now shows COMPILE TIME polymorphism
/// via three overloaded Play() methods.
/// </summary>
public static class SoundHelper
{
    // Overload #1
    /// <summary>
    /// Load a clip from a Resources path/filename and play at world origin.
    /// </summary>
    public static void Play(string clipName)
    {
        var clip = Resources.Load<AudioClip>(clipName);
        
        if (clip == null)
        {
            Debug.LogWarning($"SoundHelper: '{clipName}' not found in Resources.");
            return;
        }

        Play(clip); // forward to overload #2
    }

    // Overload #2
    /// <summary>
    /// Play a clip at world origin.
    /// </summary>
    public static void Play(AudioClip clip)
    {
        Play(clip, Vector3.zero); // forward to overload #3
    }

    // Overload #3
    /// <summary>
    /// Play a clip at a custom position.
    /// </summary>
    public static void Play(AudioClip clip, Vector3 position)
    {
        if (clip == null) return;
        AudioSource.PlayClipAtPoint(clip, position);
    }
}
