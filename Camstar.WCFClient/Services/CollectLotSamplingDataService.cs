// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CollectLotSamplingDataService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CollectLotSamplingDataService : CollectSamplingDataBase
  {
    public CollectLotSamplingDataService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICollectLotSamplingDataService), userProfile);
    }

    public ResultStatus CreateParametricData(
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Parameters parameters,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      result = (CollectLotSamplingData_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) collectLotSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectLotSamplingDataService) this._Channel).CreateParametricData(this._UserProfile, collectLotSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectLotSamplingDataMethod(collectLotSamplingData, CollectLotSamplingDataMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) collectLotSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CollectLotSamplingData) null, (CollectLotSamplingData_Parameters) null, (CollectLotSamplingData_Request) null, out CollectLotSamplingData_Result _);
    }

    public ResultStatus CreateParametricData(
      CollectLotSamplingData collectLotSamplingData)
    {
      return this.CreateParametricData(collectLotSamplingData, (CollectLotSamplingData_Parameters) null, (CollectLotSamplingData_Request) null, out CollectLotSamplingData_Result _);
    }

    public ResultStatus CreateParametricData(
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      return this.CreateParametricData(collectLotSamplingData, (CollectLotSamplingData_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Parameters parameters,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      result = (CollectLotSamplingData_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) collectLotSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectLotSamplingDataService) this._Channel).GetActions(this._UserProfile, collectLotSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectLotSamplingDataMethod(collectLotSamplingData, CollectLotSamplingDataMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) collectLotSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CollectLotSamplingData) null, (CollectLotSamplingData_Parameters) null, (CollectLotSamplingData_Request) null, out CollectLotSamplingData_Result _);
    }

    public ResultStatus GetActions(CollectLotSamplingData collectLotSamplingData)
    {
      return this.GetActions(collectLotSamplingData, (CollectLotSamplingData_Parameters) null, (CollectLotSamplingData_Request) null, out CollectLotSamplingData_Result _);
    }

    public ResultStatus GetActions(
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      return this.GetActions(collectLotSamplingData, (CollectLotSamplingData_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Parameters parameters,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      result = (CollectLotSamplingData_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) collectLotSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectLotSamplingDataService) this._Channel).GetDataPoints(this._UserProfile, collectLotSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectLotSamplingDataMethod(collectLotSamplingData, CollectLotSamplingDataMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) collectLotSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CollectLotSamplingData) null, (CollectLotSamplingData_Parameters) null, (CollectLotSamplingData_Request) null, out CollectLotSamplingData_Result _);
    }

    public ResultStatus GetDataPoints(CollectLotSamplingData collectLotSamplingData)
    {
      return this.GetDataPoints(collectLotSamplingData, (CollectLotSamplingData_Parameters) null, (CollectLotSamplingData_Request) null, out CollectLotSamplingData_Result _);
    }

    public ResultStatus GetDataPoints(
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      return this.GetDataPoints(collectLotSamplingData, (CollectLotSamplingData_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Parameters parameters,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      result = (CollectLotSamplingData_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) collectLotSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectLotSamplingDataService) this._Channel).GetWIPMsgs(this._UserProfile, collectLotSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectLotSamplingDataMethod(collectLotSamplingData, CollectLotSamplingDataMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) collectLotSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CollectLotSamplingData) null, (CollectLotSamplingData_Parameters) null, (CollectLotSamplingData_Request) null, out CollectLotSamplingData_Result _);
    }

    public ResultStatus GetWIPMsgs(CollectLotSamplingData collectLotSamplingData)
    {
      return this.GetWIPMsgs(collectLotSamplingData, (CollectLotSamplingData_Parameters) null, (CollectLotSamplingData_Request) null, out CollectLotSamplingData_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      return this.GetWIPMsgs(collectLotSamplingData, (CollectLotSamplingData_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Parameters parameters,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      result = (CollectLotSamplingData_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) collectLotSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectLotSamplingDataService) this._Channel).Load(this._UserProfile, collectLotSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectLotSamplingDataMethod(collectLotSamplingData, CollectLotSamplingDataMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) collectLotSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CollectLotSamplingData) null, (CollectLotSamplingData_Parameters) null, (CollectLotSamplingData_Request) null, out CollectLotSamplingData_Result _);
    }

    public ResultStatus Load(CollectLotSamplingData collectLotSamplingData)
    {
      return this.Load(collectLotSamplingData, (CollectLotSamplingData_Parameters) null, (CollectLotSamplingData_Request) null, out CollectLotSamplingData_Result _);
    }

    public ResultStatus Load(
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      return this.Load(collectLotSamplingData, (CollectLotSamplingData_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_LoadESigDetails_Parameters parameters,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      result = (CollectLotSamplingData_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) collectLotSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectLotSamplingDataService) this._Channel).LoadESigDetails(this._UserProfile, collectLotSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectLotSamplingDataMethod(collectLotSamplingData, CollectLotSamplingDataMethods.LoadESigDetails, (CollectLotSamplingData_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) collectLotSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CollectLotSamplingData) null, (CollectLotSamplingData_LoadESigDetails_Parameters) null, (CollectLotSamplingData_Request) null, out CollectLotSamplingData_Result _);
    }

    public ResultStatus LoadESigDetails(CollectLotSamplingData collectLotSamplingData)
    {
      return this.LoadESigDetails(collectLotSamplingData, (CollectLotSamplingData_LoadESigDetails_Parameters) null, (CollectLotSamplingData_Request) null, out CollectLotSamplingData_Result _);
    }

    public ResultStatus LoadESigDetails(
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      return this.LoadESigDetails(collectLotSamplingData, (CollectLotSamplingData_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Parameters parameters,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      result = (CollectLotSamplingData_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) collectLotSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectLotSamplingDataService) this._Channel).ProcessComputation(this._UserProfile, collectLotSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectLotSamplingDataMethod(collectLotSamplingData, CollectLotSamplingDataMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) collectLotSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CollectLotSamplingData) null, (CollectLotSamplingData_Parameters) null, (CollectLotSamplingData_Request) null, out CollectLotSamplingData_Result _);
    }

    public ResultStatus ProcessComputation(CollectLotSamplingData collectLotSamplingData)
    {
      return this.ProcessComputation(collectLotSamplingData, (CollectLotSamplingData_Parameters) null, (CollectLotSamplingData_Request) null, out CollectLotSamplingData_Result _);
    }

    public ResultStatus ProcessComputation(
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      return this.ProcessComputation(collectLotSamplingData, (CollectLotSamplingData_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Parameters parameters,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      result = (CollectLotSamplingData_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) collectLotSamplingData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectLotSamplingDataService) this._Channel).ResolveParametricData(this._UserProfile, collectLotSamplingData, parameters, request, out result) : this.AddMethod((Method) new CollectLotSamplingDataMethod(collectLotSamplingData, CollectLotSamplingDataMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) collectLotSamplingData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CollectLotSamplingData) null, (CollectLotSamplingData_Parameters) null, (CollectLotSamplingData_Request) null, out CollectLotSamplingData_Result _);
    }

    public ResultStatus ResolveParametricData(
      CollectLotSamplingData collectLotSamplingData)
    {
      return this.ResolveParametricData(collectLotSamplingData, (CollectLotSamplingData_Parameters) null, (CollectLotSamplingData_Request) null, out CollectLotSamplingData_Result _);
    }

    public ResultStatus ResolveParametricData(
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      return this.ResolveParametricData(collectLotSamplingData, (CollectLotSamplingData_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject collectLotSamplingData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectLotSamplingData_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CollectLotSamplingData) collectLotSamplingData, (CollectLotSamplingData_Parameters) parameters, (CollectLotSamplingData_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject collectLotSamplingData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectLotSamplingData_Result result1;
        ResultStatus actions = this.GetActions((CollectLotSamplingData) collectLotSamplingData, (CollectLotSamplingData_Parameters) parameters, (CollectLotSamplingData_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject collectLotSamplingData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectLotSamplingData_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CollectLotSamplingData) collectLotSamplingData, (CollectLotSamplingData_Parameters) parameters, (CollectLotSamplingData_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject collectLotSamplingData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectLotSamplingData_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CollectLotSamplingData) collectLotSamplingData, (CollectLotSamplingData_LoadESigDetails_Parameters) parameters, (CollectLotSamplingData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject collectLotSamplingData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectLotSamplingData_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CollectLotSamplingData) collectLotSamplingData, (CollectLotSamplingData_Parameters) parameters, (CollectLotSamplingData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject collectLotSamplingData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectLotSamplingData_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CollectLotSamplingData) collectLotSamplingData, (CollectLotSamplingData_Parameters) parameters, (CollectLotSamplingData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject collectLotSamplingData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectLotSamplingData_Result result1;
        ResultStatus resultStatus = this.Load((CollectLotSamplingData) collectLotSamplingData, (CollectLotSamplingData_Parameters) parameters, (CollectLotSamplingData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject collectLotSamplingData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectLotSamplingData_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CollectLotSamplingData) collectLotSamplingData, (CollectLotSamplingData_Parameters) parameters, (CollectLotSamplingData_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      result = (CollectLotSamplingData_Result) null;
      try
      {
        CollectLotSamplingDataMethod[] methods = new CollectLotSamplingDataMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICollectLotSamplingDataService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CollectLotSamplingData_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CollectLotSamplingData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CollectLotSamplingData cdo,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      result = (CollectLotSamplingData_Result) null;
      try
      {
        return ((ICollectLotSamplingDataService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CollectLotSamplingData_Result result1;
        ResultStatus environment = this.GetEnvironment((CollectLotSamplingData) cdo, (CollectLotSamplingData_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      return this.GetEnvironment((CollectLotSamplingData) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CollectLotSamplingData cdo,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      result = (CollectLotSamplingData_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectLotSamplingDataService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CollectLotSamplingDataMethod(cdo, CollectLotSamplingDataMethods.ExecuteTransaction, (CollectLotSamplingData_Parameters) null));
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
        CollectLotSamplingData_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CollectLotSamplingData) cdo, (CollectLotSamplingData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CollectLotSamplingData cdo)
    {
      return this.ExecuteTransaction(cdo, (CollectLotSamplingData_Request) null, out CollectLotSamplingData_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result)
    {
      return this.ExecuteTransaction((CollectLotSamplingData) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CollectLotSamplingData cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CollectLotSamplingDataMethod(cdo, CollectLotSamplingDataMethods.AddDataTransaction, (CollectLotSamplingData_Parameters) null));
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
        return this.AddDataTransaction((CollectLotSamplingData) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
