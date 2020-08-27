// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangeStatusTxnsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ChangeStatusTxnsService : ChangeMgtTxnsBase
  {
    public ChangeStatusTxnsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IChangeStatusTxnsService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Parameters parameters,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      result = (ChangeStatusTxns_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) changeStatusTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnsService) this._Channel).CreateParametricData(this._UserProfile, changeStatusTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusTxnsMethod(changeStatusTxns, ChangeStatusTxnsMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) changeStatusTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ChangeStatusTxns) null, (ChangeStatusTxns_Parameters) null, (ChangeStatusTxns_Request) null, out ChangeStatusTxns_Result _);
    }

    public ResultStatus CreateParametricData(ChangeStatusTxns changeStatusTxns)
    {
      return this.CreateParametricData(changeStatusTxns, (ChangeStatusTxns_Parameters) null, (ChangeStatusTxns_Request) null, out ChangeStatusTxns_Result _);
    }

    public ResultStatus CreateParametricData(
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      return this.CreateParametricData(changeStatusTxns, (ChangeStatusTxns_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Parameters parameters,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      result = (ChangeStatusTxns_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) changeStatusTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnsService) this._Channel).GetActions(this._UserProfile, changeStatusTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusTxnsMethod(changeStatusTxns, ChangeStatusTxnsMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) changeStatusTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ChangeStatusTxns) null, (ChangeStatusTxns_Parameters) null, (ChangeStatusTxns_Request) null, out ChangeStatusTxns_Result _);
    }

    public ResultStatus GetActions(ChangeStatusTxns changeStatusTxns)
    {
      return this.GetActions(changeStatusTxns, (ChangeStatusTxns_Parameters) null, (ChangeStatusTxns_Request) null, out ChangeStatusTxns_Result _);
    }

    public ResultStatus GetActions(
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      return this.GetActions(changeStatusTxns, (ChangeStatusTxns_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Parameters parameters,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      result = (ChangeStatusTxns_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) changeStatusTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnsService) this._Channel).GetDataPoints(this._UserProfile, changeStatusTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusTxnsMethod(changeStatusTxns, ChangeStatusTxnsMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) changeStatusTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ChangeStatusTxns) null, (ChangeStatusTxns_Parameters) null, (ChangeStatusTxns_Request) null, out ChangeStatusTxns_Result _);
    }

    public ResultStatus GetDataPoints(ChangeStatusTxns changeStatusTxns)
    {
      return this.GetDataPoints(changeStatusTxns, (ChangeStatusTxns_Parameters) null, (ChangeStatusTxns_Request) null, out ChangeStatusTxns_Result _);
    }

    public ResultStatus GetDataPoints(
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      return this.GetDataPoints(changeStatusTxns, (ChangeStatusTxns_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Parameters parameters,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      result = (ChangeStatusTxns_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) changeStatusTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnsService) this._Channel).GetWIPMsgs(this._UserProfile, changeStatusTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusTxnsMethod(changeStatusTxns, ChangeStatusTxnsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) changeStatusTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ChangeStatusTxns) null, (ChangeStatusTxns_Parameters) null, (ChangeStatusTxns_Request) null, out ChangeStatusTxns_Result _);
    }

    public ResultStatus GetWIPMsgs(ChangeStatusTxns changeStatusTxns)
    {
      return this.GetWIPMsgs(changeStatusTxns, (ChangeStatusTxns_Parameters) null, (ChangeStatusTxns_Request) null, out ChangeStatusTxns_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      return this.GetWIPMsgs(changeStatusTxns, (ChangeStatusTxns_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Parameters parameters,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      result = (ChangeStatusTxns_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) changeStatusTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnsService) this._Channel).Load(this._UserProfile, changeStatusTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusTxnsMethod(changeStatusTxns, ChangeStatusTxnsMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) changeStatusTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ChangeStatusTxns) null, (ChangeStatusTxns_Parameters) null, (ChangeStatusTxns_Request) null, out ChangeStatusTxns_Result _);
    }

    public ResultStatus Load(ChangeStatusTxns changeStatusTxns)
    {
      return this.Load(changeStatusTxns, (ChangeStatusTxns_Parameters) null, (ChangeStatusTxns_Request) null, out ChangeStatusTxns_Result _);
    }

    public ResultStatus Load(
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      return this.Load(changeStatusTxns, (ChangeStatusTxns_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_LoadESigDetails_Parameters parameters,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      result = (ChangeStatusTxns_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) changeStatusTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnsService) this._Channel).LoadESigDetails(this._UserProfile, changeStatusTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusTxnsMethod(changeStatusTxns, ChangeStatusTxnsMethods.LoadESigDetails, (ChangeStatusTxns_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) changeStatusTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ChangeStatusTxns) null, (ChangeStatusTxns_LoadESigDetails_Parameters) null, (ChangeStatusTxns_Request) null, out ChangeStatusTxns_Result _);
    }

    public ResultStatus LoadESigDetails(ChangeStatusTxns changeStatusTxns)
    {
      return this.LoadESigDetails(changeStatusTxns, (ChangeStatusTxns_LoadESigDetails_Parameters) null, (ChangeStatusTxns_Request) null, out ChangeStatusTxns_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      return this.LoadESigDetails(changeStatusTxns, (ChangeStatusTxns_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Parameters parameters,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      result = (ChangeStatusTxns_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) changeStatusTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnsService) this._Channel).ProcessComputation(this._UserProfile, changeStatusTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusTxnsMethod(changeStatusTxns, ChangeStatusTxnsMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) changeStatusTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ChangeStatusTxns) null, (ChangeStatusTxns_Parameters) null, (ChangeStatusTxns_Request) null, out ChangeStatusTxns_Result _);
    }

    public ResultStatus ProcessComputation(ChangeStatusTxns changeStatusTxns)
    {
      return this.ProcessComputation(changeStatusTxns, (ChangeStatusTxns_Parameters) null, (ChangeStatusTxns_Request) null, out ChangeStatusTxns_Result _);
    }

    public ResultStatus ProcessComputation(
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      return this.ProcessComputation(changeStatusTxns, (ChangeStatusTxns_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Parameters parameters,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      result = (ChangeStatusTxns_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) changeStatusTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnsService) this._Channel).ResolveParametricData(this._UserProfile, changeStatusTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusTxnsMethod(changeStatusTxns, ChangeStatusTxnsMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) changeStatusTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ChangeStatusTxns) null, (ChangeStatusTxns_Parameters) null, (ChangeStatusTxns_Request) null, out ChangeStatusTxns_Result _);
    }

    public ResultStatus ResolveParametricData(ChangeStatusTxns changeStatusTxns)
    {
      return this.ResolveParametricData(changeStatusTxns, (ChangeStatusTxns_Parameters) null, (ChangeStatusTxns_Request) null, out ChangeStatusTxns_Result _);
    }

    public ResultStatus ResolveParametricData(
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      return this.ResolveParametricData(changeStatusTxns, (ChangeStatusTxns_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject changeStatusTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusTxns_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ChangeStatusTxns) changeStatusTxns, (ChangeStatusTxns_Parameters) parameters, (ChangeStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject changeStatusTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusTxns_Result result1;
        ResultStatus actions = this.GetActions((ChangeStatusTxns) changeStatusTxns, (ChangeStatusTxns_Parameters) parameters, (ChangeStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject changeStatusTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusTxns_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ChangeStatusTxns) changeStatusTxns, (ChangeStatusTxns_Parameters) parameters, (ChangeStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject changeStatusTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusTxns_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ChangeStatusTxns) changeStatusTxns, (ChangeStatusTxns_LoadESigDetails_Parameters) parameters, (ChangeStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject changeStatusTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusTxns_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ChangeStatusTxns) changeStatusTxns, (ChangeStatusTxns_Parameters) parameters, (ChangeStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject changeStatusTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusTxns_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ChangeStatusTxns) changeStatusTxns, (ChangeStatusTxns_Parameters) parameters, (ChangeStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject changeStatusTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusTxns_Result result1;
        ResultStatus resultStatus = this.Load((ChangeStatusTxns) changeStatusTxns, (ChangeStatusTxns_Parameters) parameters, (ChangeStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject changeStatusTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusTxns_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ChangeStatusTxns) changeStatusTxns, (ChangeStatusTxns_Parameters) parameters, (ChangeStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      result = (ChangeStatusTxns_Result) null;
      try
      {
        ChangeStatusTxnsMethod[] methods = new ChangeStatusTxnsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IChangeStatusTxnsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ChangeStatusTxns_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ChangeStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeStatusTxns cdo,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      result = (ChangeStatusTxns_Result) null;
      try
      {
        return ((IChangeStatusTxnsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ChangeStatusTxns_Result result1;
        ResultStatus environment = this.GetEnvironment((ChangeStatusTxns) cdo, (ChangeStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      return this.GetEnvironment((ChangeStatusTxns) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ChangeStatusTxns cdo,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      result = (ChangeStatusTxns_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ChangeStatusTxnsMethod(cdo, ChangeStatusTxnsMethods.ExecuteTransaction, (ChangeStatusTxns_Parameters) null));
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
        ChangeStatusTxns_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ChangeStatusTxns) cdo, (ChangeStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ChangeStatusTxns cdo)
    {
      return this.ExecuteTransaction(cdo, (ChangeStatusTxns_Request) null, out ChangeStatusTxns_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result)
    {
      return this.ExecuteTransaction((ChangeStatusTxns) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ChangeStatusTxns cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ChangeStatusTxnsMethod(cdo, ChangeStatusTxnsMethods.AddDataTransaction, (ChangeStatusTxns_Parameters) null));
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
        return this.AddDataTransaction((ChangeStatusTxns) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
