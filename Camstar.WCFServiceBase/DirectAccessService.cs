// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.DirectAccessService
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System;

namespace Camstar.WCF.Service
{
  public class DirectAccessService : ServiceBase, IDirectAccessService
  {
    public ResultStatus Submit(
      UserProfile userProfile,
      string inputXml,
      out string outputXml)
    {
      outputXml = (string) null;
      try
      {
        ResultStatus resultStatus = new ResultStatus();
        ServerManager serverManager = new ServerManager(this.GetType().Name, userProfile);
        outputXml = serverManager.CallDirectAccessServer(inputXml, resultStatus);
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
