// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ServiceBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public class ServiceBase : WCFService, IServiceBase
  {
    protected virtual ResultStatus OnGetWIPMsgs(
      DCObject service,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("GetWIPMsgs");
    }

    ResultStatus IServiceBase.GetWIPMsgs(
      DCObject service,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnGetWIPMsgs(service, parameters, request, out result);
    }

    ResultStatus IServiceBase.GetWIPMsgs()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIServiceBase\u002EGetWIPMsgs((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IServiceBase.GetWIPMsgs(DCObject service)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIServiceBase\u002EGetWIPMsgs(service, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IServiceBase.GetWIPMsgs(
      DCObject service,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIServiceBase\u002EGetWIPMsgs(service, (Parameters) null, request, out result);
    }
  }
}
