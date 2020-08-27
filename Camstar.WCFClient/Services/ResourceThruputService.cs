// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResourceThruputService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResourceThruputService : ResourceTxnBase
  {
    public ResourceThruputService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResourceThruputService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ResourceThruput resourceThruput,
      ResourceThruput_Parameters parameters,
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      result = (ResourceThruput_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) resourceThruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceThruputService) this._Channel).CreateParametricData(this._UserProfile, resourceThruput, parameters, request, out result) : this.AddMethod((Method) new ResourceThruputMethod(resourceThruput, ResourceThruputMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) resourceThruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ResourceThruput) null, (ResourceThruput_Parameters) null, (ResourceThruput_Request) null, out ResourceThruput_Result _);
    }

    public ResultStatus CreateParametricData(ResourceThruput resourceThruput)
    {
      return this.CreateParametricData(resourceThruput, (ResourceThruput_Parameters) null, (ResourceThruput_Request) null, out ResourceThruput_Result _);
    }

    public ResultStatus CreateParametricData(
      ResourceThruput resourceThruput,
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      return this.CreateParametricData(resourceThruput, (ResourceThruput_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ResourceThruput resourceThruput,
      ResourceThruput_Parameters parameters,
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      result = (ResourceThruput_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) resourceThruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceThruputService) this._Channel).GetActions(this._UserProfile, resourceThruput, parameters, request, out result) : this.AddMethod((Method) new ResourceThruputMethod(resourceThruput, ResourceThruputMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) resourceThruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ResourceThruput) null, (ResourceThruput_Parameters) null, (ResourceThruput_Request) null, out ResourceThruput_Result _);
    }

    public ResultStatus GetActions(ResourceThruput resourceThruput)
    {
      return this.GetActions(resourceThruput, (ResourceThruput_Parameters) null, (ResourceThruput_Request) null, out ResourceThruput_Result _);
    }

    public ResultStatus GetActions(
      ResourceThruput resourceThruput,
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      return this.GetActions(resourceThruput, (ResourceThruput_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ResourceThruput resourceThruput,
      ResourceThruput_Parameters parameters,
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      result = (ResourceThruput_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) resourceThruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceThruputService) this._Channel).GetDataPoints(this._UserProfile, resourceThruput, parameters, request, out result) : this.AddMethod((Method) new ResourceThruputMethod(resourceThruput, ResourceThruputMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) resourceThruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ResourceThruput) null, (ResourceThruput_Parameters) null, (ResourceThruput_Request) null, out ResourceThruput_Result _);
    }

    public ResultStatus GetDataPoints(ResourceThruput resourceThruput)
    {
      return this.GetDataPoints(resourceThruput, (ResourceThruput_Parameters) null, (ResourceThruput_Request) null, out ResourceThruput_Result _);
    }

    public ResultStatus GetDataPoints(
      ResourceThruput resourceThruput,
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      return this.GetDataPoints(resourceThruput, (ResourceThruput_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ResourceThruput resourceThruput,
      ResourceThruput_Parameters parameters,
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      result = (ResourceThruput_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) resourceThruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceThruputService) this._Channel).GetWIPMsgs(this._UserProfile, resourceThruput, parameters, request, out result) : this.AddMethod((Method) new ResourceThruputMethod(resourceThruput, ResourceThruputMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) resourceThruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResourceThruput) null, (ResourceThruput_Parameters) null, (ResourceThruput_Request) null, out ResourceThruput_Result _);
    }

    public ResultStatus GetWIPMsgs(ResourceThruput resourceThruput)
    {
      return this.GetWIPMsgs(resourceThruput, (ResourceThruput_Parameters) null, (ResourceThruput_Request) null, out ResourceThruput_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResourceThruput resourceThruput,
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      return this.GetWIPMsgs(resourceThruput, (ResourceThruput_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ResourceThruput resourceThruput,
      ResourceThruput_Parameters parameters,
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      result = (ResourceThruput_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) resourceThruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceThruputService) this._Channel).Load(this._UserProfile, resourceThruput, parameters, request, out result) : this.AddMethod((Method) new ResourceThruputMethod(resourceThruput, ResourceThruputMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) resourceThruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ResourceThruput) null, (ResourceThruput_Parameters) null, (ResourceThruput_Request) null, out ResourceThruput_Result _);
    }

    public ResultStatus Load(ResourceThruput resourceThruput)
    {
      return this.Load(resourceThruput, (ResourceThruput_Parameters) null, (ResourceThruput_Request) null, out ResourceThruput_Result _);
    }

    public ResultStatus Load(
      ResourceThruput resourceThruput,
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      return this.Load(resourceThruput, (ResourceThruput_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ResourceThruput resourceThruput,
      ResourceThruput_LoadESigDetails_Parameters parameters,
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      result = (ResourceThruput_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) resourceThruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceThruputService) this._Channel).LoadESigDetails(this._UserProfile, resourceThruput, parameters, request, out result) : this.AddMethod((Method) new ResourceThruputMethod(resourceThruput, ResourceThruputMethods.LoadESigDetails, (ResourceThruput_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) resourceThruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ResourceThruput) null, (ResourceThruput_LoadESigDetails_Parameters) null, (ResourceThruput_Request) null, out ResourceThruput_Result _);
    }

    public ResultStatus LoadESigDetails(ResourceThruput resourceThruput)
    {
      return this.LoadESigDetails(resourceThruput, (ResourceThruput_LoadESigDetails_Parameters) null, (ResourceThruput_Request) null, out ResourceThruput_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResourceThruput resourceThruput,
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      return this.LoadESigDetails(resourceThruput, (ResourceThruput_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ResourceThruput resourceThruput,
      ResourceThruput_Parameters parameters,
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      result = (ResourceThruput_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) resourceThruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceThruputService) this._Channel).ProcessComputation(this._UserProfile, resourceThruput, parameters, request, out result) : this.AddMethod((Method) new ResourceThruputMethod(resourceThruput, ResourceThruputMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) resourceThruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ResourceThruput) null, (ResourceThruput_Parameters) null, (ResourceThruput_Request) null, out ResourceThruput_Result _);
    }

    public ResultStatus ProcessComputation(ResourceThruput resourceThruput)
    {
      return this.ProcessComputation(resourceThruput, (ResourceThruput_Parameters) null, (ResourceThruput_Request) null, out ResourceThruput_Result _);
    }

    public ResultStatus ProcessComputation(
      ResourceThruput resourceThruput,
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      return this.ProcessComputation(resourceThruput, (ResourceThruput_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ResourceThruput resourceThruput,
      ResourceThruput_Parameters parameters,
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      result = (ResourceThruput_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) resourceThruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceThruputService) this._Channel).ResolveParametricData(this._UserProfile, resourceThruput, parameters, request, out result) : this.AddMethod((Method) new ResourceThruputMethod(resourceThruput, ResourceThruputMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) resourceThruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ResourceThruput) null, (ResourceThruput_Parameters) null, (ResourceThruput_Request) null, out ResourceThruput_Result _);
    }

    public ResultStatus ResolveParametricData(ResourceThruput resourceThruput)
    {
      return this.ResolveParametricData(resourceThruput, (ResourceThruput_Parameters) null, (ResourceThruput_Request) null, out ResourceThruput_Result _);
    }

    public ResultStatus ResolveParametricData(
      ResourceThruput resourceThruput,
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      return this.ResolveParametricData(resourceThruput, (ResourceThruput_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject resourceThruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceThruput_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ResourceThruput) resourceThruput, (ResourceThruput_Parameters) parameters, (ResourceThruput_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject resourceThruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceThruput_Result result1;
        ResultStatus actions = this.GetActions((ResourceThruput) resourceThruput, (ResourceThruput_Parameters) parameters, (ResourceThruput_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject resourceThruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceThruput_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ResourceThruput) resourceThruput, (ResourceThruput_Parameters) parameters, (ResourceThruput_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject resourceThruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceThruput_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ResourceThruput) resourceThruput, (ResourceThruput_LoadESigDetails_Parameters) parameters, (ResourceThruput_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject resourceThruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceThruput_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ResourceThruput) resourceThruput, (ResourceThruput_Parameters) parameters, (ResourceThruput_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject resourceThruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceThruput_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ResourceThruput) resourceThruput, (ResourceThruput_Parameters) parameters, (ResourceThruput_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject resourceThruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceThruput_Result result1;
        ResultStatus resultStatus = this.Load((ResourceThruput) resourceThruput, (ResourceThruput_Parameters) parameters, (ResourceThruput_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject resourceThruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceThruput_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResourceThruput) resourceThruput, (ResourceThruput_Parameters) parameters, (ResourceThruput_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      result = (ResourceThruput_Result) null;
      try
      {
        ResourceThruputMethod[] methods = new ResourceThruputMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResourceThruputService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ResourceThruput_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResourceThruput_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceThruput cdo,
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      result = (ResourceThruput_Result) null;
      try
      {
        return ((IResourceThruputService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ResourceThruput_Result result1;
        ResultStatus environment = this.GetEnvironment((ResourceThruput) cdo, (ResourceThruput_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      return this.GetEnvironment((ResourceThruput) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResourceThruput cdo,
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      result = (ResourceThruput_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceThruputService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResourceThruputMethod(cdo, ResourceThruputMethods.ExecuteTransaction, (ResourceThruput_Parameters) null));
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
        ResourceThruput_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResourceThruput) cdo, (ResourceThruput_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResourceThruput cdo)
    {
      return this.ExecuteTransaction(cdo, (ResourceThruput_Request) null, out ResourceThruput_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResourceThruput_Request request,
      out ResourceThruput_Result result)
    {
      return this.ExecuteTransaction((ResourceThruput) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResourceThruput cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResourceThruputMethod(cdo, ResourceThruputMethods.AddDataTransaction, (ResourceThruput_Parameters) null));
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
        return this.AddDataTransaction((ResourceThruput) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
