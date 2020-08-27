// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateEventLogsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UpdateEventLogsService : UpdateEventDetailsBase
  {
    public UpdateEventLogsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUpdateEventLogsService), userProfile);
    }

    public ResultStatus CreateParametricData(
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Parameters parameters,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      result = (UpdateEventLogs_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) updateEventLogs, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventLogsService) this._Channel).CreateParametricData(this._UserProfile, updateEventLogs, parameters, request, out result) : this.AddMethod((Method) new UpdateEventLogsMethod(updateEventLogs, UpdateEventLogsMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) updateEventLogs, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((UpdateEventLogs) null, (UpdateEventLogs_Parameters) null, (UpdateEventLogs_Request) null, out UpdateEventLogs_Result _);
    }

    public ResultStatus CreateParametricData(UpdateEventLogs updateEventLogs)
    {
      return this.CreateParametricData(updateEventLogs, (UpdateEventLogs_Parameters) null, (UpdateEventLogs_Request) null, out UpdateEventLogs_Result _);
    }

    public ResultStatus CreateParametricData(
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      return this.CreateParametricData(updateEventLogs, (UpdateEventLogs_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Parameters parameters,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      result = (UpdateEventLogs_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) updateEventLogs, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventLogsService) this._Channel).GetActions(this._UserProfile, updateEventLogs, parameters, request, out result) : this.AddMethod((Method) new UpdateEventLogsMethod(updateEventLogs, UpdateEventLogsMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) updateEventLogs, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((UpdateEventLogs) null, (UpdateEventLogs_Parameters) null, (UpdateEventLogs_Request) null, out UpdateEventLogs_Result _);
    }

    public ResultStatus GetActions(UpdateEventLogs updateEventLogs)
    {
      return this.GetActions(updateEventLogs, (UpdateEventLogs_Parameters) null, (UpdateEventLogs_Request) null, out UpdateEventLogs_Result _);
    }

    public ResultStatus GetActions(
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      return this.GetActions(updateEventLogs, (UpdateEventLogs_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Parameters parameters,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      result = (UpdateEventLogs_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) updateEventLogs, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventLogsService) this._Channel).GetDataPoints(this._UserProfile, updateEventLogs, parameters, request, out result) : this.AddMethod((Method) new UpdateEventLogsMethod(updateEventLogs, UpdateEventLogsMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) updateEventLogs, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((UpdateEventLogs) null, (UpdateEventLogs_Parameters) null, (UpdateEventLogs_Request) null, out UpdateEventLogs_Result _);
    }

    public ResultStatus GetDataPoints(UpdateEventLogs updateEventLogs)
    {
      return this.GetDataPoints(updateEventLogs, (UpdateEventLogs_Parameters) null, (UpdateEventLogs_Request) null, out UpdateEventLogs_Result _);
    }

    public ResultStatus GetDataPoints(
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      return this.GetDataPoints(updateEventLogs, (UpdateEventLogs_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Parameters parameters,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      result = (UpdateEventLogs_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) updateEventLogs, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventLogsService) this._Channel).GetWIPMsgs(this._UserProfile, updateEventLogs, parameters, request, out result) : this.AddMethod((Method) new UpdateEventLogsMethod(updateEventLogs, UpdateEventLogsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) updateEventLogs, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UpdateEventLogs) null, (UpdateEventLogs_Parameters) null, (UpdateEventLogs_Request) null, out UpdateEventLogs_Result _);
    }

    public ResultStatus GetWIPMsgs(UpdateEventLogs updateEventLogs)
    {
      return this.GetWIPMsgs(updateEventLogs, (UpdateEventLogs_Parameters) null, (UpdateEventLogs_Request) null, out UpdateEventLogs_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      return this.GetWIPMsgs(updateEventLogs, (UpdateEventLogs_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Parameters parameters,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      result = (UpdateEventLogs_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) updateEventLogs, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventLogsService) this._Channel).Load(this._UserProfile, updateEventLogs, parameters, request, out result) : this.AddMethod((Method) new UpdateEventLogsMethod(updateEventLogs, UpdateEventLogsMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) updateEventLogs, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UpdateEventLogs) null, (UpdateEventLogs_Parameters) null, (UpdateEventLogs_Request) null, out UpdateEventLogs_Result _);
    }

    public ResultStatus Load(UpdateEventLogs updateEventLogs)
    {
      return this.Load(updateEventLogs, (UpdateEventLogs_Parameters) null, (UpdateEventLogs_Request) null, out UpdateEventLogs_Result _);
    }

    public ResultStatus Load(
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      return this.Load(updateEventLogs, (UpdateEventLogs_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Parameters parameters,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      result = (UpdateEventLogs_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) updateEventLogs, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventLogsService) this._Channel).LoadESigDetails(this._UserProfile, updateEventLogs, parameters, request, out result) : this.AddMethod((Method) new UpdateEventLogsMethod(updateEventLogs, UpdateEventLogsMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) updateEventLogs, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UpdateEventLogs) null, (UpdateEventLogs_Parameters) null, (UpdateEventLogs_Request) null, out UpdateEventLogs_Result _);
    }

    public ResultStatus LoadESigDetails(UpdateEventLogs updateEventLogs)
    {
      return this.LoadESigDetails(updateEventLogs, (UpdateEventLogs_Parameters) null, (UpdateEventLogs_Request) null, out UpdateEventLogs_Result _);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      return this.LoadESigDetails(updateEventLogs, (UpdateEventLogs_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Parameters parameters,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      result = (UpdateEventLogs_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) updateEventLogs, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventLogsService) this._Channel).ProcessComputation(this._UserProfile, updateEventLogs, parameters, request, out result) : this.AddMethod((Method) new UpdateEventLogsMethod(updateEventLogs, UpdateEventLogsMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) updateEventLogs, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((UpdateEventLogs) null, (UpdateEventLogs_Parameters) null, (UpdateEventLogs_Request) null, out UpdateEventLogs_Result _);
    }

    public ResultStatus ProcessComputation(UpdateEventLogs updateEventLogs)
    {
      return this.ProcessComputation(updateEventLogs, (UpdateEventLogs_Parameters) null, (UpdateEventLogs_Request) null, out UpdateEventLogs_Result _);
    }

    public ResultStatus ProcessComputation(
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      return this.ProcessComputation(updateEventLogs, (UpdateEventLogs_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Parameters parameters,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      result = (UpdateEventLogs_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) updateEventLogs, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventLogsService) this._Channel).ResolveParametricData(this._UserProfile, updateEventLogs, parameters, request, out result) : this.AddMethod((Method) new UpdateEventLogsMethod(updateEventLogs, UpdateEventLogsMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) updateEventLogs, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((UpdateEventLogs) null, (UpdateEventLogs_Parameters) null, (UpdateEventLogs_Request) null, out UpdateEventLogs_Result _);
    }

    public ResultStatus ResolveParametricData(UpdateEventLogs updateEventLogs)
    {
      return this.ResolveParametricData(updateEventLogs, (UpdateEventLogs_Parameters) null, (UpdateEventLogs_Request) null, out UpdateEventLogs_Result _);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      return this.ResolveParametricData(updateEventLogs, (UpdateEventLogs_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject updateEventLogs,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventLogs_Result result1;
        ResultStatus parametricData = this.CreateParametricData((UpdateEventLogs) updateEventLogs, (UpdateEventLogs_Parameters) parameters, (UpdateEventLogs_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject updateEventLogs,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventLogs_Result result1;
        ResultStatus actions = this.GetActions((UpdateEventLogs) updateEventLogs, (UpdateEventLogs_Parameters) parameters, (UpdateEventLogs_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject updateEventLogs,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventLogs_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((UpdateEventLogs) updateEventLogs, (UpdateEventLogs_Parameters) parameters, (UpdateEventLogs_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject updateEventLogs,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventLogs_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UpdateEventLogs) updateEventLogs, (UpdateEventLogs_Parameters) parameters, (UpdateEventLogs_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject updateEventLogs,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventLogs_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((UpdateEventLogs) updateEventLogs, (UpdateEventLogs_Parameters) parameters, (UpdateEventLogs_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject updateEventLogs,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventLogs_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((UpdateEventLogs) updateEventLogs, (UpdateEventLogs_Parameters) parameters, (UpdateEventLogs_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject updateEventLogs,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventLogs_Result result1;
        ResultStatus resultStatus = this.Load((UpdateEventLogs) updateEventLogs, (UpdateEventLogs_Parameters) parameters, (UpdateEventLogs_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject updateEventLogs,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventLogs_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UpdateEventLogs) updateEventLogs, (UpdateEventLogs_Parameters) parameters, (UpdateEventLogs_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      result = (UpdateEventLogs_Result) null;
      try
      {
        UpdateEventLogsMethod[] methods = new UpdateEventLogsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUpdateEventLogsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UpdateEventLogs_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UpdateEventLogs_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventLogs cdo,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      result = (UpdateEventLogs_Result) null;
      try
      {
        return ((IUpdateEventLogsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UpdateEventLogs_Result result1;
        ResultStatus environment = this.GetEnvironment((UpdateEventLogs) cdo, (UpdateEventLogs_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      return this.GetEnvironment((UpdateEventLogs) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventLogs cdo,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      result = (UpdateEventLogs_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventLogsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UpdateEventLogsMethod(cdo, UpdateEventLogsMethods.ExecuteTransaction, (UpdateEventLogs_Parameters) null));
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
        UpdateEventLogs_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UpdateEventLogs) cdo, (UpdateEventLogs_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UpdateEventLogs cdo)
    {
      return this.ExecuteTransaction(cdo, (UpdateEventLogs_Request) null, out UpdateEventLogs_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result)
    {
      return this.ExecuteTransaction((UpdateEventLogs) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UpdateEventLogs cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UpdateEventLogsMethod(cdo, UpdateEventLogsMethods.AddDataTransaction, (UpdateEventLogs_Parameters) null));
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
        return this.AddDataTransaction((UpdateEventLogs) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
