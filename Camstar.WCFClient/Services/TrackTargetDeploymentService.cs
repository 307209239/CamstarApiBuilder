// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TrackTargetDeploymentService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class TrackTargetDeploymentService : ShopFloorBase
  {
    public TrackTargetDeploymentService(UserProfile userProfile)
    {
      this.Initialize(typeof (ITrackTargetDeploymentService), userProfile);
    }

    public ResultStatus CreateParametricData(
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Parameters parameters,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      result = (TrackTargetDeployment_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) trackTargetDeployment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrackTargetDeploymentService) this._Channel).CreateParametricData(this._UserProfile, trackTargetDeployment, parameters, request, out result) : this.AddMethod((Method) new TrackTargetDeploymentMethod(trackTargetDeployment, TrackTargetDeploymentMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) trackTargetDeployment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((TrackTargetDeployment) null, (TrackTargetDeployment_Parameters) null, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus CreateParametricData(TrackTargetDeployment trackTargetDeployment)
    {
      return this.CreateParametricData(trackTargetDeployment, (TrackTargetDeployment_Parameters) null, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus CreateParametricData(
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      return this.CreateParametricData(trackTargetDeployment, (TrackTargetDeployment_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Parameters parameters,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      result = (TrackTargetDeployment_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) trackTargetDeployment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrackTargetDeploymentService) this._Channel).GetActions(this._UserProfile, trackTargetDeployment, parameters, request, out result) : this.AddMethod((Method) new TrackTargetDeploymentMethod(trackTargetDeployment, TrackTargetDeploymentMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) trackTargetDeployment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((TrackTargetDeployment) null, (TrackTargetDeployment_Parameters) null, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus GetActions(TrackTargetDeployment trackTargetDeployment)
    {
      return this.GetActions(trackTargetDeployment, (TrackTargetDeployment_Parameters) null, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus GetActions(
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      return this.GetActions(trackTargetDeployment, (TrackTargetDeployment_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Parameters parameters,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      result = (TrackTargetDeployment_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) trackTargetDeployment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrackTargetDeploymentService) this._Channel).GetDataPoints(this._UserProfile, trackTargetDeployment, parameters, request, out result) : this.AddMethod((Method) new TrackTargetDeploymentMethod(trackTargetDeployment, TrackTargetDeploymentMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) trackTargetDeployment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((TrackTargetDeployment) null, (TrackTargetDeployment_Parameters) null, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus GetDataPoints(TrackTargetDeployment trackTargetDeployment)
    {
      return this.GetDataPoints(trackTargetDeployment, (TrackTargetDeployment_Parameters) null, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus GetDataPoints(
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      return this.GetDataPoints(trackTargetDeployment, (TrackTargetDeployment_Parameters) null, request, out result);
    }

    public ResultStatus GetNextAvailableTargetDeployment(
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Parameters parameters,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      result = (TrackTargetDeployment_Result) null;
      this.OnBeforeCall(nameof (GetNextAvailableTargetDeployment), (DCObject) trackTargetDeployment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrackTargetDeploymentService) this._Channel).GetNextAvailableTargetDeployment(this._UserProfile, trackTargetDeployment, parameters, request, out result) : this.AddMethod((Method) new TrackTargetDeploymentMethod(trackTargetDeployment, TrackTargetDeploymentMethods.GetNextAvailableTargetDeployment, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetNextAvailableTargetDeployment), res, (DCObject) trackTargetDeployment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetNextAvailableTargetDeployment()
    {
      return this.GetNextAvailableTargetDeployment((TrackTargetDeployment) null, (TrackTargetDeployment_Parameters) null, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus GetNextAvailableTargetDeployment(
      TrackTargetDeployment trackTargetDeployment)
    {
      return this.GetNextAvailableTargetDeployment(trackTargetDeployment, (TrackTargetDeployment_Parameters) null, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus GetNextAvailableTargetDeployment(
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      return this.GetNextAvailableTargetDeployment(trackTargetDeployment, (TrackTargetDeployment_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Parameters parameters,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      result = (TrackTargetDeployment_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) trackTargetDeployment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrackTargetDeploymentService) this._Channel).GetWIPMsgs(this._UserProfile, trackTargetDeployment, parameters, request, out result) : this.AddMethod((Method) new TrackTargetDeploymentMethod(trackTargetDeployment, TrackTargetDeploymentMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) trackTargetDeployment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((TrackTargetDeployment) null, (TrackTargetDeployment_Parameters) null, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus GetWIPMsgs(TrackTargetDeployment trackTargetDeployment)
    {
      return this.GetWIPMsgs(trackTargetDeployment, (TrackTargetDeployment_Parameters) null, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus GetWIPMsgs(
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      return this.GetWIPMsgs(trackTargetDeployment, (TrackTargetDeployment_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Parameters parameters,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      result = (TrackTargetDeployment_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) trackTargetDeployment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrackTargetDeploymentService) this._Channel).Load(this._UserProfile, trackTargetDeployment, parameters, request, out result) : this.AddMethod((Method) new TrackTargetDeploymentMethod(trackTargetDeployment, TrackTargetDeploymentMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) trackTargetDeployment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((TrackTargetDeployment) null, (TrackTargetDeployment_Parameters) null, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus Load(TrackTargetDeployment trackTargetDeployment)
    {
      return this.Load(trackTargetDeployment, (TrackTargetDeployment_Parameters) null, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus Load(
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      return this.Load(trackTargetDeployment, (TrackTargetDeployment_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_LoadESigDetails_Parameters parameters,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      result = (TrackTargetDeployment_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) trackTargetDeployment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrackTargetDeploymentService) this._Channel).LoadESigDetails(this._UserProfile, trackTargetDeployment, parameters, request, out result) : this.AddMethod((Method) new TrackTargetDeploymentMethod(trackTargetDeployment, TrackTargetDeploymentMethods.LoadESigDetails, (TrackTargetDeployment_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) trackTargetDeployment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((TrackTargetDeployment) null, (TrackTargetDeployment_LoadESigDetails_Parameters) null, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus LoadESigDetails(TrackTargetDeployment trackTargetDeployment)
    {
      return this.LoadESigDetails(trackTargetDeployment, (TrackTargetDeployment_LoadESigDetails_Parameters) null, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus LoadESigDetails(
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      return this.LoadESigDetails(trackTargetDeployment, (TrackTargetDeployment_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Parameters parameters,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      result = (TrackTargetDeployment_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) trackTargetDeployment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrackTargetDeploymentService) this._Channel).ProcessComputation(this._UserProfile, trackTargetDeployment, parameters, request, out result) : this.AddMethod((Method) new TrackTargetDeploymentMethod(trackTargetDeployment, TrackTargetDeploymentMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) trackTargetDeployment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((TrackTargetDeployment) null, (TrackTargetDeployment_Parameters) null, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus ProcessComputation(TrackTargetDeployment trackTargetDeployment)
    {
      return this.ProcessComputation(trackTargetDeployment, (TrackTargetDeployment_Parameters) null, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus ProcessComputation(
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      return this.ProcessComputation(trackTargetDeployment, (TrackTargetDeployment_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Parameters parameters,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      result = (TrackTargetDeployment_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) trackTargetDeployment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrackTargetDeploymentService) this._Channel).ResolveParametricData(this._UserProfile, trackTargetDeployment, parameters, request, out result) : this.AddMethod((Method) new TrackTargetDeploymentMethod(trackTargetDeployment, TrackTargetDeploymentMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) trackTargetDeployment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((TrackTargetDeployment) null, (TrackTargetDeployment_Parameters) null, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus ResolveParametricData(
      TrackTargetDeployment trackTargetDeployment)
    {
      return this.ResolveParametricData(trackTargetDeployment, (TrackTargetDeployment_Parameters) null, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus ResolveParametricData(
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      return this.ResolveParametricData(trackTargetDeployment, (TrackTargetDeployment_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject trackTargetDeployment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrackTargetDeployment_Result result1;
        ResultStatus parametricData = this.CreateParametricData((TrackTargetDeployment) trackTargetDeployment, (TrackTargetDeployment_Parameters) parameters, (TrackTargetDeployment_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject trackTargetDeployment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrackTargetDeployment_Result result1;
        ResultStatus actions = this.GetActions((TrackTargetDeployment) trackTargetDeployment, (TrackTargetDeployment_Parameters) parameters, (TrackTargetDeployment_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject trackTargetDeployment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrackTargetDeployment_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((TrackTargetDeployment) trackTargetDeployment, (TrackTargetDeployment_Parameters) parameters, (TrackTargetDeployment_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject trackTargetDeployment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrackTargetDeployment_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((TrackTargetDeployment) trackTargetDeployment, (TrackTargetDeployment_LoadESigDetails_Parameters) parameters, (TrackTargetDeployment_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject trackTargetDeployment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrackTargetDeployment_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((TrackTargetDeployment) trackTargetDeployment, (TrackTargetDeployment_Parameters) parameters, (TrackTargetDeployment_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject trackTargetDeployment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrackTargetDeployment_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((TrackTargetDeployment) trackTargetDeployment, (TrackTargetDeployment_Parameters) parameters, (TrackTargetDeployment_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject trackTargetDeployment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrackTargetDeployment_Result result1;
        ResultStatus resultStatus = this.Load((TrackTargetDeployment) trackTargetDeployment, (TrackTargetDeployment_Parameters) parameters, (TrackTargetDeployment_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject trackTargetDeployment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrackTargetDeployment_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((TrackTargetDeployment) trackTargetDeployment, (TrackTargetDeployment_Parameters) parameters, (TrackTargetDeployment_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      result = (TrackTargetDeployment_Result) null;
      try
      {
        TrackTargetDeploymentMethod[] methods = new TrackTargetDeploymentMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ITrackTargetDeploymentService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        TrackTargetDeployment_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((TrackTargetDeployment_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TrackTargetDeployment cdo,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      result = (TrackTargetDeployment_Result) null;
      try
      {
        return ((ITrackTargetDeploymentService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        TrackTargetDeployment_Result result1;
        ResultStatus environment = this.GetEnvironment((TrackTargetDeployment) cdo, (TrackTargetDeployment_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      return this.GetEnvironment((TrackTargetDeployment) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      TrackTargetDeployment cdo,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      result = (TrackTargetDeployment_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrackTargetDeploymentService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new TrackTargetDeploymentMethod(cdo, TrackTargetDeploymentMethods.ExecuteTransaction, (TrackTargetDeployment_Parameters) null));
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
        TrackTargetDeployment_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((TrackTargetDeployment) cdo, (TrackTargetDeployment_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(TrackTargetDeployment cdo)
    {
      return this.ExecuteTransaction(cdo, (TrackTargetDeployment_Request) null, out TrackTargetDeployment_Result _);
    }

    public ResultStatus ExecuteTransaction(
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result)
    {
      return this.ExecuteTransaction((TrackTargetDeployment) null, request, out result);
    }

    public ResultStatus AddDataTransaction(TrackTargetDeployment cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new TrackTargetDeploymentMethod(cdo, TrackTargetDeploymentMethods.AddDataTransaction, (TrackTargetDeployment_Parameters) null));
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
        return this.AddDataTransaction((TrackTargetDeployment) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
