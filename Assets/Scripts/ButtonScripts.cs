using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScripts : MonoBehaviour
{
    public Text ScoreText;
    public Button bttn;
    public Sprite newImageBttn;
    public int ScoreNumber = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = ScoreNumber.ToString();
    }

    public void ChangeButtonImage()
    {
        bttn.image.sprite = newImageBttn;
    }

    public void ChangeTextNumber()
    {
        ScoreNumber += 1;
    }
}