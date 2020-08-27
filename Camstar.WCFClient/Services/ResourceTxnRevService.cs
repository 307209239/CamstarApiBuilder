// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResourceTxnRevService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResourceTxnRevService : ResourceTxnBase
  {
    public ResourceTxnRevService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResourceTxnRevService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      result = (ResourceTxnRev_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnRevService) this._Channel).CreateParametricData(this._UserProfile, resourceTxnRev, parameters, request, out result) : this.AddMethod((Method) new ResourceTxnRevMethod(resourceTxnRev, ResourceTxnRevMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ResourceTxnRev) null, (ResourceTxnRev_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus CreateParametricData(ResourceTxnRev resourceTxnRev)
    {
      return this.CreateParametricData(resourceTxnRev, (ResourceTxnRev_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus CreateParametricData(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      return this.CreateParametricData(resourceTxnRev, (ResourceTxnRev_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      result = (ResourceTxnRev_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnRevService) this._Channel).GetActions(this._UserProfile, resourceTxnRev, parameters, request, out result) : this.AddMethod((Method) new ResourceTxnRevMethod(resourceTxnRev, ResourceTxnRevMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ResourceTxnRev) null, (ResourceTxnRev_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus GetActions(ResourceTxnRev resourceTxnRev)
    {
      return this.GetActions(resourceTxnRev, (ResourceTxnRev_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus GetActions(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      return this.GetActions(resourceTxnRev, (ResourceTxnRev_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      result = (ResourceTxnRev_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnRevService) this._Channel).GetDataPoints(this._UserProfile, resourceTxnRev, parameters, request, out result) : this.AddMethod((Method) new ResourceTxnRevMethod(resourceTxnRev, ResourceTxnRevMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ResourceTxnRev) null, (ResourceTxnRev_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus GetDataPoints(ResourceTxnRev resourceTxnRev)
    {
      return this.GetDataPoints(resourceTxnRev, (ResourceTxnRev_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus GetDataPoints(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      return this.GetDataPoints(resourceTxnRev, (ResourceTxnRev_Parameters) null, request, out result);
    }

    public ResultStatus GetLastTxnHistory(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      result = (ResourceTxnRev_Result) null;
      this.OnBeforeCall(nameof (GetLastTxnHistory), (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnRevService) this._Channel).GetLastTxnHistory(this._UserProfile, resourceTxnRev, parameters, request, out result) : this.AddMethod((Method) new ResourceTxnRevMethod(resourceTxnRev, ResourceTxnRevMethods.GetLastTxnHistory, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetLastTxnHistory), res, (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetLastTxnHistory()
    {
      return this.GetLastTxnHistory((ResourceTxnRev) null, (ResourceTxnRev_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus GetLastTxnHistory(ResourceTxnRev resourceTxnRev)
    {
      return this.GetLastTxnHistory(resourceTxnRev, (ResourceTxnRev_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus GetLastTxnHistory(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      return this.GetLastTxnHistory(resourceTxnRev, (ResourceTxnRev_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      result = (ResourceTxnRev_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnRevService) this._Channel).GetWIPMsgs(this._UserProfile, resourceTxnRev, parameters, request, out result) : this.AddMethod((Method) new ResourceTxnRevMethod(resourceTxnRev, ResourceTxnRevMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResourceTxnRev) null, (ResourceTxnRev_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus GetWIPMsgs(ResourceTxnRev resourceTxnRev)
    {
      return this.GetWIPMsgs(resourceTxnRev, (ResourceTxnRev_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      return this.GetWIPMsgs(resourceTxnRev, (ResourceTxnRev_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      result = (ResourceTxnRev_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnRevService) this._Channel).Load(this._UserProfile, resourceTxnRev, parameters, request, out result) : this.AddMethod((Method) new ResourceTxnRevMethod(resourceTxnRev, ResourceTxnRevMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ResourceTxnRev) null, (ResourceTxnRev_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus Load(ResourceTxnRev resourceTxnRev)
    {
      return this.Load(resourceTxnRev, (ResourceTxnRev_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus Load(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      return this.Load(resourceTxnRev, (ResourceTxnRev_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_LoadESigDetails_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      result = (ResourceTxnRev_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnRevService) this._Channel).LoadESigDetails(this._UserProfile, resourceTxnRev, parameters, request, out result) : this.AddMethod((Method) new ResourceTxnRevMethod(resourceTxnRev, ResourceTxnRevMethods.LoadESigDetails, (ResourceTxnRev_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ResourceTxnRev) null, (ResourceTxnRev_LoadESigDetails_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus LoadESigDetails(ResourceTxnRev resourceTxnRev)
    {
      return this.LoadESigDetails(resourceTxnRev, (ResourceTxnRev_LoadESigDetails_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      return this.LoadESigDetails(resourceTxnRev, (ResourceTxnRev_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      result = (ResourceTxnRev_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnRevService) this._Channel).ProcessComputation(this._UserProfile, resourceTxnRev, parameters, request, out result) : this.AddMethod((Method) new ResourceTxnRevMethod(resourceTxnRev, ResourceTxnRevMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ResourceTxnRev) null, (ResourceTxnRev_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus ProcessComputation(ResourceTxnRev resourceTxnRev)
    {
      return this.ProcessComputation(resourceTxnRev, (ResourceTxnRev_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus ProcessComputation(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      return this.ProcessComputation(resourceTxnRev, (ResourceTxnRev_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      result = (ResourceTxnRev_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnRevService) this._Channel).ResolveParametricData(this._UserProfile, resourceTxnRev, parameters, request, out result) : this.AddMethod((Method) new ResourceTxnRevMethod(resourceTxnRev, ResourceTxnRevMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ResourceTxnRev) null, (ResourceTxnRev_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus ResolveParametricData(ResourceTxnRev resourceTxnRev)
    {
      return this.ResolveParametricData(resourceTxnRev, (ResourceTxnRev_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus ResolveParametricData(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      return this.ResolveParametricData(resourceTxnRev, (ResourceTxnRev_Parameters) null, request, out result);
    }

    public ResultStatus SetTxnRevHistoryMainline(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_SetTxnRevHistoryMainline_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      result = (ResourceTxnRev_Result) null;
      this.OnBeforeCall(nameof (SetTxnRevHistoryMainline), (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnRevService) this._Channel).SetTxnRevHistoryMainline(this._UserProfile, resourceTxnRev, parameters, request, out result) : this.AddMethod((Method) new ResourceTxnRevMethod(resourceTxnRev, ResourceTxnRevMethods.SetTxnRevHistoryMainline, (ResourceTxnRev_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetTxnRevHistoryMainline), res, (DCObject) resourceTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetTxnRevHistoryMainline()
    {
      return this.SetTxnRevHistoryMainline((ResourceTxnRev) null, (ResourceTxnRev_SetTxnRevHistoryMainline_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus SetTxnRevHistoryMainline(ResourceTxnRev resourceTxnRev)
    {
      return this.SetTxnRevHistoryMainline(resourceTxnRev, (ResourceTxnRev_SetTxnRevHistoryMainline_Parameters) null, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus SetTxnRevHistoryMainline(
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      return this.SetTxnRevHistoryMainline(resourceTxnRev, (ResourceTxnRev_SetTxnRevHistoryMainline_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject resourceTxnRev,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTxnRev_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ResourceTxnRev) resourceTxnRev, (ResourceTxnRev_Parameters) parameters, (ResourceTxnRev_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject resourceTxnRev,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTxnRev_Result result1;
        ResultStatus actions = this.GetActions((ResourceTxnRev) resourceTxnRev, (ResourceTxnRev_Parameters) parameters, (ResourceTxnRev_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject resourceTxnRev,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTxnRev_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ResourceTxnRev) resourceTxnRev, (ResourceTxnRev_Parameters) parameters, (ResourceTxnRev_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject resourceTxnRev,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTxnRev_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ResourceTxnRev) resourceTxnRev, (ResourceTxnRev_LoadESigDetails_Parameters) parameters, (ResourceTxnRev_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject resourceTxnRev,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTxnRev_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ResourceTxnRev) resourceTxnRev, (ResourceTxnRev_Parameters) parameters, (ResourceTxnRev_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject resourceTxnRev,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTxnRev_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ResourceTxnRev) resourceTxnRev, (ResourceTxnRev_Parameters) parameters, (ResourceTxnRev_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject resourceTxnRev,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTxnRev_Result result1;
        ResultStatus resultStatus = this.Load((ResourceTxnRev) resourceTxnRev, (ResourceTxnRev_Parameters) parameters, (ResourceTxnRev_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject resourceTxnRev,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTxnRev_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResourceTxnRev) resourceTxnRev, (ResourceTxnRev_Parameters) parameters, (ResourceTxnRev_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      result = (ResourceTxnRev_Result) null;
      try
      {
        ResourceTxnRevMethod[] methods = new ResourceTxnRevMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResourceTxnRevService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ResourceTxnRev_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResourceTxnRev_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceTxnRev cdo,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      result = (ResourceTxnRev_Result) null;
      try
      {
        return ((IResourceTxnRevService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ResourceTxnRev_Result result1;
        ResultStatus environment = this.GetEnvironment((ResourceTxnRev) cdo, (ResourceTxnRev_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      return this.GetEnvironment((ResourceTxnRev) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResourceTxnRev cdo,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      result = (ResourceTxnRev_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnRevService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResourceTxnRevMethod(cdo, ResourceTxnRevMethods.ExecuteTransaction, (ResourceTxnRev_Parameters) null));
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
        ResourceTxnRev_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResourceTxnRev) cdo, (ResourceTxnRev_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResourceTxnRev cdo)
    {
      return this.ExecuteTransaction(cdo, (ResourceTxnRev_Request) null, out ResourceTxnRev_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result)
    {
      return this.ExecuteTransaction((ResourceTxnRev) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResourceTxnRev cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResourceTxnRevMethod(cdo, ResourceTxnRevMethods.AddDataTransaction, (ResourceTxnRev_Parameters) null));
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
        return this.AddDataTransaction((ResourceTxnRev) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
