using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInit : MonoBehaviour
{
    //�Q�[���I�u�W�F�N�g�^�̕ϐ����`
    public GameObject boxObjPrefab;
    public GameObject boxesObj;

    //Awake��Start���������Ă΂��C�x���g�֐�
    void Awake()
    {
        //��8�~�c5��Box��Prefab���C���X�^���X�����Ă���
        for (int x = 0; x < 8; x++)
        {
            for(int y = 0; y < 5; y++)
            {
                //��U"g"�Ƃ���GameObject�^�̕ϐ�����肻�̒���Prefab���C���X�^���X�����Ă���
                GameObject g = Instantiate(boxObjPrefab, boxesObj.transform);

                //�ϐ�"g"�ɃC���X�^���X�����ē����ꂽ�Q�[���I�u�W�F�N�g��
                //transform.position�̒l��for�����g���ČX�̍��W�Ɉړ�������
                g.transform.position = new Vector3((2f + (1f * y)), 0.4f, (-4.2f + (1.2f * x)));
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
