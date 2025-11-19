using UnityEngine;
using UnityEngine.Video;



[CreateAssetMenu(fileName = "VideoSO", menuName = "ScriptableObjects/Video", order = -1000)]
public class VideoSO : ScriptableObject
{
    public VideoClip video;
    public VideoClip Video => video;
}