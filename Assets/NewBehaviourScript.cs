using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using System.Threading.Tasks;

public class NewBehaviourScript : MonoBehaviour
    
{
    public PathCreator pathCreator;
    public float speed = 2;
    float distanceTravelled;
    void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
    }
    // Start is called before the first frame update
    //float xp, yp;
    //int m;
    //int q = 0;

    //public GameObject mob;
    //void Start()
    //{


    //    pon[0, 0] = -0.800000012f;
    //    pon[0, 1] = 4.92000008f;
    //    pon[1, 0] = 0.939999998f;
    //    pon[1, 1] = 5.17000008f;
    //    pon[2, 0] = 1.44000006f;
    //    pon[2, 1] = 8.60999966f;
    //    pon[3, 0] = 5.01000023f;
    //    pon[3, 1] = 8.60999966f;
    //    pon[4, 0] = 5.80000019f;
    //    pon[4, 1] = 2.93000007f;
    //    pon[5, 0] = 10.8999996f;
    //    pon[5, 1] = 2.68000007f;
    //    pon[6, 0] = 11.6000004f;
    //    pon[6, 1] = 5.71000004f;
    //    pon[7, 0] = 18.5300007f;
    //    pon[7, 1] = 5.84000015f;
    //    //pon[8, 0] = 17.7199993f;
    //    //pon[8, 1] = 5.88999987f;
    //    //transform.localPosition = new Vector3(pon[0,0], pon[0,1], 0);
    //    xp = pon[0, 0];
    //    yp = pon[0, 1];
    //}
    //float[,] pon = new float[9, 2];

    // Update is called once per frame
    //void Update()
    //{
        
    //    for (int i = 0; i < 7; i++)
    //        if (mob.transform.localPosition.x >= pon[i, 0] - 1 && mob.transform.localPosition.x <= pon[i, 0] + 1)
        


    //        StartCoroutine(walk());
    //        //else q = 0;
    //        //xp = pon[m + 1, 0];
    //        //yp = pon[m + 1, 1];
    //        //mob.transform.localPosition = new Vector3(xp, yp, 0);
    //    }
        

    //    IEnumerator walk()
    //    {
    

    //        for (int i = 0; i < 7; i++)
    //        {

    //            if (mob.transform.localPosition.x >= pon[i, 0] - 1 && mob.transform.localPosition.x <= pon[i, 0] + 1)
    //            {

            
    //        if (i < 7)
    //        {

    //            if (mob.transform.localPosition.x >= pon[i, 0] - 1 && mob.transform.localPosition.x <= pon[i, 0] + 1)
    //            {

    //                float xt = 0;
    //                float yt = 0;

    //                xt = (pon[i + 1, 0] - pon[i, 0]) / 32.0f;
    //                yt = (pon[i + 1, 1] - pon[i, 1]) / 32.0f; ;
    //                for (int g = 0; g < 32; g++)
    //                {
    //                    yield return new WaitForSeconds(10f);
    //                    xp += xt;
    //                    yp += yt;
    //                    mob.transform.localPosition = new Vector3(xp, yp, 0);

    //                }
    //            }
    //            //i++;
    //        }
    //        //else i = 0;
    //    }
    
    //}
    //}
}