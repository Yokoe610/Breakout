using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartShot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�I�u�W�F�N�g��Transform�̉�]�p����x=0, y=�����_����(30�`120), z=0�ɂ���
        transform.eulerAngles = new Vector3(0, Random.Range(30, 120), 0);
        
        //�I�u�W�F�N�g�ɃA�^�b�`����Ă���"RigidBody"�R���|�[�l���g�́AAddForce�֐����Ă�
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
