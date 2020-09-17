using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Convo2 : MonoBehaviour
{
     public GameObject dialogBox; 
    public Text dialogText; 
    public string dialog; 
    public bool chick2InRange; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && chick2InRange)
        {
            if(dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false); 
            } else { 
                    dialogBox.SetActive(true); 
                    dialogText.text = dialog; 

            }

            }

        }
        
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("chick2"))
        {
            chick2InRange = true; 
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("chick2"))
        {
            chick2InRange = false; 
            dialogBox.SetActive(false); 
        }
    }

}
