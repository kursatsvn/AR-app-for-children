using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoscript : MonoBehaviour
{
    VideoPlayer videoPlayer;
    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }
    public void FindVideoPlayer(bool isFind)
    {
        if (isFind)
        {
            videoPlayer.Play();
        }
        else
        {
            videoPlayer.Stop();
        }
    }
}