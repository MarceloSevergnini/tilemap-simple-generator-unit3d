using UnityEngine;
using System.Collections;

public class GenerateFloor : MonoBehaviour {

    public GameObject[] objects;
    public int largura;
    public int altura;
    public int[] contructor;
    private int[,] position;

	void Start () {
        position = new int[largura, altura];
        for(int i = 0;i< contructor.Length; i++) {
            contructor[i] = Random.Range(0,3);
            Debug.Log(contructor[i]);
        }

        if ((largura * altura) > contructor.Length) {
            Debug.Log("size of list need be bigger than width * height");
        }
        for (int x = 0; x < largura;x++) {
            for (int y = 0;y< altura;y++) {
                position[x, y] = contructor[(x * altura) + y];
            }
        }
        for (int i = 0; i < largura; i++) {
            for (int j = 0; j < altura; j++) {
                Vector3 positionBidimencional = new Vector3(i,j,0);
                if (position[i,j] < objects.Length) {
                    Instantiate(objects[position[i, j]], positionBidimencional,transform.rotation);
                } 
                else {
                    Debug.Log("Item not exists, please check");
                }
            }
        }
    }
	
	
	void Update () {
	
	}
}
