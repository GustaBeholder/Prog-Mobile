using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    
    [SerializeField] private Text textDisplay;
    private int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        textDisplay.text = "Gustavo Soares";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonText()
    {
        points++;
        textDisplay.text = points.ToString();
    }
}
