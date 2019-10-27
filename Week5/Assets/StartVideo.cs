using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartVideo : MonoBehaviour
{
    public VideoClip videoToPlay;
    public RawImage image;
    private VideoPlayer videoPlayer;
    private VideoSource videoSource;
    // Start is called before the first frame update
    void Start()
    {
        Application.runInBackground = true;
        StartCoroutine(playVideo());
        videoPlayer.loopPointReached += LoadScene;
    }

    IEnumerator playVideo()
    {
        //Add VideoPlayer to the GameObject
        videoPlayer = gameObject.AddComponent<VideoPlayer>();

        
        //Disable Play on Awake for both Video 
        videoPlayer.playOnAwake = false;

        //We want to play from video clip not from url
        videoPlayer.source = VideoSource.VideoClip;

        //Set video To Play then prepare Audio to prevent Buffering
        videoPlayer.clip = videoToPlay;
        videoPlayer.Prepare();

        //Wait until video is prepared
        while (!videoPlayer.isPrepared)
        {
            Debug.Log("Preparing Video");
            yield return null;
        }

        Debug.Log("Done Preparing Video");
        image.texture = videoPlayer.texture;
        //Play Video
        videoPlayer.Play();
        Debug.Log("Playing Video");
        while (videoPlayer.isPlaying)
        {
            Debug.LogWarning("Video Time: " + Mathf.FloorToInt((float)videoPlayer.time));
            yield return null;
        }
        Debug.Log("Done Playing Video");

    }
    void LoadScene(VideoPlayer vp)
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("MainMenu");
    }
}
