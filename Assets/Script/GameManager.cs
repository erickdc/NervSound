using UnityEngine;

using System.Collections;

public class GameManager : MonoBehaviour {

    float[] posX;
	
	float TimeK ;
	public GameObject Key;
	// Use this for initialization
	void Start () {
        this.TimeK = 0.0f;
        posX=new float[4];
	    posX[0] = -5.296273f;
		

	    for (int i = 1; i < posX.Length; i++)
	        posX[i] = posX[i - 1] + 3.418167f;

	}
	
	// Update is called once per frame
	void Update () {

		if (TimeK > 30) {

			GameObject key;
            key = (GameObject)GameObject.Instantiate(Key, new Vector3(RandomPosX(), 5.5f, 0.0f), Quaternion.identity);
			TimeK=0.0f;
		}
		TimeK++;
	}

	float RandomPosX()
	{
	    int N =Random.Range(1, 5);
	    return posX[N - 1];
	}
}
