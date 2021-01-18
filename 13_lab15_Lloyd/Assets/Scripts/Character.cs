using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public GameObject jumpText;
    private int JumpCounter;
    private Rigidbody rb;
    private AudioSource audioSource;
    public AudioClip[] audioclipArr;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            JumpCounter++;
            jumpText.GetComponent<Text>().text = "Jump: " + JumpCounter;
            rb.AddForce(new Vector3(0, 250, 0));

            //audioSource.Play();
            int rand = Random.Range(0, audioclipArr.Length);
            audioSource.PlayOneShot(audioclipArr[rand]);

        }
    }
}
