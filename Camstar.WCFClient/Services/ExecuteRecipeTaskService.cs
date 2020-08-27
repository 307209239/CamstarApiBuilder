// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ExecuteRecipeTaskService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ExecuteRecipeTaskService : ExecuteProductionProcessBase
  {
    public ExecuteRecipeTaskService(UserProfile userProfile)
    {
      this.Initialize(typeof (IExecuteRecipeTaskService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Parameters parameters,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      result = (ExecuteRecipeTask_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) executeRecipeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteRecipeTaskService) this._Channel).CreateParametricData(this._UserProfile, executeRecipeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteRecipeTaskMethod(executeRecipeTask, ExecuteRecipeTaskMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) executeRecipeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ExecuteRecipeTask) null, (ExecuteRecipeTask_Parameters) null, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus CreateParametricData(ExecuteRecipeTask executeRecipeTask)
    {
      return this.CreateParametricData(executeRecipeTask, (ExecuteRecipeTask_Parameters) null, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus CreateParametricData(
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      return this.CreateParametricData(executeRecipeTask, (ExecuteRecipeTask_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Parameters parameters,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      result = (ExecuteRecipeTask_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) executeRecipeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteRecipeTaskService) this._Channel).GetActions(this._UserProfile, executeRecipeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteRecipeTaskMethod(executeRecipeTask, ExecuteRecipeTaskMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) executeRecipeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ExecuteRecipeTask) null, (ExecuteRecipeTask_Parameters) null, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus GetActions(ExecuteRecipeTask executeRecipeTask)
    {
      return this.GetActions(executeRecipeTask, (ExecuteRecipeTask_Parameters) null, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus GetActions(
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      return this.GetActions(executeRecipeTask, (ExecuteRecipeTask_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Parameters parameters,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      result = (ExecuteRecipeTask_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) executeRecipeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteRecipeTaskService) this._Channel).GetDataPoints(this._UserProfile, executeRecipeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteRecipeTaskMethod(executeRecipeTask, ExecuteRecipeTaskMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) executeRecipeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ExecuteRecipeTask) null, (ExecuteRecipeTask_Parameters) null, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus GetDataPoints(ExecuteRecipeTask executeRecipeTask)
    {
      return this.GetDataPoints(executeRecipeTask, (ExecuteRecipeTask_Parameters) null, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus GetDataPoints(
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      return this.GetDataPoints(executeRecipeTask, (ExecuteRecipeTask_Parameters) null, request, out result);
    }

    public ResultStatus GetMaterialSelectionValues(
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_GetMaterialSelectionValues_Parameters parameters,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      result = (ExecuteRecipeTask_Result) null;
      this.OnBeforeCall(nameof (GetMaterialSelectionValues), (DCObject) executeRecipeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteRecipeTaskService) this._Channel).GetMaterialSelectionValues(this._UserProfile, executeRecipeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteRecipeTaskMethod(executeRecipeTask, ExecuteRecipeTaskMethods.GetMaterialSelectionValues, (ExecuteRecipeTask_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetMaterialSelectionValues), res, (DCObject) executeRecipeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetMaterialSelectionValues()
    {
      return this.GetMaterialSelectionValues((ExecuteRecipeTask) null, (ExecuteRecipeTask_GetMaterialSelectionValues_Parameters) null, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus GetMaterialSelectionValues(ExecuteRecipeTask executeRecipeTask)
    {
      return this.GetMaterialSelectionValues(executeRecipeTask, (ExecuteRecipeTask_GetMaterialSelectionValues_Parameters) null, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus GetMaterialSelectionValues(
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      return this.GetMaterialSelectionValues(executeRecipeTask, (ExecuteRecipeTask_GetMaterialSelectionValues_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Parameters parameters,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      result = (ExecuteRecipeTask_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) executeRecipeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteRecipeTaskService) this._Channel).GetWIPMsgs(this._UserProfile, executeRecipeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteRecipeTaskMethod(executeRecipeTask, ExecuteRecipeTaskMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) executeRecipeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ExecuteRecipeTask) null, (ExecuteRecipeTask_Parameters) null, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus GetWIPMsgs(ExecuteRecipeTask executeRecipeTask)
    {
      return this.GetWIPMsgs(executeRecipeTask, (ExecuteRecipeTask_Parameters) null, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      return this.GetWIPMsgs(executeRecipeTask, (ExecuteRecipeTask_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Parameters parameters,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      result = (ExecuteRecipeTask_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) executeRecipeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteRecipeTaskService) this._Channel).Load(this._UserProfile, executeRecipeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteRecipeTaskMethod(executeRecipeTask, ExecuteRecipeTaskMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) executeRecipeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ExecuteRecipeTask) null, (ExecuteRecipeTask_Parameters) null, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus Load(ExecuteRecipeTask executeRecipeTask)
    {
      return this.Load(executeRecipeTask, (ExecuteRecipeTask_Parameters) null, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus Load(
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      return this.Load(executeRecipeTask, (ExecuteRecipeTask_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_LoadESigDetails_Parameters parameters,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      result = (ExecuteRecipeTask_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) executeRecipeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteRecipeTaskService) this._Channel).LoadESigDetails(this._UserProfile, executeRecipeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteRecipeTaskMethod(executeRecipeTask, ExecuteRecipeTaskMethods.LoadESigDetails, (ExecuteRecipeTask_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) executeRecipeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ExecuteRecipeTask) null, (ExecuteRecipeTask_LoadESigDetails_Parameters) null, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus LoadESigDetails(ExecuteRecipeTask executeRecipeTask)
    {
      return this.LoadESigDetails(executeRecipeTask, (ExecuteRecipeTask_LoadESigDetails_Parameters) null, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus LoadESigDetails(
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      return this.LoadESigDetails(executeRecipeTask, (ExecuteRecipeTask_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Parameters parameters,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      result = (ExecuteRecipeTask_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) executeRecipeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteRecipeTaskService) this._Channel).ProcessComputation(this._UserProfile, executeRecipeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteRecipeTaskMethod(executeRecipeTask, ExecuteRecipeTaskMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) executeRecipeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ExecuteRecipeTask) null, (ExecuteRecipeTask_Parameters) null, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus ProcessComputation(ExecuteRecipeTask executeRecipeTask)
    {
      return this.ProcessComputation(executeRecipeTask, (ExecuteRecipeTask_Parameters) null, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus ProcessComputation(
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      return this.ProcessComputation(executeRecipeTask, (ExecuteRecipeTask_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Parameters parameters,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      result = (ExecuteRecipeTask_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) executeRecipeTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteRecipeTaskService) this._Channel).ResolveParametricData(this._UserProfile, executeRecipeTask, parameters, request, out result) : this.AddMethod((Method) new ExecuteRecipeTaskMethod(executeRecipeTask, ExecuteRecipeTaskMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) executeRecipeTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ExecuteRecipeTask) null, (ExecuteRecipeTask_Parameters) null, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus ResolveParametricData(ExecuteRecipeTask executeRecipeTask)
    {
      return this.ResolveParametricData(executeRecipeTask, (ExecuteRecipeTask_Parameters) null, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus ResolveParametricData(
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      return this.ResolveParametricData(executeRecipeTask, (ExecuteRecipeTask_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject executeRecipeTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteRecipeTask_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ExecuteRecipeTask) executeRecipeTask, (ExecuteRecipeTask_Parameters) parameters, (ExecuteRecipeTask_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject executeRecipeTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteRecipeTask_Result result1;
        ResultStatus actions = this.GetActions((ExecuteRecipeTask) executeRecipeTask, (ExecuteRecipeTask_Parameters) parameters, (ExecuteRecipeTask_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject executeRecipeTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteRecipeTask_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ExecuteRecipeTask) executeRecipeTask, (ExecuteRecipeTask_Parameters) parameters, (ExecuteRecipeTask_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject executeRecipeTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteRecipeTask_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ExecuteRecipeTask) executeRecipeTask, (ExecuteRecipeTask_LoadESigDetails_Parameters) parameters, (ExecuteRecipeTask_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject executeRecipeTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteRecipeTask_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ExecuteRecipeTask) executeRecipeTask, (ExecuteRecipeTask_Parameters) parameters, (ExecuteRecipeTask_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject executeRecipeTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteRecipeTask_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ExecuteRecipeTask) executeRecipeTask, (ExecuteRecipeTask_Parameters) parameters, (ExecuteRecipeTask_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject executeRecipeTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteRecipeTask_Result result1;
        ResultStatus resultStatus = this.Load((ExecuteRecipeTask) executeRecipeTask, (ExecuteRecipeTask_Parameters) parameters, (ExecuteRecipeTask_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject executeRecipeTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteRecipeTask_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ExecuteRecipeTask) executeRecipeTask, (ExecuteRecipeTask_Parameters) parameters, (ExecuteRecipeTask_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      result = (ExecuteRecipeTask_Result) null;
      try
      {
        ExecuteRecipeTaskMethod[] methods = new ExecuteRecipeTaskMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IExecuteRecipeTaskService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ExecuteRecipeTask_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ExecuteRecipeTask_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ExecuteRecipeTask cdo,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      result = (ExecuteRecipeTask_Result) null;
      try
      {
        return ((IExecuteRecipeTaskService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ExecuteRecipeTask_Result result1;
        ResultStatus environment = this.GetEnvironment((ExecuteRecipeTask) cdo, (ExecuteRecipeTask_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      return this.GetEnvironment((ExecuteRecipeTask) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ExecuteRecipeTask cdo,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      result = (ExecuteRecipeTask_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteRecipeTaskService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ExecuteRecipeTaskMethod(cdo, ExecuteRecipeTaskMethods.ExecuteTransaction, (ExecuteRecipeTask_Parameters) null));
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
        ExecuteRecipeTask_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ExecuteRecipeTask) cdo, (ExecuteRecipeTask_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ExecuteRecipeTask cdo)
    {
      return this.ExecuteTransaction(cdo, (ExecuteRecipeTask_Request) null, out ExecuteRecipeTask_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result)
    {
      return this.ExecuteTransaction((ExecuteRecipeTask) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ExecuteRecipeTask cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ExecuteRecipeTaskMethod(cdo, ExecuteRecipeTaskMethods.AddDataTransaction, (ExecuteRecipeTask_Parameters) null));
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
        return this.AddDataTransaction((ExecuteRecipeTask) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
