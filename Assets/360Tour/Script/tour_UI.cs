using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tour_UI: MonoBehaviour {
    [Header("クロスヘア（照準）の画像をつけたUIを入れる")] 
    public Image aimPointImage;
    [Header("スライダー（捕捉時間目安）のUIを入れる")]
    public Slider myslider;//UIのスライダー
    float slideValue = 0f;//スライダーの値用の変数
    bool soundBool = false;//音を連続再生されるのを防止するBool
    [Header("エイムにロックした時の音")] 
    public AudioClip scopesound;//クロスヘアにロックした時の音 

    [Header("移動時のSE")] 
    public AudioClip get_se;//クロスヘアにロックした時の音
    [Header("ジャンプ先で判定したいタグ名")] 
    public string waypoint_tag;

    Transform tag_hit_point;
    AudioSource myaudio;//オーディオソース用 
    AudioSource myaudio2; 

    [Header("矢印のオブジェクトたち")]
     public List<GameObject> ArrowObjects = new List<GameObject>();
    [Header("ゴールのオブジェクトたち")]
    public List<GameObject> GoalObjects = new List<GameObject>();

    [Header("到着地名や説明")]
    public List<string> wayPointName = new List<string>();
    [Header("未着のスタンプを設定")]
    public List<GameObject> Stamps = new List<GameObject>();
    [Header("訪問済みのスタンプ")]
    public Sprite ArrivesSprite;
    [Header("到着先表示用パネル")]
    public GameObject textPanel;
    Image stampImage;
    [Header("到着先表示用TextUI")]
    public Text arriveText;
    //int point = 0;//得点用
    private void Start() { 
        AudioSource[] audioSources = gameObject.GetComponents<AudioSource>();//Maincameraにアサインされている複数のAudioSourceを取得し配列に入れる 
        myaudio = audioSources[0];//一つ目のオーディオソースの名前をaudioに 
        myaudio2 = audioSources[1];
        //到着先表示用パネルを見えなくする
        textPanel.SetActive(false);
            }
             
        void FixedUpdate() { 
            // Rayを飛ばす 
            Ray ray = new Ray(transform.position, transform.forward); 
            // outパラメータ用に、Rayのヒット情報を取得するための変数を用意 
            Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
            //Debug.DrawRay(transform.position, forward, Color.green);

            RaycastHit hit; 
            // Rayのhit情報を取得する
            if (Physics.Raycast(ray,out hit,6.0f)){
            // Rayがhitしたオブジェクトのタグ名を取得 
            string hitTag = hit.collider.tag;

            //Debug.Log(hitTag);//consoleで確認する例

            // タグの名前がpresentだったら、照準の色が変わる 
            if ((hitTag.Equals(waypoint_tag))){ 
                //照準を青に変える 
                aimPointImage.color = new Color(0f, 0.5f, 1.0f, 0.75f); 
                slideValue += 1.5f;//スライドバー用の値をアップさせる
                 myslider.value = slideValue;//スライドバーの値をセットする 
                 if(!soundBool){
                     //連打再生されないようにBoolで飛ばす 
                     soundBool = true;
                     //スコープ用の音を再生する 
                     myaudio.PlayOneShot(scopesound, 0.5f);
                } 
                     //99越えたら消す 
                if(slideValue > 99){ 
                    myaudio2.PlayOneShot(get_se, 0.5f);//移動サウンドを再生
                    soundBool = false;//再び再生できるようにする 

                    //ListのArrowObjectsの中から、hitしたGameObjectを検索しそのIndex番号（Listの何番目か）をArrowIndex入れる
                    int ArrowIndex = ArrowObjects.IndexOf(hit.collider.gameObject);
                    
                    //GoalObjectsのListの中のArrowIndex番目のGameObjectを取り出し、その位置に移動
                    this.transform.position = GoalObjects[ArrowIndex].transform.position;
                    //スタンプを訪問済みに入れ替える
                    stampImage = Stamps[ArrowIndex].GetComponent<Image>();//スタンプ達のうち、現在の訪問先番号のスタンプを取得
                    stampImage.sprite = ArrivesSprite;//そのスタンプの画像（Sprite）を訪問済みの物に入れ替える
                    //到着地のパネル表示用の関数を、現在のパネル番号を引数にして実行
                    showPanel(ArrowIndex);
                } 
            }else{ 
                // present以外ではグレーの薄い色に
                aimPointImage.color = new Color(1.0f, 1.0f, 1.0f, 0.25f); 
                slideValue = 0f;//スライド値を０にする 
                myslider.value = slideValue;//その値をスライドにセットする 
                myaudio.Stop();//音再生停止 
                soundBool = false; 
                } 
            }else{ 
                // Rayがヒットしていない場合はグレーの薄い色に
                aimPointImage.color = new Color(1.0f, 1.0f, 1.0f, 0.25f); 
                slideValue = 0f; 
                myslider.value = slideValue; 
                myaudio.Stop(); 
                soundBool = false; 
                } 
            } 

    
    //戻るボタン用
    public void goHomeBtn(){
        //シーン遷移前に何か保存する必用があるならば、ここで実行する

        //シーン遷移する。BuildSttingsに設定しているシーン名opに遷移する
        SceneManager.LoadScene("op");
    }
        
    //タイムアップ処理
    public void showScore(){
        //スコア表示画面へ 
        SceneManager.LoadScene("end");
    }

//パネルを表示して、事前の到着地名や説明を表示する
    void showPanel(int ArriveIndex){
        //下記を適宜変更してください。
    arriveText.text =  wayPointName[ArriveIndex] + "を訪問しました。";
    //パネルを表示する
        textPanel.SetActive(true);
    }

//パネルとタッチするとここが実行され、パネルが非表示になる
    public void hideTextPanel(){
    textPanel.SetActive(false);
    }
}