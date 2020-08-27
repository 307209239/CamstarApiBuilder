// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DocumentMaintBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public class DocumentMaintBase : RevisionedObjectMaintBase, IDocumentMaintBase
  {
    protected virtual ResultStatus OnDownloadFile(
      DCObject documentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("DownloadFile");
    }

    ResultStatus IDocumentMaintBase.DownloadFile(
      DCObject documentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnDownloadFile(documentMaint, parameters, request, out result);
    }

    ResultStatus IDocumentMaintBase.DownloadFile()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIDocumentMaintBase\u002EDownloadFile((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IDocumentMaintBase.DownloadFile(
      DCObject documentMaint)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIDocumentMaintBase\u002EDownloadFile(documentMaint, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IDocumentMaintBase.DownloadFile(
      DCObject documentMaint,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIDocumentMaintBase\u002EDownloadFile(documentMaint, (Parameters) null, request, out result);
    }
  }
}
