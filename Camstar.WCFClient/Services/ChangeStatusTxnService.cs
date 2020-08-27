// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangeStatusTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ChangeStatusTxnService : ChangeMgtTxnBase
  {
    public ChangeStatusTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IChangeStatusTxnService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Parameters parameters,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      result = (ChangeStatusTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) changeStatusTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnService) this._Channel).CreateParametricData(this._UserProfile, changeStatusTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusTxnMethod(changeStatusTxn, ChangeStatusTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) changeStatusTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ChangeStatusTxn) null, (ChangeStatusTxn_Parameters) null, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus CreateParametricData(ChangeStatusTxn changeStatusTxn)
    {
      return this.CreateParametricData(changeStatusTxn, (ChangeStatusTxn_Parameters) null, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      return this.CreateParametricData(changeStatusTxn, (ChangeStatusTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Parameters parameters,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      result = (ChangeStatusTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) changeStatusTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnService) this._Channel).GetActions(this._UserProfile, changeStatusTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusTxnMethod(changeStatusTxn, ChangeStatusTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) changeStatusTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ChangeStatusTxn) null, (ChangeStatusTxn_Parameters) null, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus GetActions(ChangeStatusTxn changeStatusTxn)
    {
      return this.GetActions(changeStatusTxn, (ChangeStatusTxn_Parameters) null, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus GetActions(
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      return this.GetActions(changeStatusTxn, (ChangeStatusTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Parameters parameters,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      result = (ChangeStatusTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) changeStatusTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnService) this._Channel).GetDataPoints(this._UserProfile, changeStatusTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusTxnMethod(changeStatusTxn, ChangeStatusTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) changeStatusTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ChangeStatusTxn) null, (ChangeStatusTxn_Parameters) null, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus GetDataPoints(ChangeStatusTxn changeStatusTxn)
    {
      return this.GetDataPoints(changeStatusTxn, (ChangeStatusTxn_Parameters) null, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      return this.GetDataPoints(changeStatusTxn, (ChangeStatusTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Parameters parameters,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      result = (ChangeStatusTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) changeStatusTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnService) this._Channel).GetWIPMsgs(this._UserProfile, changeStatusTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusTxnMethod(changeStatusTxn, ChangeStatusTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) changeStatusTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ChangeStatusTxn) null, (ChangeStatusTxn_Parameters) null, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(ChangeStatusTxn changeStatusTxn)
    {
      return this.GetWIPMsgs(changeStatusTxn, (ChangeStatusTxn_Parameters) null, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      return this.GetWIPMsgs(changeStatusTxn, (ChangeStatusTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Parameters parameters,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      result = (ChangeStatusTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) changeStatusTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnService) this._Channel).Load(this._UserProfile, changeStatusTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusTxnMethod(changeStatusTxn, ChangeStatusTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) changeStatusTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ChangeStatusTxn) null, (ChangeStatusTxn_Parameters) null, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus Load(ChangeStatusTxn changeStatusTxn)
    {
      return this.Load(changeStatusTxn, (ChangeStatusTxn_Parameters) null, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus Load(
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      return this.Load(changeStatusTxn, (ChangeStatusTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_LoadESigDetails_Parameters parameters,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      result = (ChangeStatusTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) changeStatusTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnService) this._Channel).LoadESigDetails(this._UserProfile, changeStatusTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusTxnMethod(changeStatusTxn, ChangeStatusTxnMethods.LoadESigDetails, (ChangeStatusTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) changeStatusTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ChangeStatusTxn) null, (ChangeStatusTxn_LoadESigDetails_Parameters) null, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus LoadESigDetails(ChangeStatusTxn changeStatusTxn)
    {
      return this.LoadESigDetails(changeStatusTxn, (ChangeStatusTxn_LoadESigDetails_Parameters) null, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      return this.LoadESigDetails(changeStatusTxn, (ChangeStatusTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Parameters parameters,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      result = (ChangeStatusTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) changeStatusTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnService) this._Channel).ProcessComputation(this._UserProfile, changeStatusTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusTxnMethod(changeStatusTxn, ChangeStatusTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) changeStatusTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ChangeStatusTxn) null, (ChangeStatusTxn_Parameters) null, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus ProcessComputation(ChangeStatusTxn changeStatusTxn)
    {
      return this.ProcessComputation(changeStatusTxn, (ChangeStatusTxn_Parameters) null, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      return this.ProcessComputation(changeStatusTxn, (ChangeStatusTxn_Parameters) null, request, out result);
    }

    public ResultStatus ProcessModelingLocks(
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Parameters parameters,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      result = (ChangeStatusTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessModelingLocks), (DCObject) changeStatusTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnService) this._Channel).ProcessModelingLocks(this._UserProfile, changeStatusTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusTxnMethod(changeStatusTxn, ChangeStatusTxnMethods.ProcessModelingLocks, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessModelingLocks), res, (DCObject) changeStatusTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessModelingLocks()
    {
      return this.ProcessModelingLocks((ChangeStatusTxn) null, (ChangeStatusTxn_Parameters) null, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus ProcessModelingLocks(ChangeStatusTxn changeStatusTxn)
    {
      return this.ProcessModelingLocks(changeStatusTxn, (ChangeStatusTxn_Parameters) null, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus ProcessModelingLocks(
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      return this.ProcessModelingLocks(changeStatusTxn, (ChangeStatusTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Parameters parameters,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      result = (ChangeStatusTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) changeStatusTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnService) this._Channel).ResolveParametricData(this._UserProfile, changeStatusTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusTxnMethod(changeStatusTxn, ChangeStatusTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) changeStatusTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ChangeStatusTxn) null, (ChangeStatusTxn_Parameters) null, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus ResolveParametricData(ChangeStatusTxn changeStatusTxn)
    {
      return this.ResolveParametricData(changeStatusTxn, (ChangeStatusTxn_Parameters) null, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      return this.ResolveParametricData(changeStatusTxn, (ChangeStatusTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject changeStatusTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ChangeStatusTxn) changeStatusTxn, (ChangeStatusTxn_Parameters) parameters, (ChangeStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject changeStatusTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusTxn_Result result1;
        ResultStatus actions = this.GetActions((ChangeStatusTxn) changeStatusTxn, (ChangeStatusTxn_Parameters) parameters, (ChangeStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject changeStatusTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ChangeStatusTxn) changeStatusTxn, (ChangeStatusTxn_Parameters) parameters, (ChangeStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject changeStatusTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ChangeStatusTxn) changeStatusTxn, (ChangeStatusTxn_LoadESigDetails_Parameters) parameters, (ChangeStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject changeStatusTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ChangeStatusTxn) changeStatusTxn, (ChangeStatusTxn_Parameters) parameters, (ChangeStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject changeStatusTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ChangeStatusTxn) changeStatusTxn, (ChangeStatusTxn_Parameters) parameters, (ChangeStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject changeStatusTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusTxn_Result result1;
        ResultStatus resultStatus = this.Load((ChangeStatusTxn) changeStatusTxn, (ChangeStatusTxn_Parameters) parameters, (ChangeStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject changeStatusTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ChangeStatusTxn) changeStatusTxn, (ChangeStatusTxn_Parameters) parameters, (ChangeStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      result = (ChangeStatusTxn_Result) null;
      try
      {
        ChangeStatusTxnMethod[] methods = new ChangeStatusTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IChangeStatusTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ChangeStatusTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ChangeStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeStatusTxn cdo,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      result = (ChangeStatusTxn_Result) null;
      try
      {
        return ((IChangeStatusTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ChangeStatusTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((ChangeStatusTxn) cdo, (ChangeStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      return this.GetEnvironment((ChangeStatusTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ChangeStatusTxn cdo,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      result = (ChangeStatusTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ChangeStatusTxnMethod(cdo, ChangeStatusTxnMethods.ExecuteTransaction, (ChangeStatusTxn_Parameters) null));
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
        ChangeStatusTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ChangeStatusTxn) cdo, (ChangeStatusTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ChangeStatusTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (ChangeStatusTxn_Request) null, out ChangeStatusTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result)
    {
      return this.ExecuteTransaction((ChangeStatusTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ChangeStatusTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ChangeStatusTxnMethod(cdo, ChangeStatusTxnMethods.AddDataTransaction, (ChangeStatusTxn_Parameters) null));
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
        return this.AddDataTransaction((ChangeStatusTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
