// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CompleteActivityBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public class CompleteActivityBase : ProcessObjectTxnBase, ICompleteActivityBase
  {
    protected virtual ResultStatus OnGetChecklistEntries(
      DCObject completeActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("GetChecklistEntries");
    }

    ResultStatus ICompleteActivityBase.GetChecklistEntries(
      DCObject completeActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnGetChecklistEntries(completeActivity, parameters, request, out result);
    }

    ResultStatus ICompleteActivityBase.GetChecklistEntries()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EICompleteActivityBase\u002EGetChecklistEntries((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus ICompleteActivityBase.GetChecklistEntries(
      DCObject completeActivity)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EICompleteActivityBase\u002EGetChecklistEntries(completeActivity, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus ICompleteActivityBase.GetChecklistEntries(
      DCObject completeActivity,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EICompleteActivityBase\u002EGetChecklistEntries(completeActivity, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnLoadDataPoints(
      DCObject completeActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("LoadDataPoints");
    }

    ResultStatus ICompleteActivityBase.LoadDataPoints(
      DCObject completeActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnLoadDataPoints(completeActivity, parameters, request, out result);
    }

    ResultStatus ICompleteActivityBase.LoadDataPoints()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EICompleteActivityBase\u002ELoadDataPoints((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus ICompleteActivityBase.LoadDataPoints(
      DCObject completeActivity)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EICompleteActivityBase\u002ELoadDataPoints(completeActivity, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus ICompleteActivityBase.LoadDataPoints(
      DCObject completeActivity,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EICompleteActivityBase\u002ELoadDataPoints(completeActivity, (Parameters) null, request, out result);
    }
  }
}
