using System;
using System.Collections.Generic;

namespace Recorder
{
    [Serializable]
    public class TransformNode
    {
        public TransformData NodeTransformData;
        public List<TransformNode> ChildrenTransformsData;
    }
}