// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResourceActivationService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResourceActivationService : MaintenanceReqTxnBase
  {
    public ResourceActivationService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResourceActivationService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ResourceActivation resourceActivation,
      ResourceActivation_Parameters parameters,
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      result = (ResourceActivation_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) resourceActivation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceActivationService) this._Channel).CreateParametricData(this._UserProfile, resourceActivation, parameters, request, out result) : this.AddMethod((Method) new ResourceActivationMethod(resourceActivation, ResourceActivationMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) resourceActivation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ResourceActivation) null, (ResourceActivation_Parameters) null, (ResourceActivation_Request) null, out ResourceActivation_Result _);
    }

    public ResultStatus CreateParametricData(ResourceActivation resourceActivation)
    {
      return this.CreateParametricData(resourceActivation, (ResourceActivation_Parameters) null, (ResourceActivation_Request) null, out ResourceActivation_Result _);
    }

    public ResultStatus CreateParametricData(
      ResourceActivation resourceActivation,
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      return this.CreateParametricData(resourceActivation, (ResourceActivation_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ResourceActivation resourceActivation,
      ResourceActivation_Parameters parameters,
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      result = (ResourceActivation_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) resourceActivation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceActivationService) this._Channel).GetActions(this._UserProfile, resourceActivation, parameters, request, out result) : this.AddMethod((Method) new ResourceActivationMethod(resourceActivation, ResourceActivationMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) resourceActivation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ResourceActivation) null, (ResourceActivation_Parameters) null, (ResourceActivation_Request) null, out ResourceActivation_Result _);
    }

    public ResultStatus GetActions(ResourceActivation resourceActivation)
    {
      return this.GetActions(resourceActivation, (ResourceActivation_Parameters) null, (ResourceActivation_Request) null, out ResourceActivation_Result _);
    }

    public ResultStatus GetActions(
      ResourceActivation resourceActivation,
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      return this.GetActions(resourceActivation, (ResourceActivation_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ResourceActivation resourceActivation,
      ResourceActivation_Parameters parameters,
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      result = (ResourceActivation_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) resourceActivation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceActivationService) this._Channel).GetDataPoints(this._UserProfile, resourceActivation, parameters, request, out result) : this.AddMethod((Method) new ResourceActivationMethod(resourceActivation, ResourceActivationMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) resourceActivation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ResourceActivation) null, (ResourceActivation_Parameters) null, (ResourceActivation_Request) null, out ResourceActivation_Result _);
    }

    public ResultStatus GetDataPoints(ResourceActivation resourceActivation)
    {
      return this.GetDataPoints(resourceActivation, (ResourceActivation_Parameters) null, (ResourceActivation_Request) null, out ResourceActivation_Result _);
    }

    public ResultStatus GetDataPoints(
      ResourceActivation resourceActivation,
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      return this.GetDataPoints(resourceActivation, (ResourceActivation_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ResourceActivation resourceActivation,
      ResourceActivation_Parameters parameters,
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      result = (ResourceActivation_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) resourceActivation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceActivationService) this._Channel).GetWIPMsgs(this._UserProfile, resourceActivation, parameters, request, out result) : this.AddMethod((Method) new ResourceActivationMethod(resourceActivation, ResourceActivationMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) resourceActivation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResourceActivation) null, (ResourceActivation_Parameters) null, (ResourceActivation_Request) null, out ResourceActivation_Result _);
    }

    public ResultStatus GetWIPMsgs(ResourceActivation resourceActivation)
    {
      return this.GetWIPMsgs(resourceActivation, (ResourceActivation_Parameters) null, (ResourceActivation_Request) null, out ResourceActivation_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResourceActivation resourceActivation,
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      return this.GetWIPMsgs(resourceActivation, (ResourceActivation_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ResourceActivation resourceActivation,
      ResourceActivation_Parameters parameters,
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      result = (ResourceActivation_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) resourceActivation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceActivationService) this._Channel).Load(this._UserProfile, resourceActivation, parameters, request, out result) : this.AddMethod((Method) new ResourceActivationMethod(resourceActivation, ResourceActivationMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) resourceActivation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ResourceActivation) null, (ResourceActivation_Parameters) null, (ResourceActivation_Request) null, out ResourceActivation_Result _);
    }

    public ResultStatus Load(ResourceActivation resourceActivation)
    {
      return this.Load(resourceActivation, (ResourceActivation_Parameters) null, (ResourceActivation_Request) null, out ResourceActivation_Result _);
    }

    public ResultStatus Load(
      ResourceActivation resourceActivation,
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      return this.Load(resourceActivation, (ResourceActivation_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ResourceActivation resourceActivation,
      ResourceActivation_LoadESigDetails_Parameters parameters,
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      result = (ResourceActivation_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) resourceActivation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceActivationService) this._Channel).LoadESigDetails(this._UserProfile, resourceActivation, parameters, request, out result) : this.AddMethod((Method) new ResourceActivationMethod(resourceActivation, ResourceActivationMethods.LoadESigDetails, (ResourceActivation_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) resourceActivation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ResourceActivation) null, (ResourceActivation_LoadESigDetails_Parameters) null, (ResourceActivation_Request) null, out ResourceActivation_Result _);
    }

    public ResultStatus LoadESigDetails(ResourceActivation resourceActivation)
    {
      return this.LoadESigDetails(resourceActivation, (ResourceActivation_LoadESigDetails_Parameters) null, (ResourceActivation_Request) null, out ResourceActivation_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResourceActivation resourceActivation,
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      return this.LoadESigDetails(resourceActivation, (ResourceActivation_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ResourceActivation resourceActivation,
      ResourceActivation_Parameters parameters,
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      result = (ResourceActivation_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) resourceActivation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceActivationService) this._Channel).ProcessComputation(this._UserProfile, resourceActivation, parameters, request, out result) : this.AddMethod((Method) new ResourceActivationMethod(resourceActivation, ResourceActivationMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) resourceActivation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ResourceActivation) null, (ResourceActivation_Parameters) null, (ResourceActivation_Request) null, out ResourceActivation_Result _);
    }

    public ResultStatus ProcessComputation(ResourceActivation resourceActivation)
    {
      return this.ProcessComputation(resourceActivation, (ResourceActivation_Parameters) null, (ResourceActivation_Request) null, out ResourceActivation_Result _);
    }

    public ResultStatus ProcessComputation(
      ResourceActivation resourceActivation,
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      return this.ProcessComputation(resourceActivation, (ResourceActivation_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ResourceActivation resourceActivation,
      ResourceActivation_Parameters parameters,
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      result = (ResourceActivation_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) resourceActivation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceActivationService) this._Channel).ResolveParametricData(this._UserProfile, resourceActivation, parameters, request, out result) : this.AddMethod((Method) new ResourceActivationMethod(resourceActivation, ResourceActivationMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) resourceActivation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ResourceActivation) null, (ResourceActivation_Parameters) null, (ResourceActivation_Request) null, out ResourceActivation_Result _);
    }

    public ResultStatus ResolveParametricData(ResourceActivation resourceActivation)
    {
      return this.ResolveParametricData(resourceActivation, (ResourceActivation_Parameters) null, (ResourceActivation_Request) null, out ResourceActivation_Result _);
    }

    public ResultStatus ResolveParametricData(
      ResourceActivation resourceActivation,
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      return this.ResolveParametricData(resourceActivation, (ResourceActivation_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject resourceActivation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceActivation_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ResourceActivation) resourceActivation, (ResourceActivation_Parameters) parameters, (ResourceActivation_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject resourceActivation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceActivation_Result result1;
        ResultStatus actions = this.GetActions((ResourceActivation) resourceActivation, (ResourceActivation_Parameters) parameters, (ResourceActivation_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject resourceActivation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceActivation_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ResourceActivation) resourceActivation, (ResourceActivation_Parameters) parameters, (ResourceActivation_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject resourceActivation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceActivation_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ResourceActivation) resourceActivation, (ResourceActivation_LoadESigDetails_Parameters) parameters, (ResourceActivation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject resourceActivation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceActivation_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ResourceActivation) resourceActivation, (ResourceActivation_Parameters) parameters, (ResourceActivation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject resourceActivation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceActivation_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ResourceActivation) resourceActivation, (ResourceActivation_Parameters) parameters, (ResourceActivation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject resourceActivation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceActivation_Result result1;
        ResultStatus resultStatus = this.Load((ResourceActivation) resourceActivation, (ResourceActivation_Parameters) parameters, (ResourceActivation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject resourceActivation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceActivation_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResourceActivation) resourceActivation, (ResourceActivation_Parameters) parameters, (ResourceActivation_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      result = (ResourceActivation_Result) null;
      try
      {
        ResourceActivationMethod[] methods = new ResourceActivationMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResourceActivationService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ResourceActivation_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResourceActivation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceActivation cdo,
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      result = (ResourceActivation_Result) null;
      try
      {
        return ((IResourceActivationService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ResourceActivation_Result result1;
        ResultStatus environment = this.GetEnvironment((ResourceActivation) cdo, (ResourceActivation_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      return this.GetEnvironment((ResourceActivation) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResourceActivation cdo,
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      result = (ResourceActivation_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceActivationService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResourceActivationMethod(cdo, ResourceActivationMethods.ExecuteTransaction, (ResourceActivation_Parameters) null));
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
        ResourceActivation_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResourceActivation) cdo, (ResourceActivation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResourceActivation cdo)
    {
      return this.ExecuteTransaction(cdo, (ResourceActivation_Request) null, out ResourceActivation_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResourceActivation_Request request,
      out ResourceActivation_Result result)
    {
      return this.ExecuteTransaction((ResourceActivation) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResourceActivation cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResourceActivationMethod(cdo, ResourceActivationMethods.AddDataTransaction, (ResourceActivation_Parameters) null));
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
        return this.AddDataTransaction((ResourceActivation) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
