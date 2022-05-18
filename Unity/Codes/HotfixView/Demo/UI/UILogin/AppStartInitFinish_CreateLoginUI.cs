

using UnityEngine;
using Vector3 = System.Numerics.Vector3;

namespace ET
{
	public class AppStartInitFinish_RemoveLoginUI: AEvent<EventType.AppStartInitFinish>
	{
		protected override async ETTask Run(EventType.AppStartInitFinish args)
		{
			await UIHelper.Create(args.ZoneScene, UIType.UILogin);


			Computer computer = args.ZoneScene.AddChild<Computer>();
			//同步事件
			//Game.EventSystem.Publish(new EventType.InstallComputer() { Computer = computer});
			//异步事件
			await Game.EventSystem.Publish(new EventType.InstallComputer() { Computer = computer});
			computer.Start();
			/*
			computer.AddChild<PCCaseComponent>();
			computer.AddChild<MonitorsComponent>();
			computer.AddChild<KeyBoardComponent>();
			computer.AddChild<MouseComponent>();
			
			computer.Start();

			await TimerComponent.Instance.WaitAsync(3000);
			
			computer.Dispose();

			UnitConfig config = UnitConfigCategory.Instance.Get(1001);
			Log.Debug(config.Name);
			var allUnitConfig = UnitConfigCategory.Instance.GetAll();
			foreach (var unitConfig in allUnitConfig.Values)
			{
				Log.Debug(unitConfig.Name);
				Log.Debug(unitConfig.TestValue.ToString());
			}

			UnitConfig heightConfig = UnitConfigCategory.Instance.GetUnitConigByHeight(178);
			
			Log.Debug(heightConfig.Name);
			*/


			Log.Debug("aaaaaaaaaaaaaaaaaaa");
			//await this.TestAsync();//a1b2
			this.TestAsync().Coroutine();//a1b2
			Log.Debug("bbbbbbbbbbbbbbbbbbb");

			ETCancellationToken etCancellationToken = new ETCancellationToken();
			MoveToAsync(Vector3.Zero, etCancellationToken).Coroutine();
			etCancellationToken.Cancel();
		}

		public async ETTask TestAsync()
		{
			Log.Debug("111111111111111111111111111111");
			await TimerComponent.Instance.WaitAsync(2000);
			Log.Debug("222222222222222222222222222222");
			
			await ETTask.CompletedTask;
		}

		public async ETTask MoveToAsync(Vector3 pos,ETCancellationToken cancellationToken)
		{
			Log.Debug("MOve Start!!!");
			bool ret =await TimerComponent.Instance.WaitAsync(3000,cancellationToken);
			if (ret)
			{
				Log.Debug("Move OVer!!!");
			}
			else
			{
				Log.Debug("Move Stop!!!");
			}
			

			await ETTask.CompletedTask;
		}
	}
}
