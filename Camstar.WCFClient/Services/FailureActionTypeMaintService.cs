// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.FailureActionTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class FailureActionTypeMaintService : UserCodeMaintBase
  {
    public FailureActionTypeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IFailureActionTypeMaintService), userProfile);
    }

    public ResultStatus Delete(
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Parameters parameters,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      result = (FailureActionTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) failureActionTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeMaintService) this._Channel).Delete(this._UserProfile, failureActionTypeMaint, parameters, request, out result) : this.AddMethod((Method) new FailureActionTypeMaintMethod(failureActionTypeMaint, FailureActionTypeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) failureActionTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((FailureActionTypeMaint) null, (FailureActionTypeMaint_Parameters) null, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus Delete(FailureActionTypeMaint failureActionTypeMaint)
    {
      return this.Delete(failureActionTypeMaint, (FailureActionTypeMaint_Parameters) null, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus Delete(
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      return this.Delete(failureActionTypeMaint, (FailureActionTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Parameters parameters,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      result = (FailureActionTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) failureActionTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeMaintService) this._Channel).Freeze(this._UserProfile, failureActionTypeMaint, parameters, request, out result) : this.AddMethod((Method) new FailureActionTypeMaintMethod(failureActionTypeMaint, FailureActionTypeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) failureActionTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((FailureActionTypeMaint) null, (FailureActionTypeMaint_Parameters) null, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus Freeze(FailureActionTypeMaint failureActionTypeMaint)
    {
      return this.Freeze(failureActionTypeMaint, (FailureActionTypeMaint_Parameters) null, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus Freeze(
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      return this.Freeze(failureActionTypeMaint, (FailureActionTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Parameters parameters,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      result = (FailureActionTypeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) failureActionTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, failureActionTypeMaint, parameters, request, out result) : this.AddMethod((Method) new FailureActionTypeMaintMethod(failureActionTypeMaint, FailureActionTypeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) failureActionTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((FailureActionTypeMaint) null, (FailureActionTypeMaint_Parameters) null, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(FailureActionTypeMaint failureActionTypeMaint)
    {
      return this.GetWIPMsgs(failureActionTypeMaint, (FailureActionTypeMaint_Parameters) null, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      return this.GetWIPMsgs(failureActionTypeMaint, (FailureActionTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Parameters parameters,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      result = (FailureActionTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) failureActionTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeMaintService) this._Channel).Load(this._UserProfile, failureActionTypeMaint, parameters, request, out result) : this.AddMethod((Method) new FailureActionTypeMaintMethod(failureActionTypeMaint, FailureActionTypeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) failureActionTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((FailureActionTypeMaint) null, (FailureActionTypeMaint_Parameters) null, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus Load(FailureActionTypeMaint failureActionTypeMaint)
    {
      return this.Load(failureActionTypeMaint, (FailureActionTypeMaint_Parameters) null, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus Load(
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      return this.Load(failureActionTypeMaint, (FailureActionTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_LoadESigDetails_Parameters parameters,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      result = (FailureActionTypeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) failureActionTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeMaintService) this._Channel).LoadESigDetails(this._UserProfile, failureActionTypeMaint, parameters, request, out result) : this.AddMethod((Method) new FailureActionTypeMaintMethod(failureActionTypeMaint, FailureActionTypeMaintMethods.LoadESigDetails, (FailureActionTypeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) failureActionTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((FailureActionTypeMaint) null, (FailureActionTypeMaint_LoadESigDetails_Parameters) null, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(FailureActionTypeMaint failureActionTypeMaint)
    {
      return this.LoadESigDetails(failureActionTypeMaint, (FailureActionTypeMaint_LoadESigDetails_Parameters) null, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      return this.LoadESigDetails(failureActionTypeMaint, (FailureActionTypeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Parameters parameters,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      result = (FailureActionTypeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) failureActionTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeMaintService) this._Channel).New(this._UserProfile, failureActionTypeMaint, parameters, request, out result) : this.AddMethod((Method) new FailureActionTypeMaintMethod(failureActionTypeMaint, FailureActionTypeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) failureActionTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((FailureActionTypeMaint) null, (FailureActionTypeMaint_Parameters) null, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus New(FailureActionTypeMaint failureActionTypeMaint)
    {
      return this.New(failureActionTypeMaint, (FailureActionTypeMaint_Parameters) null, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus New(
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      return this.New(failureActionTypeMaint, (FailureActionTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Parameters parameters,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      result = (FailureActionTypeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) failureActionTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeMaintService) this._Channel).NewCopy(this._UserProfile, failureActionTypeMaint, parameters, request, out result) : this.AddMethod((Method) new FailureActionTypeMaintMethod(failureActionTypeMaint, FailureActionTypeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) failureActionTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((FailureActionTypeMaint) null, (FailureActionTypeMaint_Parameters) null, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus NewCopy(FailureActionTypeMaint failureActionTypeMaint)
    {
      return this.NewCopy(failureActionTypeMaint, (FailureActionTypeMaint_Parameters) null, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus NewCopy(
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      return this.NewCopy(failureActionTypeMaint, (FailureActionTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Parameters parameters,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      result = (FailureActionTypeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) failureActionTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeMaintService) this._Channel).SaveAs(this._UserProfile, failureActionTypeMaint, parameters, request, out result) : this.AddMethod((Method) new FailureActionTypeMaintMethod(failureActionTypeMaint, FailureActionTypeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) failureActionTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((FailureActionTypeMaint) null, (FailureActionTypeMaint_Parameters) null, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus SaveAs(FailureActionTypeMaint failureActionTypeMaint)
    {
      return this.SaveAs(failureActionTypeMaint, (FailureActionTypeMaint_Parameters) null, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus SaveAs(
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      return this.SaveAs(failureActionTypeMaint, (FailureActionTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Parameters parameters,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      result = (FailureActionTypeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) failureActionTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeMaintService) this._Channel).UnFreeze(this._UserProfile, failureActionTypeMaint, parameters, request, out result) : this.AddMethod((Method) new FailureActionTypeMaintMethod(failureActionTypeMaint, FailureActionTypeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) failureActionTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((FailureActionTypeMaint) null, (FailureActionTypeMaint_Parameters) null, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(FailureActionTypeMaint failureActionTypeMaint)
    {
      return this.UnFreeze(failureActionTypeMaint, (FailureActionTypeMaint_Parameters) null, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      return this.UnFreeze(failureActionTypeMaint, (FailureActionTypeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject failureActionTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureActionTypeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((FailureActionTypeMaint) failureActionTypeMaint, (FailureActionTypeMaint_Parameters) parameters, (FailureActionTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject failureActionTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureActionTypeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((FailureActionTypeMaint) failureActionTypeMaint, (FailureActionTypeMaint_Parameters) parameters, (FailureActionTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject failureActionTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureActionTypeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((FailureActionTypeMaint) failureActionTypeMaint, (FailureActionTypeMaint_LoadESigDetails_Parameters) parameters, (FailureActionTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject failureActionTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureActionTypeMaint_Result result1;
        ResultStatus resultStatus = this.New((FailureActionTypeMaint) failureActionTypeMaint, (FailureActionTypeMaint_Parameters) parameters, (FailureActionTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject failureActionTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureActionTypeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((FailureActionTypeMaint) failureActionTypeMaint, (FailureActionTypeMaint_Parameters) parameters, (FailureActionTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject failureActionTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureActionTypeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((FailureActionTypeMaint) failureActionTypeMaint, (FailureActionTypeMaint_Parameters) parameters, (FailureActionTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject failureActionTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureActionTypeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((FailureActionTypeMaint) failureActionTypeMaint, (FailureActionTypeMaint_Parameters) parameters, (FailureActionTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject failureActionTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureActionTypeMaint_Result result1;
        ResultStatus resultStatus = this.Load((FailureActionTypeMaint) failureActionTypeMaint, (FailureActionTypeMaint_Parameters) parameters, (FailureActionTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject failureActionTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureActionTypeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((FailureActionTypeMaint) failureActionTypeMaint, (FailureActionTypeMaint_Parameters) parameters, (FailureActionTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      result = (FailureActionTypeMaint_Result) null;
      try
      {
        FailureActionTypeMaintMethod[] methods = new FailureActionTypeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IFailureActionTypeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        FailureActionTypeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((FailureActionTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      FailureActionTypeMaint cdo,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      result = (FailureActionTypeMaint_Result) null;
      try
      {
        return ((IFailureActionTypeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        FailureActionTypeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((FailureActionTypeMaint) cdo, (FailureActionTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      return this.GetEnvironment((FailureActionTypeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      FailureActionTypeMaint cdo,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      result = (FailureActionTypeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureActionTypeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new FailureActionTypeMaintMethod(cdo, FailureActionTypeMaintMethods.ExecuteTransaction, (FailureActionTypeMaint_Parameters) null));
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
        FailureActionTypeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((FailureActionTypeMaint) cdo, (FailureActionTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(FailureActionTypeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (FailureActionTypeMaint_Request) null, out FailureActionTypeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result)
    {
      return this.ExecuteTransaction((FailureActionTypeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(FailureActionTypeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new FailureActionTypeMaintMethod(cdo, FailureActionTypeMaintMethods.AddDataTransaction, (FailureActionTypeMaint_Parameters) null));
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
        return this.AddDataTransaction((FailureActionTypeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
