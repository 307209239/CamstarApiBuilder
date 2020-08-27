// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CollectResourceDataService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CollectResourceDataService : ResourceTxnBase
  {
    public CollectResourceDataService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICollectResourceDataService), userProfile);
    }

    public ResultStatus CreateParametricData(
      CollectResourceData collectResourceData,
      CollectResourceData_Parameters parameters,
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      result = (CollectResourceData_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) collectResourceData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectResourceDataService) this._Channel).CreateParametricData(this._UserProfile, collectResourceData, parameters, request, out result) : this.AddMethod((Method) new CollectResourceDataMethod(collectResourceData, CollectResourceDataMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) collectResourceData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CollectResourceData) null, (CollectResourceData_Parameters) null, (CollectResourceData_Request) null, out CollectResourceData_Result _);
    }

    public ResultStatus CreateParametricData(CollectResourceData collectResourceData)
    {
      return this.CreateParametricData(collectResourceData, (CollectResourceData_Parameters) null, (CollectResourceData_Request) null, out CollectResourceData_Result _);
    }

    public ResultStatus CreateParametricData(
      CollectResourceData collectResourceData,
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      return this.CreateParametricData(collectResourceData, (CollectResourceData_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CollectResourceData collectResourceData,
      CollectResourceData_Parameters parameters,
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      result = (CollectResourceData_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) collectResourceData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectResourceDataService) this._Channel).GetActions(this._UserProfile, collectResourceData, parameters, request, out result) : this.AddMethod((Method) new CollectResourceDataMethod(collectResourceData, CollectResourceDataMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) collectResourceData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CollectResourceData) null, (CollectResourceData_Parameters) null, (CollectResourceData_Request) null, out CollectResourceData_Result _);
    }

    public ResultStatus GetActions(CollectResourceData collectResourceData)
    {
      return this.GetActions(collectResourceData, (CollectResourceData_Parameters) null, (CollectResourceData_Request) null, out CollectResourceData_Result _);
    }

    public ResultStatus GetActions(
      CollectResourceData collectResourceData,
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      return this.GetActions(collectResourceData, (CollectResourceData_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CollectResourceData collectResourceData,
      CollectResourceData_Parameters parameters,
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      result = (CollectResourceData_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) collectResourceData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectResourceDataService) this._Channel).GetDataPoints(this._UserProfile, collectResourceData, parameters, request, out result) : this.AddMethod((Method) new CollectResourceDataMethod(collectResourceData, CollectResourceDataMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) collectResourceData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CollectResourceData) null, (CollectResourceData_Parameters) null, (CollectResourceData_Request) null, out CollectResourceData_Result _);
    }

    public ResultStatus GetDataPoints(CollectResourceData collectResourceData)
    {
      return this.GetDataPoints(collectResourceData, (CollectResourceData_Parameters) null, (CollectResourceData_Request) null, out CollectResourceData_Result _);
    }

    public ResultStatus GetDataPoints(
      CollectResourceData collectResourceData,
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      return this.GetDataPoints(collectResourceData, (CollectResourceData_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CollectResourceData collectResourceData,
      CollectResourceData_Parameters parameters,
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      result = (CollectResourceData_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) collectResourceData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectResourceDataService) this._Channel).GetWIPMsgs(this._UserProfile, collectResourceData, parameters, request, out result) : this.AddMethod((Method) new CollectResourceDataMethod(collectResourceData, CollectResourceDataMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) collectResourceData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CollectResourceData) null, (CollectResourceData_Parameters) null, (CollectResourceData_Request) null, out CollectResourceData_Result _);
    }

    public ResultStatus GetWIPMsgs(CollectResourceData collectResourceData)
    {
      return this.GetWIPMsgs(collectResourceData, (CollectResourceData_Parameters) null, (CollectResourceData_Request) null, out CollectResourceData_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CollectResourceData collectResourceData,
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      return this.GetWIPMsgs(collectResourceData, (CollectResourceData_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CollectResourceData collectResourceData,
      CollectResourceData_Parameters parameters,
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      result = (CollectResourceData_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) collectResourceData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectResourceDataService) this._Channel).Load(this._UserProfile, collectResourceData, parameters, request, out result) : this.AddMethod((Method) new CollectResourceDataMethod(collectResourceData, CollectResourceDataMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) collectResourceData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CollectResourceData) null, (CollectResourceData_Parameters) null, (CollectResourceData_Request) null, out CollectResourceData_Result _);
    }

    public ResultStatus Load(CollectResourceData collectResourceData)
    {
      return this.Load(collectResourceData, (CollectResourceData_Parameters) null, (CollectResourceData_Request) null, out CollectResourceData_Result _);
    }

    public ResultStatus Load(
      CollectResourceData collectResourceData,
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      return this.Load(collectResourceData, (CollectResourceData_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CollectResourceData collectResourceData,
      CollectResourceData_LoadESigDetails_Parameters parameters,
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      result = (CollectResourceData_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) collectResourceData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectResourceDataService) this._Channel).LoadESigDetails(this._UserProfile, collectResourceData, parameters, request, out result) : this.AddMethod((Method) new CollectResourceDataMethod(collectResourceData, CollectResourceDataMethods.LoadESigDetails, (CollectResourceData_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) collectResourceData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CollectResourceData) null, (CollectResourceData_LoadESigDetails_Parameters) null, (CollectResourceData_Request) null, out CollectResourceData_Result _);
    }

    public ResultStatus LoadESigDetails(CollectResourceData collectResourceData)
    {
      return this.LoadESigDetails(collectResourceData, (CollectResourceData_LoadESigDetails_Parameters) null, (CollectResourceData_Request) null, out CollectResourceData_Result _);
    }

    public ResultStatus LoadESigDetails(
      CollectResourceData collectResourceData,
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      return this.LoadESigDetails(collectResourceData, (CollectResourceData_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CollectResourceData collectResourceData,
      CollectResourceData_Parameters parameters,
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      result = (CollectResourceData_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) collectResourceData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectResourceDataService) this._Channel).ProcessComputation(this._UserProfile, collectResourceData, parameters, request, out result) : this.AddMethod((Method) new CollectResourceDataMethod(collectResourceData, CollectResourceDataMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) collectResourceData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CollectResourceData) null, (CollectResourceData_Parameters) null, (CollectResourceData_Request) null, out CollectResourceData_Result _);
    }

    public ResultStatus ProcessComputation(CollectResourceData collectResourceData)
    {
      return this.ProcessComputation(collectResourceData, (CollectResourceData_Parameters) null, (CollectResourceData_Request) null, out CollectResourceData_Result _);
    }

    public ResultStatus ProcessComputation(
      CollectResourceData collectResourceData,
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      return this.ProcessComputation(collectResourceData, (CollectResourceData_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CollectResourceData collectResourceData,
      CollectResourceData_Parameters parameters,
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      result = (CollectResourceData_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) collectResourceData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectResourceDataService) this._Channel).ResolveParametricData(this._UserProfile, collectResourceData, parameters, request, out result) : this.AddMethod((Method) new CollectResourceDataMethod(collectResourceData, CollectResourceDataMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) collectResourceData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CollectResourceData) null, (CollectResourceData_Parameters) null, (CollectResourceData_Request) null, out CollectResourceData_Result _);
    }

    public ResultStatus ResolveParametricData(CollectResourceData collectResourceData)
    {
      return this.ResolveParametricData(collectResourceData, (CollectResourceData_Parameters) null, (CollectResourceData_Request) null, out CollectResourceData_Result _);
    }

    public ResultStatus ResolveParametricData(
      CollectResourceData collectResourceData,
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      return this.ResolveParametricData(collectResourceData, (CollectResourceData_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject collectResourceData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectResourceData_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CollectResourceData) collectResourceData, (CollectResourceData_Parameters) parameters, (CollectResourceData_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject collectResourceData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectResourceData_Result result1;
        ResultStatus actions = this.GetActions((CollectResourceData) collectResourceData, (CollectResourceData_Parameters) parameters, (CollectResourceData_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject collectResourceData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectResourceData_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CollectResourceData) collectResourceData, (CollectResourceData_Parameters) parameters, (CollectResourceData_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject collectResourceData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectResourceData_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CollectResourceData) collectResourceData, (CollectResourceData_LoadESigDetails_Parameters) parameters, (CollectResourceData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject collectResourceData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectResourceData_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CollectResourceData) collectResourceData, (CollectResourceData_Parameters) parameters, (CollectResourceData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject collectResourceData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectResourceData_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CollectResourceData) collectResourceData, (CollectResourceData_Parameters) parameters, (CollectResourceData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject collectResourceData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectResourceData_Result result1;
        ResultStatus resultStatus = this.Load((CollectResourceData) collectResourceData, (CollectResourceData_Parameters) parameters, (CollectResourceData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject collectResourceData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectResourceData_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CollectResourceData) collectResourceData, (CollectResourceData_Parameters) parameters, (CollectResourceData_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      result = (CollectResourceData_Result) null;
      try
      {
        CollectResourceDataMethod[] methods = new CollectResourceDataMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICollectResourceDataService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CollectResourceData_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CollectResourceData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CollectResourceData cdo,
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      result = (CollectResourceData_Result) null;
      try
      {
        return ((ICollectResourceDataService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CollectResourceData_Result result1;
        ResultStatus environment = this.GetEnvironment((CollectResourceData) cdo, (CollectResourceData_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      return this.GetEnvironment((CollectResourceData) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CollectResourceData cdo,
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      result = (CollectResourceData_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectResourceDataService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CollectResourceDataMethod(cdo, CollectResourceDataMethods.ExecuteTransaction, (CollectResourceData_Parameters) null));
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
        CollectResourceData_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CollectResourceData) cdo, (CollectResourceData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CollectResourceData cdo)
    {
      return this.ExecuteTransaction(cdo, (CollectResourceData_Request) null, out CollectResourceData_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CollectResourceData_Request request,
      out CollectResourceData_Result result)
    {
      return this.ExecuteTransaction((CollectResourceData) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CollectResourceData cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CollectResourceDataMethod(cdo, CollectResourceDataMethods.AddDataTransaction, (CollectResourceData_Parameters) null));
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
        return this.AddDataTransaction((CollectResourceData) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
