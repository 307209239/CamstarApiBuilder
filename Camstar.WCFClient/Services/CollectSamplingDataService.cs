// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CollectSamplingDataService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CollectSamplingDataService : ContainerTxnBase
  {
    public CollectSamplingDataService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICollectSamplingDataService), userProfile);
    }

    public ResultStatus CollectSampling_ChangeQty(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      result = (CollectSamplingData_Result) null;
      this.OnBeforeCall(nameof (CollectSampling_ChangeQty), (DCObject) collectSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectSamplingDataService) this._Channel).CollectSampling_ChangeQty(this._UserProfile, collectSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectSamplingDataMethod(collectSamplingData, CollectSamplingDataMethods.CollectSampling_ChangeQty, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CollectSampling_ChangeQty), res, (DCObject) collectSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CollectSampling_ChangeQty()
    {
      return this.CollectSampling_ChangeQty((CollectSamplingData) null, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus CollectSampling_ChangeQty(
      CollectSamplingData collectSamplingData)
    {
      return this.CollectSampling_ChangeQty(collectSamplingData, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus CollectSampling_ChangeQty(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      return this.CollectSampling_ChangeQty(collectSamplingData, (CollectSamplingData_Parameters) null, request, out result);
    }

    public ResultStatus CollectSampling_Execution(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      result = (CollectSamplingData_Result) null;
      this.OnBeforeCall(nameof (CollectSampling_Execution), (DCObject) collectSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectSamplingDataService) this._Channel).CollectSampling_Execution(this._UserProfile, collectSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectSamplingDataMethod(collectSamplingData, CollectSamplingDataMethods.CollectSampling_Execution, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CollectSampling_Execution), res, (DCObject) collectSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CollectSampling_Execution()
    {
      return this.CollectSampling_Execution((CollectSamplingData) null, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus CollectSampling_Execution(
      CollectSamplingData collectSamplingData)
    {
      return this.CollectSampling_Execution(collectSamplingData, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus CollectSampling_Execution(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      return this.CollectSampling_Execution(collectSamplingData, (CollectSamplingData_Parameters) null, request, out result);
    }

    public ResultStatus CollectSampling_ProductionEvent(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      result = (CollectSamplingData_Result) null;
      this.OnBeforeCall(nameof (CollectSampling_ProductionEvent), (DCObject) collectSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectSamplingDataService) this._Channel).CollectSampling_ProductionEvent(this._UserProfile, collectSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectSamplingDataMethod(collectSamplingData, CollectSamplingDataMethods.CollectSampling_ProductionEvent, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CollectSampling_ProductionEvent), res, (DCObject) collectSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CollectSampling_ProductionEvent()
    {
      return this.CollectSampling_ProductionEvent((CollectSamplingData) null, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus CollectSampling_ProductionEvent(
      CollectSamplingData collectSamplingData)
    {
      return this.CollectSampling_ProductionEvent(collectSamplingData, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus CollectSampling_ProductionEvent(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      return this.CollectSampling_ProductionEvent(collectSamplingData, (CollectSamplingData_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      result = (CollectSamplingData_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) collectSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectSamplingDataService) this._Channel).CreateParametricData(this._UserProfile, collectSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectSamplingDataMethod(collectSamplingData, CollectSamplingDataMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) collectSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CollectSamplingData) null, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus CreateParametricData(CollectSamplingData collectSamplingData)
    {
      return this.CreateParametricData(collectSamplingData, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus CreateParametricData(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      return this.CreateParametricData(collectSamplingData, (CollectSamplingData_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      result = (CollectSamplingData_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) collectSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectSamplingDataService) this._Channel).GetActions(this._UserProfile, collectSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectSamplingDataMethod(collectSamplingData, CollectSamplingDataMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) collectSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CollectSamplingData) null, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus GetActions(CollectSamplingData collectSamplingData)
    {
      return this.GetActions(collectSamplingData, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus GetActions(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      return this.GetActions(collectSamplingData, (CollectSamplingData_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      result = (CollectSamplingData_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) collectSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectSamplingDataService) this._Channel).GetDataPoints(this._UserProfile, collectSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectSamplingDataMethod(collectSamplingData, CollectSamplingDataMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) collectSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CollectSamplingData) null, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus GetDataPoints(CollectSamplingData collectSamplingData)
    {
      return this.GetDataPoints(collectSamplingData, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus GetDataPoints(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      return this.GetDataPoints(collectSamplingData, (CollectSamplingData_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      result = (CollectSamplingData_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) collectSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectSamplingDataService) this._Channel).GetWIPMsgs(this._UserProfile, collectSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectSamplingDataMethod(collectSamplingData, CollectSamplingDataMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) collectSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CollectSamplingData) null, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus GetWIPMsgs(CollectSamplingData collectSamplingData)
    {
      return this.GetWIPMsgs(collectSamplingData, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      return this.GetWIPMsgs(collectSamplingData, (CollectSamplingData_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      result = (CollectSamplingData_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) collectSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectSamplingDataService) this._Channel).Load(this._UserProfile, collectSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectSamplingDataMethod(collectSamplingData, CollectSamplingDataMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) collectSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CollectSamplingData) null, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus Load(CollectSamplingData collectSamplingData)
    {
      return this.Load(collectSamplingData, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus Load(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      return this.Load(collectSamplingData, (CollectSamplingData_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_LoadESigDetails_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      result = (CollectSamplingData_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) collectSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectSamplingDataService) this._Channel).LoadESigDetails(this._UserProfile, collectSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectSamplingDataMethod(collectSamplingData, CollectSamplingDataMethods.LoadESigDetails, (CollectSamplingData_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) collectSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CollectSamplingData) null, (CollectSamplingData_LoadESigDetails_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus LoadESigDetails(CollectSamplingData collectSamplingData)
    {
      return this.LoadESigDetails(collectSamplingData, (CollectSamplingData_LoadESigDetails_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus LoadESigDetails(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      return this.LoadESigDetails(collectSamplingData, (CollectSamplingData_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      result = (CollectSamplingData_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) collectSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectSamplingDataService) this._Channel).ProcessComputation(this._UserProfile, collectSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectSamplingDataMethod(collectSamplingData, CollectSamplingDataMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) collectSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CollectSamplingData) null, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus ProcessComputation(CollectSamplingData collectSamplingData)
    {
      return this.ProcessComputation(collectSamplingData, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus ProcessComputation(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      return this.ProcessComputation(collectSamplingData, (CollectSamplingData_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      result = (CollectSamplingData_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) collectSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectSamplingDataService) this._Channel).ResolveParametricData(this._UserProfile, collectSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectSamplingDataMethod(collectSamplingData, CollectSamplingDataMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) collectSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CollectSamplingData) null, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus ResolveParametricData(CollectSamplingData collectSamplingData)
    {
      return this.ResolveParametricData(collectSamplingData, (CollectSamplingData_Parameters) null, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus ResolveParametricData(
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      return this.ResolveParametricData(collectSamplingData, (CollectSamplingData_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject collectSamplingData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectSamplingData_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CollectSamplingData) collectSamplingData, (CollectSamplingData_Parameters) parameters, (CollectSamplingData_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject collectSamplingData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectSamplingData_Result result1;
        ResultStatus actions = this.GetActions((CollectSamplingData) collectSamplingData, (CollectSamplingData_Parameters) parameters, (CollectSamplingData_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject collectSamplingData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectSamplingData_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CollectSamplingData) collectSamplingData, (CollectSamplingData_Parameters) parameters, (CollectSamplingData_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject collectSamplingData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectSamplingData_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CollectSamplingData) collectSamplingData, (CollectSamplingData_LoadESigDetails_Parameters) parameters, (CollectSamplingData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject collectSamplingData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectSamplingData_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CollectSamplingData) collectSamplingData, (CollectSamplingData_Parameters) parameters, (CollectSamplingData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject collectSamplingData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectSamplingData_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CollectSamplingData) collectSamplingData, (CollectSamplingData_Parameters) parameters, (CollectSamplingData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject collectSamplingData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectSamplingData_Result result1;
        ResultStatus resultStatus = this.Load((CollectSamplingData) collectSamplingData, (CollectSamplingData_Parameters) parameters, (CollectSamplingData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject collectSamplingData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectSamplingData_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CollectSamplingData) collectSamplingData, (CollectSamplingData_Parameters) parameters, (CollectSamplingData_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      result = (CollectSamplingData_Result) null;
      try
      {
        CollectSamplingDataMethod[] methods = new CollectSamplingDataMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICollectSamplingDataService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CollectSamplingData_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CollectSamplingData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CollectSamplingData cdo,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      result = (CollectSamplingData_Result) null;
      try
      {
        return ((ICollectSamplingDataService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CollectSamplingData_Result result1;
        ResultStatus environment = this.GetEnvironment((CollectSamplingData) cdo, (CollectSamplingData_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      return this.GetEnvironment((CollectSamplingData) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CollectSamplingData cdo,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      result = (CollectSamplingData_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectSamplingDataService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CollectSamplingDataMethod(cdo, CollectSamplingDataMethods.ExecuteTransaction, (CollectSamplingData_Parameters) null));
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
        CollectSamplingData_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CollectSamplingData) cdo, (CollectSamplingData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CollectSamplingData cdo)
    {
      return this.ExecuteTransaction(cdo, (CollectSamplingData_Request) null, out CollectSamplingData_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result)
    {
      return this.ExecuteTransaction((CollectSamplingData) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CollectSamplingData cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CollectSamplingDataMethod(cdo, CollectSamplingDataMethods.AddDataTransaction, (CollectSamplingData_Parameters) null));
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
        return this.AddDataTransaction((CollectSamplingData) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
