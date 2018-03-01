using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Update_Manager : MonoBehaviour
{
    public Text text;

    public string url = "https://github.com/Millies-Studio/Fortnite.git";
    IEnumerator Start()
    {
        using (WWW www = new WWW(url))
        {
            yield return www;

        }
    }
}