// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IssueDifferenceReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class IssueDifferenceReasonMaintService : UserCodeMaintBase
  {
    public IssueDifferenceReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IIssueDifferenceReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint,
      IssueDifferenceReasonMaint_Parameters parameters,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      result = (IssueDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) issueDifferenceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueDifferenceReasonMaintService) this._Channel).Delete(this._UserProfile, issueDifferenceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new IssueDifferenceReasonMaintMethod(issueDifferenceReasonMaint, IssueDifferenceReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) issueDifferenceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((IssueDifferenceReasonMaint) null, (IssueDifferenceReasonMaint_Parameters) null, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus Delete(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint)
    {
      return this.Delete(issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) null, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus Delete(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      return this.Delete(issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint,
      IssueDifferenceReasonMaint_Parameters parameters,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      result = (IssueDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) issueDifferenceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueDifferenceReasonMaintService) this._Channel).Freeze(this._UserProfile, issueDifferenceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new IssueDifferenceReasonMaintMethod(issueDifferenceReasonMaint, IssueDifferenceReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) issueDifferenceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((IssueDifferenceReasonMaint) null, (IssueDifferenceReasonMaint_Parameters) null, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint)
    {
      return this.Freeze(issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) null, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      return this.Freeze(issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint,
      IssueDifferenceReasonMaint_Parameters parameters,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      result = (IssueDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) issueDifferenceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueDifferenceReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, issueDifferenceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new IssueDifferenceReasonMaintMethod(issueDifferenceReasonMaint, IssueDifferenceReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) issueDifferenceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((IssueDifferenceReasonMaint) null, (IssueDifferenceReasonMaint_Parameters) null, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint)
    {
      return this.GetWIPMsgs(issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) null, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      return this.GetWIPMsgs(issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint,
      IssueDifferenceReasonMaint_Parameters parameters,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      result = (IssueDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) issueDifferenceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueDifferenceReasonMaintService) this._Channel).Load(this._UserProfile, issueDifferenceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new IssueDifferenceReasonMaintMethod(issueDifferenceReasonMaint, IssueDifferenceReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) issueDifferenceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((IssueDifferenceReasonMaint) null, (IssueDifferenceReasonMaint_Parameters) null, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus Load(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint)
    {
      return this.Load(issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) null, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus Load(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      return this.Load(issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint,
      IssueDifferenceReasonMaint_LoadESigDetails_Parameters parameters,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      result = (IssueDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) issueDifferenceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueDifferenceReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, issueDifferenceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new IssueDifferenceReasonMaintMethod(issueDifferenceReasonMaint, IssueDifferenceReasonMaintMethods.LoadESigDetails, (IssueDifferenceReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) issueDifferenceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((IssueDifferenceReasonMaint) null, (IssueDifferenceReasonMaint_LoadESigDetails_Parameters) null, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint)
    {
      return this.LoadESigDetails(issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_LoadESigDetails_Parameters) null, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      return this.LoadESigDetails(issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint,
      IssueDifferenceReasonMaint_Parameters parameters,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      result = (IssueDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) issueDifferenceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueDifferenceReasonMaintService) this._Channel).New(this._UserProfile, issueDifferenceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new IssueDifferenceReasonMaintMethod(issueDifferenceReasonMaint, IssueDifferenceReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) issueDifferenceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((IssueDifferenceReasonMaint) null, (IssueDifferenceReasonMaint_Parameters) null, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus New(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint)
    {
      return this.New(issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) null, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus New(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      return this.New(issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint,
      IssueDifferenceReasonMaint_Parameters parameters,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      result = (IssueDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) issueDifferenceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueDifferenceReasonMaintService) this._Channel).NewCopy(this._UserProfile, issueDifferenceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new IssueDifferenceReasonMaintMethod(issueDifferenceReasonMaint, IssueDifferenceReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) issueDifferenceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((IssueDifferenceReasonMaint) null, (IssueDifferenceReasonMaint_Parameters) null, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint)
    {
      return this.NewCopy(issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) null, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      return this.NewCopy(issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint,
      IssueDifferenceReasonMaint_Parameters parameters,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      result = (IssueDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) issueDifferenceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueDifferenceReasonMaintService) this._Channel).SaveAs(this._UserProfile, issueDifferenceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new IssueDifferenceReasonMaintMethod(issueDifferenceReasonMaint, IssueDifferenceReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) issueDifferenceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((IssueDifferenceReasonMaint) null, (IssueDifferenceReasonMaint_Parameters) null, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint)
    {
      return this.SaveAs(issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) null, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      return this.SaveAs(issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint,
      IssueDifferenceReasonMaint_Parameters parameters,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      result = (IssueDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) issueDifferenceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueDifferenceReasonMaintService) this._Channel).UnFreeze(this._UserProfile, issueDifferenceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new IssueDifferenceReasonMaintMethod(issueDifferenceReasonMaint, IssueDifferenceReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) issueDifferenceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((IssueDifferenceReasonMaint) null, (IssueDifferenceReasonMaint_Parameters) null, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint)
    {
      return this.UnFreeze(issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) null, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      IssueDifferenceReasonMaint issueDifferenceReasonMaint,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      return this.UnFreeze(issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject issueDifferenceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        IssueDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((IssueDifferenceReasonMaint) issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) parameters, (IssueDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject issueDifferenceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        IssueDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((IssueDifferenceReasonMaint) issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) parameters, (IssueDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject issueDifferenceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        IssueDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((IssueDifferenceReasonMaint) issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_LoadESigDetails_Parameters) parameters, (IssueDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject issueDifferenceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        IssueDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((IssueDifferenceReasonMaint) issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) parameters, (IssueDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject issueDifferenceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        IssueDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((IssueDifferenceReasonMaint) issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) parameters, (IssueDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject issueDifferenceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        IssueDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((IssueDifferenceReasonMaint) issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) parameters, (IssueDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject issueDifferenceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        IssueDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((IssueDifferenceReasonMaint) issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) parameters, (IssueDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject issueDifferenceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        IssueDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((IssueDifferenceReasonMaint) issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) parameters, (IssueDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject issueDifferenceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        IssueDifferenceReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((IssueDifferenceReasonMaint) issueDifferenceReasonMaint, (IssueDifferenceReasonMaint_Parameters) parameters, (IssueDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      result = (IssueDifferenceReasonMaint_Result) null;
      try
      {
        IssueDifferenceReasonMaintMethod[] methods = new IssueDifferenceReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IIssueDifferenceReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        IssueDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((IssueDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      IssueDifferenceReasonMaint cdo,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      result = (IssueDifferenceReasonMaint_Result) null;
      try
      {
        return ((IIssueDifferenceReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        IssueDifferenceReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((IssueDifferenceReasonMaint) cdo, (IssueDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      return this.GetEnvironment((IssueDifferenceReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      IssueDifferenceReasonMaint cdo,
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      result = (IssueDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueDifferenceReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new IssueDifferenceReasonMaintMethod(cdo, IssueDifferenceReasonMaintMethods.ExecuteTransaction, (IssueDifferenceReasonMaint_Parameters) null));
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
        IssueDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((IssueDifferenceReasonMaint) cdo, (IssueDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(IssueDifferenceReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (IssueDifferenceReasonMaint_Request) null, out IssueDifferenceReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      IssueDifferenceReasonMaint_Request request,
      out IssueDifferenceReasonMaint_Result result)
    {
      return this.ExecuteTransaction((IssueDifferenceReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(IssueDifferenceReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new IssueDifferenceReasonMaintMethod(cdo, IssueDifferenceReasonMaintMethods.AddDataTransaction, (IssueDifferenceReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((IssueDifferenceReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
