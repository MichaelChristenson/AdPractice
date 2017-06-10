using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ad : MonoBehaviour {

    public void ShowAd()
    {
        Debug.Log("Attempting to Show Ad");
        if (Advertisement.IsReady())
        {
            Debug.Log("Showing Ad");
            Advertisement.Show("", new ShowOptions() { resultCallback = HandleAdResult });
        }   
    }

    private void HandleAdResult(ShowResult result)
    {
        switch(result)
        {
            case ShowResult.Finished:
                reward();
                break;
            case ShowResult.Skipped:
                skip();
                break;
            case ShowResult.Failed:
                failed();
                break;
        }
    }

    private void reward()
    {
        Debug.Log("Yay");
    }

    private void skip()
    {
        Debug.Log("Boo");
    }

    private void failed()
    {
        Debug.Log("Failure");
    }
        
}
