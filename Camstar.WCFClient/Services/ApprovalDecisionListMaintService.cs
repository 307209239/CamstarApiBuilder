// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ApprovalDecisionListMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ApprovalDecisionListMaintService : NamedDataObjectMaintBase
  {
    public ApprovalDecisionListMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IApprovalDecisionListMaintService), userProfile);
    }

    public ResultStatus Delete(
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Parameters parameters,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      result = (ApprovalDecisionListMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) approvalDecisionListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalDecisionListMaintService) this._Channel).Delete(this._UserProfile, approvalDecisionListMaint, parameters, request, out result) : this.AddMethod((Method) new ApprovalDecisionListMaintMethod(approvalDecisionListMaint, ApprovalDecisionListMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) approvalDecisionListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ApprovalDecisionListMaint) null, (ApprovalDecisionListMaint_Parameters) null, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus Delete(
      ApprovalDecisionListMaint approvalDecisionListMaint)
    {
      return this.Delete(approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) null, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus Delete(
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      return this.Delete(approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Parameters parameters,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      result = (ApprovalDecisionListMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) approvalDecisionListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalDecisionListMaintService) this._Channel).Freeze(this._UserProfile, approvalDecisionListMaint, parameters, request, out result) : this.AddMethod((Method) new ApprovalDecisionListMaintMethod(approvalDecisionListMaint, ApprovalDecisionListMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) approvalDecisionListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ApprovalDecisionListMaint) null, (ApprovalDecisionListMaint_Parameters) null, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus Freeze(
      ApprovalDecisionListMaint approvalDecisionListMaint)
    {
      return this.Freeze(approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) null, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus Freeze(
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      return this.Freeze(approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Parameters parameters,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      result = (ApprovalDecisionListMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) approvalDecisionListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalDecisionListMaintService) this._Channel).GetWIPMsgs(this._UserProfile, approvalDecisionListMaint, parameters, request, out result) : this.AddMethod((Method) new ApprovalDecisionListMaintMethod(approvalDecisionListMaint, ApprovalDecisionListMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) approvalDecisionListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ApprovalDecisionListMaint) null, (ApprovalDecisionListMaint_Parameters) null, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ApprovalDecisionListMaint approvalDecisionListMaint)
    {
      return this.GetWIPMsgs(approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) null, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      return this.GetWIPMsgs(approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Parameters parameters,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      result = (ApprovalDecisionListMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) approvalDecisionListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalDecisionListMaintService) this._Channel).Load(this._UserProfile, approvalDecisionListMaint, parameters, request, out result) : this.AddMethod((Method) new ApprovalDecisionListMaintMethod(approvalDecisionListMaint, ApprovalDecisionListMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) approvalDecisionListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ApprovalDecisionListMaint) null, (ApprovalDecisionListMaint_Parameters) null, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus Load(
      ApprovalDecisionListMaint approvalDecisionListMaint)
    {
      return this.Load(approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) null, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus Load(
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      return this.Load(approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_LoadESigDetails_Parameters parameters,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      result = (ApprovalDecisionListMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) approvalDecisionListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalDecisionListMaintService) this._Channel).LoadESigDetails(this._UserProfile, approvalDecisionListMaint, parameters, request, out result) : this.AddMethod((Method) new ApprovalDecisionListMaintMethod(approvalDecisionListMaint, ApprovalDecisionListMaintMethods.LoadESigDetails, (ApprovalDecisionListMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) approvalDecisionListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ApprovalDecisionListMaint) null, (ApprovalDecisionListMaint_LoadESigDetails_Parameters) null, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ApprovalDecisionListMaint approvalDecisionListMaint)
    {
      return this.LoadESigDetails(approvalDecisionListMaint, (ApprovalDecisionListMaint_LoadESigDetails_Parameters) null, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      return this.LoadESigDetails(approvalDecisionListMaint, (ApprovalDecisionListMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Parameters parameters,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      result = (ApprovalDecisionListMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) approvalDecisionListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalDecisionListMaintService) this._Channel).New(this._UserProfile, approvalDecisionListMaint, parameters, request, out result) : this.AddMethod((Method) new ApprovalDecisionListMaintMethod(approvalDecisionListMaint, ApprovalDecisionListMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) approvalDecisionListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ApprovalDecisionListMaint) null, (ApprovalDecisionListMaint_Parameters) null, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus New(
      ApprovalDecisionListMaint approvalDecisionListMaint)
    {
      return this.New(approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) null, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus New(
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      return this.New(approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Parameters parameters,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      result = (ApprovalDecisionListMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) approvalDecisionListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalDecisionListMaintService) this._Channel).NewCopy(this._UserProfile, approvalDecisionListMaint, parameters, request, out result) : this.AddMethod((Method) new ApprovalDecisionListMaintMethod(approvalDecisionListMaint, ApprovalDecisionListMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) approvalDecisionListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ApprovalDecisionListMaint) null, (ApprovalDecisionListMaint_Parameters) null, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus NewCopy(
      ApprovalDecisionListMaint approvalDecisionListMaint)
    {
      return this.NewCopy(approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) null, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus NewCopy(
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      return this.NewCopy(approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Parameters parameters,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      result = (ApprovalDecisionListMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) approvalDecisionListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalDecisionListMaintService) this._Channel).SaveAs(this._UserProfile, approvalDecisionListMaint, parameters, request, out result) : this.AddMethod((Method) new ApprovalDecisionListMaintMethod(approvalDecisionListMaint, ApprovalDecisionListMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) approvalDecisionListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ApprovalDecisionListMaint) null, (ApprovalDecisionListMaint_Parameters) null, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus SaveAs(
      ApprovalDecisionListMaint approvalDecisionListMaint)
    {
      return this.SaveAs(approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) null, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus SaveAs(
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      return this.SaveAs(approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Parameters parameters,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      result = (ApprovalDecisionListMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) approvalDecisionListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalDecisionListMaintService) this._Channel).UnFreeze(this._UserProfile, approvalDecisionListMaint, parameters, request, out result) : this.AddMethod((Method) new ApprovalDecisionListMaintMethod(approvalDecisionListMaint, ApprovalDecisionListMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) approvalDecisionListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ApprovalDecisionListMaint) null, (ApprovalDecisionListMaint_Parameters) null, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ApprovalDecisionListMaint approvalDecisionListMaint)
    {
      return this.UnFreeze(approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) null, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      return this.UnFreeze(approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject approvalDecisionListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalDecisionListMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ApprovalDecisionListMaint) approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) parameters, (ApprovalDecisionListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject approvalDecisionListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalDecisionListMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ApprovalDecisionListMaint) approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) parameters, (ApprovalDecisionListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject approvalDecisionListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalDecisionListMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ApprovalDecisionListMaint) approvalDecisionListMaint, (ApprovalDecisionListMaint_LoadESigDetails_Parameters) parameters, (ApprovalDecisionListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject approvalDecisionListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalDecisionListMaint_Result result1;
        ResultStatus resultStatus = this.New((ApprovalDecisionListMaint) approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) parameters, (ApprovalDecisionListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject approvalDecisionListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalDecisionListMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ApprovalDecisionListMaint) approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) parameters, (ApprovalDecisionListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject approvalDecisionListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalDecisionListMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ApprovalDecisionListMaint) approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) parameters, (ApprovalDecisionListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject approvalDecisionListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalDecisionListMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ApprovalDecisionListMaint) approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) parameters, (ApprovalDecisionListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject approvalDecisionListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalDecisionListMaint_Result result1;
        ResultStatus resultStatus = this.Load((ApprovalDecisionListMaint) approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) parameters, (ApprovalDecisionListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject approvalDecisionListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalDecisionListMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ApprovalDecisionListMaint) approvalDecisionListMaint, (ApprovalDecisionListMaint_Parameters) parameters, (ApprovalDecisionListMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      result = (ApprovalDecisionListMaint_Result) null;
      try
      {
        ApprovalDecisionListMaintMethod[] methods = new ApprovalDecisionListMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IApprovalDecisionListMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ApprovalDecisionListMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ApprovalDecisionListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ApprovalDecisionListMaint cdo,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      result = (ApprovalDecisionListMaint_Result) null;
      try
      {
        return ((IApprovalDecisionListMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ApprovalDecisionListMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ApprovalDecisionListMaint) cdo, (ApprovalDecisionListMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      return this.GetEnvironment((ApprovalDecisionListMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ApprovalDecisionListMaint cdo,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      result = (ApprovalDecisionListMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalDecisionListMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ApprovalDecisionListMaintMethod(cdo, ApprovalDecisionListMaintMethods.ExecuteTransaction, (ApprovalDecisionListMaint_Parameters) null));
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
        ApprovalDecisionListMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ApprovalDecisionListMaint) cdo, (ApprovalDecisionListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ApprovalDecisionListMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ApprovalDecisionListMaint_Request) null, out ApprovalDecisionListMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result)
    {
      return this.ExecuteTransaction((ApprovalDecisionListMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ApprovalDecisionListMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ApprovalDecisionListMaintMethod(cdo, ApprovalDecisionListMaintMethods.AddDataTransaction, (ApprovalDecisionListMaint_Parameters) null));
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
        return this.AddDataTransaction((ApprovalDecisionListMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
