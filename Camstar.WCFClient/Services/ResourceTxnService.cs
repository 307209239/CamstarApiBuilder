// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResourceTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResourceTxnService : ShopFloorBase
  {
    public ResourceTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResourceTxnService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ResourceTxn resourceTxn,
      ResourceTxn_Parameters parameters,
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      result = (ResourceTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) resourceTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnService) this._Channel).CreateParametricData(this._UserProfile, resourceTxn, parameters, request, out result) : this.AddMethod((Method) new ResourceTxnMethod(resourceTxn, ResourceTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) resourceTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ResourceTxn) null, (ResourceTxn_Parameters) null, (ResourceTxn_Request) null, out ResourceTxn_Result _);
    }

    public ResultStatus CreateParametricData(ResourceTxn resourceTxn)
    {
      return this.CreateParametricData(resourceTxn, (ResourceTxn_Parameters) null, (ResourceTxn_Request) null, out ResourceTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      ResourceTxn resourceTxn,
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      return this.CreateParametricData(resourceTxn, (ResourceTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ResourceTxn resourceTxn,
      ResourceTxn_Parameters parameters,
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      result = (ResourceTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) resourceTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnService) this._Channel).GetActions(this._UserProfile, resourceTxn, parameters, request, out result) : this.AddMethod((Method) new ResourceTxnMethod(resourceTxn, ResourceTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) resourceTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ResourceTxn) null, (ResourceTxn_Parameters) null, (ResourceTxn_Request) null, out ResourceTxn_Result _);
    }

    public ResultStatus GetActions(ResourceTxn resourceTxn)
    {
      return this.GetActions(resourceTxn, (ResourceTxn_Parameters) null, (ResourceTxn_Request) null, out ResourceTxn_Result _);
    }

    public ResultStatus GetActions(
      ResourceTxn resourceTxn,
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      return this.GetActions(resourceTxn, (ResourceTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ResourceTxn resourceTxn,
      ResourceTxn_Parameters parameters,
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      result = (ResourceTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) resourceTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnService) this._Channel).GetDataPoints(this._UserProfile, resourceTxn, parameters, request, out result) : this.AddMethod((Method) new ResourceTxnMethod(resourceTxn, ResourceTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) resourceTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ResourceTxn) null, (ResourceTxn_Parameters) null, (ResourceTxn_Request) null, out ResourceTxn_Result _);
    }

    public ResultStatus GetDataPoints(ResourceTxn resourceTxn)
    {
      return this.GetDataPoints(resourceTxn, (ResourceTxn_Parameters) null, (ResourceTxn_Request) null, out ResourceTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      ResourceTxn resourceTxn,
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      return this.GetDataPoints(resourceTxn, (ResourceTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ResourceTxn resourceTxn,
      ResourceTxn_Parameters parameters,
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      result = (ResourceTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) resourceTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnService) this._Channel).GetWIPMsgs(this._UserProfile, resourceTxn, parameters, request, out result) : this.AddMethod((Method) new ResourceTxnMethod(resourceTxn, ResourceTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) resourceTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResourceTxn) null, (ResourceTxn_Parameters) null, (ResourceTxn_Request) null, out ResourceTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(ResourceTxn resourceTxn)
    {
      return this.GetWIPMsgs(resourceTxn, (ResourceTxn_Parameters) null, (ResourceTxn_Request) null, out ResourceTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResourceTxn resourceTxn,
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      return this.GetWIPMsgs(resourceTxn, (ResourceTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ResourceTxn resourceTxn,
      ResourceTxn_Parameters parameters,
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      result = (ResourceTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) resourceTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnService) this._Channel).Load(this._UserProfile, resourceTxn, parameters, request, out result) : this.AddMethod((Method) new ResourceTxnMethod(resourceTxn, ResourceTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) resourceTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ResourceTxn) null, (ResourceTxn_Parameters) null, (ResourceTxn_Request) null, out ResourceTxn_Result _);
    }

    public ResultStatus Load(ResourceTxn resourceTxn)
    {
      return this.Load(resourceTxn, (ResourceTxn_Parameters) null, (ResourceTxn_Request) null, out ResourceTxn_Result _);
    }

    public ResultStatus Load(
      ResourceTxn resourceTxn,
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      return this.Load(resourceTxn, (ResourceTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ResourceTxn resourceTxn,
      ResourceTxn_LoadESigDetails_Parameters parameters,
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      result = (ResourceTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) resourceTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnService) this._Channel).LoadESigDetails(this._UserProfile, resourceTxn, parameters, request, out result) : this.AddMethod((Method) new ResourceTxnMethod(resourceTxn, ResourceTxnMethods.LoadESigDetails, (ResourceTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) resourceTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ResourceTxn) null, (ResourceTxn_LoadESigDetails_Parameters) null, (ResourceTxn_Request) null, out ResourceTxn_Result _);
    }

    public ResultStatus LoadESigDetails(ResourceTxn resourceTxn)
    {
      return this.LoadESigDetails(resourceTxn, (ResourceTxn_LoadESigDetails_Parameters) null, (ResourceTxn_Request) null, out ResourceTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResourceTxn resourceTxn,
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      return this.LoadESigDetails(resourceTxn, (ResourceTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ResourceTxn resourceTxn,
      ResourceTxn_Parameters parameters,
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      result = (ResourceTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) resourceTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnService) this._Channel).ProcessComputation(this._UserProfile, resourceTxn, parameters, request, out result) : this.AddMethod((Method) new ResourceTxnMethod(resourceTxn, ResourceTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) resourceTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ResourceTxn) null, (ResourceTxn_Parameters) null, (ResourceTxn_Request) null, out ResourceTxn_Result _);
    }

    public ResultStatus ProcessComputation(ResourceTxn resourceTxn)
    {
      return this.ProcessComputation(resourceTxn, (ResourceTxn_Parameters) null, (ResourceTxn_Request) null, out ResourceTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      ResourceTxn resourceTxn,
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      return this.ProcessComputation(resourceTxn, (ResourceTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ResourceTxn resourceTxn,
      ResourceTxn_Parameters parameters,
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      result = (ResourceTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) resourceTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnService) this._Channel).ResolveParametricData(this._UserProfile, resourceTxn, parameters, request, out result) : this.AddMethod((Method) new ResourceTxnMethod(resourceTxn, ResourceTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) resourceTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ResourceTxn) null, (ResourceTxn_Parameters) null, (ResourceTxn_Request) null, out ResourceTxn_Result _);
    }

    public ResultStatus ResolveParametricData(ResourceTxn resourceTxn)
    {
      return this.ResolveParametricData(resourceTxn, (ResourceTxn_Parameters) null, (ResourceTxn_Request) null, out ResourceTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      ResourceTxn resourceTxn,
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      return this.ResolveParametricData(resourceTxn, (ResourceTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject resourceTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ResourceTxn) resourceTxn, (ResourceTxn_Parameters) parameters, (ResourceTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject resourceTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTxn_Result result1;
        ResultStatus actions = this.GetActions((ResourceTxn) resourceTxn, (ResourceTxn_Parameters) parameters, (ResourceTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject resourceTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ResourceTxn) resourceTxn, (ResourceTxn_Parameters) parameters, (ResourceTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject resourceTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ResourceTxn) resourceTxn, (ResourceTxn_LoadESigDetails_Parameters) parameters, (ResourceTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject resourceTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ResourceTxn) resourceTxn, (ResourceTxn_Parameters) parameters, (ResourceTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject resourceTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ResourceTxn) resourceTxn, (ResourceTxn_Parameters) parameters, (ResourceTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject resourceTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTxn_Result result1;
        ResultStatus resultStatus = this.Load((ResourceTxn) resourceTxn, (ResourceTxn_Parameters) parameters, (ResourceTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject resourceTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResourceTxn) resourceTxn, (ResourceTxn_Parameters) parameters, (ResourceTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      result = (ResourceTxn_Result) null;
      try
      {
        ResourceTxnMethod[] methods = new ResourceTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResourceTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ResourceTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResourceTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceTxn cdo,
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      result = (ResourceTxn_Result) null;
      try
      {
        return ((IResourceTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ResourceTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((ResourceTxn) cdo, (ResourceTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      return this.GetEnvironment((ResourceTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResourceTxn cdo,
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      result = (ResourceTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResourceTxnMethod(cdo, ResourceTxnMethods.ExecuteTransaction, (ResourceTxn_Parameters) null));
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
        ResourceTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResourceTxn) cdo, (ResourceTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResourceTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (ResourceTxn_Request) null, out ResourceTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResourceTxn_Request request,
      out ResourceTxn_Result result)
    {
      return this.ExecuteTransaction((ResourceTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResourceTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResourceTxnMethod(cdo, ResourceTxnMethods.AddDataTransaction, (ResourceTxn_Parameters) null));
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
        return this.AddDataTransaction((ResourceTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
