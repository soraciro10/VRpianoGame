using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grab : MonoBehaviour
{
    [SerializeField] OVRHand MYRightHand;
    [SerializeField] OVRSkeleton MYRightSkelton;
    [SerializeField] GameObject IndexSphere;
    [SerializeField] GameObject piano;
    [SerializeField] GameObject hand;
    private bool isIndexPinching;
    private bool isMiddlePinching;
    private bool isRingPinching;
    private float ThumbPinchStrength;
    bool on;
    float timer=0;
    [SerializeField] Text ontext;

    void Update()
    {
        isIndexPinching = MYRightHand.GetFingerIsPinching(OVRHand.HandFinger.Index);
        isMiddlePinching = MYRightHand.GetFingerIsPinching(OVRHand.HandFinger.Middle);
        isRingPinching = MYRightHand.GetFingerIsPinching(OVRHand.HandFinger.Ring);


        ThumbPinchStrength = MYRightHand.GetFingerPinchStrength(OVRHand.HandFinger.Thumb);

        Vector3 indexTipPos = MYRightSkelton.Bones[(int)OVRSkeleton.BoneId.Hand_IndexTip].Transform.position;
        Quaternion indexTipRotate = MYRightSkelton.Bones[(int)OVRSkeleton.BoneId.Hand_IndexTip].Transform.rotation;
        IndexSphere.transform.position = indexTipPos;
        IndexSphere.transform.rotation = indexTipRotate;

        if (isMiddlePinching)
        {
            if (timer > 2.0f)
            {
                on = true;
                ontext.text = "ハンドジェスチャーモード";
            }
            else
            {
                timer += Time.deltaTime;  //タイマー加算
            }
        }
        if (MYRightHand.GetFingerPinchStrength(OVRHand.HandFinger.Middle) >= 0.5f && MYRightHand.GetFingerPinchStrength(OVRHand.HandFinger.Index) >= 0.1f)
        {
            on = false;
            ontext.text = "Off";
            timer = 0;
        }


        if (on)
        {
            if ((isMiddlePinching))
            {

                piano.transform.Rotate(0, 1, 0);
               
            }

            if ((MYRightHand.GetFingerPinchStrength(OVRHand.HandFinger.Pinky) >= 0.05f) && (MYRightHand.GetFingerPinchStrength(OVRHand.HandFinger.Ring) >= 0.2f))
            {
                float handposX = hand.transform.position.x;
                float handposY = hand.transform.position.y;
                float handposZ = hand.transform.position.z;
                piano.transform.position = new Vector3(handposX, handposY - 1, handposZ+0.8f);
            }
        }
    }

    void OnTriggerStay(Collider other)
    {

        if (isIndexPinching)///つかんだ
        {
            other.gameObject.transform.parent = IndexSphere.transform;
            other.GetComponent<Rigidbody>().isKinematic = true;
            other.gameObject.transform.localPosition = Vector3.zero;

        }
        else///はなした
        {
            other.GetComponent<Rigidbody>().isKinematic = false;
            other.transform.parent = null;

        }
    }
}