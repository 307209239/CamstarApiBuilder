// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReportTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ReportTemplateMaintService : DocumentMaintBase
  {
    public ReportTemplateMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IReportTemplateMaintService), userProfile);
    }

    public ResultStatus Delete(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      result = (ReportTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportTemplateMaintService) this._Channel).Delete(this._UserProfile, reportTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ReportTemplateMaintMethod(reportTemplateMaint, ReportTemplateMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ReportTemplateMaint) null, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus Delete(ReportTemplateMaint reportTemplateMaint)
    {
      return this.Delete(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus Delete(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      return this.Delete(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      result = (ReportTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportTemplateMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, reportTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ReportTemplateMaintMethod(reportTemplateMaint, ReportTemplateMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((ReportTemplateMaint) null, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(ReportTemplateMaint reportTemplateMaint)
    {
      return this.DeleteAllRevisions(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      return this.DeleteAllRevisions(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus DownloadFile(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      result = (ReportTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (DownloadFile), (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportTemplateMaintService) this._Channel).DownloadFile(this._UserProfile, reportTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ReportTemplateMaintMethod(reportTemplateMaint, ReportTemplateMaintMethods.DownloadFile, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DownloadFile), res, (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DownloadFile()
    {
      return this.DownloadFile((ReportTemplateMaint) null, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus DownloadFile(ReportTemplateMaint reportTemplateMaint)
    {
      return this.DownloadFile(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus DownloadFile(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      return this.DownloadFile(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      result = (ReportTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportTemplateMaintService) this._Channel).Freeze(this._UserProfile, reportTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ReportTemplateMaintMethod(reportTemplateMaint, ReportTemplateMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ReportTemplateMaint) null, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus Freeze(ReportTemplateMaint reportTemplateMaint)
    {
      return this.Freeze(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus Freeze(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      return this.Freeze(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      result = (ReportTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportTemplateMaintService) this._Channel).GetWIPMsgs(this._UserProfile, reportTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ReportTemplateMaintMethod(reportTemplateMaint, ReportTemplateMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ReportTemplateMaint) null, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ReportTemplateMaint reportTemplateMaint)
    {
      return this.GetWIPMsgs(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      return this.GetWIPMsgs(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      result = (ReportTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportTemplateMaintService) this._Channel).Load(this._UserProfile, reportTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ReportTemplateMaintMethod(reportTemplateMaint, ReportTemplateMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ReportTemplateMaint) null, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus Load(ReportTemplateMaint reportTemplateMaint)
    {
      return this.Load(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus Load(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      return this.Load(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_LoadESigDetails_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      result = (ReportTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportTemplateMaintService) this._Channel).LoadESigDetails(this._UserProfile, reportTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ReportTemplateMaintMethod(reportTemplateMaint, ReportTemplateMaintMethods.LoadESigDetails, (ReportTemplateMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ReportTemplateMaint) null, (ReportTemplateMaint_LoadESigDetails_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ReportTemplateMaint reportTemplateMaint)
    {
      return this.LoadESigDetails(reportTemplateMaint, (ReportTemplateMaint_LoadESigDetails_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      return this.LoadESigDetails(reportTemplateMaint, (ReportTemplateMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      result = (ReportTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportTemplateMaintService) this._Channel).New(this._UserProfile, reportTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ReportTemplateMaintMethod(reportTemplateMaint, ReportTemplateMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ReportTemplateMaint) null, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus New(ReportTemplateMaint reportTemplateMaint)
    {
      return this.New(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus New(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      return this.New(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      result = (ReportTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportTemplateMaintService) this._Channel).NewCopy(this._UserProfile, reportTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ReportTemplateMaintMethod(reportTemplateMaint, ReportTemplateMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ReportTemplateMaint) null, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(ReportTemplateMaint reportTemplateMaint)
    {
      return this.NewCopy(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      return this.NewCopy(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      result = (ReportTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportTemplateMaintService) this._Channel).NewRev(this._UserProfile, reportTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ReportTemplateMaintMethod(reportTemplateMaint, ReportTemplateMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((ReportTemplateMaint) null, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus NewRev(ReportTemplateMaint reportTemplateMaint)
    {
      return this.NewRev(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus NewRev(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      return this.NewRev(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      result = (ReportTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportTemplateMaintService) this._Channel).NewRevCopy(this._UserProfile, reportTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ReportTemplateMaintMethod(reportTemplateMaint, ReportTemplateMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((ReportTemplateMaint) null, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus NewRevCopy(ReportTemplateMaint reportTemplateMaint)
    {
      return this.NewRevCopy(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      return this.NewRevCopy(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      result = (ReportTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportTemplateMaintService) this._Channel).SaveAs(this._UserProfile, reportTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ReportTemplateMaintMethod(reportTemplateMaint, ReportTemplateMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ReportTemplateMaint) null, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(ReportTemplateMaint reportTemplateMaint)
    {
      return this.SaveAs(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      return this.SaveAs(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      result = (ReportTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportTemplateMaintService) this._Channel).SaveAsRev(this._UserProfile, reportTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ReportTemplateMaintMethod(reportTemplateMaint, ReportTemplateMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((ReportTemplateMaint) null, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus SaveAsRev(ReportTemplateMaint reportTemplateMaint)
    {
      return this.SaveAsRev(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      return this.SaveAsRev(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      result = (ReportTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportTemplateMaintService) this._Channel).UnFreeze(this._UserProfile, reportTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ReportTemplateMaintMethod(reportTemplateMaint, ReportTemplateMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) reportTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ReportTemplateMaint) null, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(ReportTemplateMaint reportTemplateMaint)
    {
      return this.UnFreeze(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      return this.UnFreeze(reportTemplateMaint, (ReportTemplateMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDownloadFile(
      DCObject reportTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportTemplateMaint_Result result1;
        ResultStatus resultStatus = this.DownloadFile((ReportTemplateMaint) reportTemplateMaint, (ReportTemplateMaint_Parameters) parameters, (ReportTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject reportTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportTemplateMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((ReportTemplateMaint) reportTemplateMaint, (ReportTemplateMaint_Parameters) parameters, (ReportTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject reportTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportTemplateMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((ReportTemplateMaint) reportTemplateMaint, (ReportTemplateMaint_Parameters) parameters, (ReportTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject reportTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportTemplateMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((ReportTemplateMaint) reportTemplateMaint, (ReportTemplateMaint_Parameters) parameters, (ReportTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject reportTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportTemplateMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((ReportTemplateMaint) reportTemplateMaint, (ReportTemplateMaint_Parameters) parameters, (ReportTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject reportTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ReportTemplateMaint) reportTemplateMaint, (ReportTemplateMaint_Parameters) parameters, (ReportTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject reportTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ReportTemplateMaint) reportTemplateMaint, (ReportTemplateMaint_Parameters) parameters, (ReportTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject reportTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportTemplateMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ReportTemplateMaint) reportTemplateMaint, (ReportTemplateMaint_LoadESigDetails_Parameters) parameters, (ReportTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject reportTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportTemplateMaint_Result result1;
        ResultStatus resultStatus = this.New((ReportTemplateMaint) reportTemplateMaint, (ReportTemplateMaint_Parameters) parameters, (ReportTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject reportTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportTemplateMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ReportTemplateMaint) reportTemplateMaint, (ReportTemplateMaint_Parameters) parameters, (ReportTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject reportTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportTemplateMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ReportTemplateMaint) reportTemplateMaint, (ReportTemplateMaint_Parameters) parameters, (ReportTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject reportTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportTemplateMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ReportTemplateMaint) reportTemplateMaint, (ReportTemplateMaint_Parameters) parameters, (ReportTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject reportTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Load((ReportTemplateMaint) reportTemplateMaint, (ReportTemplateMaint_Parameters) parameters, (ReportTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject reportTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportTemplateMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ReportTemplateMaint) reportTemplateMaint, (ReportTemplateMaint_Parameters) parameters, (ReportTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      result = (ReportTemplateMaint_Result) null;
      try
      {
        ReportTemplateMaintMethod[] methods = new ReportTemplateMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IReportTemplateMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportTemplateMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ReportTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReportTemplateMaint cdo,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      result = (ReportTemplateMaint_Result) null;
      try
      {
        return ((IReportTemplateMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportTemplateMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ReportTemplateMaint) cdo, (ReportTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      return this.GetEnvironment((ReportTemplateMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ReportTemplateMaint cdo,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      result = (ReportTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportTemplateMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ReportTemplateMaintMethod(cdo, ReportTemplateMaintMethods.ExecuteTransaction, (ReportTemplateMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportTemplateMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ReportTemplateMaint) cdo, (ReportTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ReportTemplateMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ReportTemplateMaint_Request) null, out ReportTemplateMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result)
    {
      return this.ExecuteTransaction((ReportTemplateMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ReportTemplateMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ReportTemplateMaintMethod(cdo, ReportTemplateMaintMethods.AddDataTransaction, (ReportTemplateMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((ReportTemplateMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
