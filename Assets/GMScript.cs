using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GMScript : MonoBehaviour
{
    public GameObject connectionError;

    string url = "YOURURL/api/hello";

    // Use this for initialization
    IEnumerator Start()
    {
        Handheld.SetActivityIndicatorStyle(AndroidActivityIndicatorStyle.Large);

        // this is for chaining coroutines. Start will return after TryToConnect is done. 
        // could also make Start not a coroutine. 
        yield return StartCoroutine(TryToConnect());
    }

    private IEnumerator TryToConnect() 
    {
        connectionError.SetActive(false);

        Handheld.StartActivityIndicator();
        WWW www = new WWW(url);
        while (!www.isDone)
        {
            yield return null;
        }
        Handheld.StopActivityIndicator();

        if (www.text.Length > 0) 
        {
            PlayerPrefs.SetString("score", www.text);
            Application.LoadLevel(1);
        } 
        else 
        {
            connectionError.SetActive(true);
        }
    }

    public void TryToConnectAgain() 
    {
        StartCoroutine(TryToConnect());
    }
}
