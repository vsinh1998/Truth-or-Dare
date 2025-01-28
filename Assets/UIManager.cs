using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button truthButton;
    public Button dareButton;
    public TextMeshProUGUI Questions;
    // Start is called before the first frame update
    void Start()
    {
        truthButton.onClick.AddListener(() => ShowRandomTruth());
        dareButton.onClick.AddListener(() => ShowRandomDare());
    }

    void ShowRandomTruth()
    {
        
    }
    void ShowRandomDare()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
