// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateEventDataService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UpdateEventDataService : UpdateEventDetailsBase
  {
    public UpdateEventDataService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUpdateEventDataService), userProfile);
    }

    public ResultStatus CreateParametricData(
      UpdateEventData updateEventData,
      UpdateEventData_Parameters parameters,
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      result = (UpdateEventData_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) updateEventData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDataService) this._Channel).CreateParametricData(this._UserProfile, updateEventData, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDataMethod(updateEventData, UpdateEventDataMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) updateEventData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((UpdateEventData) null, (UpdateEventData_Parameters) null, (UpdateEventData_Request) null, out UpdateEventData_Result _);
    }

    public ResultStatus CreateParametricData(UpdateEventData updateEventData)
    {
      return this.CreateParametricData(updateEventData, (UpdateEventData_Parameters) null, (UpdateEventData_Request) null, out UpdateEventData_Result _);
    }

    public ResultStatus CreateParametricData(
      UpdateEventData updateEventData,
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      return this.CreateParametricData(updateEventData, (UpdateEventData_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      UpdateEventData updateEventData,
      UpdateEventData_Parameters parameters,
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      result = (UpdateEventData_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) updateEventData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDataService) this._Channel).GetActions(this._UserProfile, updateEventData, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDataMethod(updateEventData, UpdateEventDataMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) updateEventData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((UpdateEventData) null, (UpdateEventData_Parameters) null, (UpdateEventData_Request) null, out UpdateEventData_Result _);
    }

    public ResultStatus GetActions(UpdateEventData updateEventData)
    {
      return this.GetActions(updateEventData, (UpdateEventData_Parameters) null, (UpdateEventData_Request) null, out UpdateEventData_Result _);
    }

    public ResultStatus GetActions(
      UpdateEventData updateEventData,
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      return this.GetActions(updateEventData, (UpdateEventData_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      UpdateEventData updateEventData,
      UpdateEventData_Parameters parameters,
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      result = (UpdateEventData_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) updateEventData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDataService) this._Channel).GetDataPoints(this._UserProfile, updateEventData, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDataMethod(updateEventData, UpdateEventDataMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) updateEventData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((UpdateEventData) null, (UpdateEventData_Parameters) null, (UpdateEventData_Request) null, out UpdateEventData_Result _);
    }

    public ResultStatus GetDataPoints(UpdateEventData updateEventData)
    {
      return this.GetDataPoints(updateEventData, (UpdateEventData_Parameters) null, (UpdateEventData_Request) null, out UpdateEventData_Result _);
    }

    public ResultStatus GetDataPoints(
      UpdateEventData updateEventData,
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      return this.GetDataPoints(updateEventData, (UpdateEventData_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventData updateEventData,
      UpdateEventData_Parameters parameters,
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      result = (UpdateEventData_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) updateEventData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDataService) this._Channel).GetWIPMsgs(this._UserProfile, updateEventData, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDataMethod(updateEventData, UpdateEventDataMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) updateEventData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UpdateEventData) null, (UpdateEventData_Parameters) null, (UpdateEventData_Request) null, out UpdateEventData_Result _);
    }

    public ResultStatus GetWIPMsgs(UpdateEventData updateEventData)
    {
      return this.GetWIPMsgs(updateEventData, (UpdateEventData_Parameters) null, (UpdateEventData_Request) null, out UpdateEventData_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventData updateEventData,
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      return this.GetWIPMsgs(updateEventData, (UpdateEventData_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UpdateEventData updateEventData,
      UpdateEventData_Parameters parameters,
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      result = (UpdateEventData_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) updateEventData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDataService) this._Channel).Load(this._UserProfile, updateEventData, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDataMethod(updateEventData, UpdateEventDataMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) updateEventData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UpdateEventData) null, (UpdateEventData_Parameters) null, (UpdateEventData_Request) null, out UpdateEventData_Result _);
    }

    public ResultStatus Load(UpdateEventData updateEventData)
    {
      return this.Load(updateEventData, (UpdateEventData_Parameters) null, (UpdateEventData_Request) null, out UpdateEventData_Result _);
    }

    public ResultStatus Load(
      UpdateEventData updateEventData,
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      return this.Load(updateEventData, (UpdateEventData_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventData updateEventData,
      UpdateEventData_Parameters parameters,
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      result = (UpdateEventData_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) updateEventData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDataService) this._Channel).LoadESigDetails(this._UserProfile, updateEventData, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDataMethod(updateEventData, UpdateEventDataMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) updateEventData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UpdateEventData) null, (UpdateEventData_Parameters) null, (UpdateEventData_Request) null, out UpdateEventData_Result _);
    }

    public ResultStatus LoadESigDetails(UpdateEventData updateEventData)
    {
      return this.LoadESigDetails(updateEventData, (UpdateEventData_Parameters) null, (UpdateEventData_Request) null, out UpdateEventData_Result _);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventData updateEventData,
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      return this.LoadESigDetails(updateEventData, (UpdateEventData_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      UpdateEventData updateEventData,
      UpdateEventData_Parameters parameters,
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      result = (UpdateEventData_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) updateEventData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDataService) this._Channel).ProcessComputation(this._UserProfile, updateEventData, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDataMethod(updateEventData, UpdateEventDataMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) updateEventData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((UpdateEventData) null, (UpdateEventData_Parameters) null, (UpdateEventData_Request) null, out UpdateEventData_Result _);
    }

    public ResultStatus ProcessComputation(UpdateEventData updateEventData)
    {
      return this.ProcessComputation(updateEventData, (UpdateEventData_Parameters) null, (UpdateEventData_Request) null, out UpdateEventData_Result _);
    }

    public ResultStatus ProcessComputation(
      UpdateEventData updateEventData,
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      return this.ProcessComputation(updateEventData, (UpdateEventData_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventData updateEventData,
      UpdateEventData_Parameters parameters,
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      result = (UpdateEventData_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) updateEventData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDataService) this._Channel).ResolveParametricData(this._UserProfile, updateEventData, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDataMethod(updateEventData, UpdateEventDataMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) updateEventData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((UpdateEventData) null, (UpdateEventData_Parameters) null, (UpdateEventData_Request) null, out UpdateEventData_Result _);
    }

    public ResultStatus ResolveParametricData(UpdateEventData updateEventData)
    {
      return this.ResolveParametricData(updateEventData, (UpdateEventData_Parameters) null, (UpdateEventData_Request) null, out UpdateEventData_Result _);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventData updateEventData,
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      return this.ResolveParametricData(updateEventData, (UpdateEventData_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject updateEventData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventData_Result result1;
        ResultStatus parametricData = this.CreateParametricData((UpdateEventData) updateEventData, (UpdateEventData_Parameters) parameters, (UpdateEventData_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject updateEventData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventData_Result result1;
        ResultStatus actions = this.GetActions((UpdateEventData) updateEventData, (UpdateEventData_Parameters) parameters, (UpdateEventData_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject updateEventData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventData_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((UpdateEventData) updateEventData, (UpdateEventData_Parameters) parameters, (UpdateEventData_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject updateEventData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventData_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UpdateEventData) updateEventData, (UpdateEventData_Parameters) parameters, (UpdateEventData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject updateEventData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventData_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((UpdateEventData) updateEventData, (UpdateEventData_Parameters) parameters, (UpdateEventData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject updateEventData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventData_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((UpdateEventData) updateEventData, (UpdateEventData_Parameters) parameters, (UpdateEventData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject updateEventData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventData_Result result1;
        ResultStatus resultStatus = this.Load((UpdateEventData) updateEventData, (UpdateEventData_Parameters) parameters, (UpdateEventData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject updateEventData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventData_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UpdateEventData) updateEventData, (UpdateEventData_Parameters) parameters, (UpdateEventData_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      result = (UpdateEventData_Result) null;
      try
      {
        UpdateEventDataMethod[] methods = new UpdateEventDataMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUpdateEventDataService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UpdateEventData_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UpdateEventData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventData cdo,
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      result = (UpdateEventData_Result) null;
      try
      {
        return ((IUpdateEventDataService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UpdateEventData_Result result1;
        ResultStatus environment = this.GetEnvironment((UpdateEventData) cdo, (UpdateEventData_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      return this.GetEnvironment((UpdateEventData) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventData cdo,
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      result = (UpdateEventData_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDataService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UpdateEventDataMethod(cdo, UpdateEventDataMethods.ExecuteTransaction, (UpdateEventData_Parameters) null));
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
        UpdateEventData_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UpdateEventData) cdo, (UpdateEventData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UpdateEventData cdo)
    {
      return this.ExecuteTransaction(cdo, (UpdateEventData_Request) null, out UpdateEventData_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventData_Request request,
      out UpdateEventData_Result result)
    {
      return this.ExecuteTransaction((UpdateEventData) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UpdateEventData cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UpdateEventDataMethod(cdo, UpdateEventDataMethods.AddDataTransaction, (UpdateEventData_Parameters) null));
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
        return this.AddDataTransaction((UpdateEventData) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
