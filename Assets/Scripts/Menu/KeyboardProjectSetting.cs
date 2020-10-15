using Microsoft.MixedReality.Toolkit.Experimental.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardProjectSetting : MixedRealityKeyboardBase
{
    // Start is called before the first frame update
    public override string Text
    {
        get;
        protected set;
    } = string.Empty;
}
