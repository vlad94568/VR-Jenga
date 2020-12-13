using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour
{
    public int layerNum = 100;
    public int blocksPerLayer = 3;

    public GameObject block;

    // Start is called before the first frame update
    void Start()
    {
        for(int layer=0; layer<layerNum; layer++)
        {
            buildLayer(layer);
        }
    }

    void buildLayer(int layer)
    {
        int x = 0; 
        float y = 1.015906f + layer * block.transform.localScale.y;
        float delta = block.transform.localScale.z / 3;

        for(int b=0; b<blocksPerLayer; b++)
        {
            GameObject blockClone = Instantiate(block);

            bool isRotate = layer % 2 == 0;

            if(isRotate)
            {
                blockClone.transform.position = new Vector3(
                    delta,
                    y, 
                    (x * block.transform.localScale.x) - delta + 1
                );
            }

            else
            {
                blockClone.transform.position = new Vector3(
                    x * block.transform.localScale.x, 
                    y, 
                    1
                );
            }


            if(isRotate)
            {
                blockClone.transform.eulerAngles = new Vector3(
                    blockClone.transform.eulerAngles.x,
                    blockClone.transform.eulerAngles.y + 90,
                    blockClone.transform.eulerAngles.z
                );
            }

            blockClone.SetActive(true);

            x++;
        }
    }
}
