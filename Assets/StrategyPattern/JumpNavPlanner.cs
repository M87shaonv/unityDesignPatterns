﻿using UnityEngine;

namespace StrategyPattern
{
    public class JumpNavPlanner : AbstractNavPlanner
    {
        public override Vector3[] GetNavPath(Vector3 startPos, Vector3 endPos)
        {
            // 返回一个包含起始点、跳跃高点和终点的路径
            return new[] { startPos, startPos + (endPos / 2) + Vector3.up, endPos, };
        }
    }
}