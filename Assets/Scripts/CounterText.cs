using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//This controlls the counter that displays how many targets still need to be destroyed.
public class CounterText : MonoBehaviour
{
    public TMP_Text textBox;

    // Start is called before the first frame update
    // Initializes the text boxes for the target counter
    void Start()
    {
        textBox = GetComponent<TMP_Text>();
        textBox.text = PlayerMovement.targetAmount.ToString();
    }

    // Update is called once per frame
    // Changes text to the amount of targets that are left
    void Update()
    {
        textBox.text = PlayerMovement.targetAmount.ToString();
    }
}