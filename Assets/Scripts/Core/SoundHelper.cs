using UnityEngine;

/// <summary>
/// Tiny stub so the project compiles during the inheritance branch.
/// We’ll extend it with overloaded Play() methods in the next branch.
/// </summary>
public static class SoundHelper
{
    // Basic version: accept a clip?name string, look it up, and play it.
    public static void Play(string clipName)
    {
        var clip = Resources.Load<AudioClip>(clipName);
        if (clip == null)
        {
            Debug.LogWarning($"SoundHelper: '{clipName}' not found in Resources.");
            return;
        }
        Play(clip);
    }

    // Secondary method that actually plays the clip.
    public static void Play(AudioClip clip)
    {
        if (clip == null) return;
        AudioSource.PlayClipAtPoint(clip, Vector3.zero);
    }
}
