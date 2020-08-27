// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.HoldService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class HoldService : HoldStatusTxnBase
  {
    public HoldService(UserProfile userProfile)
    {
      this.Initialize(typeof (IHoldService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Hold hold,
      Hold_Parameters parameters,
      Hold_Request request,
      out Hold_Result result)
    {
      result = (Hold_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) hold, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldService) this._Channel).CreateParametricData(this._UserProfile, hold, parameters, request, out result) : this.AddMethod((Method) new HoldMethod(hold, HoldMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) hold, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Hold) null, (Hold_Parameters) null, (Hold_Request) null, out Hold_Result _);
    }

    public ResultStatus CreateParametricData(Hold hold)
    {
      return this.CreateParametricData(hold, (Hold_Parameters) null, (Hold_Request) null, out Hold_Result _);
    }

    public ResultStatus CreateParametricData(
      Hold hold,
      Hold_Request request,
      out Hold_Result result)
    {
      return this.CreateParametricData(hold, (Hold_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Hold hold,
      Hold_Parameters parameters,
      Hold_Request request,
      out Hold_Result result)
    {
      result = (Hold_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) hold, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldService) this._Channel).GetActions(this._UserProfile, hold, parameters, request, out result) : this.AddMethod((Method) new HoldMethod(hold, HoldMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) hold, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Hold) null, (Hold_Parameters) null, (Hold_Request) null, out Hold_Result _);
    }

    public ResultStatus GetActions(Hold hold)
    {
      return this.GetActions(hold, (Hold_Parameters) null, (Hold_Request) null, out Hold_Result _);
    }

    public ResultStatus GetActions(
      Hold hold,
      Hold_Request request,
      out Hold_Result result)
    {
      return this.GetActions(hold, (Hold_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Hold hold,
      Hold_Parameters parameters,
      Hold_Request request,
      out Hold_Result result)
    {
      result = (Hold_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) hold, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldService) this._Channel).GetDataPoints(this._UserProfile, hold, parameters, request, out result) : this.AddMethod((Method) new HoldMethod(hold, HoldMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) hold, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Hold) null, (Hold_Parameters) null, (Hold_Request) null, out Hold_Result _);
    }

    public ResultStatus GetDataPoints(Hold hold)
    {
      return this.GetDataPoints(hold, (Hold_Parameters) null, (Hold_Request) null, out Hold_Result _);
    }

    public ResultStatus GetDataPoints(
      Hold hold,
      Hold_Request request,
      out Hold_Result result)
    {
      return this.GetDataPoints(hold, (Hold_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Hold hold,
      Hold_Parameters parameters,
      Hold_Request request,
      out Hold_Result result)
    {
      result = (Hold_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) hold, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldService) this._Channel).GetWIPMsgs(this._UserProfile, hold, parameters, request, out result) : this.AddMethod((Method) new HoldMethod(hold, HoldMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) hold, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Hold) null, (Hold_Parameters) null, (Hold_Request) null, out Hold_Result _);
    }

    public ResultStatus GetWIPMsgs(Hold hold)
    {
      return this.GetWIPMsgs(hold, (Hold_Parameters) null, (Hold_Request) null, out Hold_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Hold hold,
      Hold_Request request,
      out Hold_Result result)
    {
      return this.GetWIPMsgs(hold, (Hold_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Hold hold,
      Hold_Parameters parameters,
      Hold_Request request,
      out Hold_Result result)
    {
      result = (Hold_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) hold, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldService) this._Channel).Load(this._UserProfile, hold, parameters, request, out result) : this.AddMethod((Method) new HoldMethod(hold, HoldMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) hold, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Hold) null, (Hold_Parameters) null, (Hold_Request) null, out Hold_Result _);
    }

    public ResultStatus Load(Hold hold)
    {
      return this.Load(hold, (Hold_Parameters) null, (Hold_Request) null, out Hold_Result _);
    }

    public ResultStatus Load(Hold hold, Hold_Request request, out Hold_Result result)
    {
      return this.Load(hold, (Hold_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Hold hold,
      Hold_LoadESigDetails_Parameters parameters,
      Hold_Request request,
      out Hold_Result result)
    {
      result = (Hold_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) hold, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldService) this._Channel).LoadESigDetails(this._UserProfile, hold, parameters, request, out result) : this.AddMethod((Method) new HoldMethod(hold, HoldMethods.LoadESigDetails, (Hold_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) hold, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Hold) null, (Hold_LoadESigDetails_Parameters) null, (Hold_Request) null, out Hold_Result _);
    }

    public ResultStatus LoadESigDetails(Hold hold)
    {
      return this.LoadESigDetails(hold, (Hold_LoadESigDetails_Parameters) null, (Hold_Request) null, out Hold_Result _);
    }

    public ResultStatus LoadESigDetails(
      Hold hold,
      Hold_Request request,
      out Hold_Result result)
    {
      return this.LoadESigDetails(hold, (Hold_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Hold hold,
      Hold_Parameters parameters,
      Hold_Request request,
      out Hold_Result result)
    {
      result = (Hold_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) hold, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldService) this._Channel).ProcessComputation(this._UserProfile, hold, parameters, request, out result) : this.AddMethod((Method) new HoldMethod(hold, HoldMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) hold, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Hold) null, (Hold_Parameters) null, (Hold_Request) null, out Hold_Result _);
    }

    public ResultStatus ProcessComputation(Hold hold)
    {
      return this.ProcessComputation(hold, (Hold_Parameters) null, (Hold_Request) null, out Hold_Result _);
    }

    public ResultStatus ProcessComputation(
      Hold hold,
      Hold_Request request,
      out Hold_Result result)
    {
      return this.ProcessComputation(hold, (Hold_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Hold hold,
      Hold_Parameters parameters,
      Hold_Request request,
      out Hold_Result result)
    {
      result = (Hold_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) hold, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldService) this._Channel).ResolveParametricData(this._UserProfile, hold, parameters, request, out result) : this.AddMethod((Method) new HoldMethod(hold, HoldMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) hold, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Hold) null, (Hold_Parameters) null, (Hold_Request) null, out Hold_Result _);
    }

    public ResultStatus ResolveParametricData(Hold hold)
    {
      return this.ResolveParametricData(hold, (Hold_Parameters) null, (Hold_Request) null, out Hold_Result _);
    }

    public ResultStatus ResolveParametricData(
      Hold hold,
      Hold_Request request,
      out Hold_Result result)
    {
      return this.ResolveParametricData(hold, (Hold_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject hold,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Hold_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Hold) hold, (Hold_Parameters) parameters, (Hold_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject hold,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Hold_Result result1;
        ResultStatus actions = this.GetActions((Hold) hold, (Hold_Parameters) parameters, (Hold_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject hold,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Hold_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Hold) hold, (Hold_Parameters) parameters, (Hold_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject hold,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Hold_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Hold) hold, (Hold_LoadESigDetails_Parameters) parameters, (Hold_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject hold,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Hold_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Hold) hold, (Hold_Parameters) parameters, (Hold_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject hold,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Hold_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Hold) hold, (Hold_Parameters) parameters, (Hold_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject hold,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Hold_Result result1;
        ResultStatus resultStatus = this.Load((Hold) hold, (Hold_Parameters) parameters, (Hold_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject hold,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Hold_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Hold) hold, (Hold_Parameters) parameters, (Hold_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(Hold_Request request, out Hold_Result result)
    {
      result = (Hold_Result) null;
      try
      {
        HoldMethod[] methods = new HoldMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IHoldService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Hold_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Hold_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Hold cdo,
      Hold_Request request,
      out Hold_Result result)
    {
      result = (Hold_Result) null;
      try
      {
        return ((IHoldService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Hold_Result result1;
        ResultStatus environment = this.GetEnvironment((Hold) cdo, (Hold_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(Hold_Request request, out Hold_Result result)
    {
      return this.GetEnvironment((Hold) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Hold cdo,
      Hold_Request request,
      out Hold_Result result)
    {
      result = (Hold_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new HoldMethod(cdo, HoldMethods.ExecuteTransaction, (Hold_Parameters) null));
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
        Hold_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Hold) cdo, (Hold_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Hold cdo)
    {
      return this.ExecuteTransaction(cdo, (Hold_Request) null, out Hold_Result _);
    }

    public ResultStatus ExecuteTransaction(Hold_Request request, out Hold_Result result)
    {
      return this.ExecuteTransaction((Hold) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Hold cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new HoldMethod(cdo, HoldMethods.AddDataTransaction, (Hold_Parameters) null));
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
        return this.AddDataTransaction((Hold) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
