﻿namespace ET
{
    [MessageHandler]
    public class R2C_SayGoodByeHandle:AMHandler<R2C_SayGoodBye>
    {
        protected override async ETTask Run(Session session, R2C_SayGoodBye message)
        {
            Log.Debug(message.GoodBye);
            await ETTask.CompletedTask;
        }
    }
}