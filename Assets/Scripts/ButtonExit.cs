using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonExit : MonoBehaviour
{
    public Button bttn_exit;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = bttn_exit.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }
}
