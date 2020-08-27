// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DelegateTaskService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DelegateTaskService : GenericTxnBase
  {
    public DelegateTaskService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDelegateTaskService), userProfile);
    }

    public ResultStatus CreateParametricData(
      DelegateTask delegateTask,
      DelegateTask_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      result = (DelegateTask_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) delegateTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTaskService) this._Channel).CreateParametricData(this._UserProfile, delegateTask, parameters, request, out result) : this.AddMethod((Method) new DelegateTaskMethod(delegateTask, DelegateTaskMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) delegateTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((DelegateTask) null, (DelegateTask_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus CreateParametricData(DelegateTask delegateTask)
    {
      return this.CreateParametricData(delegateTask, (DelegateTask_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus CreateParametricData(
      DelegateTask delegateTask,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      return this.CreateParametricData(delegateTask, (DelegateTask_Parameters) null, request, out result);
    }

    public ResultStatus DelegateApprover(
      DelegateTask delegateTask,
      DelegateTask_DelegateApprover_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      result = (DelegateTask_Result) null;
      this.OnBeforeCall(nameof (DelegateApprover), (DCObject) delegateTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTaskService) this._Channel).DelegateApprover(this._UserProfile, delegateTask, parameters, request, out result) : this.AddMethod((Method) new DelegateTaskMethod(delegateTask, DelegateTaskMethods.DelegateApprover, (DelegateTask_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DelegateApprover), res, (DCObject) delegateTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DelegateApprover()
    {
      return this.DelegateApprover((DelegateTask) null, (DelegateTask_DelegateApprover_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus DelegateApprover(DelegateTask delegateTask)
    {
      return this.DelegateApprover(delegateTask, (DelegateTask_DelegateApprover_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus DelegateApprover(
      DelegateTask delegateTask,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      return this.DelegateApprover(delegateTask, (DelegateTask_DelegateApprover_Parameters) null, request, out result);
    }

    public ResultStatus DelegateCollaborator(
      DelegateTask delegateTask,
      DelegateTask_DelegateCollaborator_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      result = (DelegateTask_Result) null;
      this.OnBeforeCall(nameof (DelegateCollaborator), (DCObject) delegateTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTaskService) this._Channel).DelegateCollaborator(this._UserProfile, delegateTask, parameters, request, out result) : this.AddMethod((Method) new DelegateTaskMethod(delegateTask, DelegateTaskMethods.DelegateCollaborator, (DelegateTask_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DelegateCollaborator), res, (DCObject) delegateTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DelegateCollaborator()
    {
      return this.DelegateCollaborator((DelegateTask) null, (DelegateTask_DelegateCollaborator_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus DelegateCollaborator(DelegateTask delegateTask)
    {
      return this.DelegateCollaborator(delegateTask, (DelegateTask_DelegateCollaborator_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus DelegateCollaborator(
      DelegateTask delegateTask,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      return this.DelegateCollaborator(delegateTask, (DelegateTask_DelegateCollaborator_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      DelegateTask delegateTask,
      DelegateTask_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      result = (DelegateTask_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) delegateTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTaskService) this._Channel).GetActions(this._UserProfile, delegateTask, parameters, request, out result) : this.AddMethod((Method) new DelegateTaskMethod(delegateTask, DelegateTaskMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) delegateTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((DelegateTask) null, (DelegateTask_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus GetActions(DelegateTask delegateTask)
    {
      return this.GetActions(delegateTask, (DelegateTask_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus GetActions(
      DelegateTask delegateTask,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      return this.GetActions(delegateTask, (DelegateTask_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      DelegateTask delegateTask,
      DelegateTask_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      result = (DelegateTask_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) delegateTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTaskService) this._Channel).GetDataPoints(this._UserProfile, delegateTask, parameters, request, out result) : this.AddMethod((Method) new DelegateTaskMethod(delegateTask, DelegateTaskMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) delegateTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((DelegateTask) null, (DelegateTask_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus GetDataPoints(DelegateTask delegateTask)
    {
      return this.GetDataPoints(delegateTask, (DelegateTask_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus GetDataPoints(
      DelegateTask delegateTask,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      return this.GetDataPoints(delegateTask, (DelegateTask_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DelegateTask delegateTask,
      DelegateTask_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      result = (DelegateTask_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) delegateTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTaskService) this._Channel).GetWIPMsgs(this._UserProfile, delegateTask, parameters, request, out result) : this.AddMethod((Method) new DelegateTaskMethod(delegateTask, DelegateTaskMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) delegateTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DelegateTask) null, (DelegateTask_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus GetWIPMsgs(DelegateTask delegateTask)
    {
      return this.GetWIPMsgs(delegateTask, (DelegateTask_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DelegateTask delegateTask,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      return this.GetWIPMsgs(delegateTask, (DelegateTask_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DelegateTask delegateTask,
      DelegateTask_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      result = (DelegateTask_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) delegateTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTaskService) this._Channel).Load(this._UserProfile, delegateTask, parameters, request, out result) : this.AddMethod((Method) new DelegateTaskMethod(delegateTask, DelegateTaskMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) delegateTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DelegateTask) null, (DelegateTask_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus Load(DelegateTask delegateTask)
    {
      return this.Load(delegateTask, (DelegateTask_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus Load(
      DelegateTask delegateTask,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      return this.Load(delegateTask, (DelegateTask_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DelegateTask delegateTask,
      DelegateTask_LoadESigDetails_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      result = (DelegateTask_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) delegateTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTaskService) this._Channel).LoadESigDetails(this._UserProfile, delegateTask, parameters, request, out result) : this.AddMethod((Method) new DelegateTaskMethod(delegateTask, DelegateTaskMethods.LoadESigDetails, (DelegateTask_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) delegateTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DelegateTask) null, (DelegateTask_LoadESigDetails_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus LoadESigDetails(DelegateTask delegateTask)
    {
      return this.LoadESigDetails(delegateTask, (DelegateTask_LoadESigDetails_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus LoadESigDetails(
      DelegateTask delegateTask,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      return this.LoadESigDetails(delegateTask, (DelegateTask_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      DelegateTask delegateTask,
      DelegateTask_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      result = (DelegateTask_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) delegateTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTaskService) this._Channel).ProcessComputation(this._UserProfile, delegateTask, parameters, request, out result) : this.AddMethod((Method) new DelegateTaskMethod(delegateTask, DelegateTaskMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) delegateTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((DelegateTask) null, (DelegateTask_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus ProcessComputation(DelegateTask delegateTask)
    {
      return this.ProcessComputation(delegateTask, (DelegateTask_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus ProcessComputation(
      DelegateTask delegateTask,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      return this.ProcessComputation(delegateTask, (DelegateTask_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      DelegateTask delegateTask,
      DelegateTask_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      result = (DelegateTask_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) delegateTask, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTaskService) this._Channel).ResolveParametricData(this._UserProfile, delegateTask, parameters, request, out result) : this.AddMethod((Method) new DelegateTaskMethod(delegateTask, DelegateTaskMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) delegateTask, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((DelegateTask) null, (DelegateTask_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus ResolveParametricData(DelegateTask delegateTask)
    {
      return this.ResolveParametricData(delegateTask, (DelegateTask_Parameters) null, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus ResolveParametricData(
      DelegateTask delegateTask,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      return this.ResolveParametricData(delegateTask, (DelegateTask_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject delegateTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegateTask_Result result1;
        ResultStatus parametricData = this.CreateParametricData((DelegateTask) delegateTask, (DelegateTask_Parameters) parameters, (DelegateTask_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject delegateTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegateTask_Result result1;
        ResultStatus actions = this.GetActions((DelegateTask) delegateTask, (DelegateTask_Parameters) parameters, (DelegateTask_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject delegateTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegateTask_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((DelegateTask) delegateTask, (DelegateTask_Parameters) parameters, (DelegateTask_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject delegateTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegateTask_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DelegateTask) delegateTask, (DelegateTask_LoadESigDetails_Parameters) parameters, (DelegateTask_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject delegateTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegateTask_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((DelegateTask) delegateTask, (DelegateTask_Parameters) parameters, (DelegateTask_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject delegateTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegateTask_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((DelegateTask) delegateTask, (DelegateTask_Parameters) parameters, (DelegateTask_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject delegateTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegateTask_Result result1;
        ResultStatus resultStatus = this.Load((DelegateTask) delegateTask, (DelegateTask_Parameters) parameters, (DelegateTask_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject delegateTask,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegateTask_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DelegateTask) delegateTask, (DelegateTask_Parameters) parameters, (DelegateTask_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      result = (DelegateTask_Result) null;
      try
      {
        DelegateTaskMethod[] methods = new DelegateTaskMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDelegateTaskService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DelegateTask_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DelegateTask_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DelegateTask cdo,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      result = (DelegateTask_Result) null;
      try
      {
        return ((IDelegateTaskService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DelegateTask_Result result1;
        ResultStatus environment = this.GetEnvironment((DelegateTask) cdo, (DelegateTask_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      return this.GetEnvironment((DelegateTask) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DelegateTask cdo,
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      result = (DelegateTask_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTaskService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DelegateTaskMethod(cdo, DelegateTaskMethods.ExecuteTransaction, (DelegateTask_Parameters) null));
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
        DelegateTask_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DelegateTask) cdo, (DelegateTask_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DelegateTask cdo)
    {
      return this.ExecuteTransaction(cdo, (DelegateTask_Request) null, out DelegateTask_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DelegateTask_Request request,
      out DelegateTask_Result result)
    {
      return this.ExecuteTransaction((DelegateTask) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DelegateTask cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DelegateTaskMethod(cdo, DelegateTaskMethods.AddDataTransaction, (DelegateTask_Parameters) null));
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
        return this.AddDataTransaction((DelegateTask) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
