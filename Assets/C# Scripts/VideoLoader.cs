using UnityEngine;


public class VideoLoader : MonoBehaviour
{
    public static VideoLoader Instance { get; private set; }


    [SerializeField] private VideoUISlot[] videoUISlots;

    
    private void Awake()
    {
        Instance = this;
        
        videoUISlots = GetComponentsInChildren<VideoUISlot>();
        for (int i = 0; i < videoUISlots.Length; i++)
        {
            videoUISlots[i].Id = i;
        }
    }
}