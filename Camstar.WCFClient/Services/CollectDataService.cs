// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CollectDataService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CollectDataService : ContainerTxnBase
  {
    public CollectDataService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICollectDataService), userProfile);
    }

    public ResultStatus CreateParametricData(
      CollectData collectData,
      CollectData_Parameters parameters,
      CollectData_Request request,
      out CollectData_Result result)
    {
      result = (CollectData_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) collectData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataService) this._Channel).CreateParametricData(this._UserProfile, collectData, parameters, request, out result) : this.AddMethod((Method) new CollectDataMethod(collectData, CollectDataMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) collectData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CollectData) null, (CollectData_Parameters) null, (CollectData_Request) null, out CollectData_Result _);
    }

    public ResultStatus CreateParametricData(CollectData collectData)
    {
      return this.CreateParametricData(collectData, (CollectData_Parameters) null, (CollectData_Request) null, out CollectData_Result _);
    }

    public ResultStatus CreateParametricData(
      CollectData collectData,
      CollectData_Request request,
      out CollectData_Result result)
    {
      return this.CreateParametricData(collectData, (CollectData_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CollectData collectData,
      CollectData_Parameters parameters,
      CollectData_Request request,
      out CollectData_Result result)
    {
      result = (CollectData_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) collectData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataService) this._Channel).GetActions(this._UserProfile, collectData, parameters, request, out result) : this.AddMethod((Method) new CollectDataMethod(collectData, CollectDataMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) collectData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CollectData) null, (CollectData_Parameters) null, (CollectData_Request) null, out CollectData_Result _);
    }

    public ResultStatus GetActions(CollectData collectData)
    {
      return this.GetActions(collectData, (CollectData_Parameters) null, (CollectData_Request) null, out CollectData_Result _);
    }

    public ResultStatus GetActions(
      CollectData collectData,
      CollectData_Request request,
      out CollectData_Result result)
    {
      return this.GetActions(collectData, (CollectData_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CollectData collectData,
      CollectData_Parameters parameters,
      CollectData_Request request,
      out CollectData_Result result)
    {
      result = (CollectData_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) collectData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataService) this._Channel).GetDataPoints(this._UserProfile, collectData, parameters, request, out result) : this.AddMethod((Method) new CollectDataMethod(collectData, CollectDataMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) collectData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CollectData) null, (CollectData_Parameters) null, (CollectData_Request) null, out CollectData_Result _);
    }

    public ResultStatus GetDataPoints(CollectData collectData)
    {
      return this.GetDataPoints(collectData, (CollectData_Parameters) null, (CollectData_Request) null, out CollectData_Result _);
    }

    public ResultStatus GetDataPoints(
      CollectData collectData,
      CollectData_Request request,
      out CollectData_Result result)
    {
      return this.GetDataPoints(collectData, (CollectData_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CollectData collectData,
      CollectData_Parameters parameters,
      CollectData_Request request,
      out CollectData_Result result)
    {
      result = (CollectData_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) collectData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataService) this._Channel).GetWIPMsgs(this._UserProfile, collectData, parameters, request, out result) : this.AddMethod((Method) new CollectDataMethod(collectData, CollectDataMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) collectData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CollectData) null, (CollectData_Parameters) null, (CollectData_Request) null, out CollectData_Result _);
    }

    public ResultStatus GetWIPMsgs(CollectData collectData)
    {
      return this.GetWIPMsgs(collectData, (CollectData_Parameters) null, (CollectData_Request) null, out CollectData_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CollectData collectData,
      CollectData_Request request,
      out CollectData_Result result)
    {
      return this.GetWIPMsgs(collectData, (CollectData_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CollectData collectData,
      CollectData_Parameters parameters,
      CollectData_Request request,
      out CollectData_Result result)
    {
      result = (CollectData_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) collectData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataService) this._Channel).Load(this._UserProfile, collectData, parameters, request, out result) : this.AddMethod((Method) new CollectDataMethod(collectData, CollectDataMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) collectData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CollectData) null, (CollectData_Parameters) null, (CollectData_Request) null, out CollectData_Result _);
    }

    public ResultStatus Load(CollectData collectData)
    {
      return this.Load(collectData, (CollectData_Parameters) null, (CollectData_Request) null, out CollectData_Result _);
    }

    public ResultStatus Load(
      CollectData collectData,
      CollectData_Request request,
      out CollectData_Result result)
    {
      return this.Load(collectData, (CollectData_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CollectData collectData,
      CollectData_LoadESigDetails_Parameters parameters,
      CollectData_Request request,
      out CollectData_Result result)
    {
      result = (CollectData_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) collectData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataService) this._Channel).LoadESigDetails(this._UserProfile, collectData, parameters, request, out result) : this.AddMethod((Method) new CollectDataMethod(collectData, CollectDataMethods.LoadESigDetails, (CollectData_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) collectData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CollectData) null, (CollectData_LoadESigDetails_Parameters) null, (CollectData_Request) null, out CollectData_Result _);
    }

    public ResultStatus LoadESigDetails(CollectData collectData)
    {
      return this.LoadESigDetails(collectData, (CollectData_LoadESigDetails_Parameters) null, (CollectData_Request) null, out CollectData_Result _);
    }

    public ResultStatus LoadESigDetails(
      CollectData collectData,
      CollectData_Request request,
      out CollectData_Result result)
    {
      return this.LoadESigDetails(collectData, (CollectData_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CollectData collectData,
      CollectData_Parameters parameters,
      CollectData_Request request,
      out CollectData_Result result)
    {
      result = (CollectData_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) collectData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataService) this._Channel).ProcessComputation(this._UserProfile, collectData, parameters, request, out result) : this.AddMethod((Method) new CollectDataMethod(collectData, CollectDataMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) collectData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CollectData) null, (CollectData_Parameters) null, (CollectData_Request) null, out CollectData_Result _);
    }

    public ResultStatus ProcessComputation(CollectData collectData)
    {
      return this.ProcessComputation(collectData, (CollectData_Parameters) null, (CollectData_Request) null, out CollectData_Result _);
    }

    public ResultStatus ProcessComputation(
      CollectData collectData,
      CollectData_Request request,
      out CollectData_Result result)
    {
      return this.ProcessComputation(collectData, (CollectData_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CollectData collectData,
      CollectData_Parameters parameters,
      CollectData_Request request,
      out CollectData_Result result)
    {
      result = (CollectData_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) collectData, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataService) this._Channel).ResolveParametricData(this._UserProfile, collectData, parameters, request, out result) : this.AddMethod((Method) new CollectDataMethod(collectData, CollectDataMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) collectData, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CollectData) null, (CollectData_Parameters) null, (CollectData_Request) null, out CollectData_Result _);
    }

    public ResultStatus ResolveParametricData(CollectData collectData)
    {
      return this.ResolveParametricData(collectData, (CollectData_Parameters) null, (CollectData_Request) null, out CollectData_Result _);
    }

    public ResultStatus ResolveParametricData(
      CollectData collectData,
      CollectData_Request request,
      out CollectData_Result result)
    {
      return this.ResolveParametricData(collectData, (CollectData_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject collectData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectData_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CollectData) collectData, (CollectData_Parameters) parameters, (CollectData_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject collectData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectData_Result result1;
        ResultStatus actions = this.GetActions((CollectData) collectData, (CollectData_Parameters) parameters, (CollectData_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject collectData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectData_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CollectData) collectData, (CollectData_Parameters) parameters, (CollectData_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject collectData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectData_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CollectData) collectData, (CollectData_LoadESigDetails_Parameters) parameters, (CollectData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject collectData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectData_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CollectData) collectData, (CollectData_Parameters) parameters, (CollectData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject collectData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectData_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CollectData) collectData, (CollectData_Parameters) parameters, (CollectData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject collectData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectData_Result result1;
        ResultStatus resultStatus = this.Load((CollectData) collectData, (CollectData_Parameters) parameters, (CollectData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject collectData,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectData_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CollectData) collectData, (CollectData_Parameters) parameters, (CollectData_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CollectData_Request request,
      out CollectData_Result result)
    {
      result = (CollectData_Result) null;
      try
      {
        CollectDataMethod[] methods = new CollectDataMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICollectDataService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CollectData_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CollectData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CollectData cdo,
      CollectData_Request request,
      out CollectData_Result result)
    {
      result = (CollectData_Result) null;
      try
      {
        return ((ICollectDataService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CollectData_Result result1;
        ResultStatus environment = this.GetEnvironment((CollectData) cdo, (CollectData_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CollectData_Request request,
      out CollectData_Result result)
    {
      return this.GetEnvironment((CollectData) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CollectData cdo,
      CollectData_Request request,
      out CollectData_Result result)
    {
      result = (CollectData_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CollectDataMethod(cdo, CollectDataMethods.ExecuteTransaction, (CollectData_Parameters) null));
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
        CollectData_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CollectData) cdo, (CollectData_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CollectData cdo)
    {
      return this.ExecuteTransaction(cdo, (CollectData_Request) null, out CollectData_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CollectData_Request request,
      out CollectData_Result result)
    {
      return this.ExecuteTransaction((CollectData) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CollectData cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CollectDataMethod(cdo, CollectDataMethods.AddDataTransaction, (CollectData_Parameters) null));
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
        return this.AddDataTransaction((CollectData) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
