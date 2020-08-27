// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ExportImportInquiryBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public class ExportImportInquiryBase : InquiryBase, IExportImportInquiryBase
  {
    protected virtual ResultStatus OnGetStatusDetails(
      DCObject exportImportInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("GetStatusDetails");
    }

    ResultStatus IExportImportInquiryBase.GetStatusDetails(
      DCObject exportImportInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnGetStatusDetails(exportImportInquiry, parameters, request, out result);
    }

    ResultStatus IExportImportInquiryBase.GetStatusDetails()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIExportImportInquiryBase\u002EGetStatusDetails((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IExportImportInquiryBase.GetStatusDetails(
      DCObject exportImportInquiry)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIExportImportInquiryBase\u002EGetStatusDetails(exportImportInquiry, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IExportImportInquiryBase.GetStatusDetails(
      DCObject exportImportInquiry,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIExportImportInquiryBase\u002EGetStatusDetails(exportImportInquiry, (Parameters) null, request, out result);
    }
  }
}
