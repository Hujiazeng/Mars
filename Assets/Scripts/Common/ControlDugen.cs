using UnityEngine;


//  **********************
//  Function :     
//  **********************



public class ControlDugen : MonoBehaviour

{
    private Animation ani;
    private void Awake()
    {
        ani = gameObject.GetComponent<Animation>();
    }

    private void Start()
    {
        if (ani != null)
        {
            InvokeRepeating("PlayDugen", 0,20);
        }
    }

    private void PlayDugen()
    {
        ani.Play();
    }





}
