// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ExecuteTaskService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ExecuteTaskService : ExecuteProductionProcessBase
  {
    public ExecuteTaskService(UserProfile userProfile)
    {
      this.Initialize(typeof (IExecuteTaskService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ExecuteTask executeTask,
      ExecuteTask_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      result = (ExecuteTask_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) executeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteTaskService) this._Channel).CreateParametricData(this._UserProfile, executeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteTaskMethod(executeTask, ExecuteTaskMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) executeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ExecuteTask) null, (ExecuteTask_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus CreateParametricData(ExecuteTask executeTask)
    {
      return this.CreateParametricData(executeTask, (ExecuteTask_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus CreateParametricData(
      ExecuteTask executeTask,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      return this.CreateParametricData(executeTask, (ExecuteTask_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ExecuteTask executeTask,
      ExecuteTask_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      result = (ExecuteTask_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) executeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteTaskService) this._Channel).GetActions(this._UserProfile, executeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteTaskMethod(executeTask, ExecuteTaskMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) executeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ExecuteTask) null, (ExecuteTask_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus GetActions(ExecuteTask executeTask)
    {
      return this.GetActions(executeTask, (ExecuteTask_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus GetActions(
      ExecuteTask executeTask,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      return this.GetActions(executeTask, (ExecuteTask_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ExecuteTask executeTask,
      ExecuteTask_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      result = (ExecuteTask_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) executeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteTaskService) this._Channel).GetDataPoints(this._UserProfile, executeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteTaskMethod(executeTask, ExecuteTaskMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) executeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ExecuteTask) null, (ExecuteTask_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus GetDataPoints(ExecuteTask executeTask)
    {
      return this.GetDataPoints(executeTask, (ExecuteTask_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus GetDataPoints(
      ExecuteTask executeTask,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      return this.GetDataPoints(executeTask, (ExecuteTask_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ExecuteTask executeTask,
      ExecuteTask_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      result = (ExecuteTask_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) executeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteTaskService) this._Channel).GetWIPMsgs(this._UserProfile, executeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteTaskMethod(executeTask, ExecuteTaskMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) executeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ExecuteTask) null, (ExecuteTask_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus GetWIPMsgs(ExecuteTask executeTask)
    {
      return this.GetWIPMsgs(executeTask, (ExecuteTask_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ExecuteTask executeTask,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      return this.GetWIPMsgs(executeTask, (ExecuteTask_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ExecuteTask executeTask,
      ExecuteTask_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      result = (ExecuteTask_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) executeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteTaskService) this._Channel).Load(this._UserProfile, executeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteTaskMethod(executeTask, ExecuteTaskMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) executeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ExecuteTask) null, (ExecuteTask_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus Load(ExecuteTask executeTask)
    {
      return this.Load(executeTask, (ExecuteTask_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus Load(
      ExecuteTask executeTask,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      return this.Load(executeTask, (ExecuteTask_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ExecuteTask executeTask,
      ExecuteTask_LoadESigDetails_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      result = (ExecuteTask_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) executeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteTaskService) this._Channel).LoadESigDetails(this._UserProfile, executeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteTaskMethod(executeTask, ExecuteTaskMethods.LoadESigDetails, (ExecuteTask_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) executeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ExecuteTask) null, (ExecuteTask_LoadESigDetails_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus LoadESigDetails(ExecuteTask executeTask)
    {
      return this.LoadESigDetails(executeTask, (ExecuteTask_LoadESigDetails_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus LoadESigDetails(
      ExecuteTask executeTask,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      return this.LoadESigDetails(executeTask, (ExecuteTask_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ExecuteTask executeTask,
      ExecuteTask_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      result = (ExecuteTask_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) executeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteTaskService) this._Channel).ProcessComputation(this._UserProfile, executeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteTaskMethod(executeTask, ExecuteTaskMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) executeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ExecuteTask) null, (ExecuteTask_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus ProcessComputation(ExecuteTask executeTask)
    {
      return this.ProcessComputation(executeTask, (ExecuteTask_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus ProcessComputation(
      ExecuteTask executeTask,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      return this.ProcessComputation(executeTask, (ExecuteTask_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ExecuteTask executeTask,
      ExecuteTask_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      result = (ExecuteTask_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) executeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteTaskService) this._Channel).ResolveParametricData(this._UserProfile, executeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteTaskMethod(executeTask, ExecuteTaskMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) executeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ExecuteTask) null, (ExecuteTask_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus ResolveParametricData(ExecuteTask executeTask)
    {
      return this.ResolveParametricData(executeTask, (ExecuteTask_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus ResolveParametricData(
      ExecuteTask executeTask,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      return this.ResolveParametricData(executeTask, (ExecuteTask_Parameters) null, request, out result);
    }

    public ResultStatus StartTaskTimers(
      ExecuteTask executeTask,
      ExecuteTask_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      result = (ExecuteTask_Result) null;
      this.OnBeforeCall(nameof (StartTaskTimers), (DCObject) executeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteTaskService) this._Channel).StartTaskTimers(this._UserProfile, executeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteTaskMethod(executeTask, ExecuteTaskMethods.StartTaskTimers, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (StartTaskTimers), res, (DCObject) executeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus StartTaskTimers()
    {
      return this.StartTaskTimers((ExecuteTask) null, (ExecuteTask_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus StartTaskTimers(ExecuteTask executeTask)
    {
      return this.StartTaskTimers(executeTask, (ExecuteTask_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus StartTaskTimers(
      ExecuteTask executeTask,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      return this.StartTaskTimers(executeTask, (ExecuteTask_Parameters) null, request, out result);
    }

    public ResultStatus ValidateTaskTimers(
      ExecuteTask executeTask,
      ExecuteTask_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      result = (ExecuteTask_Result) null;
      this.OnBeforeCall(nameof (ValidateTaskTimers), (DCObject) executeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteTaskService) this._Channel).ValidateTaskTimers(this._UserProfile, executeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteTaskMethod(executeTask, ExecuteTaskMethods.ValidateTaskTimers, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateTaskTimers), res, (DCObject) executeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateTaskTimers()
    {
      return this.ValidateTaskTimers((ExecuteTask) null, (ExecuteTask_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus ValidateTaskTimers(ExecuteTask executeTask)
    {
      return this.ValidateTaskTimers(executeTask, (ExecuteTask_Parameters) null, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus ValidateTaskTimers(
      ExecuteTask executeTask,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      return this.ValidateTaskTimers(executeTask, (ExecuteTask_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject executeTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteTask_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ExecuteTask) executeTask, (ExecuteTask_Parameters) parameters, (ExecuteTask_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject executeTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteTask_Result result1;
        ResultStatus actions = this.GetActions((ExecuteTask) executeTask, (ExecuteTask_Parameters) parameters, (ExecuteTask_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject executeTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteTask_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ExecuteTask) executeTask, (ExecuteTask_Parameters) parameters, (ExecuteTask_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject executeTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteTask_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ExecuteTask) executeTask, (ExecuteTask_LoadESigDetails_Parameters) parameters, (ExecuteTask_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject executeTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteTask_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ExecuteTask) executeTask, (ExecuteTask_Parameters) parameters, (ExecuteTask_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject executeTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteTask_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ExecuteTask) executeTask, (ExecuteTask_Parameters) parameters, (ExecuteTask_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject executeTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteTask_Result result1;
        ResultStatus resultStatus = this.Load((ExecuteTask) executeTask, (ExecuteTask_Parameters) parameters, (ExecuteTask_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject executeTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteTask_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ExecuteTask) executeTask, (ExecuteTask_Parameters) parameters, (ExecuteTask_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      result = (ExecuteTask_Result) null;
      try
      {
        ExecuteTaskMethod[] methods = new ExecuteTaskMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IExecuteTaskService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ExecuteTask_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ExecuteTask_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ExecuteTask cdo,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      result = (ExecuteTask_Result) null;
      try
      {
        return ((IExecuteTaskService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ExecuteTask_Result result1;
        ResultStatus environment = this.GetEnvironment((ExecuteTask) cdo, (ExecuteTask_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      return this.GetEnvironment((ExecuteTask) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ExecuteTask cdo,
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      result = (ExecuteTask_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteTaskService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ExecuteTaskMethod(cdo, ExecuteTaskMethods.ExecuteTransaction, (ExecuteTask_Parameters) null));
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
        ExecuteTask_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ExecuteTask) cdo, (ExecuteTask_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ExecuteTask cdo)
    {
      return this.ExecuteTransaction(cdo, (ExecuteTask_Request) null, out ExecuteTask_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ExecuteTask_Request request,
      out ExecuteTask_Result result)
    {
      return this.ExecuteTransaction((ExecuteTask) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ExecuteTask cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ExecuteTaskMethod(cdo, ExecuteTaskMethods.AddDataTransaction, (ExecuteTask_Parameters) null));
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
        return this.AddDataTransaction((ExecuteTask) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
