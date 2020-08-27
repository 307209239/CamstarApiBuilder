// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ApprovalSheetTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ApprovalSheetTemplateMaintService : NamedDataObjectMaintBase
  {
    public ApprovalSheetTemplateMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IApprovalSheetTemplateMaintService), userProfile);
    }

    public ResultStatus Delete(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Parameters parameters,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      result = (ApprovalSheetTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) approvalSheetTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalSheetTemplateMaintService) this._Channel).Delete(this._UserProfile, approvalSheetTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ApprovalSheetTemplateMaintMethod(approvalSheetTemplateMaint, ApprovalSheetTemplateMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) approvalSheetTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ApprovalSheetTemplateMaint) null, (ApprovalSheetTemplateMaint_Parameters) null, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus Delete(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint)
    {
      return this.Delete(approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) null, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus Delete(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      return this.Delete(approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Parameters parameters,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      result = (ApprovalSheetTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) approvalSheetTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalSheetTemplateMaintService) this._Channel).Freeze(this._UserProfile, approvalSheetTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ApprovalSheetTemplateMaintMethod(approvalSheetTemplateMaint, ApprovalSheetTemplateMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) approvalSheetTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ApprovalSheetTemplateMaint) null, (ApprovalSheetTemplateMaint_Parameters) null, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus Freeze(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint)
    {
      return this.Freeze(approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) null, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus Freeze(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      return this.Freeze(approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Parameters parameters,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      result = (ApprovalSheetTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) approvalSheetTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalSheetTemplateMaintService) this._Channel).GetWIPMsgs(this._UserProfile, approvalSheetTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ApprovalSheetTemplateMaintMethod(approvalSheetTemplateMaint, ApprovalSheetTemplateMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) approvalSheetTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ApprovalSheetTemplateMaint) null, (ApprovalSheetTemplateMaint_Parameters) null, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint)
    {
      return this.GetWIPMsgs(approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) null, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      return this.GetWIPMsgs(approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Parameters parameters,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      result = (ApprovalSheetTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) approvalSheetTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalSheetTemplateMaintService) this._Channel).Load(this._UserProfile, approvalSheetTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ApprovalSheetTemplateMaintMethod(approvalSheetTemplateMaint, ApprovalSheetTemplateMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) approvalSheetTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ApprovalSheetTemplateMaint) null, (ApprovalSheetTemplateMaint_Parameters) null, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus Load(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint)
    {
      return this.Load(approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) null, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus Load(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      return this.Load(approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_LoadESigDetails_Parameters parameters,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      result = (ApprovalSheetTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) approvalSheetTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalSheetTemplateMaintService) this._Channel).LoadESigDetails(this._UserProfile, approvalSheetTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ApprovalSheetTemplateMaintMethod(approvalSheetTemplateMaint, ApprovalSheetTemplateMaintMethods.LoadESigDetails, (ApprovalSheetTemplateMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) approvalSheetTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ApprovalSheetTemplateMaint) null, (ApprovalSheetTemplateMaint_LoadESigDetails_Parameters) null, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint)
    {
      return this.LoadESigDetails(approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_LoadESigDetails_Parameters) null, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      return this.LoadESigDetails(approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Parameters parameters,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      result = (ApprovalSheetTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) approvalSheetTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalSheetTemplateMaintService) this._Channel).New(this._UserProfile, approvalSheetTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ApprovalSheetTemplateMaintMethod(approvalSheetTemplateMaint, ApprovalSheetTemplateMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) approvalSheetTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ApprovalSheetTemplateMaint) null, (ApprovalSheetTemplateMaint_Parameters) null, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus New(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint)
    {
      return this.New(approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) null, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus New(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      return this.New(approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Parameters parameters,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      result = (ApprovalSheetTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) approvalSheetTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalSheetTemplateMaintService) this._Channel).NewCopy(this._UserProfile, approvalSheetTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ApprovalSheetTemplateMaintMethod(approvalSheetTemplateMaint, ApprovalSheetTemplateMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) approvalSheetTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ApprovalSheetTemplateMaint) null, (ApprovalSheetTemplateMaint_Parameters) null, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint)
    {
      return this.NewCopy(approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) null, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      return this.NewCopy(approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Parameters parameters,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      result = (ApprovalSheetTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) approvalSheetTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalSheetTemplateMaintService) this._Channel).SaveAs(this._UserProfile, approvalSheetTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ApprovalSheetTemplateMaintMethod(approvalSheetTemplateMaint, ApprovalSheetTemplateMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) approvalSheetTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ApprovalSheetTemplateMaint) null, (ApprovalSheetTemplateMaint_Parameters) null, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint)
    {
      return this.SaveAs(approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) null, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      return this.SaveAs(approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Parameters parameters,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      result = (ApprovalSheetTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) approvalSheetTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalSheetTemplateMaintService) this._Channel).UnFreeze(this._UserProfile, approvalSheetTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ApprovalSheetTemplateMaintMethod(approvalSheetTemplateMaint, ApprovalSheetTemplateMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) approvalSheetTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ApprovalSheetTemplateMaint) null, (ApprovalSheetTemplateMaint_Parameters) null, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint)
    {
      return this.UnFreeze(approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) null, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      return this.UnFreeze(approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject approvalSheetTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalSheetTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ApprovalSheetTemplateMaint) approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) parameters, (ApprovalSheetTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject approvalSheetTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalSheetTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ApprovalSheetTemplateMaint) approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) parameters, (ApprovalSheetTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject approvalSheetTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalSheetTemplateMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ApprovalSheetTemplateMaint) approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_LoadESigDetails_Parameters) parameters, (ApprovalSheetTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject approvalSheetTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalSheetTemplateMaint_Result result1;
        ResultStatus resultStatus = this.New((ApprovalSheetTemplateMaint) approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) parameters, (ApprovalSheetTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject approvalSheetTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalSheetTemplateMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ApprovalSheetTemplateMaint) approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) parameters, (ApprovalSheetTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject approvalSheetTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalSheetTemplateMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ApprovalSheetTemplateMaint) approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) parameters, (ApprovalSheetTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject approvalSheetTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalSheetTemplateMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ApprovalSheetTemplateMaint) approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) parameters, (ApprovalSheetTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject approvalSheetTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalSheetTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Load((ApprovalSheetTemplateMaint) approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) parameters, (ApprovalSheetTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject approvalSheetTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalSheetTemplateMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ApprovalSheetTemplateMaint) approvalSheetTemplateMaint, (ApprovalSheetTemplateMaint_Parameters) parameters, (ApprovalSheetTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      result = (ApprovalSheetTemplateMaint_Result) null;
      try
      {
        ApprovalSheetTemplateMaintMethod[] methods = new ApprovalSheetTemplateMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IApprovalSheetTemplateMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ApprovalSheetTemplateMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ApprovalSheetTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ApprovalSheetTemplateMaint cdo,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      result = (ApprovalSheetTemplateMaint_Result) null;
      try
      {
        return ((IApprovalSheetTemplateMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ApprovalSheetTemplateMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ApprovalSheetTemplateMaint) cdo, (ApprovalSheetTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      return this.GetEnvironment((ApprovalSheetTemplateMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ApprovalSheetTemplateMaint cdo,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      result = (ApprovalSheetTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalSheetTemplateMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ApprovalSheetTemplateMaintMethod(cdo, ApprovalSheetTemplateMaintMethods.ExecuteTransaction, (ApprovalSheetTemplateMaint_Parameters) null));
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
        ApprovalSheetTemplateMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ApprovalSheetTemplateMaint) cdo, (ApprovalSheetTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ApprovalSheetTemplateMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ApprovalSheetTemplateMaint_Request) null, out ApprovalSheetTemplateMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result)
    {
      return this.ExecuteTransaction((ApprovalSheetTemplateMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ApprovalSheetTemplateMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ApprovalSheetTemplateMaintMethod(cdo, ApprovalSheetTemplateMaintMethods.AddDataTransaction, (ApprovalSheetTemplateMaint_Parameters) null));
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
        return this.AddDataTransaction((ApprovalSheetTemplateMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
