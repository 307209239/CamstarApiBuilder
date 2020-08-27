// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SamplingLotTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SamplingLotTxnService : ShopFloorBase
  {
    public SamplingLotTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISamplingLotTxnService), userProfile);
    }

    public ResultStatus CreateParametricData(
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Parameters parameters,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      result = (SamplingLotTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) samplingLotTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingLotTxnService) this._Channel).CreateParametricData(this._UserProfile, samplingLotTxn, parameters, request, out result) : this.AddMethod((Method) new SamplingLotTxnMethod(samplingLotTxn, SamplingLotTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) samplingLotTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((SamplingLotTxn) null, (SamplingLotTxn_Parameters) null, (SamplingLotTxn_Request) null, out SamplingLotTxn_Result _);
    }

    public ResultStatus CreateParametricData(SamplingLotTxn samplingLotTxn)
    {
      return this.CreateParametricData(samplingLotTxn, (SamplingLotTxn_Parameters) null, (SamplingLotTxn_Request) null, out SamplingLotTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      return this.CreateParametricData(samplingLotTxn, (SamplingLotTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Parameters parameters,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      result = (SamplingLotTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) samplingLotTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingLotTxnService) this._Channel).GetActions(this._UserProfile, samplingLotTxn, parameters, request, out result) : this.AddMethod((Method) new SamplingLotTxnMethod(samplingLotTxn, SamplingLotTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) samplingLotTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((SamplingLotTxn) null, (SamplingLotTxn_Parameters) null, (SamplingLotTxn_Request) null, out SamplingLotTxn_Result _);
    }

    public ResultStatus GetActions(SamplingLotTxn samplingLotTxn)
    {
      return this.GetActions(samplingLotTxn, (SamplingLotTxn_Parameters) null, (SamplingLotTxn_Request) null, out SamplingLotTxn_Result _);
    }

    public ResultStatus GetActions(
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      return this.GetActions(samplingLotTxn, (SamplingLotTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Parameters parameters,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      result = (SamplingLotTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) samplingLotTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingLotTxnService) this._Channel).GetDataPoints(this._UserProfile, samplingLotTxn, parameters, request, out result) : this.AddMethod((Method) new SamplingLotTxnMethod(samplingLotTxn, SamplingLotTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) samplingLotTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((SamplingLotTxn) null, (SamplingLotTxn_Parameters) null, (SamplingLotTxn_Request) null, out SamplingLotTxn_Result _);
    }

    public ResultStatus GetDataPoints(SamplingLotTxn samplingLotTxn)
    {
      return this.GetDataPoints(samplingLotTxn, (SamplingLotTxn_Parameters) null, (SamplingLotTxn_Request) null, out SamplingLotTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      return this.GetDataPoints(samplingLotTxn, (SamplingLotTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Parameters parameters,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      result = (SamplingLotTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) samplingLotTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingLotTxnService) this._Channel).GetWIPMsgs(this._UserProfile, samplingLotTxn, parameters, request, out result) : this.AddMethod((Method) new SamplingLotTxnMethod(samplingLotTxn, SamplingLotTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) samplingLotTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SamplingLotTxn) null, (SamplingLotTxn_Parameters) null, (SamplingLotTxn_Request) null, out SamplingLotTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(SamplingLotTxn samplingLotTxn)
    {
      return this.GetWIPMsgs(samplingLotTxn, (SamplingLotTxn_Parameters) null, (SamplingLotTxn_Request) null, out SamplingLotTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      return this.GetWIPMsgs(samplingLotTxn, (SamplingLotTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Parameters parameters,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      result = (SamplingLotTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) samplingLotTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingLotTxnService) this._Channel).Load(this._UserProfile, samplingLotTxn, parameters, request, out result) : this.AddMethod((Method) new SamplingLotTxnMethod(samplingLotTxn, SamplingLotTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) samplingLotTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SamplingLotTxn) null, (SamplingLotTxn_Parameters) null, (SamplingLotTxn_Request) null, out SamplingLotTxn_Result _);
    }

    public ResultStatus Load(SamplingLotTxn samplingLotTxn)
    {
      return this.Load(samplingLotTxn, (SamplingLotTxn_Parameters) null, (SamplingLotTxn_Request) null, out SamplingLotTxn_Result _);
    }

    public ResultStatus Load(
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      return this.Load(samplingLotTxn, (SamplingLotTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_LoadESigDetails_Parameters parameters,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      result = (SamplingLotTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) samplingLotTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingLotTxnService) this._Channel).LoadESigDetails(this._UserProfile, samplingLotTxn, parameters, request, out result) : this.AddMethod((Method) new SamplingLotTxnMethod(samplingLotTxn, SamplingLotTxnMethods.LoadESigDetails, (SamplingLotTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) samplingLotTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SamplingLotTxn) null, (SamplingLotTxn_LoadESigDetails_Parameters) null, (SamplingLotTxn_Request) null, out SamplingLotTxn_Result _);
    }

    public ResultStatus LoadESigDetails(SamplingLotTxn samplingLotTxn)
    {
      return this.LoadESigDetails(samplingLotTxn, (SamplingLotTxn_LoadESigDetails_Parameters) null, (SamplingLotTxn_Request) null, out SamplingLotTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      return this.LoadESigDetails(samplingLotTxn, (SamplingLotTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Parameters parameters,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      result = (SamplingLotTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) samplingLotTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingLotTxnService) this._Channel).ProcessComputation(this._UserProfile, samplingLotTxn, parameters, request, out result) : this.AddMethod((Method) new SamplingLotTxnMethod(samplingLotTxn, SamplingLotTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) samplingLotTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((SamplingLotTxn) null, (SamplingLotTxn_Parameters) null, (SamplingLotTxn_Request) null, out SamplingLotTxn_Result _);
    }

    public ResultStatus ProcessComputation(SamplingLotTxn samplingLotTxn)
    {
      return this.ProcessComputation(samplingLotTxn, (SamplingLotTxn_Parameters) null, (SamplingLotTxn_Request) null, out SamplingLotTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      return this.ProcessComputation(samplingLotTxn, (SamplingLotTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Parameters parameters,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      result = (SamplingLotTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) samplingLotTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingLotTxnService) this._Channel).ResolveParametricData(this._UserProfile, samplingLotTxn, parameters, request, out result) : this.AddMethod((Method) new SamplingLotTxnMethod(samplingLotTxn, SamplingLotTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) samplingLotTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((SamplingLotTxn) null, (SamplingLotTxn_Parameters) null, (SamplingLotTxn_Request) null, out SamplingLotTxn_Result _);
    }

    public ResultStatus ResolveParametricData(SamplingLotTxn samplingLotTxn)
    {
      return this.ResolveParametricData(samplingLotTxn, (SamplingLotTxn_Parameters) null, (SamplingLotTxn_Request) null, out SamplingLotTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      return this.ResolveParametricData(samplingLotTxn, (SamplingLotTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject samplingLotTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingLotTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((SamplingLotTxn) samplingLotTxn, (SamplingLotTxn_Parameters) parameters, (SamplingLotTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject samplingLotTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingLotTxn_Result result1;
        ResultStatus actions = this.GetActions((SamplingLotTxn) samplingLotTxn, (SamplingLotTxn_Parameters) parameters, (SamplingLotTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject samplingLotTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingLotTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((SamplingLotTxn) samplingLotTxn, (SamplingLotTxn_Parameters) parameters, (SamplingLotTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject samplingLotTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingLotTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SamplingLotTxn) samplingLotTxn, (SamplingLotTxn_LoadESigDetails_Parameters) parameters, (SamplingLotTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject samplingLotTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingLotTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((SamplingLotTxn) samplingLotTxn, (SamplingLotTxn_Parameters) parameters, (SamplingLotTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject samplingLotTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingLotTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((SamplingLotTxn) samplingLotTxn, (SamplingLotTxn_Parameters) parameters, (SamplingLotTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject samplingLotTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingLotTxn_Result result1;
        ResultStatus resultStatus = this.Load((SamplingLotTxn) samplingLotTxn, (SamplingLotTxn_Parameters) parameters, (SamplingLotTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject samplingLotTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingLotTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SamplingLotTxn) samplingLotTxn, (SamplingLotTxn_Parameters) parameters, (SamplingLotTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      result = (SamplingLotTxn_Result) null;
      try
      {
        SamplingLotTxnMethod[] methods = new SamplingLotTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISamplingLotTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SamplingLotTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SamplingLotTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SamplingLotTxn cdo,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      result = (SamplingLotTxn_Result) null;
      try
      {
        return ((ISamplingLotTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SamplingLotTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((SamplingLotTxn) cdo, (SamplingLotTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      return this.GetEnvironment((SamplingLotTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SamplingLotTxn cdo,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      result = (SamplingLotTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingLotTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SamplingLotTxnMethod(cdo, SamplingLotTxnMethods.ExecuteTransaction, (SamplingLotTxn_Parameters) null));
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
        SamplingLotTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SamplingLotTxn) cdo, (SamplingLotTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SamplingLotTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (SamplingLotTxn_Request) null, out SamplingLotTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result)
    {
      return this.ExecuteTransaction((SamplingLotTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SamplingLotTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SamplingLotTxnMethod(cdo, SamplingLotTxnMethods.AddDataTransaction, (SamplingLotTxn_Parameters) null));
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
        return this.AddDataTransaction((SamplingLotTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
