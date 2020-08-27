// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RecordSPCViolationService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RecordSPCViolationService : SPCTxnBase
  {
    public RecordSPCViolationService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRecordSPCViolationService), userProfile);
    }

    public ResultStatus CreateParametricData(
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Parameters parameters,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      result = (RecordSPCViolation_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) recordSPCViolation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecordSPCViolationService) this._Channel).CreateParametricData(this._UserProfile, recordSPCViolation, parameters, request, out result) : this.AddMethod((Method) new RecordSPCViolationMethod(recordSPCViolation, RecordSPCViolationMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) recordSPCViolation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((RecordSPCViolation) null, (RecordSPCViolation_Parameters) null, (RecordSPCViolation_Request) null, out RecordSPCViolation_Result _);
    }

    public ResultStatus CreateParametricData(RecordSPCViolation recordSPCViolation)
    {
      return this.CreateParametricData(recordSPCViolation, (RecordSPCViolation_Parameters) null, (RecordSPCViolation_Request) null, out RecordSPCViolation_Result _);
    }

    public ResultStatus CreateParametricData(
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      return this.CreateParametricData(recordSPCViolation, (RecordSPCViolation_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Parameters parameters,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      result = (RecordSPCViolation_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) recordSPCViolation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecordSPCViolationService) this._Channel).GetActions(this._UserProfile, recordSPCViolation, parameters, request, out result) : this.AddMethod((Method) new RecordSPCViolationMethod(recordSPCViolation, RecordSPCViolationMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) recordSPCViolation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((RecordSPCViolation) null, (RecordSPCViolation_Parameters) null, (RecordSPCViolation_Request) null, out RecordSPCViolation_Result _);
    }

    public ResultStatus GetActions(RecordSPCViolation recordSPCViolation)
    {
      return this.GetActions(recordSPCViolation, (RecordSPCViolation_Parameters) null, (RecordSPCViolation_Request) null, out RecordSPCViolation_Result _);
    }

    public ResultStatus GetActions(
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      return this.GetActions(recordSPCViolation, (RecordSPCViolation_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Parameters parameters,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      result = (RecordSPCViolation_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) recordSPCViolation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecordSPCViolationService) this._Channel).GetDataPoints(this._UserProfile, recordSPCViolation, parameters, request, out result) : this.AddMethod((Method) new RecordSPCViolationMethod(recordSPCViolation, RecordSPCViolationMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) recordSPCViolation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((RecordSPCViolation) null, (RecordSPCViolation_Parameters) null, (RecordSPCViolation_Request) null, out RecordSPCViolation_Result _);
    }

    public ResultStatus GetDataPoints(RecordSPCViolation recordSPCViolation)
    {
      return this.GetDataPoints(recordSPCViolation, (RecordSPCViolation_Parameters) null, (RecordSPCViolation_Request) null, out RecordSPCViolation_Result _);
    }

    public ResultStatus GetDataPoints(
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      return this.GetDataPoints(recordSPCViolation, (RecordSPCViolation_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Parameters parameters,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      result = (RecordSPCViolation_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) recordSPCViolation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecordSPCViolationService) this._Channel).GetWIPMsgs(this._UserProfile, recordSPCViolation, parameters, request, out result) : this.AddMethod((Method) new RecordSPCViolationMethod(recordSPCViolation, RecordSPCViolationMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) recordSPCViolation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RecordSPCViolation) null, (RecordSPCViolation_Parameters) null, (RecordSPCViolation_Request) null, out RecordSPCViolation_Result _);
    }

    public ResultStatus GetWIPMsgs(RecordSPCViolation recordSPCViolation)
    {
      return this.GetWIPMsgs(recordSPCViolation, (RecordSPCViolation_Parameters) null, (RecordSPCViolation_Request) null, out RecordSPCViolation_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      return this.GetWIPMsgs(recordSPCViolation, (RecordSPCViolation_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Parameters parameters,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      result = (RecordSPCViolation_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) recordSPCViolation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecordSPCViolationService) this._Channel).Load(this._UserProfile, recordSPCViolation, parameters, request, out result) : this.AddMethod((Method) new RecordSPCViolationMethod(recordSPCViolation, RecordSPCViolationMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) recordSPCViolation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RecordSPCViolation) null, (RecordSPCViolation_Parameters) null, (RecordSPCViolation_Request) null, out RecordSPCViolation_Result _);
    }

    public ResultStatus Load(RecordSPCViolation recordSPCViolation)
    {
      return this.Load(recordSPCViolation, (RecordSPCViolation_Parameters) null, (RecordSPCViolation_Request) null, out RecordSPCViolation_Result _);
    }

    public ResultStatus Load(
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      return this.Load(recordSPCViolation, (RecordSPCViolation_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_LoadESigDetails_Parameters parameters,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      result = (RecordSPCViolation_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) recordSPCViolation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecordSPCViolationService) this._Channel).LoadESigDetails(this._UserProfile, recordSPCViolation, parameters, request, out result) : this.AddMethod((Method) new RecordSPCViolationMethod(recordSPCViolation, RecordSPCViolationMethods.LoadESigDetails, (RecordSPCViolation_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) recordSPCViolation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RecordSPCViolation) null, (RecordSPCViolation_LoadESigDetails_Parameters) null, (RecordSPCViolation_Request) null, out RecordSPCViolation_Result _);
    }

    public ResultStatus LoadESigDetails(RecordSPCViolation recordSPCViolation)
    {
      return this.LoadESigDetails(recordSPCViolation, (RecordSPCViolation_LoadESigDetails_Parameters) null, (RecordSPCViolation_Request) null, out RecordSPCViolation_Result _);
    }

    public ResultStatus LoadESigDetails(
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      return this.LoadESigDetails(recordSPCViolation, (RecordSPCViolation_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Parameters parameters,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      result = (RecordSPCViolation_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) recordSPCViolation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecordSPCViolationService) this._Channel).ProcessComputation(this._UserProfile, recordSPCViolation, parameters, request, out result) : this.AddMethod((Method) new RecordSPCViolationMethod(recordSPCViolation, RecordSPCViolationMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) recordSPCViolation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((RecordSPCViolation) null, (RecordSPCViolation_Parameters) null, (RecordSPCViolation_Request) null, out RecordSPCViolation_Result _);
    }

    public ResultStatus ProcessComputation(RecordSPCViolation recordSPCViolation)
    {
      return this.ProcessComputation(recordSPCViolation, (RecordSPCViolation_Parameters) null, (RecordSPCViolation_Request) null, out RecordSPCViolation_Result _);
    }

    public ResultStatus ProcessComputation(
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      return this.ProcessComputation(recordSPCViolation, (RecordSPCViolation_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Parameters parameters,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      result = (RecordSPCViolation_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) recordSPCViolation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecordSPCViolationService) this._Channel).ResolveParametricData(this._UserProfile, recordSPCViolation, parameters, request, out result) : this.AddMethod((Method) new RecordSPCViolationMethod(recordSPCViolation, RecordSPCViolationMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) recordSPCViolation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((RecordSPCViolation) null, (RecordSPCViolation_Parameters) null, (RecordSPCViolation_Request) null, out RecordSPCViolation_Result _);
    }

    public ResultStatus ResolveParametricData(RecordSPCViolation recordSPCViolation)
    {
      return this.ResolveParametricData(recordSPCViolation, (RecordSPCViolation_Parameters) null, (RecordSPCViolation_Request) null, out RecordSPCViolation_Result _);
    }

    public ResultStatus ResolveParametricData(
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      return this.ResolveParametricData(recordSPCViolation, (RecordSPCViolation_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject recordSPCViolation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecordSPCViolation_Result result1;
        ResultStatus parametricData = this.CreateParametricData((RecordSPCViolation) recordSPCViolation, (RecordSPCViolation_Parameters) parameters, (RecordSPCViolation_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject recordSPCViolation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecordSPCViolation_Result result1;
        ResultStatus actions = this.GetActions((RecordSPCViolation) recordSPCViolation, (RecordSPCViolation_Parameters) parameters, (RecordSPCViolation_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject recordSPCViolation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecordSPCViolation_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((RecordSPCViolation) recordSPCViolation, (RecordSPCViolation_Parameters) parameters, (RecordSPCViolation_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject recordSPCViolation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecordSPCViolation_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RecordSPCViolation) recordSPCViolation, (RecordSPCViolation_LoadESigDetails_Parameters) parameters, (RecordSPCViolation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject recordSPCViolation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecordSPCViolation_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((RecordSPCViolation) recordSPCViolation, (RecordSPCViolation_Parameters) parameters, (RecordSPCViolation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject recordSPCViolation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecordSPCViolation_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((RecordSPCViolation) recordSPCViolation, (RecordSPCViolation_Parameters) parameters, (RecordSPCViolation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject recordSPCViolation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecordSPCViolation_Result result1;
        ResultStatus resultStatus = this.Load((RecordSPCViolation) recordSPCViolation, (RecordSPCViolation_Parameters) parameters, (RecordSPCViolation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject recordSPCViolation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecordSPCViolation_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RecordSPCViolation) recordSPCViolation, (RecordSPCViolation_Parameters) parameters, (RecordSPCViolation_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      result = (RecordSPCViolation_Result) null;
      try
      {
        RecordSPCViolationMethod[] methods = new RecordSPCViolationMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRecordSPCViolationService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RecordSPCViolation_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RecordSPCViolation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RecordSPCViolation cdo,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      result = (RecordSPCViolation_Result) null;
      try
      {
        return ((IRecordSPCViolationService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RecordSPCViolation_Result result1;
        ResultStatus environment = this.GetEnvironment((RecordSPCViolation) cdo, (RecordSPCViolation_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      return this.GetEnvironment((RecordSPCViolation) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RecordSPCViolation cdo,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      result = (RecordSPCViolation_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecordSPCViolationService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RecordSPCViolationMethod(cdo, RecordSPCViolationMethods.ExecuteTransaction, (RecordSPCViolation_Parameters) null));
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
        RecordSPCViolation_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RecordSPCViolation) cdo, (RecordSPCViolation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RecordSPCViolation cdo)
    {
      return this.ExecuteTransaction(cdo, (RecordSPCViolation_Request) null, out RecordSPCViolation_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result)
    {
      return this.ExecuteTransaction((RecordSPCViolation) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RecordSPCViolation cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RecordSPCViolationMethod(cdo, RecordSPCViolationMethods.AddDataTransaction, (RecordSPCViolation_Parameters) null));
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
        return this.AddDataTransaction((RecordSPCViolation) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
