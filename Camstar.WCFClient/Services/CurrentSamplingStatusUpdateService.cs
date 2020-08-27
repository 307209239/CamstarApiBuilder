// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CurrentSamplingStatusUpdateService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CurrentSamplingStatusUpdateService : GenericTxnBase
  {
    public CurrentSamplingStatusUpdateService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICurrentSamplingStatusUpdateService), userProfile);
    }

    public ResultStatus CreateParametricData(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Parameters parameters,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      result = (CurrentSamplingStatusUpdate_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) currentSamplingStatusUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICurrentSamplingStatusUpdateService) this._Channel).CreateParametricData(this._UserProfile, currentSamplingStatusUpdate, parameters, request, out result) : this.AddMethod((Method) new CurrentSamplingStatusUpdateMethod(currentSamplingStatusUpdate, CurrentSamplingStatusUpdateMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) currentSamplingStatusUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CurrentSamplingStatusUpdate) null, (CurrentSamplingStatusUpdate_Parameters) null, (CurrentSamplingStatusUpdate_Request) null, out CurrentSamplingStatusUpdate_Result _);
    }

    public ResultStatus CreateParametricData(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate)
    {
      return this.CreateParametricData(currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) null, (CurrentSamplingStatusUpdate_Request) null, out CurrentSamplingStatusUpdate_Result _);
    }

    public ResultStatus CreateParametricData(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      return this.CreateParametricData(currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Parameters parameters,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      result = (CurrentSamplingStatusUpdate_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) currentSamplingStatusUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICurrentSamplingStatusUpdateService) this._Channel).GetActions(this._UserProfile, currentSamplingStatusUpdate, parameters, request, out result) : this.AddMethod((Method) new CurrentSamplingStatusUpdateMethod(currentSamplingStatusUpdate, CurrentSamplingStatusUpdateMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) currentSamplingStatusUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CurrentSamplingStatusUpdate) null, (CurrentSamplingStatusUpdate_Parameters) null, (CurrentSamplingStatusUpdate_Request) null, out CurrentSamplingStatusUpdate_Result _);
    }

    public ResultStatus GetActions(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate)
    {
      return this.GetActions(currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) null, (CurrentSamplingStatusUpdate_Request) null, out CurrentSamplingStatusUpdate_Result _);
    }

    public ResultStatus GetActions(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      return this.GetActions(currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Parameters parameters,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      result = (CurrentSamplingStatusUpdate_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) currentSamplingStatusUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICurrentSamplingStatusUpdateService) this._Channel).GetDataPoints(this._UserProfile, currentSamplingStatusUpdate, parameters, request, out result) : this.AddMethod((Method) new CurrentSamplingStatusUpdateMethod(currentSamplingStatusUpdate, CurrentSamplingStatusUpdateMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) currentSamplingStatusUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CurrentSamplingStatusUpdate) null, (CurrentSamplingStatusUpdate_Parameters) null, (CurrentSamplingStatusUpdate_Request) null, out CurrentSamplingStatusUpdate_Result _);
    }

    public ResultStatus GetDataPoints(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate)
    {
      return this.GetDataPoints(currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) null, (CurrentSamplingStatusUpdate_Request) null, out CurrentSamplingStatusUpdate_Result _);
    }

    public ResultStatus GetDataPoints(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      return this.GetDataPoints(currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Parameters parameters,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      result = (CurrentSamplingStatusUpdate_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) currentSamplingStatusUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICurrentSamplingStatusUpdateService) this._Channel).GetWIPMsgs(this._UserProfile, currentSamplingStatusUpdate, parameters, request, out result) : this.AddMethod((Method) new CurrentSamplingStatusUpdateMethod(currentSamplingStatusUpdate, CurrentSamplingStatusUpdateMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) currentSamplingStatusUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CurrentSamplingStatusUpdate) null, (CurrentSamplingStatusUpdate_Parameters) null, (CurrentSamplingStatusUpdate_Request) null, out CurrentSamplingStatusUpdate_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate)
    {
      return this.GetWIPMsgs(currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) null, (CurrentSamplingStatusUpdate_Request) null, out CurrentSamplingStatusUpdate_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      return this.GetWIPMsgs(currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Parameters parameters,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      result = (CurrentSamplingStatusUpdate_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) currentSamplingStatusUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICurrentSamplingStatusUpdateService) this._Channel).Load(this._UserProfile, currentSamplingStatusUpdate, parameters, request, out result) : this.AddMethod((Method) new CurrentSamplingStatusUpdateMethod(currentSamplingStatusUpdate, CurrentSamplingStatusUpdateMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) currentSamplingStatusUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CurrentSamplingStatusUpdate) null, (CurrentSamplingStatusUpdate_Parameters) null, (CurrentSamplingStatusUpdate_Request) null, out CurrentSamplingStatusUpdate_Result _);
    }

    public ResultStatus Load(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate)
    {
      return this.Load(currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) null, (CurrentSamplingStatusUpdate_Request) null, out CurrentSamplingStatusUpdate_Result _);
    }

    public ResultStatus Load(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      return this.Load(currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_LoadESigDetails_Parameters parameters,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      result = (CurrentSamplingStatusUpdate_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) currentSamplingStatusUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICurrentSamplingStatusUpdateService) this._Channel).LoadESigDetails(this._UserProfile, currentSamplingStatusUpdate, parameters, request, out result) : this.AddMethod((Method) new CurrentSamplingStatusUpdateMethod(currentSamplingStatusUpdate, CurrentSamplingStatusUpdateMethods.LoadESigDetails, (CurrentSamplingStatusUpdate_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) currentSamplingStatusUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CurrentSamplingStatusUpdate) null, (CurrentSamplingStatusUpdate_LoadESigDetails_Parameters) null, (CurrentSamplingStatusUpdate_Request) null, out CurrentSamplingStatusUpdate_Result _);
    }

    public ResultStatus LoadESigDetails(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate)
    {
      return this.LoadESigDetails(currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_LoadESigDetails_Parameters) null, (CurrentSamplingStatusUpdate_Request) null, out CurrentSamplingStatusUpdate_Result _);
    }

    public ResultStatus LoadESigDetails(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      return this.LoadESigDetails(currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Parameters parameters,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      result = (CurrentSamplingStatusUpdate_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) currentSamplingStatusUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICurrentSamplingStatusUpdateService) this._Channel).ProcessComputation(this._UserProfile, currentSamplingStatusUpdate, parameters, request, out result) : this.AddMethod((Method) new CurrentSamplingStatusUpdateMethod(currentSamplingStatusUpdate, CurrentSamplingStatusUpdateMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) currentSamplingStatusUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CurrentSamplingStatusUpdate) null, (CurrentSamplingStatusUpdate_Parameters) null, (CurrentSamplingStatusUpdate_Request) null, out CurrentSamplingStatusUpdate_Result _);
    }

    public ResultStatus ProcessComputation(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate)
    {
      return this.ProcessComputation(currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) null, (CurrentSamplingStatusUpdate_Request) null, out CurrentSamplingStatusUpdate_Result _);
    }

    public ResultStatus ProcessComputation(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      return this.ProcessComputation(currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Parameters parameters,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      result = (CurrentSamplingStatusUpdate_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) currentSamplingStatusUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICurrentSamplingStatusUpdateService) this._Channel).ResolveParametricData(this._UserProfile, currentSamplingStatusUpdate, parameters, request, out result) : this.AddMethod((Method) new CurrentSamplingStatusUpdateMethod(currentSamplingStatusUpdate, CurrentSamplingStatusUpdateMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) currentSamplingStatusUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CurrentSamplingStatusUpdate) null, (CurrentSamplingStatusUpdate_Parameters) null, (CurrentSamplingStatusUpdate_Request) null, out CurrentSamplingStatusUpdate_Result _);
    }

    public ResultStatus ResolveParametricData(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate)
    {
      return this.ResolveParametricData(currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) null, (CurrentSamplingStatusUpdate_Request) null, out CurrentSamplingStatusUpdate_Result _);
    }

    public ResultStatus ResolveParametricData(
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      return this.ResolveParametricData(currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject currentSamplingStatusUpdate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CurrentSamplingStatusUpdate_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CurrentSamplingStatusUpdate) currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) parameters, (CurrentSamplingStatusUpdate_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject currentSamplingStatusUpdate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CurrentSamplingStatusUpdate_Result result1;
        ResultStatus actions = this.GetActions((CurrentSamplingStatusUpdate) currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) parameters, (CurrentSamplingStatusUpdate_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject currentSamplingStatusUpdate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CurrentSamplingStatusUpdate_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CurrentSamplingStatusUpdate) currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) parameters, (CurrentSamplingStatusUpdate_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject currentSamplingStatusUpdate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CurrentSamplingStatusUpdate_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CurrentSamplingStatusUpdate) currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_LoadESigDetails_Parameters) parameters, (CurrentSamplingStatusUpdate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject currentSamplingStatusUpdate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CurrentSamplingStatusUpdate_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CurrentSamplingStatusUpdate) currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) parameters, (CurrentSamplingStatusUpdate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject currentSamplingStatusUpdate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CurrentSamplingStatusUpdate_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CurrentSamplingStatusUpdate) currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) parameters, (CurrentSamplingStatusUpdate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject currentSamplingStatusUpdate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CurrentSamplingStatusUpdate_Result result1;
        ResultStatus resultStatus = this.Load((CurrentSamplingStatusUpdate) currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) parameters, (CurrentSamplingStatusUpdate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject currentSamplingStatusUpdate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CurrentSamplingStatusUpdate_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CurrentSamplingStatusUpdate) currentSamplingStatusUpdate, (CurrentSamplingStatusUpdate_Parameters) parameters, (CurrentSamplingStatusUpdate_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      result = (CurrentSamplingStatusUpdate_Result) null;
      try
      {
        CurrentSamplingStatusUpdateMethod[] methods = new CurrentSamplingStatusUpdateMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICurrentSamplingStatusUpdateService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CurrentSamplingStatusUpdate_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CurrentSamplingStatusUpdate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CurrentSamplingStatusUpdate cdo,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      result = (CurrentSamplingStatusUpdate_Result) null;
      try
      {
        return ((ICurrentSamplingStatusUpdateService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CurrentSamplingStatusUpdate_Result result1;
        ResultStatus environment = this.GetEnvironment((CurrentSamplingStatusUpdate) cdo, (CurrentSamplingStatusUpdate_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      return this.GetEnvironment((CurrentSamplingStatusUpdate) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CurrentSamplingStatusUpdate cdo,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      result = (CurrentSamplingStatusUpdate_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICurrentSamplingStatusUpdateService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CurrentSamplingStatusUpdateMethod(cdo, CurrentSamplingStatusUpdateMethods.ExecuteTransaction, (CurrentSamplingStatusUpdate_Parameters) null));
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
        CurrentSamplingStatusUpdate_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CurrentSamplingStatusUpdate) cdo, (CurrentSamplingStatusUpdate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CurrentSamplingStatusUpdate cdo)
    {
      return this.ExecuteTransaction(cdo, (CurrentSamplingStatusUpdate_Request) null, out CurrentSamplingStatusUpdate_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result)
    {
      return this.ExecuteTransaction((CurrentSamplingStatusUpdate) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CurrentSamplingStatusUpdate cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CurrentSamplingStatusUpdateMethod(cdo, CurrentSamplingStatusUpdateMethods.AddDataTransaction, (CurrentSamplingStatusUpdate_Parameters) null));
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
        return this.AddDataTransaction((CurrentSamplingStatusUpdate) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
