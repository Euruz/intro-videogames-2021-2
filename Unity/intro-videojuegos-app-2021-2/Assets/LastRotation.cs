using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastRotation : MonoBehaviour
{
    // Start is called before the first frame update

    public float thisCharactersXrotation;
    public float thisCharactersYrotation;
    public float thisCharactersZrotation;
    void Awake()
    {
        thisCharactersXrotation = PlayerPrefs.GetFloat ("MyRotationX");
        thisCharactersYrotation = PlayerPrefs.GetFloat ("MyRotationY");
        thisCharactersZrotation = PlayerPrefs.GetFloat ("MyRotationZ");
    }
    void Start()
    {
        transform.rotation = Quaternion.Euler(thisCharactersXrotation,thisCharactersYrotation,thisCharactersZrotation);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("MyRotationX", transform.eulerAngles.x);
        PlayerPrefs.SetFloat("MyRotationY", transform.eulerAngles.y);
        PlayerPrefs.SetFloat("MyRotationZ", transform.eulerAngles.z);
    }
}
