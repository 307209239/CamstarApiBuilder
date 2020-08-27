// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.FailureActionTypeGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class FailureActionTypeGroupMaintService : UserCodeGroupMaintBase
  {
    public FailureActionTypeGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IFailureActionTypeGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Parameters parameters,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      result = (FailureActionTypeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) failureActionTypeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeGroupMaintService) this._Channel).Delete(this._UserProfile, failureActionTypeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new FailureActionTypeGroupMaintMethod(failureActionTypeGroupMaint, FailureActionTypeGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) failureActionTypeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((FailureActionTypeGroupMaint) null, (FailureActionTypeGroupMaint_Parameters) null, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus Delete(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint)
    {
      return this.Delete(failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) null, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus Delete(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      return this.Delete(failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Parameters parameters,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      result = (FailureActionTypeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) failureActionTypeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeGroupMaintService) this._Channel).Freeze(this._UserProfile, failureActionTypeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new FailureActionTypeGroupMaintMethod(failureActionTypeGroupMaint, FailureActionTypeGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) failureActionTypeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((FailureActionTypeGroupMaint) null, (FailureActionTypeGroupMaint_Parameters) null, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint)
    {
      return this.Freeze(failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) null, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      return this.Freeze(failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Parameters parameters,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      result = (FailureActionTypeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) failureActionTypeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, failureActionTypeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new FailureActionTypeGroupMaintMethod(failureActionTypeGroupMaint, FailureActionTypeGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) failureActionTypeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((FailureActionTypeGroupMaint) null, (FailureActionTypeGroupMaint_Parameters) null, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint)
    {
      return this.GetWIPMsgs(failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) null, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      return this.GetWIPMsgs(failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Parameters parameters,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      result = (FailureActionTypeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) failureActionTypeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeGroupMaintService) this._Channel).Load(this._UserProfile, failureActionTypeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new FailureActionTypeGroupMaintMethod(failureActionTypeGroupMaint, FailureActionTypeGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) failureActionTypeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((FailureActionTypeGroupMaint) null, (FailureActionTypeGroupMaint_Parameters) null, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus Load(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint)
    {
      return this.Load(failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) null, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus Load(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      return this.Load(failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_LoadESigDetails_Parameters parameters,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      result = (FailureActionTypeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) failureActionTypeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, failureActionTypeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new FailureActionTypeGroupMaintMethod(failureActionTypeGroupMaint, FailureActionTypeGroupMaintMethods.LoadESigDetails, (FailureActionTypeGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) failureActionTypeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((FailureActionTypeGroupMaint) null, (FailureActionTypeGroupMaint_LoadESigDetails_Parameters) null, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint)
    {
      return this.LoadESigDetails(failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_LoadESigDetails_Parameters) null, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      return this.LoadESigDetails(failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Parameters parameters,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      result = (FailureActionTypeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) failureActionTypeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeGroupMaintService) this._Channel).New(this._UserProfile, failureActionTypeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new FailureActionTypeGroupMaintMethod(failureActionTypeGroupMaint, FailureActionTypeGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) failureActionTypeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((FailureActionTypeGroupMaint) null, (FailureActionTypeGroupMaint_Parameters) null, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus New(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint)
    {
      return this.New(failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) null, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus New(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      return this.New(failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Parameters parameters,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      result = (FailureActionTypeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) failureActionTypeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeGroupMaintService) this._Channel).NewCopy(this._UserProfile, failureActionTypeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new FailureActionTypeGroupMaintMethod(failureActionTypeGroupMaint, FailureActionTypeGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) failureActionTypeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((FailureActionTypeGroupMaint) null, (FailureActionTypeGroupMaint_Parameters) null, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint)
    {
      return this.NewCopy(failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) null, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      return this.NewCopy(failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Parameters parameters,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      result = (FailureActionTypeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) failureActionTypeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeGroupMaintService) this._Channel).SaveAs(this._UserProfile, failureActionTypeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new FailureActionTypeGroupMaintMethod(failureActionTypeGroupMaint, FailureActionTypeGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) failureActionTypeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((FailureActionTypeGroupMaint) null, (FailureActionTypeGroupMaint_Parameters) null, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint)
    {
      return this.SaveAs(failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) null, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      return this.SaveAs(failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Parameters parameters,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      result = (FailureActionTypeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) failureActionTypeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeGroupMaintService) this._Channel).UnFreeze(this._UserProfile, failureActionTypeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new FailureActionTypeGroupMaintMethod(failureActionTypeGroupMaint, FailureActionTypeGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) failureActionTypeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((FailureActionTypeGroupMaint) null, (FailureActionTypeGroupMaint_Parameters) null, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint)
    {
      return this.UnFreeze(failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) null, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      return this.UnFreeze(failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject failureActionTypeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureActionTypeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((FailureActionTypeGroupMaint) failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) parameters, (FailureActionTypeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject failureActionTypeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureActionTypeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((FailureActionTypeGroupMaint) failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) parameters, (FailureActionTypeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject failureActionTypeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureActionTypeGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((FailureActionTypeGroupMaint) failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_LoadESigDetails_Parameters) parameters, (FailureActionTypeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject failureActionTypeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureActionTypeGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((FailureActionTypeGroupMaint) failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) parameters, (FailureActionTypeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject failureActionTypeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureActionTypeGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((FailureActionTypeGroupMaint) failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) parameters, (FailureActionTypeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject failureActionTypeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureActionTypeGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((FailureActionTypeGroupMaint) failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) parameters, (FailureActionTypeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject failureActionTypeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureActionTypeGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((FailureActionTypeGroupMaint) failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) parameters, (FailureActionTypeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject failureActionTypeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureActionTypeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((FailureActionTypeGroupMaint) failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) parameters, (FailureActionTypeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject failureActionTypeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureActionTypeGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((FailureActionTypeGroupMaint) failureActionTypeGroupMaint, (FailureActionTypeGroupMaint_Parameters) parameters, (FailureActionTypeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      result = (FailureActionTypeGroupMaint_Result) null;
      try
      {
        FailureActionTypeGroupMaintMethod[] methods = new FailureActionTypeGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IFailureActionTypeGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        FailureActionTypeGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((FailureActionTypeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      FailureActionTypeGroupMaint cdo,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      result = (FailureActionTypeGroupMaint_Result) null;
      try
      {
        return ((IFailureActionTypeGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        FailureActionTypeGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((FailureActionTypeGroupMaint) cdo, (FailureActionTypeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      return this.GetEnvironment((FailureActionTypeGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      FailureActionTypeGroupMaint cdo,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      result = (FailureActionTypeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new FailureActionTypeGroupMaintMethod(cdo, FailureActionTypeGroupMaintMethods.ExecuteTransaction, (FailureActionTypeGroupMaint_Parameters) null));
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
        FailureActionTypeGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((FailureActionTypeGroupMaint) cdo, (FailureActionTypeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(FailureActionTypeGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (FailureActionTypeGroupMaint_Request) null, out FailureActionTypeGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result)
    {
      return this.ExecuteTransaction((FailureActionTypeGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(FailureActionTypeGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new FailureActionTypeGroupMaintMethod(cdo, FailureActionTypeGroupMaintMethods.AddDataTransaction, (FailureActionTypeGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((FailureActionTypeGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
