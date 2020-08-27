// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReportMappingConfigMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ReportMappingConfigMaintService : NamedDataObjectMaintBase
  {
    public ReportMappingConfigMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IReportMappingConfigMaintService), userProfile);
    }

    public ResultStatus Delete(
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Parameters parameters,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      result = (ReportMappingConfigMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) reportMappingConfigMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportMappingConfigMaintService) this._Channel).Delete(this._UserProfile, reportMappingConfigMaint, parameters, request, out result) : this.AddMethod((Method) new ReportMappingConfigMaintMethod(reportMappingConfigMaint, ReportMappingConfigMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) reportMappingConfigMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ReportMappingConfigMaint) null, (ReportMappingConfigMaint_Parameters) null, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus Delete(ReportMappingConfigMaint reportMappingConfigMaint)
    {
      return this.Delete(reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) null, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus Delete(
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      return this.Delete(reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Parameters parameters,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      result = (ReportMappingConfigMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) reportMappingConfigMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportMappingConfigMaintService) this._Channel).Freeze(this._UserProfile, reportMappingConfigMaint, parameters, request, out result) : this.AddMethod((Method) new ReportMappingConfigMaintMethod(reportMappingConfigMaint, ReportMappingConfigMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) reportMappingConfigMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ReportMappingConfigMaint) null, (ReportMappingConfigMaint_Parameters) null, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus Freeze(ReportMappingConfigMaint reportMappingConfigMaint)
    {
      return this.Freeze(reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) null, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus Freeze(
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      return this.Freeze(reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Parameters parameters,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      result = (ReportMappingConfigMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) reportMappingConfigMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportMappingConfigMaintService) this._Channel).GetWIPMsgs(this._UserProfile, reportMappingConfigMaint, parameters, request, out result) : this.AddMethod((Method) new ReportMappingConfigMaintMethod(reportMappingConfigMaint, ReportMappingConfigMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) reportMappingConfigMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ReportMappingConfigMaint) null, (ReportMappingConfigMaint_Parameters) null, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ReportMappingConfigMaint reportMappingConfigMaint)
    {
      return this.GetWIPMsgs(reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) null, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      return this.GetWIPMsgs(reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Parameters parameters,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      result = (ReportMappingConfigMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) reportMappingConfigMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportMappingConfigMaintService) this._Channel).Load(this._UserProfile, reportMappingConfigMaint, parameters, request, out result) : this.AddMethod((Method) new ReportMappingConfigMaintMethod(reportMappingConfigMaint, ReportMappingConfigMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) reportMappingConfigMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ReportMappingConfigMaint) null, (ReportMappingConfigMaint_Parameters) null, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus Load(ReportMappingConfigMaint reportMappingConfigMaint)
    {
      return this.Load(reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) null, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus Load(
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      return this.Load(reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_LoadESigDetails_Parameters parameters,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      result = (ReportMappingConfigMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) reportMappingConfigMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportMappingConfigMaintService) this._Channel).LoadESigDetails(this._UserProfile, reportMappingConfigMaint, parameters, request, out result) : this.AddMethod((Method) new ReportMappingConfigMaintMethod(reportMappingConfigMaint, ReportMappingConfigMaintMethods.LoadESigDetails, (ReportMappingConfigMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) reportMappingConfigMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ReportMappingConfigMaint) null, (ReportMappingConfigMaint_LoadESigDetails_Parameters) null, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ReportMappingConfigMaint reportMappingConfigMaint)
    {
      return this.LoadESigDetails(reportMappingConfigMaint, (ReportMappingConfigMaint_LoadESigDetails_Parameters) null, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      return this.LoadESigDetails(reportMappingConfigMaint, (ReportMappingConfigMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Parameters parameters,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      result = (ReportMappingConfigMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) reportMappingConfigMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportMappingConfigMaintService) this._Channel).New(this._UserProfile, reportMappingConfigMaint, parameters, request, out result) : this.AddMethod((Method) new ReportMappingConfigMaintMethod(reportMappingConfigMaint, ReportMappingConfigMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) reportMappingConfigMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ReportMappingConfigMaint) null, (ReportMappingConfigMaint_Parameters) null, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus New(ReportMappingConfigMaint reportMappingConfigMaint)
    {
      return this.New(reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) null, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus New(
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      return this.New(reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Parameters parameters,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      result = (ReportMappingConfigMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) reportMappingConfigMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportMappingConfigMaintService) this._Channel).NewCopy(this._UserProfile, reportMappingConfigMaint, parameters, request, out result) : this.AddMethod((Method) new ReportMappingConfigMaintMethod(reportMappingConfigMaint, ReportMappingConfigMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) reportMappingConfigMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ReportMappingConfigMaint) null, (ReportMappingConfigMaint_Parameters) null, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus NewCopy(ReportMappingConfigMaint reportMappingConfigMaint)
    {
      return this.NewCopy(reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) null, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus NewCopy(
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      return this.NewCopy(reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Parameters parameters,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      result = (ReportMappingConfigMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) reportMappingConfigMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportMappingConfigMaintService) this._Channel).SaveAs(this._UserProfile, reportMappingConfigMaint, parameters, request, out result) : this.AddMethod((Method) new ReportMappingConfigMaintMethod(reportMappingConfigMaint, ReportMappingConfigMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) reportMappingConfigMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ReportMappingConfigMaint) null, (ReportMappingConfigMaint_Parameters) null, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus SaveAs(ReportMappingConfigMaint reportMappingConfigMaint)
    {
      return this.SaveAs(reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) null, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus SaveAs(
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      return this.SaveAs(reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Parameters parameters,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      result = (ReportMappingConfigMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) reportMappingConfigMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportMappingConfigMaintService) this._Channel).UnFreeze(this._UserProfile, reportMappingConfigMaint, parameters, request, out result) : this.AddMethod((Method) new ReportMappingConfigMaintMethod(reportMappingConfigMaint, ReportMappingConfigMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) reportMappingConfigMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ReportMappingConfigMaint) null, (ReportMappingConfigMaint_Parameters) null, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus UnFreeze(ReportMappingConfigMaint reportMappingConfigMaint)
    {
      return this.UnFreeze(reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) null, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      return this.UnFreeze(reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject reportMappingConfigMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportMappingConfigMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ReportMappingConfigMaint) reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) parameters, (ReportMappingConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject reportMappingConfigMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportMappingConfigMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ReportMappingConfigMaint) reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) parameters, (ReportMappingConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject reportMappingConfigMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportMappingConfigMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ReportMappingConfigMaint) reportMappingConfigMaint, (ReportMappingConfigMaint_LoadESigDetails_Parameters) parameters, (ReportMappingConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject reportMappingConfigMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportMappingConfigMaint_Result result1;
        ResultStatus resultStatus = this.New((ReportMappingConfigMaint) reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) parameters, (ReportMappingConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject reportMappingConfigMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportMappingConfigMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ReportMappingConfigMaint) reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) parameters, (ReportMappingConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject reportMappingConfigMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportMappingConfigMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ReportMappingConfigMaint) reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) parameters, (ReportMappingConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject reportMappingConfigMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportMappingConfigMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ReportMappingConfigMaint) reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) parameters, (ReportMappingConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject reportMappingConfigMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportMappingConfigMaint_Result result1;
        ResultStatus resultStatus = this.Load((ReportMappingConfigMaint) reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) parameters, (ReportMappingConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject reportMappingConfigMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReportMappingConfigMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ReportMappingConfigMaint) reportMappingConfigMaint, (ReportMappingConfigMaint_Parameters) parameters, (ReportMappingConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      result = (ReportMappingConfigMaint_Result) null;
      try
      {
        ReportMappingConfigMaintMethod[] methods = new ReportMappingConfigMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IReportMappingConfigMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ReportMappingConfigMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ReportMappingConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReportMappingConfigMaint cdo,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      result = (ReportMappingConfigMaint_Result) null;
      try
      {
        return ((IReportMappingConfigMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ReportMappingConfigMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ReportMappingConfigMaint) cdo, (ReportMappingConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      return this.GetEnvironment((ReportMappingConfigMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ReportMappingConfigMaint cdo,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      result = (ReportMappingConfigMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReportMappingConfigMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ReportMappingConfigMaintMethod(cdo, ReportMappingConfigMaintMethods.ExecuteTransaction, (ReportMappingConfigMaint_Parameters) null));
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
        ReportMappingConfigMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ReportMappingConfigMaint) cdo, (ReportMappingConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ReportMappingConfigMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ReportMappingConfigMaint_Request) null, out ReportMappingConfigMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result)
    {
      return this.ExecuteTransaction((ReportMappingConfigMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ReportMappingConfigMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ReportMappingConfigMaintMethod(cdo, ReportMappingConfigMaintMethods.AddDataTransaction, (ReportMappingConfigMaint_Parameters) null));
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
        return this.AddDataTransaction((ReportMappingConfigMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
