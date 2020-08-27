// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CompleteActivityDispositionBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public class CompleteActivityDispositionBase : CompleteActivityBase, ICompleteActivityDispositionBase
  {
    protected virtual ResultStatus OnGetDispositionDetails(
      DCObject completeActivityDisposition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("GetDispositionDetails");
    }

    ResultStatus ICompleteActivityDispositionBase.GetDispositionDetails(
      DCObject completeActivityDisposition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnGetDispositionDetails(completeActivityDisposition, parameters, request, out result);
    }

    ResultStatus ICompleteActivityDispositionBase.GetDispositionDetails()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EICompleteActivityDispositionBase\u002EGetDispositionDetails((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus ICompleteActivityDispositionBase.GetDispositionDetails(
      DCObject completeActivityDisposition)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EICompleteActivityDispositionBase\u002EGetDispositionDetails(completeActivityDisposition, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus ICompleteActivityDispositionBase.GetDispositionDetails(
      DCObject completeActivityDisposition,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EICompleteActivityDispositionBase\u002EGetDispositionDetails(completeActivityDisposition, (Parameters) null, request, out result);
    }
  }
}
