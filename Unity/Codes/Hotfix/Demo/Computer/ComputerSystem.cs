

namespace ET
{
    public class ComputerAwakeSystem: AwakeSystem<Computer>
    {
        public override void Awake(Computer self)
        {
            Log.Debug("ComputerAwakeSystem");
        }
    }
    public class ComputerUpdateSystem: UpdateSystem<Computer>
    {
        public override void Update(Computer self)
        {
            Log.Debug("ComputerUpdateSystem");
        }
    }

    public class ComputerDestroySystem: DestroySystem<Computer>
    {
        public override void Destroy(Computer self)
        {
            Log.Debug("ComputerDestroySystem");
        }
    }
    
    public static class ComputerSystem
    {
        public static void Start(this Computer self)
        {
            Log.Debug("computer start!!!!!");
            self.GetComponent<PCCaseComponent>().StartPower();
            self.GetComponent<MonitorsComponent>().Display();
        }
    }
}