// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DefectBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public class DefectBase : ContainerTxnBase, IDefectBase
  {
    protected virtual ResultStatus OnGetActuals(
      DCObject defect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("GetActuals");
    }

    ResultStatus IDefectBase.GetActuals(
      DCObject defect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnGetActuals(defect, parameters, request, out result);
    }

    ResultStatus IDefectBase.GetActuals()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIDefectBase\u002EGetActuals((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IDefectBase.GetActuals(DCObject defect)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIDefectBase\u002EGetActuals(defect, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IDefectBase.GetActuals(
      DCObject defect,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIDefectBase\u002EGetActuals(defect, (Parameters) null, request, out result);
    }
  }
}
