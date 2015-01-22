using UnityEngine;
using System.Collections;

public class RandomGenerator : MonoBehaviour {
	public static int Difficulty = 1;
	public GameObject cubePrefab;
	void Awake() {
		StartCoroutine(GenerateCube());
		Debug.Log ("Working");
	}
	int[] array;
	public int[] GenerateCoordArray(int min, int max, int size, int range) {
		int[] rArray = new int[size*2];
		for (int i = 0; i < size*2; i++) {
			rArray[i] = Random.Range(min, max);
			if (i + 1 != 2 && (i + 1) % 2 == 0) {
				for (int j = i; j > 1; j-=2) {
					if (((rArray[j] >= rArray[j-2] - range) && (rArray[j] <= rArray[j-2] + range)) && 
					    ((rArray[j-1] >= rArray[j-3] - range) && (rArray[j-1] <= rArray[j-3] + range))) {
						rArray[j] = Random.Range(min,max);
						rArray[j-1] = Random.Range(min,max);
						j+=2;
					}
				}
			}
		}
		return rArray;
	}

	public IEnumerator GenerateCube() {
		while (Difficulty == 0) {	//easy
			array = GenerateCoordArray (-8,8,10,3);

			for(int i = 0; i+1 < array.Length; i++){
				int x = array[i];
				int y = array[i+1];
				Vector3 position = new Vector3(x, y, GameObject.Find("Head").transform.position.z + 50); //spawning cubes 
				Instantiate(cubePrefab, position, Quaternion.identity);
			}

			yield return new WaitForSeconds(0.4f);
		}

		while (Difficulty == 1) {	//medium
			array = GenerateCoordArray (-8,8,14,3);
			
			for(int i = 0; i+1 < array.Length; i++){
				int x = array[i];
				int y = array[i+1];
				Vector3 position = new Vector3(x, y, GameObject.Find("Head").transform.position.z + 50); //spawning cubes 
				Instantiate(cubePrefab, position, Quaternion.identity);
			}
			
			yield return new WaitForSeconds(0.4f);
		}

		while (Difficulty == 2) {	//hard
			array = GenerateCoordArray (-8,8,18,3);
			
			for(int i = 0; i+1 < array.Length; i++){
				int x = array[i];
				int y = array[i+1];
				Vector3 position = new Vector3(x, y, GameObject.Find("Head").transform.position.z + 50); //spawning cubes 
				Instantiate(cubePrefab, position, Quaternion.identity);
			}
			
			yield return new WaitForSeconds(0.4f);
		}
	}



}
