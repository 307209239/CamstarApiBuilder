// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.AuthenticationService
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System;

namespace Camstar.WCF.Service
{
  public class AuthenticationService : ServiceBase, IAuthenticationService
  {
    public ResultStatus Login(UserProfile userProfile, out SessionData sessionData)
    {
      sessionData = new SessionData();
      try
      {
        ResultStatus resultStatus = new ResultStatus();
        ServerManager serverManager = new ServerManager(this.GetType().Name, userProfile);
        serverManager.Login(sessionData, resultStatus);
        serverManager.Close();
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
