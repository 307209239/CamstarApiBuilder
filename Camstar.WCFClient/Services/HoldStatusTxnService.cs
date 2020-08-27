// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.HoldStatusTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class HoldStatusTxnService : ContainerTxnBase
  {
    public HoldStatusTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IHoldStatusTxnService), userProfile);
    }

    public ResultStatus CreateParametricData(
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Parameters parameters,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      result = (HoldStatusTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) holdStatusTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldStatusTxnService) this._Channel).CreateParametricData(this._UserProfile, holdStatusTxn, parameters, request, out result) : this.AddMethod((Method) new HoldStatusTxnMethod(holdStatusTxn, HoldStatusTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) holdStatusTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((HoldStatusTxn) null, (HoldStatusTxn_Parameters) null, (HoldStatusTxn_Request) null, out HoldStatusTxn_Result _);
    }

    public ResultStatus CreateParametricData(HoldStatusTxn holdStatusTxn)
    {
      return this.CreateParametricData(holdStatusTxn, (HoldStatusTxn_Parameters) null, (HoldStatusTxn_Request) null, out HoldStatusTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      return this.CreateParametricData(holdStatusTxn, (HoldStatusTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Parameters parameters,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      result = (HoldStatusTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) holdStatusTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldStatusTxnService) this._Channel).GetActions(this._UserProfile, holdStatusTxn, parameters, request, out result) : this.AddMethod((Method) new HoldStatusTxnMethod(holdStatusTxn, HoldStatusTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) holdStatusTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((HoldStatusTxn) null, (HoldStatusTxn_Parameters) null, (HoldStatusTxn_Request) null, out HoldStatusTxn_Result _);
    }

    public ResultStatus GetActions(HoldStatusTxn holdStatusTxn)
    {
      return this.GetActions(holdStatusTxn, (HoldStatusTxn_Parameters) null, (HoldStatusTxn_Request) null, out HoldStatusTxn_Result _);
    }

    public ResultStatus GetActions(
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      return this.GetActions(holdStatusTxn, (HoldStatusTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Parameters parameters,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      result = (HoldStatusTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) holdStatusTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldStatusTxnService) this._Channel).GetDataPoints(this._UserProfile, holdStatusTxn, parameters, request, out result) : this.AddMethod((Method) new HoldStatusTxnMethod(holdStatusTxn, HoldStatusTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) holdStatusTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((HoldStatusTxn) null, (HoldStatusTxn_Parameters) null, (HoldStatusTxn_Request) null, out HoldStatusTxn_Result _);
    }

    public ResultStatus GetDataPoints(HoldStatusTxn holdStatusTxn)
    {
      return this.GetDataPoints(holdStatusTxn, (HoldStatusTxn_Parameters) null, (HoldStatusTxn_Request) null, out HoldStatusTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      return this.GetDataPoints(holdStatusTxn, (HoldStatusTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Parameters parameters,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      result = (HoldStatusTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) holdStatusTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldStatusTxnService) this._Channel).GetWIPMsgs(this._UserProfile, holdStatusTxn, parameters, request, out result) : this.AddMethod((Method) new HoldStatusTxnMethod(holdStatusTxn, HoldStatusTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) holdStatusTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((HoldStatusTxn) null, (HoldStatusTxn_Parameters) null, (HoldStatusTxn_Request) null, out HoldStatusTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(HoldStatusTxn holdStatusTxn)
    {
      return this.GetWIPMsgs(holdStatusTxn, (HoldStatusTxn_Parameters) null, (HoldStatusTxn_Request) null, out HoldStatusTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      return this.GetWIPMsgs(holdStatusTxn, (HoldStatusTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Parameters parameters,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      result = (HoldStatusTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) holdStatusTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldStatusTxnService) this._Channel).Load(this._UserProfile, holdStatusTxn, parameters, request, out result) : this.AddMethod((Method) new HoldStatusTxnMethod(holdStatusTxn, HoldStatusTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) holdStatusTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((HoldStatusTxn) null, (HoldStatusTxn_Parameters) null, (HoldStatusTxn_Request) null, out HoldStatusTxn_Result _);
    }

    public ResultStatus Load(HoldStatusTxn holdStatusTxn)
    {
      return this.Load(holdStatusTxn, (HoldStatusTxn_Parameters) null, (HoldStatusTxn_Request) null, out HoldStatusTxn_Result _);
    }

    public ResultStatus Load(
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      return this.Load(holdStatusTxn, (HoldStatusTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_LoadESigDetails_Parameters parameters,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      result = (HoldStatusTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) holdStatusTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldStatusTxnService) this._Channel).LoadESigDetails(this._UserProfile, holdStatusTxn, parameters, request, out result) : this.AddMethod((Method) new HoldStatusTxnMethod(holdStatusTxn, HoldStatusTxnMethods.LoadESigDetails, (HoldStatusTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) holdStatusTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((HoldStatusTxn) null, (HoldStatusTxn_LoadESigDetails_Parameters) null, (HoldStatusTxn_Request) null, out HoldStatusTxn_Result _);
    }

    public ResultStatus LoadESigDetails(HoldStatusTxn holdStatusTxn)
    {
      return this.LoadESigDetails(holdStatusTxn, (HoldStatusTxn_LoadESigDetails_Parameters) null, (HoldStatusTxn_Request) null, out HoldStatusTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      return this.LoadESigDetails(holdStatusTxn, (HoldStatusTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Parameters parameters,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      result = (HoldStatusTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) holdStatusTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldStatusTxnService) this._Channel).ProcessComputation(this._UserProfile, holdStatusTxn, parameters, request, out result) : this.AddMethod((Method) new HoldStatusTxnMethod(holdStatusTxn, HoldStatusTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) holdStatusTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((HoldStatusTxn) null, (HoldStatusTxn_Parameters) null, (HoldStatusTxn_Request) null, out HoldStatusTxn_Result _);
    }

    public ResultStatus ProcessComputation(HoldStatusTxn holdStatusTxn)
    {
      return this.ProcessComputation(holdStatusTxn, (HoldStatusTxn_Parameters) null, (HoldStatusTxn_Request) null, out HoldStatusTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      return this.ProcessComputation(holdStatusTxn, (HoldStatusTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Parameters parameters,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      result = (HoldStatusTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) holdStatusTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldStatusTxnService) this._Channel).ResolveParametricData(this._UserProfile, holdStatusTxn, parameters, request, out result) : this.AddMethod((Method) new HoldStatusTxnMethod(holdStatusTxn, HoldStatusTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) holdStatusTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((HoldStatusTxn) null, (HoldStatusTxn_Parameters) null, (HoldStatusTxn_Request) null, out HoldStatusTxn_Result _);
    }

    public ResultStatus ResolveParametricData(HoldStatusTxn holdStatusTxn)
    {
      return this.ResolveParametricData(holdStatusTxn, (HoldStatusTxn_Parameters) null, (HoldStatusTxn_Request) null, out HoldStatusTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      return this.ResolveParametricData(holdStatusTxn, (HoldStatusTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject holdStatusTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldStatusTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((HoldStatusTxn) holdStatusTxn, (HoldStatusTxn_Parameters) parameters, (HoldStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject holdStatusTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldStatusTxn_Result result1;
        ResultStatus actions = this.GetActions((HoldStatusTxn) holdStatusTxn, (HoldStatusTxn_Parameters) parameters, (HoldStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject holdStatusTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldStatusTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((HoldStatusTxn) holdStatusTxn, (HoldStatusTxn_Parameters) parameters, (HoldStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject holdStatusTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldStatusTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((HoldStatusTxn) holdStatusTxn, (HoldStatusTxn_LoadESigDetails_Parameters) parameters, (HoldStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject holdStatusTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldStatusTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((HoldStatusTxn) holdStatusTxn, (HoldStatusTxn_Parameters) parameters, (HoldStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject holdStatusTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldStatusTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((HoldStatusTxn) holdStatusTxn, (HoldStatusTxn_Parameters) parameters, (HoldStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject holdStatusTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldStatusTxn_Result result1;
        ResultStatus resultStatus = this.Load((HoldStatusTxn) holdStatusTxn, (HoldStatusTxn_Parameters) parameters, (HoldStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject holdStatusTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldStatusTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((HoldStatusTxn) holdStatusTxn, (HoldStatusTxn_Parameters) parameters, (HoldStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      result = (HoldStatusTxn_Result) null;
      try
      {
        HoldStatusTxnMethod[] methods = new HoldStatusTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IHoldStatusTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        HoldStatusTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((HoldStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      HoldStatusTxn cdo,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      result = (HoldStatusTxn_Result) null;
      try
      {
        return ((IHoldStatusTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        HoldStatusTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((HoldStatusTxn) cdo, (HoldStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      return this.GetEnvironment((HoldStatusTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      HoldStatusTxn cdo,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      result = (HoldStatusTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldStatusTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new HoldStatusTxnMethod(cdo, HoldStatusTxnMethods.ExecuteTransaction, (HoldStatusTxn_Parameters) null));
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
        HoldStatusTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((HoldStatusTxn) cdo, (HoldStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(HoldStatusTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (HoldStatusTxn_Request) null, out HoldStatusTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result)
    {
      return this.ExecuteTransaction((HoldStatusTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(HoldStatusTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new HoldStatusTxnMethod(cdo, HoldStatusTxnMethods.AddDataTransaction, (HoldStatusTxn_Parameters) null));
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
        return this.AddDataTransaction((HoldStatusTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
