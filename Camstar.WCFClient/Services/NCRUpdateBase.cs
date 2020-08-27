// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NCRUpdateBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public class NCRUpdateBase : NCRTxnBase, INCRUpdateBase
  {
    protected virtual ResultStatus OnGetAttributes(
      DCObject nCRUpdate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("GetAttributes");
    }

    ResultStatus INCRUpdateBase.GetAttributes(
      DCObject nCRUpdate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnGetAttributes(nCRUpdate, parameters, request, out result);
    }

    ResultStatus INCRUpdateBase.GetAttributes()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EINCRUpdateBase\u002EGetAttributes((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus INCRUpdateBase.GetAttributes(DCObject nCRUpdate)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EINCRUpdateBase\u002EGetAttributes(nCRUpdate, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus INCRUpdateBase.GetAttributes(
      DCObject nCRUpdate,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EINCRUpdateBase\u002EGetAttributes(nCRUpdate, (Parameters) null, request, out result);
    }
  }
}
