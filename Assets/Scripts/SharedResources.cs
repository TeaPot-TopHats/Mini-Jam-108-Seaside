using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SharedResources
{
    public static bool IsGameOver { get; set; }
    public static int gold { get; set; }
    public static float depth { get; set; }
    public static int harpoonLevel { get; set; }
    public static int anchorLevel { get; set; }
    public static bool count { get; set; }

<<<<<<< HEAD
   

=======
    static SharedResources()
    {
        harpoonLevel = 1;
        anchorLevel = 1;
    }
>>>>>>> 3f853ea034d428a8e55b338515f95333007b6b85
public static string UpgradeHarpoon()
    {
        if (harpoonLevel < 4)
        {
            if (gold >= 100 * harpoonLevel)
            {
                gold -= 100 * harpoonLevel;
                harpoonLevel++;
                return "Upgrade Complete";
            }
            return "Not Enough Money";
        }
        return "Already Fully Upgraded";
    }

    public static string UpgradeAnchor()
    {
        if (anchorLevel < 4)
        {
            if(gold >= 100 * anchorLevel)
            {
                gold -= 100 * anchorLevel;
                anchorLevel++;
                return "Upgrade Complete";
            }
            return "Not Enough Money";
        }
        return "Already Upgraded";
    }

   

}
