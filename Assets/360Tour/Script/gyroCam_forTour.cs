using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

//このスクリプトはMainCameraにアサインしてください
public class gyroCam_forTour : MonoBehaviour {

//回転用のクォータニオンを宣言
    Quaternion gyro;

//Quaternion initialRotation;
Quaternion gyroInitialRotation;
//Quaternion offsetRotation;

    //最初の1回だけ実行。初期設定や初期化などはたいていvoid start内に書く
    void Start () {
        //ジャイロを使用可能にする
        Input.gyro.enabled = true;

    } 
    
    //void Updateは毎フレーム実行するの意味60fpsなら60回
    void Update () {

        //ジャイロセンサーに応じて回転は以下の2行
        transform.rotation = Quaternion.AngleAxis(90.0f,Vector3.right)*Input.gyro.attitude*Quaternion.AngleAxis(180.0f,Vector3.forward);
 

    }
        
}