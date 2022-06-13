using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpgrades : MonoBehaviour
{
    
    public void UpgradeHarpoon()
    {
        if (SharedResources.harpoonLevel < 4)
        {
            if (SharedResources.gold >= 100 * SharedResources.harpoonLevel)
            {
                SharedResources.gold -= 100 * SharedResources.harpoonLevel;
                SharedResources.harpoonLevel++;
               // return "Upgrade Complete";
            }
           // return "Not Enough Money";
        }
       // return "Already Fully Upgraded";
    }

    public void UpgradeAnchor()
    {
        if (SharedResources.anchorLevel < 4)
        {
            if (SharedResources.gold >= 100 * SharedResources.anchorLevel)
            {
                SharedResources.gold -= 100 * SharedResources.anchorLevel;
                SharedResources.anchorLevel++;
               // return "Upgrade Complete";
            }
           // return "Not Enough Money";
        }
        //return "Already Fully Upgraded";
    }
}
