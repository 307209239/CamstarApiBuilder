// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.GetMfgDataBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public class GetMfgDataBase : InquiryBase, IGetMfgDataBase
  {
    protected virtual ResultStatus OnGetData(
      DCObject getMfgData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("GetData");
    }

    ResultStatus IGetMfgDataBase.GetData(
      DCObject getMfgData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnGetData(getMfgData, parameters, request, out result);
    }

    ResultStatus IGetMfgDataBase.GetData()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIGetMfgDataBase\u002EGetData((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IGetMfgDataBase.GetData(DCObject getMfgData)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIGetMfgDataBase\u002EGetData(getMfgData, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IGetMfgDataBase.GetData(
      DCObject getMfgData,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIGetMfgDataBase\u002EGetData(getMfgData, (Parameters) null, request, out result);
    }
  }
}
