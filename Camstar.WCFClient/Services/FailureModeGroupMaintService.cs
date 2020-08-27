// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.FailureModeGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class FailureModeGroupMaintService : UserCodeGroupMaintBase
  {
    public FailureModeGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IFailureModeGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Parameters parameters,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      result = (FailureModeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) failureModeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeGroupMaintService) this._Channel).Delete(this._UserProfile, failureModeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new FailureModeGroupMaintMethod(failureModeGroupMaint, FailureModeGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) failureModeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((FailureModeGroupMaint) null, (FailureModeGroupMaint_Parameters) null, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus Delete(FailureModeGroupMaint failureModeGroupMaint)
    {
      return this.Delete(failureModeGroupMaint, (FailureModeGroupMaint_Parameters) null, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus Delete(
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      return this.Delete(failureModeGroupMaint, (FailureModeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Parameters parameters,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      result = (FailureModeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) failureModeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeGroupMaintService) this._Channel).Freeze(this._UserProfile, failureModeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new FailureModeGroupMaintMethod(failureModeGroupMaint, FailureModeGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) failureModeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((FailureModeGroupMaint) null, (FailureModeGroupMaint_Parameters) null, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus Freeze(FailureModeGroupMaint failureModeGroupMaint)
    {
      return this.Freeze(failureModeGroupMaint, (FailureModeGroupMaint_Parameters) null, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      return this.Freeze(failureModeGroupMaint, (FailureModeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Parameters parameters,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      result = (FailureModeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) failureModeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, failureModeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new FailureModeGroupMaintMethod(failureModeGroupMaint, FailureModeGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) failureModeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((FailureModeGroupMaint) null, (FailureModeGroupMaint_Parameters) null, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(FailureModeGroupMaint failureModeGroupMaint)
    {
      return this.GetWIPMsgs(failureModeGroupMaint, (FailureModeGroupMaint_Parameters) null, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      return this.GetWIPMsgs(failureModeGroupMaint, (FailureModeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Parameters parameters,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      result = (FailureModeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) failureModeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeGroupMaintService) this._Channel).Load(this._UserProfile, failureModeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new FailureModeGroupMaintMethod(failureModeGroupMaint, FailureModeGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) failureModeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((FailureModeGroupMaint) null, (FailureModeGroupMaint_Parameters) null, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus Load(FailureModeGroupMaint failureModeGroupMaint)
    {
      return this.Load(failureModeGroupMaint, (FailureModeGroupMaint_Parameters) null, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus Load(
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      return this.Load(failureModeGroupMaint, (FailureModeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_LoadESigDetails_Parameters parameters,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      result = (FailureModeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) failureModeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, failureModeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new FailureModeGroupMaintMethod(failureModeGroupMaint, FailureModeGroupMaintMethods.LoadESigDetails, (FailureModeGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) failureModeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((FailureModeGroupMaint) null, (FailureModeGroupMaint_LoadESigDetails_Parameters) null, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(FailureModeGroupMaint failureModeGroupMaint)
    {
      return this.LoadESigDetails(failureModeGroupMaint, (FailureModeGroupMaint_LoadESigDetails_Parameters) null, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      return this.LoadESigDetails(failureModeGroupMaint, (FailureModeGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Parameters parameters,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      result = (FailureModeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) failureModeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeGroupMaintService) this._Channel).New(this._UserProfile, failureModeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new FailureModeGroupMaintMethod(failureModeGroupMaint, FailureModeGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) failureModeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((FailureModeGroupMaint) null, (FailureModeGroupMaint_Parameters) null, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus New(FailureModeGroupMaint failureModeGroupMaint)
    {
      return this.New(failureModeGroupMaint, (FailureModeGroupMaint_Parameters) null, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus New(
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      return this.New(failureModeGroupMaint, (FailureModeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Parameters parameters,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      result = (FailureModeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) failureModeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeGroupMaintService) this._Channel).NewCopy(this._UserProfile, failureModeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new FailureModeGroupMaintMethod(failureModeGroupMaint, FailureModeGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) failureModeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((FailureModeGroupMaint) null, (FailureModeGroupMaint_Parameters) null, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus NewCopy(FailureModeGroupMaint failureModeGroupMaint)
    {
      return this.NewCopy(failureModeGroupMaint, (FailureModeGroupMaint_Parameters) null, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      return this.NewCopy(failureModeGroupMaint, (FailureModeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Parameters parameters,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      result = (FailureModeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) failureModeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeGroupMaintService) this._Channel).SaveAs(this._UserProfile, failureModeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new FailureModeGroupMaintMethod(failureModeGroupMaint, FailureModeGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) failureModeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((FailureModeGroupMaint) null, (FailureModeGroupMaint_Parameters) null, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus SaveAs(FailureModeGroupMaint failureModeGroupMaint)
    {
      return this.SaveAs(failureModeGroupMaint, (FailureModeGroupMaint_Parameters) null, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      return this.SaveAs(failureModeGroupMaint, (FailureModeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Parameters parameters,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      result = (FailureModeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) failureModeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeGroupMaintService) this._Channel).UnFreeze(this._UserProfile, failureModeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new FailureModeGroupMaintMethod(failureModeGroupMaint, FailureModeGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) failureModeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((FailureModeGroupMaint) null, (FailureModeGroupMaint_Parameters) null, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(FailureModeGroupMaint failureModeGroupMaint)
    {
      return this.UnFreeze(failureModeGroupMaint, (FailureModeGroupMaint_Parameters) null, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      return this.UnFreeze(failureModeGroupMaint, (FailureModeGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject failureModeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureModeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((FailureModeGroupMaint) failureModeGroupMaint, (FailureModeGroupMaint_Parameters) parameters, (FailureModeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject failureModeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureModeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((FailureModeGroupMaint) failureModeGroupMaint, (FailureModeGroupMaint_Parameters) parameters, (FailureModeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject failureModeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureModeGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((FailureModeGroupMaint) failureModeGroupMaint, (FailureModeGroupMaint_LoadESigDetails_Parameters) parameters, (FailureModeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject failureModeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureModeGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((FailureModeGroupMaint) failureModeGroupMaint, (FailureModeGroupMaint_Parameters) parameters, (FailureModeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject failureModeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureModeGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((FailureModeGroupMaint) failureModeGroupMaint, (FailureModeGroupMaint_Parameters) parameters, (FailureModeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject failureModeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureModeGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((FailureModeGroupMaint) failureModeGroupMaint, (FailureModeGroupMaint_Parameters) parameters, (FailureModeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject failureModeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureModeGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((FailureModeGroupMaint) failureModeGroupMaint, (FailureModeGroupMaint_Parameters) parameters, (FailureModeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject failureModeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureModeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((FailureModeGroupMaint) failureModeGroupMaint, (FailureModeGroupMaint_Parameters) parameters, (FailureModeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject failureModeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureModeGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((FailureModeGroupMaint) failureModeGroupMaint, (FailureModeGroupMaint_Parameters) parameters, (FailureModeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      result = (FailureModeGroupMaint_Result) null;
      try
      {
        FailureModeGroupMaintMethod[] methods = new FailureModeGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IFailureModeGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        FailureModeGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((FailureModeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      FailureModeGroupMaint cdo,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      result = (FailureModeGroupMaint_Result) null;
      try
      {
        return ((IFailureModeGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        FailureModeGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((FailureModeGroupMaint) cdo, (FailureModeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      return this.GetEnvironment((FailureModeGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      FailureModeGroupMaint cdo,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      result = (FailureModeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new FailureModeGroupMaintMethod(cdo, FailureModeGroupMaintMethods.ExecuteTransaction, (FailureModeGroupMaint_Parameters) null));
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
        FailureModeGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((FailureModeGroupMaint) cdo, (FailureModeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(FailureModeGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (FailureModeGroupMaint_Request) null, out FailureModeGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result)
    {
      return this.ExecuteTransaction((FailureModeGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(FailureModeGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new FailureModeGroupMaintMethod(cdo, FailureModeGroupMaintMethods.AddDataTransaction, (FailureModeGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((FailureModeGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
