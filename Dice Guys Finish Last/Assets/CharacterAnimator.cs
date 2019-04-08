using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharacterAnimator : MonoBehaviour
{
    public Animator Locomotion;
    public float xMov;
    public float yMov;

    // Start is called before the first frame update
    void Start()
    {
        Locomotion = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        xMov = Input.GetAxisRaw("Horizontal");
        Locomotion.SetFloat("xMov", xMov);
        yMov = Input.GetAxisRaw("Vertical");
        Locomotion.SetFloat("yMov", yMov);
    }
}
