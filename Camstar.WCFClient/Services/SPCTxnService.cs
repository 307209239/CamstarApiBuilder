// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SPCTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SPCTxnService : ShopFloorBase
  {
    public SPCTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISPCTxnService), userProfile);
    }

    public ResultStatus CreateParametricData(
      SPCTxn sPCTxn,
      SPCTxn_Parameters parameters,
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      result = (SPCTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) sPCTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCTxnService) this._Channel).CreateParametricData(this._UserProfile, sPCTxn, parameters, request, out result) : this.AddMethod((Method) new SPCTxnMethod(sPCTxn, SPCTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) sPCTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((SPCTxn) null, (SPCTxn_Parameters) null, (SPCTxn_Request) null, out SPCTxn_Result _);
    }

    public ResultStatus CreateParametricData(SPCTxn sPCTxn)
    {
      return this.CreateParametricData(sPCTxn, (SPCTxn_Parameters) null, (SPCTxn_Request) null, out SPCTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      SPCTxn sPCTxn,
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      return this.CreateParametricData(sPCTxn, (SPCTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      SPCTxn sPCTxn,
      SPCTxn_Parameters parameters,
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      result = (SPCTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) sPCTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCTxnService) this._Channel).GetActions(this._UserProfile, sPCTxn, parameters, request, out result) : this.AddMethod((Method) new SPCTxnMethod(sPCTxn, SPCTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) sPCTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((SPCTxn) null, (SPCTxn_Parameters) null, (SPCTxn_Request) null, out SPCTxn_Result _);
    }

    public ResultStatus GetActions(SPCTxn sPCTxn)
    {
      return this.GetActions(sPCTxn, (SPCTxn_Parameters) null, (SPCTxn_Request) null, out SPCTxn_Result _);
    }

    public ResultStatus GetActions(
      SPCTxn sPCTxn,
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      return this.GetActions(sPCTxn, (SPCTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      SPCTxn sPCTxn,
      SPCTxn_Parameters parameters,
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      result = (SPCTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) sPCTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCTxnService) this._Channel).GetDataPoints(this._UserProfile, sPCTxn, parameters, request, out result) : this.AddMethod((Method) new SPCTxnMethod(sPCTxn, SPCTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) sPCTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((SPCTxn) null, (SPCTxn_Parameters) null, (SPCTxn_Request) null, out SPCTxn_Result _);
    }

    public ResultStatus GetDataPoints(SPCTxn sPCTxn)
    {
      return this.GetDataPoints(sPCTxn, (SPCTxn_Parameters) null, (SPCTxn_Request) null, out SPCTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      SPCTxn sPCTxn,
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      return this.GetDataPoints(sPCTxn, (SPCTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SPCTxn sPCTxn,
      SPCTxn_Parameters parameters,
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      result = (SPCTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) sPCTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCTxnService) this._Channel).GetWIPMsgs(this._UserProfile, sPCTxn, parameters, request, out result) : this.AddMethod((Method) new SPCTxnMethod(sPCTxn, SPCTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) sPCTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SPCTxn) null, (SPCTxn_Parameters) null, (SPCTxn_Request) null, out SPCTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(SPCTxn sPCTxn)
    {
      return this.GetWIPMsgs(sPCTxn, (SPCTxn_Parameters) null, (SPCTxn_Request) null, out SPCTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SPCTxn sPCTxn,
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      return this.GetWIPMsgs(sPCTxn, (SPCTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SPCTxn sPCTxn,
      SPCTxn_Parameters parameters,
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      result = (SPCTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) sPCTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCTxnService) this._Channel).Load(this._UserProfile, sPCTxn, parameters, request, out result) : this.AddMethod((Method) new SPCTxnMethod(sPCTxn, SPCTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) sPCTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SPCTxn) null, (SPCTxn_Parameters) null, (SPCTxn_Request) null, out SPCTxn_Result _);
    }

    public ResultStatus Load(SPCTxn sPCTxn)
    {
      return this.Load(sPCTxn, (SPCTxn_Parameters) null, (SPCTxn_Request) null, out SPCTxn_Result _);
    }

    public ResultStatus Load(
      SPCTxn sPCTxn,
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      return this.Load(sPCTxn, (SPCTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SPCTxn sPCTxn,
      SPCTxn_LoadESigDetails_Parameters parameters,
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      result = (SPCTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) sPCTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCTxnService) this._Channel).LoadESigDetails(this._UserProfile, sPCTxn, parameters, request, out result) : this.AddMethod((Method) new SPCTxnMethod(sPCTxn, SPCTxnMethods.LoadESigDetails, (SPCTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) sPCTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SPCTxn) null, (SPCTxn_LoadESigDetails_Parameters) null, (SPCTxn_Request) null, out SPCTxn_Result _);
    }

    public ResultStatus LoadESigDetails(SPCTxn sPCTxn)
    {
      return this.LoadESigDetails(sPCTxn, (SPCTxn_LoadESigDetails_Parameters) null, (SPCTxn_Request) null, out SPCTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      SPCTxn sPCTxn,
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      return this.LoadESigDetails(sPCTxn, (SPCTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      SPCTxn sPCTxn,
      SPCTxn_Parameters parameters,
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      result = (SPCTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) sPCTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCTxnService) this._Channel).ProcessComputation(this._UserProfile, sPCTxn, parameters, request, out result) : this.AddMethod((Method) new SPCTxnMethod(sPCTxn, SPCTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) sPCTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((SPCTxn) null, (SPCTxn_Parameters) null, (SPCTxn_Request) null, out SPCTxn_Result _);
    }

    public ResultStatus ProcessComputation(SPCTxn sPCTxn)
    {
      return this.ProcessComputation(sPCTxn, (SPCTxn_Parameters) null, (SPCTxn_Request) null, out SPCTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      SPCTxn sPCTxn,
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      return this.ProcessComputation(sPCTxn, (SPCTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      SPCTxn sPCTxn,
      SPCTxn_Parameters parameters,
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      result = (SPCTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) sPCTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCTxnService) this._Channel).ResolveParametricData(this._UserProfile, sPCTxn, parameters, request, out result) : this.AddMethod((Method) new SPCTxnMethod(sPCTxn, SPCTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) sPCTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((SPCTxn) null, (SPCTxn_Parameters) null, (SPCTxn_Request) null, out SPCTxn_Result _);
    }

    public ResultStatus ResolveParametricData(SPCTxn sPCTxn)
    {
      return this.ResolveParametricData(sPCTxn, (SPCTxn_Parameters) null, (SPCTxn_Request) null, out SPCTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      SPCTxn sPCTxn,
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      return this.ResolveParametricData(sPCTxn, (SPCTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject sPCTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((SPCTxn) sPCTxn, (SPCTxn_Parameters) parameters, (SPCTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject sPCTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCTxn_Result result1;
        ResultStatus actions = this.GetActions((SPCTxn) sPCTxn, (SPCTxn_Parameters) parameters, (SPCTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject sPCTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((SPCTxn) sPCTxn, (SPCTxn_Parameters) parameters, (SPCTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject sPCTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SPCTxn) sPCTxn, (SPCTxn_LoadESigDetails_Parameters) parameters, (SPCTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject sPCTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((SPCTxn) sPCTxn, (SPCTxn_Parameters) parameters, (SPCTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject sPCTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((SPCTxn) sPCTxn, (SPCTxn_Parameters) parameters, (SPCTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject sPCTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCTxn_Result result1;
        ResultStatus resultStatus = this.Load((SPCTxn) sPCTxn, (SPCTxn_Parameters) parameters, (SPCTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject sPCTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SPCTxn) sPCTxn, (SPCTxn_Parameters) parameters, (SPCTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      result = (SPCTxn_Result) null;
      try
      {
        SPCTxnMethod[] methods = new SPCTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISPCTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SPCTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SPCTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SPCTxn cdo,
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      result = (SPCTxn_Result) null;
      try
      {
        return ((ISPCTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SPCTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((SPCTxn) cdo, (SPCTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(SPCTxn_Request request, out SPCTxn_Result result)
    {
      return this.GetEnvironment((SPCTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SPCTxn cdo,
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      result = (SPCTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SPCTxnMethod(cdo, SPCTxnMethods.ExecuteTransaction, (SPCTxn_Parameters) null));
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
        SPCTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SPCTxn) cdo, (SPCTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SPCTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (SPCTxn_Request) null, out SPCTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SPCTxn_Request request,
      out SPCTxn_Result result)
    {
      return this.ExecuteTransaction((SPCTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SPCTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SPCTxnMethod(cdo, SPCTxnMethods.AddDataTransaction, (SPCTxn_Parameters) null));
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
        return this.AddDataTransaction((SPCTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
