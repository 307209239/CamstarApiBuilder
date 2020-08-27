// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.HoldStatusTxnsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class HoldStatusTxnsService : ContainersTxnBase
  {
    public HoldStatusTxnsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IHoldStatusTxnsService), userProfile);
    }

    public ResultStatus CreateParametricData(
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Parameters parameters,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      result = (HoldStatusTxns_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) holdStatusTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldStatusTxnsService) this._Channel).CreateParametricData(this._UserProfile, holdStatusTxns, parameters, request, out result) : this.AddMethod((Method) new HoldStatusTxnsMethod(holdStatusTxns, HoldStatusTxnsMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) holdStatusTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((HoldStatusTxns) null, (HoldStatusTxns_Parameters) null, (HoldStatusTxns_Request) null, out HoldStatusTxns_Result _);
    }

    public ResultStatus CreateParametricData(HoldStatusTxns holdStatusTxns)
    {
      return this.CreateParametricData(holdStatusTxns, (HoldStatusTxns_Parameters) null, (HoldStatusTxns_Request) null, out HoldStatusTxns_Result _);
    }

    public ResultStatus CreateParametricData(
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      return this.CreateParametricData(holdStatusTxns, (HoldStatusTxns_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Parameters parameters,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      result = (HoldStatusTxns_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) holdStatusTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldStatusTxnsService) this._Channel).GetActions(this._UserProfile, holdStatusTxns, parameters, request, out result) : this.AddMethod((Method) new HoldStatusTxnsMethod(holdStatusTxns, HoldStatusTxnsMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) holdStatusTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((HoldStatusTxns) null, (HoldStatusTxns_Parameters) null, (HoldStatusTxns_Request) null, out HoldStatusTxns_Result _);
    }

    public ResultStatus GetActions(HoldStatusTxns holdStatusTxns)
    {
      return this.GetActions(holdStatusTxns, (HoldStatusTxns_Parameters) null, (HoldStatusTxns_Request) null, out HoldStatusTxns_Result _);
    }

    public ResultStatus GetActions(
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      return this.GetActions(holdStatusTxns, (HoldStatusTxns_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Parameters parameters,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      result = (HoldStatusTxns_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) holdStatusTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldStatusTxnsService) this._Channel).GetDataPoints(this._UserProfile, holdStatusTxns, parameters, request, out result) : this.AddMethod((Method) new HoldStatusTxnsMethod(holdStatusTxns, HoldStatusTxnsMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) holdStatusTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((HoldStatusTxns) null, (HoldStatusTxns_Parameters) null, (HoldStatusTxns_Request) null, out HoldStatusTxns_Result _);
    }

    public ResultStatus GetDataPoints(HoldStatusTxns holdStatusTxns)
    {
      return this.GetDataPoints(holdStatusTxns, (HoldStatusTxns_Parameters) null, (HoldStatusTxns_Request) null, out HoldStatusTxns_Result _);
    }

    public ResultStatus GetDataPoints(
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      return this.GetDataPoints(holdStatusTxns, (HoldStatusTxns_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Parameters parameters,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      result = (HoldStatusTxns_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) holdStatusTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldStatusTxnsService) this._Channel).GetWIPMsgs(this._UserProfile, holdStatusTxns, parameters, request, out result) : this.AddMethod((Method) new HoldStatusTxnsMethod(holdStatusTxns, HoldStatusTxnsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) holdStatusTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((HoldStatusTxns) null, (HoldStatusTxns_Parameters) null, (HoldStatusTxns_Request) null, out HoldStatusTxns_Result _);
    }

    public ResultStatus GetWIPMsgs(HoldStatusTxns holdStatusTxns)
    {
      return this.GetWIPMsgs(holdStatusTxns, (HoldStatusTxns_Parameters) null, (HoldStatusTxns_Request) null, out HoldStatusTxns_Result _);
    }

    public ResultStatus GetWIPMsgs(
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      return this.GetWIPMsgs(holdStatusTxns, (HoldStatusTxns_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Parameters parameters,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      result = (HoldStatusTxns_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) holdStatusTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldStatusTxnsService) this._Channel).Load(this._UserProfile, holdStatusTxns, parameters, request, out result) : this.AddMethod((Method) new HoldStatusTxnsMethod(holdStatusTxns, HoldStatusTxnsMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) holdStatusTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((HoldStatusTxns) null, (HoldStatusTxns_Parameters) null, (HoldStatusTxns_Request) null, out HoldStatusTxns_Result _);
    }

    public ResultStatus Load(HoldStatusTxns holdStatusTxns)
    {
      return this.Load(holdStatusTxns, (HoldStatusTxns_Parameters) null, (HoldStatusTxns_Request) null, out HoldStatusTxns_Result _);
    }

    public ResultStatus Load(
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      return this.Load(holdStatusTxns, (HoldStatusTxns_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_LoadESigDetails_Parameters parameters,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      result = (HoldStatusTxns_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) holdStatusTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldStatusTxnsService) this._Channel).LoadESigDetails(this._UserProfile, holdStatusTxns, parameters, request, out result) : this.AddMethod((Method) new HoldStatusTxnsMethod(holdStatusTxns, HoldStatusTxnsMethods.LoadESigDetails, (HoldStatusTxns_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) holdStatusTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((HoldStatusTxns) null, (HoldStatusTxns_LoadESigDetails_Parameters) null, (HoldStatusTxns_Request) null, out HoldStatusTxns_Result _);
    }

    public ResultStatus LoadESigDetails(HoldStatusTxns holdStatusTxns)
    {
      return this.LoadESigDetails(holdStatusTxns, (HoldStatusTxns_LoadESigDetails_Parameters) null, (HoldStatusTxns_Request) null, out HoldStatusTxns_Result _);
    }

    public ResultStatus LoadESigDetails(
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      return this.LoadESigDetails(holdStatusTxns, (HoldStatusTxns_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Parameters parameters,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      result = (HoldStatusTxns_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) holdStatusTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldStatusTxnsService) this._Channel).ProcessComputation(this._UserProfile, holdStatusTxns, parameters, request, out result) : this.AddMethod((Method) new HoldStatusTxnsMethod(holdStatusTxns, HoldStatusTxnsMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) holdStatusTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((HoldStatusTxns) null, (HoldStatusTxns_Parameters) null, (HoldStatusTxns_Request) null, out HoldStatusTxns_Result _);
    }

    public ResultStatus ProcessComputation(HoldStatusTxns holdStatusTxns)
    {
      return this.ProcessComputation(holdStatusTxns, (HoldStatusTxns_Parameters) null, (HoldStatusTxns_Request) null, out HoldStatusTxns_Result _);
    }

    public ResultStatus ProcessComputation(
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      return this.ProcessComputation(holdStatusTxns, (HoldStatusTxns_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Parameters parameters,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      result = (HoldStatusTxns_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) holdStatusTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldStatusTxnsService) this._Channel).ResolveParametricData(this._UserProfile, holdStatusTxns, parameters, request, out result) : this.AddMethod((Method) new HoldStatusTxnsMethod(holdStatusTxns, HoldStatusTxnsMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) holdStatusTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((HoldStatusTxns) null, (HoldStatusTxns_Parameters) null, (HoldStatusTxns_Request) null, out HoldStatusTxns_Result _);
    }

    public ResultStatus ResolveParametricData(HoldStatusTxns holdStatusTxns)
    {
      return this.ResolveParametricData(holdStatusTxns, (HoldStatusTxns_Parameters) null, (HoldStatusTxns_Request) null, out HoldStatusTxns_Result _);
    }

    public ResultStatus ResolveParametricData(
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      return this.ResolveParametricData(holdStatusTxns, (HoldStatusTxns_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject holdStatusTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldStatusTxns_Result result1;
        ResultStatus parametricData = this.CreateParametricData((HoldStatusTxns) holdStatusTxns, (HoldStatusTxns_Parameters) parameters, (HoldStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject holdStatusTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldStatusTxns_Result result1;
        ResultStatus actions = this.GetActions((HoldStatusTxns) holdStatusTxns, (HoldStatusTxns_Parameters) parameters, (HoldStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject holdStatusTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldStatusTxns_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((HoldStatusTxns) holdStatusTxns, (HoldStatusTxns_Parameters) parameters, (HoldStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject holdStatusTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldStatusTxns_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((HoldStatusTxns) holdStatusTxns, (HoldStatusTxns_LoadESigDetails_Parameters) parameters, (HoldStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject holdStatusTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldStatusTxns_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((HoldStatusTxns) holdStatusTxns, (HoldStatusTxns_Parameters) parameters, (HoldStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject holdStatusTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldStatusTxns_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((HoldStatusTxns) holdStatusTxns, (HoldStatusTxns_Parameters) parameters, (HoldStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject holdStatusTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldStatusTxns_Result result1;
        ResultStatus resultStatus = this.Load((HoldStatusTxns) holdStatusTxns, (HoldStatusTxns_Parameters) parameters, (HoldStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject holdStatusTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldStatusTxns_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((HoldStatusTxns) holdStatusTxns, (HoldStatusTxns_Parameters) parameters, (HoldStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      result = (HoldStatusTxns_Result) null;
      try
      {
        HoldStatusTxnsMethod[] methods = new HoldStatusTxnsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IHoldStatusTxnsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        HoldStatusTxns_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((HoldStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      HoldStatusTxns cdo,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      result = (HoldStatusTxns_Result) null;
      try
      {
        return ((IHoldStatusTxnsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        HoldStatusTxns_Result result1;
        ResultStatus environment = this.GetEnvironment((HoldStatusTxns) cdo, (HoldStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      return this.GetEnvironment((HoldStatusTxns) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      HoldStatusTxns cdo,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      result = (HoldStatusTxns_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldStatusTxnsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new HoldStatusTxnsMethod(cdo, HoldStatusTxnsMethods.ExecuteTransaction, (HoldStatusTxns_Parameters) null));
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
        HoldStatusTxns_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((HoldStatusTxns) cdo, (HoldStatusTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(HoldStatusTxns cdo)
    {
      return this.ExecuteTransaction(cdo, (HoldStatusTxns_Request) null, out HoldStatusTxns_Result _);
    }

    public ResultStatus ExecuteTransaction(
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result)
    {
      return this.ExecuteTransaction((HoldStatusTxns) null, request, out result);
    }

    public ResultStatus AddDataTransaction(HoldStatusTxns cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new HoldStatusTxnsMethod(cdo, HoldStatusTxnsMethods.AddDataTransaction, (HoldStatusTxns_Parameters) null));
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
        return this.AddDataTransaction((HoldStatusTxns) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
