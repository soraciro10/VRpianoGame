using UnityEngine;





public class FingerColliderActivity : MonoBehaviour
{
	[SerializeField, Tooltip("ピンチ状態取得用OVRHand")]
	private OVRHand _ovrHand;


	[Space(10)]
	[SerializeField, Tooltip("親指コライダー")]
	private Collider _thumbCollider;

	[SerializeField, Tooltip("人差し指コライダー")]
	private Collider _indexCollider;

	[SerializeField, Tooltip("中指コライダー")]
	private Collider _middleCollider;

	[SerializeField, Tooltip("薬指コライダー")]
	private Collider _ringCollider;

	[SerializeField, Tooltip("小指コライダー")]
	private Collider _pinkyCollider;





	/// <summary>
	/// 有効性切替
	/// </summary>
	private void Update()
	{
		// 親指
		float thumbPinchStrength = _ovrHand.GetFingerPinchStrength(OVRHand.HandFinger.Thumb);
		if (_thumbCollider.enabled == (thumbPinchStrength == 0 ? false : true))
		{
			_thumbCollider.enabled = !_thumbCollider.enabled;
		}


		// 人差し指指
		float indexPinchStrength = _ovrHand.GetFingerPinchStrength(OVRHand.HandFinger.Index);
		if (_indexCollider.enabled == (indexPinchStrength == 0 ? false : true))
		{
			_indexCollider.enabled = !_indexCollider.enabled;
		}


		// 中指
		float middlePinchStrength = _ovrHand.GetFingerPinchStrength(OVRHand.HandFinger.Middle);
		if (_middleCollider.enabled == (middlePinchStrength == 0 ? false : true))
		{
			_middleCollider.enabled = !_middleCollider.enabled;
		}


		// 薬指
		float ringPinchStrength = _ovrHand.GetFingerPinchStrength(OVRHand.HandFinger.Ring);
		if (_ringCollider.enabled == (ringPinchStrength == 0 ? false : true))
		{
			_ringCollider.enabled = !_ringCollider.enabled;
		}


		// 小指
		float pinkyPinchStrength = _ovrHand.GetFingerPinchStrength(OVRHand.HandFinger.Pinky);
		if (_pinkyCollider.enabled == (pinkyPinchStrength == 0 ? false : true))
		{
			_pinkyCollider.enabled = !_pinkyCollider.enabled;
		}
	}
}