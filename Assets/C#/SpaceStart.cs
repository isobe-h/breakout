using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpaceStart : MonoBehaviour
{
    public Text resultMessageText;

    // Start is called before the first frame update
    void Start()
    {
        resultMessageText.text = DataSender.resultMessage;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
