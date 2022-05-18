using System.Collections.Generic;
using System.Numerics;

namespace ET
{
    public partial class UnitConfig
    {
        public Vector3 TestValue;
    }

    public class TestVector3
    {
        public Vector3 TestValue;
    }

    public partial class UnitConfigCategory
    {
        public List<TestVector3> TestVector3s = new List<TestVector3>();
        public override void AfterEndInit() 
        {
            base.AfterEndInit();
            foreach (UnitConfig config in this.dict.Values)
            {
                config.TestValue = new Vector3(config.Position, config.Height, config.Weight);
                TestVector3s.Add(new TestVector3(){TestValue = config.TestValue});
            }
        }

        public UnitConfig GetUnitConigByHeight(int height)
        {
            UnitConfig unitConfig = null;

            foreach (UnitConfig info in this.dict.Values)
            {
                if (info.Height == height)
                {
                    unitConfig = info;
                    break;
                }
            }

            return unitConfig;
        }
    }
}