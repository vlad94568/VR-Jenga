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
        //if (layer % 2 == 0)

        int x = 0; // TODO: fix this to zero.
        float y = 1.015906f + layer * block.transform.localScale.y;

        for(int z=0; z<blocksPerLayer; z++)
        {
            GameObject blockClone = Instantiate(block);

            blockClone.transform.position = new Vector3(
                x * block.transform.localScale.x, 
                y, 
                1
            );

            blockClone.SetActive(true);

            x++;
        }
    }
}
