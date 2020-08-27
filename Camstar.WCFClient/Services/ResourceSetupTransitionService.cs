// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResourceSetupTransitionService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResourceSetupTransitionService : ResourceSetupBase
  {
    public ResourceSetupTransitionService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResourceSetupTransitionService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ResourceSetupTransition resourceSetupTransition,
      ResourceSetupTransition_Parameters parameters,
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      result = (ResourceSetupTransition_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) resourceSetupTransition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupTransitionService) this._Channel).CreateParametricData(this._UserProfile, resourceSetupTransition, parameters, request, out result) : this.AddMethod((Method) new ResourceSetupTransitionMethod(resourceSetupTransition, ResourceSetupTransitionMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) resourceSetupTransition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ResourceSetupTransition) null, (ResourceSetupTransition_Parameters) null, (ResourceSetupTransition_Request) null, out ResourceSetupTransition_Result _);
    }

    public ResultStatus CreateParametricData(
      ResourceSetupTransition resourceSetupTransition)
    {
      return this.CreateParametricData(resourceSetupTransition, (ResourceSetupTransition_Parameters) null, (ResourceSetupTransition_Request) null, out ResourceSetupTransition_Result _);
    }

    public ResultStatus CreateParametricData(
      ResourceSetupTransition resourceSetupTransition,
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      return this.CreateParametricData(resourceSetupTransition, (ResourceSetupTransition_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ResourceSetupTransition resourceSetupTransition,
      ResourceSetupTransition_Parameters parameters,
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      result = (ResourceSetupTransition_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) resourceSetupTransition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupTransitionService) this._Channel).GetActions(this._UserProfile, resourceSetupTransition, parameters, request, out result) : this.AddMethod((Method) new ResourceSetupTransitionMethod(resourceSetupTransition, ResourceSetupTransitionMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) resourceSetupTransition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ResourceSetupTransition) null, (ResourceSetupTransition_Parameters) null, (ResourceSetupTransition_Request) null, out ResourceSetupTransition_Result _);
    }

    public ResultStatus GetActions(ResourceSetupTransition resourceSetupTransition)
    {
      return this.GetActions(resourceSetupTransition, (ResourceSetupTransition_Parameters) null, (ResourceSetupTransition_Request) null, out ResourceSetupTransition_Result _);
    }

    public ResultStatus GetActions(
      ResourceSetupTransition resourceSetupTransition,
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      return this.GetActions(resourceSetupTransition, (ResourceSetupTransition_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ResourceSetupTransition resourceSetupTransition,
      ResourceSetupTransition_Parameters parameters,
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      result = (ResourceSetupTransition_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) resourceSetupTransition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupTransitionService) this._Channel).GetDataPoints(this._UserProfile, resourceSetupTransition, parameters, request, out result) : this.AddMethod((Method) new ResourceSetupTransitionMethod(resourceSetupTransition, ResourceSetupTransitionMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) resourceSetupTransition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ResourceSetupTransition) null, (ResourceSetupTransition_Parameters) null, (ResourceSetupTransition_Request) null, out ResourceSetupTransition_Result _);
    }

    public ResultStatus GetDataPoints(ResourceSetupTransition resourceSetupTransition)
    {
      return this.GetDataPoints(resourceSetupTransition, (ResourceSetupTransition_Parameters) null, (ResourceSetupTransition_Request) null, out ResourceSetupTransition_Result _);
    }

    public ResultStatus GetDataPoints(
      ResourceSetupTransition resourceSetupTransition,
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      return this.GetDataPoints(resourceSetupTransition, (ResourceSetupTransition_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ResourceSetupTransition resourceSetupTransition,
      ResourceSetupTransition_Parameters parameters,
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      result = (ResourceSetupTransition_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) resourceSetupTransition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupTransitionService) this._Channel).GetWIPMsgs(this._UserProfile, resourceSetupTransition, parameters, request, out result) : this.AddMethod((Method) new ResourceSetupTransitionMethod(resourceSetupTransition, ResourceSetupTransitionMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) resourceSetupTransition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResourceSetupTransition) null, (ResourceSetupTransition_Parameters) null, (ResourceSetupTransition_Request) null, out ResourceSetupTransition_Result _);
    }

    public ResultStatus GetWIPMsgs(ResourceSetupTransition resourceSetupTransition)
    {
      return this.GetWIPMsgs(resourceSetupTransition, (ResourceSetupTransition_Parameters) null, (ResourceSetupTransition_Request) null, out ResourceSetupTransition_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResourceSetupTransition resourceSetupTransition,
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      return this.GetWIPMsgs(resourceSetupTransition, (ResourceSetupTransition_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ResourceSetupTransition resourceSetupTransition,
      ResourceSetupTransition_Parameters parameters,
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      result = (ResourceSetupTransition_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) resourceSetupTransition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupTransitionService) this._Channel).Load(this._UserProfile, resourceSetupTransition, parameters, request, out result) : this.AddMethod((Method) new ResourceSetupTransitionMethod(resourceSetupTransition, ResourceSetupTransitionMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) resourceSetupTransition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ResourceSetupTransition) null, (ResourceSetupTransition_Parameters) null, (ResourceSetupTransition_Request) null, out ResourceSetupTransition_Result _);
    }

    public ResultStatus Load(ResourceSetupTransition resourceSetupTransition)
    {
      return this.Load(resourceSetupTransition, (ResourceSetupTransition_Parameters) null, (ResourceSetupTransition_Request) null, out ResourceSetupTransition_Result _);
    }

    public ResultStatus Load(
      ResourceSetupTransition resourceSetupTransition,
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      return this.Load(resourceSetupTransition, (ResourceSetupTransition_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ResourceSetupTransition resourceSetupTransition,
      ResourceSetupTransition_LoadESigDetails_Parameters parameters,
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      result = (ResourceSetupTransition_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) resourceSetupTransition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupTransitionService) this._Channel).LoadESigDetails(this._UserProfile, resourceSetupTransition, parameters, request, out result) : this.AddMethod((Method) new ResourceSetupTransitionMethod(resourceSetupTransition, ResourceSetupTransitionMethods.LoadESigDetails, (ResourceSetupTransition_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) resourceSetupTransition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ResourceSetupTransition) null, (ResourceSetupTransition_LoadESigDetails_Parameters) null, (ResourceSetupTransition_Request) null, out ResourceSetupTransition_Result _);
    }

    public ResultStatus LoadESigDetails(ResourceSetupTransition resourceSetupTransition)
    {
      return this.LoadESigDetails(resourceSetupTransition, (ResourceSetupTransition_LoadESigDetails_Parameters) null, (ResourceSetupTransition_Request) null, out ResourceSetupTransition_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResourceSetupTransition resourceSetupTransition,
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      return this.LoadESigDetails(resourceSetupTransition, (ResourceSetupTransition_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ResourceSetupTransition resourceSetupTransition,
      ResourceSetupTransition_Parameters parameters,
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      result = (ResourceSetupTransition_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) resourceSetupTransition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupTransitionService) this._Channel).ProcessComputation(this._UserProfile, resourceSetupTransition, parameters, request, out result) : this.AddMethod((Method) new ResourceSetupTransitionMethod(resourceSetupTransition, ResourceSetupTransitionMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) resourceSetupTransition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ResourceSetupTransition) null, (ResourceSetupTransition_Parameters) null, (ResourceSetupTransition_Request) null, out ResourceSetupTransition_Result _);
    }

    public ResultStatus ProcessComputation(
      ResourceSetupTransition resourceSetupTransition)
    {
      return this.ProcessComputation(resourceSetupTransition, (ResourceSetupTransition_Parameters) null, (ResourceSetupTransition_Request) null, out ResourceSetupTransition_Result _);
    }

    public ResultStatus ProcessComputation(
      ResourceSetupTransition resourceSetupTransition,
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      return this.ProcessComputation(resourceSetupTransition, (ResourceSetupTransition_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ResourceSetupTransition resourceSetupTransition,
      ResourceSetupTransition_Parameters parameters,
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      result = (ResourceSetupTransition_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) resourceSetupTransition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupTransitionService) this._Channel).ResolveParametricData(this._UserProfile, resourceSetupTransition, parameters, request, out result) : this.AddMethod((Method) new ResourceSetupTransitionMethod(resourceSetupTransition, ResourceSetupTransitionMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) resourceSetupTransition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ResourceSetupTransition) null, (ResourceSetupTransition_Parameters) null, (ResourceSetupTransition_Request) null, out ResourceSetupTransition_Result _);
    }

    public ResultStatus ResolveParametricData(
      ResourceSetupTransition resourceSetupTransition)
    {
      return this.ResolveParametricData(resourceSetupTransition, (ResourceSetupTransition_Parameters) null, (ResourceSetupTransition_Request) null, out ResourceSetupTransition_Result _);
    }

    public ResultStatus ResolveParametricData(
      ResourceSetupTransition resourceSetupTransition,
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      return this.ResolveParametricData(resourceSetupTransition, (ResourceSetupTransition_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject resourceSetupTransition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceSetupTransition_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ResourceSetupTransition) resourceSetupTransition, (ResourceSetupTransition_Parameters) parameters, (ResourceSetupTransition_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject resourceSetupTransition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceSetupTransition_Result result1;
        ResultStatus actions = this.GetActions((ResourceSetupTransition) resourceSetupTransition, (ResourceSetupTransition_Parameters) parameters, (ResourceSetupTransition_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject resourceSetupTransition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceSetupTransition_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ResourceSetupTransition) resourceSetupTransition, (ResourceSetupTransition_Parameters) parameters, (ResourceSetupTransition_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject resourceSetupTransition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceSetupTransition_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ResourceSetupTransition) resourceSetupTransition, (ResourceSetupTransition_LoadESigDetails_Parameters) parameters, (ResourceSetupTransition_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject resourceSetupTransition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceSetupTransition_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ResourceSetupTransition) resourceSetupTransition, (ResourceSetupTransition_Parameters) parameters, (ResourceSetupTransition_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject resourceSetupTransition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceSetupTransition_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ResourceSetupTransition) resourceSetupTransition, (ResourceSetupTransition_Parameters) parameters, (ResourceSetupTransition_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject resourceSetupTransition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceSetupTransition_Result result1;
        ResultStatus resultStatus = this.Load((ResourceSetupTransition) resourceSetupTransition, (ResourceSetupTransition_Parameters) parameters, (ResourceSetupTransition_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject resourceSetupTransition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceSetupTransition_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResourceSetupTransition) resourceSetupTransition, (ResourceSetupTransition_Parameters) parameters, (ResourceSetupTransition_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      result = (ResourceSetupTransition_Result) null;
      try
      {
        ResourceSetupTransitionMethod[] methods = new ResourceSetupTransitionMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResourceSetupTransitionService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ResourceSetupTransition_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResourceSetupTransition_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceSetupTransition cdo,
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      result = (ResourceSetupTransition_Result) null;
      try
      {
        return ((IResourceSetupTransitionService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ResourceSetupTransition_Result result1;
        ResultStatus environment = this.GetEnvironment((ResourceSetupTransition) cdo, (ResourceSetupTransition_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      return this.GetEnvironment((ResourceSetupTransition) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResourceSetupTransition cdo,
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      result = (ResourceSetupTransition_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupTransitionService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResourceSetupTransitionMethod(cdo, ResourceSetupTransitionMethods.ExecuteTransaction, (ResourceSetupTransition_Parameters) null));
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
        ResourceSetupTransition_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResourceSetupTransition) cdo, (ResourceSetupTransition_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResourceSetupTransition cdo)
    {
      return this.ExecuteTransaction(cdo, (ResourceSetupTransition_Request) null, out ResourceSetupTransition_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResourceSetupTransition_Request request,
      out ResourceSetupTransition_Result result)
    {
      return this.ExecuteTransaction((ResourceSetupTransition) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResourceSetupTransition cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResourceSetupTransitionMethod(cdo, ResourceSetupTransitionMethods.AddDataTransaction, (ResourceSetupTransition_Parameters) null));
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
        return this.AddDataTransaction((ResourceSetupTransition) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
