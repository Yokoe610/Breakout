using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�p����̖��O���������Ȃ��ƌp���ł��Ȃ��̂ŋC��t����
public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){

        //�����L�[�������ꂽ��
        if (Input.GetKey(KeyCode.LeftArrow)){

            //�|�W�V����Z�����Ƀv���X
            transform.position += transform.forward * 0.05f;
        
        //�����L�[�������ꂸ�ɁA�E���L�[��������Ă�����
        }else if (Input.GetKey(KeyCode.RightArrow)){

            //�|�W�V����Z�����Ƀ}�C�i�X
            transform.position -= transform.forward * 0.05f;
        }
 
    }
}
