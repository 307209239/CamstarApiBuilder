// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BatchStartService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BatchStartService : StartBase
  {
    public BatchStartService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBatchStartService), userProfile);
    }

    public ResultStatus CreateParametricData(
      BatchStart batchStart,
      BatchStart_Parameters parameters,
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      result = (BatchStart_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) batchStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchStartService) this._Channel).CreateParametricData(this._UserProfile, batchStart, parameters, request, out result) : this.AddMethod((Method) new BatchStartMethod(batchStart, BatchStartMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) batchStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((BatchStart) null, (BatchStart_Parameters) null, (BatchStart_Request) null, out BatchStart_Result _);
    }

    public ResultStatus CreateParametricData(BatchStart batchStart)
    {
      return this.CreateParametricData(batchStart, (BatchStart_Parameters) null, (BatchStart_Request) null, out BatchStart_Result _);
    }

    public ResultStatus CreateParametricData(
      BatchStart batchStart,
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      return this.CreateParametricData(batchStart, (BatchStart_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      BatchStart batchStart,
      BatchStart_Parameters parameters,
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      result = (BatchStart_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) batchStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchStartService) this._Channel).GetActions(this._UserProfile, batchStart, parameters, request, out result) : this.AddMethod((Method) new BatchStartMethod(batchStart, BatchStartMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) batchStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((BatchStart) null, (BatchStart_Parameters) null, (BatchStart_Request) null, out BatchStart_Result _);
    }

    public ResultStatus GetActions(BatchStart batchStart)
    {
      return this.GetActions(batchStart, (BatchStart_Parameters) null, (BatchStart_Request) null, out BatchStart_Result _);
    }

    public ResultStatus GetActions(
      BatchStart batchStart,
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      return this.GetActions(batchStart, (BatchStart_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      BatchStart batchStart,
      BatchStart_Parameters parameters,
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      result = (BatchStart_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) batchStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchStartService) this._Channel).GetDataPoints(this._UserProfile, batchStart, parameters, request, out result) : this.AddMethod((Method) new BatchStartMethod(batchStart, BatchStartMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) batchStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((BatchStart) null, (BatchStart_Parameters) null, (BatchStart_Request) null, out BatchStart_Result _);
    }

    public ResultStatus GetDataPoints(BatchStart batchStart)
    {
      return this.GetDataPoints(batchStart, (BatchStart_Parameters) null, (BatchStart_Request) null, out BatchStart_Result _);
    }

    public ResultStatus GetDataPoints(
      BatchStart batchStart,
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      return this.GetDataPoints(batchStart, (BatchStart_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BatchStart batchStart,
      BatchStart_Parameters parameters,
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      result = (BatchStart_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) batchStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchStartService) this._Channel).GetWIPMsgs(this._UserProfile, batchStart, parameters, request, out result) : this.AddMethod((Method) new BatchStartMethod(batchStart, BatchStartMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) batchStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BatchStart) null, (BatchStart_Parameters) null, (BatchStart_Request) null, out BatchStart_Result _);
    }

    public ResultStatus GetWIPMsgs(BatchStart batchStart)
    {
      return this.GetWIPMsgs(batchStart, (BatchStart_Parameters) null, (BatchStart_Request) null, out BatchStart_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BatchStart batchStart,
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      return this.GetWIPMsgs(batchStart, (BatchStart_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BatchStart batchStart,
      BatchStart_Parameters parameters,
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      result = (BatchStart_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) batchStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchStartService) this._Channel).Load(this._UserProfile, batchStart, parameters, request, out result) : this.AddMethod((Method) new BatchStartMethod(batchStart, BatchStartMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) batchStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BatchStart) null, (BatchStart_Parameters) null, (BatchStart_Request) null, out BatchStart_Result _);
    }

    public ResultStatus Load(BatchStart batchStart)
    {
      return this.Load(batchStart, (BatchStart_Parameters) null, (BatchStart_Request) null, out BatchStart_Result _);
    }

    public ResultStatus Load(
      BatchStart batchStart,
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      return this.Load(batchStart, (BatchStart_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BatchStart batchStart,
      BatchStart_LoadESigDetails_Parameters parameters,
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      result = (BatchStart_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) batchStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchStartService) this._Channel).LoadESigDetails(this._UserProfile, batchStart, parameters, request, out result) : this.AddMethod((Method) new BatchStartMethod(batchStart, BatchStartMethods.LoadESigDetails, (BatchStart_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) batchStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BatchStart) null, (BatchStart_LoadESigDetails_Parameters) null, (BatchStart_Request) null, out BatchStart_Result _);
    }

    public ResultStatus LoadESigDetails(BatchStart batchStart)
    {
      return this.LoadESigDetails(batchStart, (BatchStart_LoadESigDetails_Parameters) null, (BatchStart_Request) null, out BatchStart_Result _);
    }

    public ResultStatus LoadESigDetails(
      BatchStart batchStart,
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      return this.LoadESigDetails(batchStart, (BatchStart_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      BatchStart batchStart,
      BatchStart_Parameters parameters,
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      result = (BatchStart_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) batchStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchStartService) this._Channel).ProcessComputation(this._UserProfile, batchStart, parameters, request, out result) : this.AddMethod((Method) new BatchStartMethod(batchStart, BatchStartMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) batchStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((BatchStart) null, (BatchStart_Parameters) null, (BatchStart_Request) null, out BatchStart_Result _);
    }

    public ResultStatus ProcessComputation(BatchStart batchStart)
    {
      return this.ProcessComputation(batchStart, (BatchStart_Parameters) null, (BatchStart_Request) null, out BatchStart_Result _);
    }

    public ResultStatus ProcessComputation(
      BatchStart batchStart,
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      return this.ProcessComputation(batchStart, (BatchStart_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      BatchStart batchStart,
      BatchStart_Parameters parameters,
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      result = (BatchStart_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) batchStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchStartService) this._Channel).ResolveParametricData(this._UserProfile, batchStart, parameters, request, out result) : this.AddMethod((Method) new BatchStartMethod(batchStart, BatchStartMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) batchStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((BatchStart) null, (BatchStart_Parameters) null, (BatchStart_Request) null, out BatchStart_Result _);
    }

    public ResultStatus ResolveParametricData(BatchStart batchStart)
    {
      return this.ResolveParametricData(batchStart, (BatchStart_Parameters) null, (BatchStart_Request) null, out BatchStart_Result _);
    }

    public ResultStatus ResolveParametricData(
      BatchStart batchStart,
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      return this.ResolveParametricData(batchStart, (BatchStart_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject batchStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BatchStart_Result result1;
        ResultStatus parametricData = this.CreateParametricData((BatchStart) batchStart, (BatchStart_Parameters) parameters, (BatchStart_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject batchStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BatchStart_Result result1;
        ResultStatus actions = this.GetActions((BatchStart) batchStart, (BatchStart_Parameters) parameters, (BatchStart_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject batchStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BatchStart_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((BatchStart) batchStart, (BatchStart_Parameters) parameters, (BatchStart_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject batchStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BatchStart_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BatchStart) batchStart, (BatchStart_LoadESigDetails_Parameters) parameters, (BatchStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject batchStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BatchStart_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((BatchStart) batchStart, (BatchStart_Parameters) parameters, (BatchStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject batchStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BatchStart_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((BatchStart) batchStart, (BatchStart_Parameters) parameters, (BatchStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject batchStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BatchStart_Result result1;
        ResultStatus resultStatus = this.Load((BatchStart) batchStart, (BatchStart_Parameters) parameters, (BatchStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject batchStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BatchStart_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BatchStart) batchStart, (BatchStart_Parameters) parameters, (BatchStart_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      result = (BatchStart_Result) null;
      try
      {
        BatchStartMethod[] methods = new BatchStartMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBatchStartService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BatchStart_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BatchStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BatchStart cdo,
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      result = (BatchStart_Result) null;
      try
      {
        return ((IBatchStartService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BatchStart_Result result1;
        ResultStatus environment = this.GetEnvironment((BatchStart) cdo, (BatchStart_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      return this.GetEnvironment((BatchStart) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BatchStart cdo,
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      result = (BatchStart_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchStartService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BatchStartMethod(cdo, BatchStartMethods.ExecuteTransaction, (BatchStart_Parameters) null));
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
        BatchStart_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BatchStart) cdo, (BatchStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BatchStart cdo)
    {
      return this.ExecuteTransaction(cdo, (BatchStart_Request) null, out BatchStart_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BatchStart_Request request,
      out BatchStart_Result result)
    {
      return this.ExecuteTransaction((BatchStart) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BatchStart cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BatchStartMethod(cdo, BatchStartMethods.AddDataTransaction, (BatchStart_Parameters) null));
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
        return this.AddDataTransaction((BatchStart) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
