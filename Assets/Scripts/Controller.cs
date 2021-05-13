using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//継承先の名前が正しくないと継承できないので気を付けて
public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){

        //左矢印キーが押されたら
        if (Input.GetKey(KeyCode.LeftArrow)){

            //ポジションZ方向にプラス
            transform.position += transform.forward * 0.05f;
        
        //左矢印キーが押されずに、右矢印キーが押されていたら
        }else if (Input.GetKey(KeyCode.RightArrow)){

            //ポジションZ方向にマイナス
            transform.position -= transform.forward * 0.05f;
        }
 
    }
}
