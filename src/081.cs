﻿using System;
using System.Collections.Generic;
using System.Text;
public partial class Solution
{
    public bool Search(int[] nums, int target,int removeme = 0)
    {
        for (var i = 0; i < nums.Length; ++i)
        {
            if (nums[i] == target)
            { return true; }
        }
        return false;
    }
}