// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.FailureModeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class FailureModeMaintService : UserCodeMaintBase
  {
    public FailureModeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IFailureModeMaintService), userProfile);
    }

    public ResultStatus Delete(
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Parameters parameters,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      result = (FailureModeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) failureModeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeMaintService) this._Channel).Delete(this._UserProfile, failureModeMaint, parameters, request, out result) : this.AddMethod((Method) new FailureModeMaintMethod(failureModeMaint, FailureModeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) failureModeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((FailureModeMaint) null, (FailureModeMaint_Parameters) null, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus Delete(FailureModeMaint failureModeMaint)
    {
      return this.Delete(failureModeMaint, (FailureModeMaint_Parameters) null, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus Delete(
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      return this.Delete(failureModeMaint, (FailureModeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Parameters parameters,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      result = (FailureModeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) failureModeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeMaintService) this._Channel).Freeze(this._UserProfile, failureModeMaint, parameters, request, out result) : this.AddMethod((Method) new FailureModeMaintMethod(failureModeMaint, FailureModeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) failureModeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((FailureModeMaint) null, (FailureModeMaint_Parameters) null, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus Freeze(FailureModeMaint failureModeMaint)
    {
      return this.Freeze(failureModeMaint, (FailureModeMaint_Parameters) null, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus Freeze(
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      return this.Freeze(failureModeMaint, (FailureModeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Parameters parameters,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      result = (FailureModeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) failureModeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, failureModeMaint, parameters, request, out result) : this.AddMethod((Method) new FailureModeMaintMethod(failureModeMaint, FailureModeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) failureModeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((FailureModeMaint) null, (FailureModeMaint_Parameters) null, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(FailureModeMaint failureModeMaint)
    {
      return this.GetWIPMsgs(failureModeMaint, (FailureModeMaint_Parameters) null, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      return this.GetWIPMsgs(failureModeMaint, (FailureModeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Parameters parameters,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      result = (FailureModeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) failureModeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeMaintService) this._Channel).Load(this._UserProfile, failureModeMaint, parameters, request, out result) : this.AddMethod((Method) new FailureModeMaintMethod(failureModeMaint, FailureModeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) failureModeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((FailureModeMaint) null, (FailureModeMaint_Parameters) null, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus Load(FailureModeMaint failureModeMaint)
    {
      return this.Load(failureModeMaint, (FailureModeMaint_Parameters) null, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus Load(
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      return this.Load(failureModeMaint, (FailureModeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      FailureModeMaint failureModeMaint,
      FailureModeMaint_LoadESigDetails_Parameters parameters,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      result = (FailureModeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) failureModeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeMaintService) this._Channel).LoadESigDetails(this._UserProfile, failureModeMaint, parameters, request, out result) : this.AddMethod((Method) new FailureModeMaintMethod(failureModeMaint, FailureModeMaintMethods.LoadESigDetails, (FailureModeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) failureModeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((FailureModeMaint) null, (FailureModeMaint_LoadESigDetails_Parameters) null, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(FailureModeMaint failureModeMaint)
    {
      return this.LoadESigDetails(failureModeMaint, (FailureModeMaint_LoadESigDetails_Parameters) null, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      return this.LoadESigDetails(failureModeMaint, (FailureModeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Parameters parameters,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      result = (FailureModeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) failureModeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeMaintService) this._Channel).New(this._UserProfile, failureModeMaint, parameters, request, out result) : this.AddMethod((Method) new FailureModeMaintMethod(failureModeMaint, FailureModeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) failureModeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((FailureModeMaint) null, (FailureModeMaint_Parameters) null, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus New(FailureModeMaint failureModeMaint)
    {
      return this.New(failureModeMaint, (FailureModeMaint_Parameters) null, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus New(
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      return this.New(failureModeMaint, (FailureModeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Parameters parameters,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      result = (FailureModeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) failureModeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeMaintService) this._Channel).NewCopy(this._UserProfile, failureModeMaint, parameters, request, out result) : this.AddMethod((Method) new FailureModeMaintMethod(failureModeMaint, FailureModeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) failureModeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((FailureModeMaint) null, (FailureModeMaint_Parameters) null, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus NewCopy(FailureModeMaint failureModeMaint)
    {
      return this.NewCopy(failureModeMaint, (FailureModeMaint_Parameters) null, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus NewCopy(
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      return this.NewCopy(failureModeMaint, (FailureModeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Parameters parameters,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      result = (FailureModeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) failureModeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeMaintService) this._Channel).SaveAs(this._UserProfile, failureModeMaint, parameters, request, out result) : this.AddMethod((Method) new FailureModeMaintMethod(failureModeMaint, FailureModeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) failureModeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((FailureModeMaint) null, (FailureModeMaint_Parameters) null, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus SaveAs(FailureModeMaint failureModeMaint)
    {
      return this.SaveAs(failureModeMaint, (FailureModeMaint_Parameters) null, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus SaveAs(
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      return this.SaveAs(failureModeMaint, (FailureModeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Parameters parameters,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      result = (FailureModeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) failureModeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeMaintService) this._Channel).UnFreeze(this._UserProfile, failureModeMaint, parameters, request, out result) : this.AddMethod((Method) new FailureModeMaintMethod(failureModeMaint, FailureModeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) failureModeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((FailureModeMaint) null, (FailureModeMaint_Parameters) null, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus UnFreeze(FailureModeMaint failureModeMaint)
    {
      return this.UnFreeze(failureModeMaint, (FailureModeMaint_Parameters) null, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      return this.UnFreeze(failureModeMaint, (FailureModeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject failureModeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureModeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((FailureModeMaint) failureModeMaint, (FailureModeMaint_Parameters) parameters, (FailureModeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject failureModeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureModeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((FailureModeMaint) failureModeMaint, (FailureModeMaint_Parameters) parameters, (FailureModeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject failureModeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureModeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((FailureModeMaint) failureModeMaint, (FailureModeMaint_LoadESigDetails_Parameters) parameters, (FailureModeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject failureModeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureModeMaint_Result result1;
        ResultStatus resultStatus = this.New((FailureModeMaint) failureModeMaint, (FailureModeMaint_Parameters) parameters, (FailureModeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject failureModeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureModeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((FailureModeMaint) failureModeMaint, (FailureModeMaint_Parameters) parameters, (FailureModeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject failureModeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureModeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((FailureModeMaint) failureModeMaint, (FailureModeMaint_Parameters) parameters, (FailureModeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject failureModeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureModeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((FailureModeMaint) failureModeMaint, (FailureModeMaint_Parameters) parameters, (FailureModeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject failureModeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureModeMaint_Result result1;
        ResultStatus resultStatus = this.Load((FailureModeMaint) failureModeMaint, (FailureModeMaint_Parameters) parameters, (FailureModeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject failureModeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureModeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((FailureModeMaint) failureModeMaint, (FailureModeMaint_Parameters) parameters, (FailureModeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      result = (FailureModeMaint_Result) null;
      try
      {
        FailureModeMaintMethod[] methods = new FailureModeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IFailureModeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        FailureModeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((FailureModeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      FailureModeMaint cdo,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      result = (FailureModeMaint_Result) null;
      try
      {
        return ((IFailureModeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        FailureModeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((FailureModeMaint) cdo, (FailureModeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      return this.GetEnvironment((FailureModeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      FailureModeMaint cdo,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      result = (FailureModeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureModeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new FailureModeMaintMethod(cdo, FailureModeMaintMethods.ExecuteTransaction, (FailureModeMaint_Parameters) null));
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
        FailureModeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((FailureModeMaint) cdo, (FailureModeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(FailureModeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (FailureModeMaint_Request) null, out FailureModeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result)
    {
      return this.ExecuteTransaction((FailureModeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(FailureModeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new FailureModeMaintMethod(cdo, FailureModeMaintMethods.AddDataTransaction, (FailureModeMaint_Parameters) null));
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
        return this.AddDataTransaction((FailureModeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
