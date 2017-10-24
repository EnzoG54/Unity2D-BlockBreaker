using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;
	public float minx, maxx;
	private Ball ball;

	void Start() {
		ball = GameObject.FindObjectOfType<Ball> ();
		print (ball);
	}

	// Update is called once per frame
	void Update () {
		if (!autoPlay) {
			MoveWithMouse ();
		} else {
			AutoPlay();
		}
	}

	void AutoPlay() {
		Vector3 paddlePos = new Vector3 (minx, this.transform.position.y, 0f);
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp(ballPos.x, minx, maxx);
		this.transform.position = paddlePos;
	}

	void MoveWithMouse() {
		Vector3 paddlePos = new Vector3 (minx, this.transform.position.y, 0f);
		float mousePosInBlocks = Input.mousePosition.x /Screen.width * 16;
		paddlePos.x = Mathf.Clamp(mousePosInBlocks, minx, maxx);
		this.transform.position = paddlePos;
	}

	// 1.3 / 14.5
	
}
