// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.HistoryViewTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class HistoryViewTxnService : ShopFloorBase
  {
    public HistoryViewTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IHistoryViewTxnService), userProfile);
    }

    public ResultStatus CreateParametricData(
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Parameters parameters,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      result = (HistoryViewTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) historyViewTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewTxnService) this._Channel).CreateParametricData(this._UserProfile, historyViewTxn, parameters, request, out result) : this.AddMethod((Method) new HistoryViewTxnMethod(historyViewTxn, HistoryViewTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) historyViewTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((HistoryViewTxn) null, (HistoryViewTxn_Parameters) null, (HistoryViewTxn_Request) null, out HistoryViewTxn_Result _);
    }

    public ResultStatus CreateParametricData(HistoryViewTxn historyViewTxn)
    {
      return this.CreateParametricData(historyViewTxn, (HistoryViewTxn_Parameters) null, (HistoryViewTxn_Request) null, out HistoryViewTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      return this.CreateParametricData(historyViewTxn, (HistoryViewTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Parameters parameters,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      result = (HistoryViewTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) historyViewTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewTxnService) this._Channel).GetActions(this._UserProfile, historyViewTxn, parameters, request, out result) : this.AddMethod((Method) new HistoryViewTxnMethod(historyViewTxn, HistoryViewTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) historyViewTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((HistoryViewTxn) null, (HistoryViewTxn_Parameters) null, (HistoryViewTxn_Request) null, out HistoryViewTxn_Result _);
    }

    public ResultStatus GetActions(HistoryViewTxn historyViewTxn)
    {
      return this.GetActions(historyViewTxn, (HistoryViewTxn_Parameters) null, (HistoryViewTxn_Request) null, out HistoryViewTxn_Result _);
    }

    public ResultStatus GetActions(
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      return this.GetActions(historyViewTxn, (HistoryViewTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Parameters parameters,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      result = (HistoryViewTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) historyViewTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewTxnService) this._Channel).GetDataPoints(this._UserProfile, historyViewTxn, parameters, request, out result) : this.AddMethod((Method) new HistoryViewTxnMethod(historyViewTxn, HistoryViewTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) historyViewTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((HistoryViewTxn) null, (HistoryViewTxn_Parameters) null, (HistoryViewTxn_Request) null, out HistoryViewTxn_Result _);
    }

    public ResultStatus GetDataPoints(HistoryViewTxn historyViewTxn)
    {
      return this.GetDataPoints(historyViewTxn, (HistoryViewTxn_Parameters) null, (HistoryViewTxn_Request) null, out HistoryViewTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      return this.GetDataPoints(historyViewTxn, (HistoryViewTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Parameters parameters,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      result = (HistoryViewTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) historyViewTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewTxnService) this._Channel).GetWIPMsgs(this._UserProfile, historyViewTxn, parameters, request, out result) : this.AddMethod((Method) new HistoryViewTxnMethod(historyViewTxn, HistoryViewTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) historyViewTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((HistoryViewTxn) null, (HistoryViewTxn_Parameters) null, (HistoryViewTxn_Request) null, out HistoryViewTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(HistoryViewTxn historyViewTxn)
    {
      return this.GetWIPMsgs(historyViewTxn, (HistoryViewTxn_Parameters) null, (HistoryViewTxn_Request) null, out HistoryViewTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      return this.GetWIPMsgs(historyViewTxn, (HistoryViewTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Parameters parameters,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      result = (HistoryViewTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) historyViewTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewTxnService) this._Channel).Load(this._UserProfile, historyViewTxn, parameters, request, out result) : this.AddMethod((Method) new HistoryViewTxnMethod(historyViewTxn, HistoryViewTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) historyViewTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((HistoryViewTxn) null, (HistoryViewTxn_Parameters) null, (HistoryViewTxn_Request) null, out HistoryViewTxn_Result _);
    }

    public ResultStatus Load(HistoryViewTxn historyViewTxn)
    {
      return this.Load(historyViewTxn, (HistoryViewTxn_Parameters) null, (HistoryViewTxn_Request) null, out HistoryViewTxn_Result _);
    }

    public ResultStatus Load(
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      return this.Load(historyViewTxn, (HistoryViewTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_LoadESigDetails_Parameters parameters,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      result = (HistoryViewTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) historyViewTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewTxnService) this._Channel).LoadESigDetails(this._UserProfile, historyViewTxn, parameters, request, out result) : this.AddMethod((Method) new HistoryViewTxnMethod(historyViewTxn, HistoryViewTxnMethods.LoadESigDetails, (HistoryViewTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) historyViewTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((HistoryViewTxn) null, (HistoryViewTxn_LoadESigDetails_Parameters) null, (HistoryViewTxn_Request) null, out HistoryViewTxn_Result _);
    }

    public ResultStatus LoadESigDetails(HistoryViewTxn historyViewTxn)
    {
      return this.LoadESigDetails(historyViewTxn, (HistoryViewTxn_LoadESigDetails_Parameters) null, (HistoryViewTxn_Request) null, out HistoryViewTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      return this.LoadESigDetails(historyViewTxn, (HistoryViewTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Parameters parameters,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      result = (HistoryViewTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) historyViewTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewTxnService) this._Channel).ProcessComputation(this._UserProfile, historyViewTxn, parameters, request, out result) : this.AddMethod((Method) new HistoryViewTxnMethod(historyViewTxn, HistoryViewTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) historyViewTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((HistoryViewTxn) null, (HistoryViewTxn_Parameters) null, (HistoryViewTxn_Request) null, out HistoryViewTxn_Result _);
    }

    public ResultStatus ProcessComputation(HistoryViewTxn historyViewTxn)
    {
      return this.ProcessComputation(historyViewTxn, (HistoryViewTxn_Parameters) null, (HistoryViewTxn_Request) null, out HistoryViewTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      return this.ProcessComputation(historyViewTxn, (HistoryViewTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Parameters parameters,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      result = (HistoryViewTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) historyViewTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewTxnService) this._Channel).ResolveParametricData(this._UserProfile, historyViewTxn, parameters, request, out result) : this.AddMethod((Method) new HistoryViewTxnMethod(historyViewTxn, HistoryViewTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) historyViewTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((HistoryViewTxn) null, (HistoryViewTxn_Parameters) null, (HistoryViewTxn_Request) null, out HistoryViewTxn_Result _);
    }

    public ResultStatus ResolveParametricData(HistoryViewTxn historyViewTxn)
    {
      return this.ResolveParametricData(historyViewTxn, (HistoryViewTxn_Parameters) null, (HistoryViewTxn_Request) null, out HistoryViewTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      return this.ResolveParametricData(historyViewTxn, (HistoryViewTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject historyViewTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HistoryViewTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((HistoryViewTxn) historyViewTxn, (HistoryViewTxn_Parameters) parameters, (HistoryViewTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject historyViewTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HistoryViewTxn_Result result1;
        ResultStatus actions = this.GetActions((HistoryViewTxn) historyViewTxn, (HistoryViewTxn_Parameters) parameters, (HistoryViewTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject historyViewTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HistoryViewTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((HistoryViewTxn) historyViewTxn, (HistoryViewTxn_Parameters) parameters, (HistoryViewTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject historyViewTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HistoryViewTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((HistoryViewTxn) historyViewTxn, (HistoryViewTxn_LoadESigDetails_Parameters) parameters, (HistoryViewTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject historyViewTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HistoryViewTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((HistoryViewTxn) historyViewTxn, (HistoryViewTxn_Parameters) parameters, (HistoryViewTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject historyViewTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HistoryViewTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((HistoryViewTxn) historyViewTxn, (HistoryViewTxn_Parameters) parameters, (HistoryViewTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject historyViewTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HistoryViewTxn_Result result1;
        ResultStatus resultStatus = this.Load((HistoryViewTxn) historyViewTxn, (HistoryViewTxn_Parameters) parameters, (HistoryViewTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject historyViewTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HistoryViewTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((HistoryViewTxn) historyViewTxn, (HistoryViewTxn_Parameters) parameters, (HistoryViewTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      result = (HistoryViewTxn_Result) null;
      try
      {
        HistoryViewTxnMethod[] methods = new HistoryViewTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IHistoryViewTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        HistoryViewTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((HistoryViewTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      HistoryViewTxn cdo,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      result = (HistoryViewTxn_Result) null;
      try
      {
        return ((IHistoryViewTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        HistoryViewTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((HistoryViewTxn) cdo, (HistoryViewTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      return this.GetEnvironment((HistoryViewTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      HistoryViewTxn cdo,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      result = (HistoryViewTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new HistoryViewTxnMethod(cdo, HistoryViewTxnMethods.ExecuteTransaction, (HistoryViewTxn_Parameters) null));
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
        HistoryViewTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((HistoryViewTxn) cdo, (HistoryViewTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(HistoryViewTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (HistoryViewTxn_Request) null, out HistoryViewTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result)
    {
      return this.ExecuteTransaction((HistoryViewTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(HistoryViewTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new HistoryViewTxnMethod(cdo, HistoryViewTxnMethods.AddDataTransaction, (HistoryViewTxn_Parameters) null));
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
        return this.AddDataTransaction((HistoryViewTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
