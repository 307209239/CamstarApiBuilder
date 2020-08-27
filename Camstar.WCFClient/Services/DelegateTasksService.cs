// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DelegateTasksService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DelegateTasksService : GenericTxnsBase
  {
    public DelegateTasksService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDelegateTasksService), userProfile);
    }

    public ResultStatus CreateParametricData(
      DelegateTasks delegateTasks,
      DelegateTasks_Parameters parameters,
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      result = (DelegateTasks_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) delegateTasks, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTasksService) this._Channel).CreateParametricData(this._UserProfile, delegateTasks, parameters, request, out result) : this.AddMethod((Method) new DelegateTasksMethod(delegateTasks, DelegateTasksMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) delegateTasks, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((DelegateTasks) null, (DelegateTasks_Parameters) null, (DelegateTasks_Request) null, out DelegateTasks_Result _);
    }

    public ResultStatus CreateParametricData(DelegateTasks delegateTasks)
    {
      return this.CreateParametricData(delegateTasks, (DelegateTasks_Parameters) null, (DelegateTasks_Request) null, out DelegateTasks_Result _);
    }

    public ResultStatus CreateParametricData(
      DelegateTasks delegateTasks,
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      return this.CreateParametricData(delegateTasks, (DelegateTasks_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      DelegateTasks delegateTasks,
      DelegateTasks_Parameters parameters,
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      result = (DelegateTasks_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) delegateTasks, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTasksService) this._Channel).GetActions(this._UserProfile, delegateTasks, parameters, request, out result) : this.AddMethod((Method) new DelegateTasksMethod(delegateTasks, DelegateTasksMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) delegateTasks, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((DelegateTasks) null, (DelegateTasks_Parameters) null, (DelegateTasks_Request) null, out DelegateTasks_Result _);
    }

    public ResultStatus GetActions(DelegateTasks delegateTasks)
    {
      return this.GetActions(delegateTasks, (DelegateTasks_Parameters) null, (DelegateTasks_Request) null, out DelegateTasks_Result _);
    }

    public ResultStatus GetActions(
      DelegateTasks delegateTasks,
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      return this.GetActions(delegateTasks, (DelegateTasks_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      DelegateTasks delegateTasks,
      DelegateTasks_Parameters parameters,
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      result = (DelegateTasks_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) delegateTasks, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTasksService) this._Channel).GetDataPoints(this._UserProfile, delegateTasks, parameters, request, out result) : this.AddMethod((Method) new DelegateTasksMethod(delegateTasks, DelegateTasksMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) delegateTasks, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((DelegateTasks) null, (DelegateTasks_Parameters) null, (DelegateTasks_Request) null, out DelegateTasks_Result _);
    }

    public ResultStatus GetDataPoints(DelegateTasks delegateTasks)
    {
      return this.GetDataPoints(delegateTasks, (DelegateTasks_Parameters) null, (DelegateTasks_Request) null, out DelegateTasks_Result _);
    }

    public ResultStatus GetDataPoints(
      DelegateTasks delegateTasks,
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      return this.GetDataPoints(delegateTasks, (DelegateTasks_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DelegateTasks delegateTasks,
      DelegateTasks_Parameters parameters,
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      result = (DelegateTasks_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) delegateTasks, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTasksService) this._Channel).GetWIPMsgs(this._UserProfile, delegateTasks, parameters, request, out result) : this.AddMethod((Method) new DelegateTasksMethod(delegateTasks, DelegateTasksMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) delegateTasks, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DelegateTasks) null, (DelegateTasks_Parameters) null, (DelegateTasks_Request) null, out DelegateTasks_Result _);
    }

    public ResultStatus GetWIPMsgs(DelegateTasks delegateTasks)
    {
      return this.GetWIPMsgs(delegateTasks, (DelegateTasks_Parameters) null, (DelegateTasks_Request) null, out DelegateTasks_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DelegateTasks delegateTasks,
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      return this.GetWIPMsgs(delegateTasks, (DelegateTasks_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DelegateTasks delegateTasks,
      DelegateTasks_Parameters parameters,
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      result = (DelegateTasks_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) delegateTasks, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTasksService) this._Channel).Load(this._UserProfile, delegateTasks, parameters, request, out result) : this.AddMethod((Method) new DelegateTasksMethod(delegateTasks, DelegateTasksMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) delegateTasks, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DelegateTasks) null, (DelegateTasks_Parameters) null, (DelegateTasks_Request) null, out DelegateTasks_Result _);
    }

    public ResultStatus Load(DelegateTasks delegateTasks)
    {
      return this.Load(delegateTasks, (DelegateTasks_Parameters) null, (DelegateTasks_Request) null, out DelegateTasks_Result _);
    }

    public ResultStatus Load(
      DelegateTasks delegateTasks,
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      return this.Load(delegateTasks, (DelegateTasks_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DelegateTasks delegateTasks,
      DelegateTasks_LoadESigDetails_Parameters parameters,
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      result = (DelegateTasks_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) delegateTasks, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTasksService) this._Channel).LoadESigDetails(this._UserProfile, delegateTasks, parameters, request, out result) : this.AddMethod((Method) new DelegateTasksMethod(delegateTasks, DelegateTasksMethods.LoadESigDetails, (DelegateTasks_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) delegateTasks, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DelegateTasks) null, (DelegateTasks_LoadESigDetails_Parameters) null, (DelegateTasks_Request) null, out DelegateTasks_Result _);
    }

    public ResultStatus LoadESigDetails(DelegateTasks delegateTasks)
    {
      return this.LoadESigDetails(delegateTasks, (DelegateTasks_LoadESigDetails_Parameters) null, (DelegateTasks_Request) null, out DelegateTasks_Result _);
    }

    public ResultStatus LoadESigDetails(
      DelegateTasks delegateTasks,
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      return this.LoadESigDetails(delegateTasks, (DelegateTasks_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      DelegateTasks delegateTasks,
      DelegateTasks_Parameters parameters,
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      result = (DelegateTasks_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) delegateTasks, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTasksService) this._Channel).ProcessComputation(this._UserProfile, delegateTasks, parameters, request, out result) : this.AddMethod((Method) new DelegateTasksMethod(delegateTasks, DelegateTasksMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) delegateTasks, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((DelegateTasks) null, (DelegateTasks_Parameters) null, (DelegateTasks_Request) null, out DelegateTasks_Result _);
    }

    public ResultStatus ProcessComputation(DelegateTasks delegateTasks)
    {
      return this.ProcessComputation(delegateTasks, (DelegateTasks_Parameters) null, (DelegateTasks_Request) null, out DelegateTasks_Result _);
    }

    public ResultStatus ProcessComputation(
      DelegateTasks delegateTasks,
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      return this.ProcessComputation(delegateTasks, (DelegateTasks_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      DelegateTasks delegateTasks,
      DelegateTasks_Parameters parameters,
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      result = (DelegateTasks_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) delegateTasks, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTasksService) this._Channel).ResolveParametricData(this._UserProfile, delegateTasks, parameters, request, out result) : this.AddMethod((Method) new DelegateTasksMethod(delegateTasks, DelegateTasksMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) delegateTasks, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((DelegateTasks) null, (DelegateTasks_Parameters) null, (DelegateTasks_Request) null, out DelegateTasks_Result _);
    }

    public ResultStatus ResolveParametricData(DelegateTasks delegateTasks)
    {
      return this.ResolveParametricData(delegateTasks, (DelegateTasks_Parameters) null, (DelegateTasks_Request) null, out DelegateTasks_Result _);
    }

    public ResultStatus ResolveParametricData(
      DelegateTasks delegateTasks,
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      return this.ResolveParametricData(delegateTasks, (DelegateTasks_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject delegateTasks,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegateTasks_Result result1;
        ResultStatus parametricData = this.CreateParametricData((DelegateTasks) delegateTasks, (DelegateTasks_Parameters) parameters, (DelegateTasks_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject delegateTasks,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegateTasks_Result result1;
        ResultStatus actions = this.GetActions((DelegateTasks) delegateTasks, (DelegateTasks_Parameters) parameters, (DelegateTasks_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject delegateTasks,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegateTasks_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((DelegateTasks) delegateTasks, (DelegateTasks_Parameters) parameters, (DelegateTasks_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject delegateTasks,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegateTasks_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DelegateTasks) delegateTasks, (DelegateTasks_LoadESigDetails_Parameters) parameters, (DelegateTasks_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject delegateTasks,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegateTasks_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((DelegateTasks) delegateTasks, (DelegateTasks_Parameters) parameters, (DelegateTasks_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject delegateTasks,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegateTasks_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((DelegateTasks) delegateTasks, (DelegateTasks_Parameters) parameters, (DelegateTasks_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject delegateTasks,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegateTasks_Result result1;
        ResultStatus resultStatus = this.Load((DelegateTasks) delegateTasks, (DelegateTasks_Parameters) parameters, (DelegateTasks_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject delegateTasks,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegateTasks_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DelegateTasks) delegateTasks, (DelegateTasks_Parameters) parameters, (DelegateTasks_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      result = (DelegateTasks_Result) null;
      try
      {
        DelegateTasksMethod[] methods = new DelegateTasksMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDelegateTasksService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DelegateTasks_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DelegateTasks_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DelegateTasks cdo,
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      result = (DelegateTasks_Result) null;
      try
      {
        return ((IDelegateTasksService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DelegateTasks_Result result1;
        ResultStatus environment = this.GetEnvironment((DelegateTasks) cdo, (DelegateTasks_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      return this.GetEnvironment((DelegateTasks) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DelegateTasks cdo,
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      result = (DelegateTasks_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTasksService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DelegateTasksMethod(cdo, DelegateTasksMethods.ExecuteTransaction, (DelegateTasks_Parameters) null));
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
        DelegateTasks_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DelegateTasks) cdo, (DelegateTasks_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DelegateTasks cdo)
    {
      return this.ExecuteTransaction(cdo, (DelegateTasks_Request) null, out DelegateTasks_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DelegateTasks_Request request,
      out DelegateTasks_Result result)
    {
      return this.ExecuteTransaction((DelegateTasks) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DelegateTasks cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DelegateTasksMethod(cdo, DelegateTasksMethods.AddDataTransaction, (DelegateTasks_Parameters) null));
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
        return this.AddDataTransaction((DelegateTasks) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
