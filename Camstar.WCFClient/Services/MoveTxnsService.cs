// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MoveTxnsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MoveTxnsService : ContainersTxnBase
  {
    public MoveTxnsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMoveTxnsService), userProfile);
    }

    public ResultStatus CreateParametricData(
      MoveTxns moveTxns,
      MoveTxns_Parameters parameters,
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      result = (MoveTxns_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) moveTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnsService) this._Channel).CreateParametricData(this._UserProfile, moveTxns, parameters, request, out result) : this.AddMethod((Method) new MoveTxnsMethod(moveTxns, MoveTxnsMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) moveTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((MoveTxns) null, (MoveTxns_Parameters) null, (MoveTxns_Request) null, out MoveTxns_Result _);
    }

    public ResultStatus CreateParametricData(MoveTxns moveTxns)
    {
      return this.CreateParametricData(moveTxns, (MoveTxns_Parameters) null, (MoveTxns_Request) null, out MoveTxns_Result _);
    }

    public ResultStatus CreateParametricData(
      MoveTxns moveTxns,
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      return this.CreateParametricData(moveTxns, (MoveTxns_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      MoveTxns moveTxns,
      MoveTxns_Parameters parameters,
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      result = (MoveTxns_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) moveTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnsService) this._Channel).GetActions(this._UserProfile, moveTxns, parameters, request, out result) : this.AddMethod((Method) new MoveTxnsMethod(moveTxns, MoveTxnsMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) moveTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((MoveTxns) null, (MoveTxns_Parameters) null, (MoveTxns_Request) null, out MoveTxns_Result _);
    }

    public ResultStatus GetActions(MoveTxns moveTxns)
    {
      return this.GetActions(moveTxns, (MoveTxns_Parameters) null, (MoveTxns_Request) null, out MoveTxns_Result _);
    }

    public ResultStatus GetActions(
      MoveTxns moveTxns,
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      return this.GetActions(moveTxns, (MoveTxns_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      MoveTxns moveTxns,
      MoveTxns_Parameters parameters,
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      result = (MoveTxns_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) moveTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnsService) this._Channel).GetDataPoints(this._UserProfile, moveTxns, parameters, request, out result) : this.AddMethod((Method) new MoveTxnsMethod(moveTxns, MoveTxnsMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) moveTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((MoveTxns) null, (MoveTxns_Parameters) null, (MoveTxns_Request) null, out MoveTxns_Result _);
    }

    public ResultStatus GetDataPoints(MoveTxns moveTxns)
    {
      return this.GetDataPoints(moveTxns, (MoveTxns_Parameters) null, (MoveTxns_Request) null, out MoveTxns_Result _);
    }

    public ResultStatus GetDataPoints(
      MoveTxns moveTxns,
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      return this.GetDataPoints(moveTxns, (MoveTxns_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MoveTxns moveTxns,
      MoveTxns_Parameters parameters,
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      result = (MoveTxns_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) moveTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnsService) this._Channel).GetWIPMsgs(this._UserProfile, moveTxns, parameters, request, out result) : this.AddMethod((Method) new MoveTxnsMethod(moveTxns, MoveTxnsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) moveTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MoveTxns) null, (MoveTxns_Parameters) null, (MoveTxns_Request) null, out MoveTxns_Result _);
    }

    public ResultStatus GetWIPMsgs(MoveTxns moveTxns)
    {
      return this.GetWIPMsgs(moveTxns, (MoveTxns_Parameters) null, (MoveTxns_Request) null, out MoveTxns_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MoveTxns moveTxns,
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      return this.GetWIPMsgs(moveTxns, (MoveTxns_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MoveTxns moveTxns,
      MoveTxns_Parameters parameters,
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      result = (MoveTxns_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) moveTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnsService) this._Channel).Load(this._UserProfile, moveTxns, parameters, request, out result) : this.AddMethod((Method) new MoveTxnsMethod(moveTxns, MoveTxnsMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) moveTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MoveTxns) null, (MoveTxns_Parameters) null, (MoveTxns_Request) null, out MoveTxns_Result _);
    }

    public ResultStatus Load(MoveTxns moveTxns)
    {
      return this.Load(moveTxns, (MoveTxns_Parameters) null, (MoveTxns_Request) null, out MoveTxns_Result _);
    }

    public ResultStatus Load(
      MoveTxns moveTxns,
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      return this.Load(moveTxns, (MoveTxns_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MoveTxns moveTxns,
      MoveTxns_LoadESigDetails_Parameters parameters,
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      result = (MoveTxns_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) moveTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnsService) this._Channel).LoadESigDetails(this._UserProfile, moveTxns, parameters, request, out result) : this.AddMethod((Method) new MoveTxnsMethod(moveTxns, MoveTxnsMethods.LoadESigDetails, (MoveTxns_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) moveTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MoveTxns) null, (MoveTxns_LoadESigDetails_Parameters) null, (MoveTxns_Request) null, out MoveTxns_Result _);
    }

    public ResultStatus LoadESigDetails(MoveTxns moveTxns)
    {
      return this.LoadESigDetails(moveTxns, (MoveTxns_LoadESigDetails_Parameters) null, (MoveTxns_Request) null, out MoveTxns_Result _);
    }

    public ResultStatus LoadESigDetails(
      MoveTxns moveTxns,
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      return this.LoadESigDetails(moveTxns, (MoveTxns_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      MoveTxns moveTxns,
      MoveTxns_Parameters parameters,
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      result = (MoveTxns_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) moveTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnsService) this._Channel).ProcessComputation(this._UserProfile, moveTxns, parameters, request, out result) : this.AddMethod((Method) new MoveTxnsMethod(moveTxns, MoveTxnsMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) moveTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((MoveTxns) null, (MoveTxns_Parameters) null, (MoveTxns_Request) null, out MoveTxns_Result _);
    }

    public ResultStatus ProcessComputation(MoveTxns moveTxns)
    {
      return this.ProcessComputation(moveTxns, (MoveTxns_Parameters) null, (MoveTxns_Request) null, out MoveTxns_Result _);
    }

    public ResultStatus ProcessComputation(
      MoveTxns moveTxns,
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      return this.ProcessComputation(moveTxns, (MoveTxns_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      MoveTxns moveTxns,
      MoveTxns_Parameters parameters,
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      result = (MoveTxns_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) moveTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnsService) this._Channel).ResolveParametricData(this._UserProfile, moveTxns, parameters, request, out result) : this.AddMethod((Method) new MoveTxnsMethod(moveTxns, MoveTxnsMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) moveTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((MoveTxns) null, (MoveTxns_Parameters) null, (MoveTxns_Request) null, out MoveTxns_Result _);
    }

    public ResultStatus ResolveParametricData(MoveTxns moveTxns)
    {
      return this.ResolveParametricData(moveTxns, (MoveTxns_Parameters) null, (MoveTxns_Request) null, out MoveTxns_Result _);
    }

    public ResultStatus ResolveParametricData(
      MoveTxns moveTxns,
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      return this.ResolveParametricData(moveTxns, (MoveTxns_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject moveTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveTxns_Result result1;
        ResultStatus parametricData = this.CreateParametricData((MoveTxns) moveTxns, (MoveTxns_Parameters) parameters, (MoveTxns_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject moveTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveTxns_Result result1;
        ResultStatus actions = this.GetActions((MoveTxns) moveTxns, (MoveTxns_Parameters) parameters, (MoveTxns_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject moveTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveTxns_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((MoveTxns) moveTxns, (MoveTxns_Parameters) parameters, (MoveTxns_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject moveTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveTxns_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MoveTxns) moveTxns, (MoveTxns_LoadESigDetails_Parameters) parameters, (MoveTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject moveTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveTxns_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((MoveTxns) moveTxns, (MoveTxns_Parameters) parameters, (MoveTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject moveTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveTxns_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((MoveTxns) moveTxns, (MoveTxns_Parameters) parameters, (MoveTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject moveTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveTxns_Result result1;
        ResultStatus resultStatus = this.Load((MoveTxns) moveTxns, (MoveTxns_Parameters) parameters, (MoveTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject moveTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveTxns_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MoveTxns) moveTxns, (MoveTxns_Parameters) parameters, (MoveTxns_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      result = (MoveTxns_Result) null;
      try
      {
        MoveTxnsMethod[] methods = new MoveTxnsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMoveTxnsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MoveTxns_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MoveTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveTxns cdo,
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      result = (MoveTxns_Result) null;
      try
      {
        return ((IMoveTxnsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MoveTxns_Result result1;
        ResultStatus environment = this.GetEnvironment((MoveTxns) cdo, (MoveTxns_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      return this.GetEnvironment((MoveTxns) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MoveTxns cdo,
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      result = (MoveTxns_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MoveTxnsMethod(cdo, MoveTxnsMethods.ExecuteTransaction, (MoveTxns_Parameters) null));
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
        MoveTxns_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MoveTxns) cdo, (MoveTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MoveTxns cdo)
    {
      return this.ExecuteTransaction(cdo, (MoveTxns_Request) null, out MoveTxns_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MoveTxns_Request request,
      out MoveTxns_Result result)
    {
      return this.ExecuteTransaction((MoveTxns) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MoveTxns cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MoveTxnsMethod(cdo, MoveTxnsMethods.AddDataTransaction, (MoveTxns_Parameters) null));
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
        return this.AddDataTransaction((MoveTxns) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
