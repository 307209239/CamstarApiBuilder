// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RevisionedObjectMaintBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public class RevisionedObjectMaintBase : MaintenanceBase, IRevisionedObjectMaintBase
  {
    protected virtual ResultStatus OnDeleteAllRevisions(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("DeleteAllRevisions");
    }

    ResultStatus IRevisionedObjectMaintBase.DeleteAllRevisions(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnDeleteAllRevisions(revisionedObjectMaint, parameters, request, out result);
    }

    ResultStatus IRevisionedObjectMaintBase.DeleteAllRevisions()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIRevisionedObjectMaintBase\u002EDeleteAllRevisions((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IRevisionedObjectMaintBase.DeleteAllRevisions(
      DCObject revisionedObjectMaint)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIRevisionedObjectMaintBase\u002EDeleteAllRevisions(revisionedObjectMaint, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IRevisionedObjectMaintBase.DeleteAllRevisions(
      DCObject revisionedObjectMaint,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIRevisionedObjectMaintBase\u002EDeleteAllRevisions(revisionedObjectMaint, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnNewRev(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("NewRev");
    }

    ResultStatus IRevisionedObjectMaintBase.NewRev(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnNewRev(revisionedObjectMaint, parameters, request, out result);
    }

    ResultStatus IRevisionedObjectMaintBase.NewRev()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIRevisionedObjectMaintBase\u002ENewRev((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IRevisionedObjectMaintBase.NewRev(
      DCObject revisionedObjectMaint)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIRevisionedObjectMaintBase\u002ENewRev(revisionedObjectMaint, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IRevisionedObjectMaintBase.NewRev(
      DCObject revisionedObjectMaint,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIRevisionedObjectMaintBase\u002ENewRev(revisionedObjectMaint, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnNewRevCopy(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("NewRevCopy");
    }

    ResultStatus IRevisionedObjectMaintBase.NewRevCopy(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnNewRevCopy(revisionedObjectMaint, parameters, request, out result);
    }

    ResultStatus IRevisionedObjectMaintBase.NewRevCopy()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIRevisionedObjectMaintBase\u002ENewRevCopy((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IRevisionedObjectMaintBase.NewRevCopy(
      DCObject revisionedObjectMaint)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIRevisionedObjectMaintBase\u002ENewRevCopy(revisionedObjectMaint, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IRevisionedObjectMaintBase.NewRevCopy(
      DCObject revisionedObjectMaint,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIRevisionedObjectMaintBase\u002ENewRevCopy(revisionedObjectMaint, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnSaveAsRev(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("SaveAsRev");
    }

    ResultStatus IRevisionedObjectMaintBase.SaveAsRev(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnSaveAsRev(revisionedObjectMaint, parameters, request, out result);
    }

    ResultStatus IRevisionedObjectMaintBase.SaveAsRev()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIRevisionedObjectMaintBase\u002ESaveAsRev((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IRevisionedObjectMaintBase.SaveAsRev(
      DCObject revisionedObjectMaint)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIRevisionedObjectMaintBase\u002ESaveAsRev(revisionedObjectMaint, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IRevisionedObjectMaintBase.SaveAsRev(
      DCObject revisionedObjectMaint,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIRevisionedObjectMaintBase\u002ESaveAsRev(revisionedObjectMaint, (Parameters) null, request, out result);
    }
  }
}
