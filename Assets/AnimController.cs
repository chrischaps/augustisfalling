using UnityEngine;

public class AnimController : MonoBehaviour
{
    void Update()
    {
        /*GetComponent<Animator>().SetBool("Forward", Input.GetKey(KeyCode.W));
        GetComponent<Animator>().SetBool("Backward", Input.GetKey(KeyCode.S));
        GetComponent<Animator>().SetBool("Right", Input.GetKey(KeyCode.D));
        GetComponent<Animator>().SetBool("Left", Input.GetKey(KeyCode.A));*/
        
        GetComponent<Animator>().SetFloat("Forward", Input.GetKey(KeyCode.W) ? 1.0f : Input.GetKey(KeyCode.S) ? -1.0f : 0.0f);
        GetComponent<Animator>().SetFloat("Sideways", Input.GetKey(KeyCode.D) ? 1.0f : Input.GetKey(KeyCode.A) ? -1.0f : 0.0f);
        //GetComponent<Animator>().SetFloat("Forward", Input.GetKey(KeyCode.S) ? -1.0f : 0.0f);
        //GetComponent<Animator>().SetFloat("Sideways", Input.GetKey(KeyCode.D) ? 1.0f : 0.0f);
        //GetComponent<Animator>().SetFloat("Sideways", Input.GetKey(KeyCode.A) ? -1.0f : 0.0f);

    }
}
