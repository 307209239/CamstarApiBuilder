// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public class UpdateBase : ServiceBase, IUpdateBase
  {
    protected virtual ResultStatus OnLoad(
      DCObject update,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("Load");
    }

    ResultStatus IUpdateBase.Load(
      DCObject update,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnLoad(update, parameters, request, out result);
    }

    ResultStatus IUpdateBase.Load()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIUpdateBase\u002ELoad((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IUpdateBase.Load(DCObject update)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIUpdateBase\u002ELoad(update, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IUpdateBase.Load(
      DCObject update,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIUpdateBase\u002ELoad(update, (Parameters) null, request, out result);
    }
  }
}
