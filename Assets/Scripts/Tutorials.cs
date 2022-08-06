using UnityEngine;

public class Tutorials : MonoBehaviour
{
    public TextMesh myText;
    public string tutorialText;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.tag=="Player")
        {
            myText.text = tutorialText;
        }
        
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.transform.tag=="Player")
        {
            myText.text = null;
        }
        
        
    }
}
