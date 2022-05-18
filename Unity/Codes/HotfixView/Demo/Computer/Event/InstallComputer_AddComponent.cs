using ET.EventType;

namespace ET
{
    public class InstallComputer_AddComponent:AEvent<EventType.InstallComputer>
    {
        protected async override ETTask Run(InstallComputer a)
        {
            await TimerComponent.Instance.WaitAsync(10000);
            Computer computer = a.Computer;

            computer.AddComponent<PCCaseComponent>();
            computer.AddComponent<MonitorsComponent>();
            computer.AddComponent<MouseComponent>();
            computer.AddComponent<KeyBoardComponent>();
            //computer.Start();
            await ETTask.CompletedTask;
        }
    }
}