// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResourceSetupService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResourceSetupService : ResourceTxnBase
  {
    public ResourceSetupService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResourceSetupService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ResourceSetup resourceSetup,
      ResourceSetup_Parameters parameters,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      result = (ResourceSetup_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) resourceSetup, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupService) this._Channel).CreateParametricData(this._UserProfile, resourceSetup, parameters, request, out result) : this.AddMethod((Method) new ResourceSetupMethod(resourceSetup, ResourceSetupMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) resourceSetup, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ResourceSetup) null, (ResourceSetup_Parameters) null, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus CreateParametricData(ResourceSetup resourceSetup)
    {
      return this.CreateParametricData(resourceSetup, (ResourceSetup_Parameters) null, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus CreateParametricData(
      ResourceSetup resourceSetup,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      return this.CreateParametricData(resourceSetup, (ResourceSetup_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ResourceSetup resourceSetup,
      ResourceSetup_Parameters parameters,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      result = (ResourceSetup_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) resourceSetup, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupService) this._Channel).GetActions(this._UserProfile, resourceSetup, parameters, request, out result) : this.AddMethod((Method) new ResourceSetupMethod(resourceSetup, ResourceSetupMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) resourceSetup, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ResourceSetup) null, (ResourceSetup_Parameters) null, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus GetActions(ResourceSetup resourceSetup)
    {
      return this.GetActions(resourceSetup, (ResourceSetup_Parameters) null, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus GetActions(
      ResourceSetup resourceSetup,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      return this.GetActions(resourceSetup, (ResourceSetup_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ResourceSetup resourceSetup,
      ResourceSetup_Parameters parameters,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      result = (ResourceSetup_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) resourceSetup, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupService) this._Channel).GetDataPoints(this._UserProfile, resourceSetup, parameters, request, out result) : this.AddMethod((Method) new ResourceSetupMethod(resourceSetup, ResourceSetupMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) resourceSetup, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ResourceSetup) null, (ResourceSetup_Parameters) null, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus GetDataPoints(ResourceSetup resourceSetup)
    {
      return this.GetDataPoints(resourceSetup, (ResourceSetup_Parameters) null, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus GetDataPoints(
      ResourceSetup resourceSetup,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      return this.GetDataPoints(resourceSetup, (ResourceSetup_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ResourceSetup resourceSetup,
      ResourceSetup_Parameters parameters,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      result = (ResourceSetup_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) resourceSetup, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupService) this._Channel).GetWIPMsgs(this._UserProfile, resourceSetup, parameters, request, out result) : this.AddMethod((Method) new ResourceSetupMethod(resourceSetup, ResourceSetupMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) resourceSetup, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResourceSetup) null, (ResourceSetup_Parameters) null, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus GetWIPMsgs(ResourceSetup resourceSetup)
    {
      return this.GetWIPMsgs(resourceSetup, (ResourceSetup_Parameters) null, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResourceSetup resourceSetup,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      return this.GetWIPMsgs(resourceSetup, (ResourceSetup_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ResourceSetup resourceSetup,
      ResourceSetup_Parameters parameters,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      result = (ResourceSetup_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) resourceSetup, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupService) this._Channel).Load(this._UserProfile, resourceSetup, parameters, request, out result) : this.AddMethod((Method) new ResourceSetupMethod(resourceSetup, ResourceSetupMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) resourceSetup, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ResourceSetup) null, (ResourceSetup_Parameters) null, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus Load(ResourceSetup resourceSetup)
    {
      return this.Load(resourceSetup, (ResourceSetup_Parameters) null, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus Load(
      ResourceSetup resourceSetup,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      return this.Load(resourceSetup, (ResourceSetup_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ResourceSetup resourceSetup,
      ResourceSetup_LoadESigDetails_Parameters parameters,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      result = (ResourceSetup_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) resourceSetup, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupService) this._Channel).LoadESigDetails(this._UserProfile, resourceSetup, parameters, request, out result) : this.AddMethod((Method) new ResourceSetupMethod(resourceSetup, ResourceSetupMethods.LoadESigDetails, (ResourceSetup_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) resourceSetup, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ResourceSetup) null, (ResourceSetup_LoadESigDetails_Parameters) null, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus LoadESigDetails(ResourceSetup resourceSetup)
    {
      return this.LoadESigDetails(resourceSetup, (ResourceSetup_LoadESigDetails_Parameters) null, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResourceSetup resourceSetup,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      return this.LoadESigDetails(resourceSetup, (ResourceSetup_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ResourceSetup resourceSetup,
      ResourceSetup_Parameters parameters,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      result = (ResourceSetup_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) resourceSetup, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupService) this._Channel).ProcessComputation(this._UserProfile, resourceSetup, parameters, request, out result) : this.AddMethod((Method) new ResourceSetupMethod(resourceSetup, ResourceSetupMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) resourceSetup, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ResourceSetup) null, (ResourceSetup_Parameters) null, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus ProcessComputation(ResourceSetup resourceSetup)
    {
      return this.ProcessComputation(resourceSetup, (ResourceSetup_Parameters) null, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus ProcessComputation(
      ResourceSetup resourceSetup,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      return this.ProcessComputation(resourceSetup, (ResourceSetup_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ResourceSetup resourceSetup,
      ResourceSetup_Parameters parameters,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      result = (ResourceSetup_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) resourceSetup, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupService) this._Channel).ResolveParametricData(this._UserProfile, resourceSetup, parameters, request, out result) : this.AddMethod((Method) new ResourceSetupMethod(resourceSetup, ResourceSetupMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) resourceSetup, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ResourceSetup) null, (ResourceSetup_Parameters) null, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus ResolveParametricData(ResourceSetup resourceSetup)
    {
      return this.ResolveParametricData(resourceSetup, (ResourceSetup_Parameters) null, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus ResolveParametricData(
      ResourceSetup resourceSetup,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      return this.ResolveParametricData(resourceSetup, (ResourceSetup_Parameters) null, request, out result);
    }

    public ResultStatus SetLastStatusChangeDate(
      ResourceSetup resourceSetup,
      ResourceSetup_Parameters parameters,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      result = (ResourceSetup_Result) null;
      this.OnBeforeCall(nameof (SetLastStatusChangeDate), (DCObject) resourceSetup, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupService) this._Channel).SetLastStatusChangeDate(this._UserProfile, resourceSetup, parameters, request, out result) : this.AddMethod((Method) new ResourceSetupMethod(resourceSetup, ResourceSetupMethods.SetLastStatusChangeDate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetLastStatusChangeDate), res, (DCObject) resourceSetup, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetLastStatusChangeDate()
    {
      return this.SetLastStatusChangeDate((ResourceSetup) null, (ResourceSetup_Parameters) null, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus SetLastStatusChangeDate(ResourceSetup resourceSetup)
    {
      return this.SetLastStatusChangeDate(resourceSetup, (ResourceSetup_Parameters) null, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus SetLastStatusChangeDate(
      ResourceSetup resourceSetup,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      return this.SetLastStatusChangeDate(resourceSetup, (ResourceSetup_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject resourceSetup,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceSetup_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ResourceSetup) resourceSetup, (ResourceSetup_Parameters) parameters, (ResourceSetup_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject resourceSetup,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceSetup_Result result1;
        ResultStatus actions = this.GetActions((ResourceSetup) resourceSetup, (ResourceSetup_Parameters) parameters, (ResourceSetup_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject resourceSetup,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceSetup_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ResourceSetup) resourceSetup, (ResourceSetup_Parameters) parameters, (ResourceSetup_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject resourceSetup,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceSetup_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ResourceSetup) resourceSetup, (ResourceSetup_LoadESigDetails_Parameters) parameters, (ResourceSetup_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject resourceSetup,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceSetup_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ResourceSetup) resourceSetup, (ResourceSetup_Parameters) parameters, (ResourceSetup_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject resourceSetup,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceSetup_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ResourceSetup) resourceSetup, (ResourceSetup_Parameters) parameters, (ResourceSetup_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject resourceSetup,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceSetup_Result result1;
        ResultStatus resultStatus = this.Load((ResourceSetup) resourceSetup, (ResourceSetup_Parameters) parameters, (ResourceSetup_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject resourceSetup,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceSetup_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResourceSetup) resourceSetup, (ResourceSetup_Parameters) parameters, (ResourceSetup_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      result = (ResourceSetup_Result) null;
      try
      {
        ResourceSetupMethod[] methods = new ResourceSetupMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResourceSetupService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ResourceSetup_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResourceSetup_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceSetup cdo,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      result = (ResourceSetup_Result) null;
      try
      {
        return ((IResourceSetupService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ResourceSetup_Result result1;
        ResultStatus environment = this.GetEnvironment((ResourceSetup) cdo, (ResourceSetup_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      return this.GetEnvironment((ResourceSetup) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResourceSetup cdo,
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      result = (ResourceSetup_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceSetupService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResourceSetupMethod(cdo, ResourceSetupMethods.ExecuteTransaction, (ResourceSetup_Parameters) null));
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
        ResourceSetup_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResourceSetup) cdo, (ResourceSetup_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResourceSetup cdo)
    {
      return this.ExecuteTransaction(cdo, (ResourceSetup_Request) null, out ResourceSetup_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResourceSetup_Request request,
      out ResourceSetup_Result result)
    {
      return this.ExecuteTransaction((ResourceSetup) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResourceSetup cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResourceSetupMethod(cdo, ResourceSetupMethods.AddDataTransaction, (ResourceSetup_Parameters) null));
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
        return this.AddDataTransaction((ResourceSetup) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
