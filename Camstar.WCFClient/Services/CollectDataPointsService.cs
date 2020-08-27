// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CollectDataPointsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CollectDataPointsService : GenericTxnBase
  {
    public CollectDataPointsService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICollectDataPointsService), userProfile);
    }

    public ResultStatus CreateParametricData(
      CollectDataPoints collectDataPoints,
      CollectDataPoints_Parameters parameters,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      result = (CollectDataPoints_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) collectDataPoints, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataPointsService) this._Channel).CreateParametricData(this._UserProfile, collectDataPoints, parameters, request, out result) : this.AddMethod((Method) new CollectDataPointsMethod(collectDataPoints, CollectDataPointsMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) collectDataPoints, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CollectDataPoints) null, (CollectDataPoints_Parameters) null, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus CreateParametricData(CollectDataPoints collectDataPoints)
    {
      return this.CreateParametricData(collectDataPoints, (CollectDataPoints_Parameters) null, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus CreateParametricData(
      CollectDataPoints collectDataPoints,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      return this.CreateParametricData(collectDataPoints, (CollectDataPoints_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CollectDataPoints collectDataPoints,
      CollectDataPoints_Parameters parameters,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      result = (CollectDataPoints_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) collectDataPoints, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataPointsService) this._Channel).GetActions(this._UserProfile, collectDataPoints, parameters, request, out result) : this.AddMethod((Method) new CollectDataPointsMethod(collectDataPoints, CollectDataPointsMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) collectDataPoints, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CollectDataPoints) null, (CollectDataPoints_Parameters) null, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus GetActions(CollectDataPoints collectDataPoints)
    {
      return this.GetActions(collectDataPoints, (CollectDataPoints_Parameters) null, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus GetActions(
      CollectDataPoints collectDataPoints,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      return this.GetActions(collectDataPoints, (CollectDataPoints_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CollectDataPoints collectDataPoints,
      CollectDataPoints_Parameters parameters,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      result = (CollectDataPoints_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) collectDataPoints, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataPointsService) this._Channel).GetDataPoints(this._UserProfile, collectDataPoints, parameters, request, out result) : this.AddMethod((Method) new CollectDataPointsMethod(collectDataPoints, CollectDataPointsMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) collectDataPoints, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CollectDataPoints) null, (CollectDataPoints_Parameters) null, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus GetDataPoints(CollectDataPoints collectDataPoints)
    {
      return this.GetDataPoints(collectDataPoints, (CollectDataPoints_Parameters) null, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus GetDataPoints(
      CollectDataPoints collectDataPoints,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      return this.GetDataPoints(collectDataPoints, (CollectDataPoints_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CollectDataPoints collectDataPoints,
      CollectDataPoints_Parameters parameters,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      result = (CollectDataPoints_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) collectDataPoints, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataPointsService) this._Channel).GetWIPMsgs(this._UserProfile, collectDataPoints, parameters, request, out result) : this.AddMethod((Method) new CollectDataPointsMethod(collectDataPoints, CollectDataPointsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) collectDataPoints, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CollectDataPoints) null, (CollectDataPoints_Parameters) null, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus GetWIPMsgs(CollectDataPoints collectDataPoints)
    {
      return this.GetWIPMsgs(collectDataPoints, (CollectDataPoints_Parameters) null, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CollectDataPoints collectDataPoints,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      return this.GetWIPMsgs(collectDataPoints, (CollectDataPoints_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CollectDataPoints collectDataPoints,
      CollectDataPoints_Parameters parameters,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      result = (CollectDataPoints_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) collectDataPoints, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataPointsService) this._Channel).Load(this._UserProfile, collectDataPoints, parameters, request, out result) : this.AddMethod((Method) new CollectDataPointsMethod(collectDataPoints, CollectDataPointsMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) collectDataPoints, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CollectDataPoints) null, (CollectDataPoints_Parameters) null, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus Load(CollectDataPoints collectDataPoints)
    {
      return this.Load(collectDataPoints, (CollectDataPoints_Parameters) null, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus Load(
      CollectDataPoints collectDataPoints,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      return this.Load(collectDataPoints, (CollectDataPoints_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CollectDataPoints collectDataPoints,
      CollectDataPoints_LoadESigDetails_Parameters parameters,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      result = (CollectDataPoints_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) collectDataPoints, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataPointsService) this._Channel).LoadESigDetails(this._UserProfile, collectDataPoints, parameters, request, out result) : this.AddMethod((Method) new CollectDataPointsMethod(collectDataPoints, CollectDataPointsMethods.LoadESigDetails, (CollectDataPoints_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) collectDataPoints, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CollectDataPoints) null, (CollectDataPoints_LoadESigDetails_Parameters) null, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus LoadESigDetails(CollectDataPoints collectDataPoints)
    {
      return this.LoadESigDetails(collectDataPoints, (CollectDataPoints_LoadESigDetails_Parameters) null, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus LoadESigDetails(
      CollectDataPoints collectDataPoints,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      return this.LoadESigDetails(collectDataPoints, (CollectDataPoints_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CollectDataPoints collectDataPoints,
      CollectDataPoints_Parameters parameters,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      result = (CollectDataPoints_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) collectDataPoints, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataPointsService) this._Channel).ProcessComputation(this._UserProfile, collectDataPoints, parameters, request, out result) : this.AddMethod((Method) new CollectDataPointsMethod(collectDataPoints, CollectDataPointsMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) collectDataPoints, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CollectDataPoints) null, (CollectDataPoints_Parameters) null, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus ProcessComputation(CollectDataPoints collectDataPoints)
    {
      return this.ProcessComputation(collectDataPoints, (CollectDataPoints_Parameters) null, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus ProcessComputation(
      CollectDataPoints collectDataPoints,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      return this.ProcessComputation(collectDataPoints, (CollectDataPoints_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CollectDataPoints collectDataPoints,
      CollectDataPoints_Parameters parameters,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      result = (CollectDataPoints_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) collectDataPoints, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataPointsService) this._Channel).ResolveParametricData(this._UserProfile, collectDataPoints, parameters, request, out result) : this.AddMethod((Method) new CollectDataPointsMethod(collectDataPoints, CollectDataPointsMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) collectDataPoints, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CollectDataPoints) null, (CollectDataPoints_Parameters) null, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus ResolveParametricData(CollectDataPoints collectDataPoints)
    {
      return this.ResolveParametricData(collectDataPoints, (CollectDataPoints_Parameters) null, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus ResolveParametricData(
      CollectDataPoints collectDataPoints,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      return this.ResolveParametricData(collectDataPoints, (CollectDataPoints_Parameters) null, request, out result);
    }

    public ResultStatus ReviewDataPoints(
      CollectDataPoints collectDataPoints,
      CollectDataPoints_Parameters parameters,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      result = (CollectDataPoints_Result) null;
      this.OnBeforeCall(nameof (ReviewDataPoints), (DCObject) collectDataPoints, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataPointsService) this._Channel).ReviewDataPoints(this._UserProfile, collectDataPoints, parameters, request, out result) : this.AddMethod((Method) new CollectDataPointsMethod(collectDataPoints, CollectDataPointsMethods.ReviewDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ReviewDataPoints), res, (DCObject) collectDataPoints, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ReviewDataPoints()
    {
      return this.ReviewDataPoints((CollectDataPoints) null, (CollectDataPoints_Parameters) null, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus ReviewDataPoints(CollectDataPoints collectDataPoints)
    {
      return this.ReviewDataPoints(collectDataPoints, (CollectDataPoints_Parameters) null, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus ReviewDataPoints(
      CollectDataPoints collectDataPoints,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      return this.ReviewDataPoints(collectDataPoints, (CollectDataPoints_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject collectDataPoints,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectDataPoints_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CollectDataPoints) collectDataPoints, (CollectDataPoints_Parameters) parameters, (CollectDataPoints_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject collectDataPoints,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectDataPoints_Result result1;
        ResultStatus actions = this.GetActions((CollectDataPoints) collectDataPoints, (CollectDataPoints_Parameters) parameters, (CollectDataPoints_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject collectDataPoints,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectDataPoints_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CollectDataPoints) collectDataPoints, (CollectDataPoints_Parameters) parameters, (CollectDataPoints_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject collectDataPoints,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectDataPoints_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CollectDataPoints) collectDataPoints, (CollectDataPoints_LoadESigDetails_Parameters) parameters, (CollectDataPoints_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject collectDataPoints,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectDataPoints_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CollectDataPoints) collectDataPoints, (CollectDataPoints_Parameters) parameters, (CollectDataPoints_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject collectDataPoints,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectDataPoints_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CollectDataPoints) collectDataPoints, (CollectDataPoints_Parameters) parameters, (CollectDataPoints_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject collectDataPoints,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectDataPoints_Result result1;
        ResultStatus resultStatus = this.Load((CollectDataPoints) collectDataPoints, (CollectDataPoints_Parameters) parameters, (CollectDataPoints_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject collectDataPoints,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollectDataPoints_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CollectDataPoints) collectDataPoints, (CollectDataPoints_Parameters) parameters, (CollectDataPoints_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      result = (CollectDataPoints_Result) null;
      try
      {
        CollectDataPointsMethod[] methods = new CollectDataPointsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICollectDataPointsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CollectDataPoints_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CollectDataPoints_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CollectDataPoints cdo,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      result = (CollectDataPoints_Result) null;
      try
      {
        return ((ICollectDataPointsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CollectDataPoints_Result result1;
        ResultStatus environment = this.GetEnvironment((CollectDataPoints) cdo, (CollectDataPoints_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      return this.GetEnvironment((CollectDataPoints) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CollectDataPoints cdo,
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      result = (CollectDataPoints_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollectDataPointsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CollectDataPointsMethod(cdo, CollectDataPointsMethods.ExecuteTransaction, (CollectDataPoints_Parameters) null));
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
        CollectDataPoints_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CollectDataPoints) cdo, (CollectDataPoints_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CollectDataPoints cdo)
    {
      return this.ExecuteTransaction(cdo, (CollectDataPoints_Request) null, out CollectDataPoints_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CollectDataPoints_Request request,
      out CollectDataPoints_Result result)
    {
      return this.ExecuteTransaction((CollectDataPoints) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CollectDataPoints cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CollectDataPointsMethod(cdo, CollectDataPointsMethods.AddDataTransaction, (CollectDataPoints_Parameters) null));
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
        return this.AddDataTransaction((CollectDataPoints) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
