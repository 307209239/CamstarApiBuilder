// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ContainerMaintService : ContainerTxnBase
  {
    public ContainerMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IContainerMaintService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ContainerMaint containerMaint,
      ContainerMaint_Parameters parameters,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      result = (ContainerMaint_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) containerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerMaintService) this._Channel).CreateParametricData(this._UserProfile, containerMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerMaintMethod(containerMaint, ContainerMaintMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) containerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ContainerMaint) null, (ContainerMaint_Parameters) null, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus CreateParametricData(ContainerMaint containerMaint)
    {
      return this.CreateParametricData(containerMaint, (ContainerMaint_Parameters) null, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus CreateParametricData(
      ContainerMaint containerMaint,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      return this.CreateParametricData(containerMaint, (ContainerMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ContainerMaint containerMaint,
      ContainerMaint_Parameters parameters,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      result = (ContainerMaint_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) containerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerMaintService) this._Channel).GetActions(this._UserProfile, containerMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerMaintMethod(containerMaint, ContainerMaintMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) containerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ContainerMaint) null, (ContainerMaint_Parameters) null, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus GetActions(ContainerMaint containerMaint)
    {
      return this.GetActions(containerMaint, (ContainerMaint_Parameters) null, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus GetActions(
      ContainerMaint containerMaint,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      return this.GetActions(containerMaint, (ContainerMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetAttributes(
      ContainerMaint containerMaint,
      ContainerMaint_Parameters parameters,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      result = (ContainerMaint_Result) null;
      this.OnBeforeCall(nameof (GetAttributes), (DCObject) containerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerMaintService) this._Channel).GetAttributes(this._UserProfile, containerMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerMaintMethod(containerMaint, ContainerMaintMethods.GetAttributes, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetAttributes), res, (DCObject) containerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetAttributes()
    {
      return this.GetAttributes((ContainerMaint) null, (ContainerMaint_Parameters) null, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus GetAttributes(ContainerMaint containerMaint)
    {
      return this.GetAttributes(containerMaint, (ContainerMaint_Parameters) null, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus GetAttributes(
      ContainerMaint containerMaint,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      return this.GetAttributes(containerMaint, (ContainerMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ContainerMaint containerMaint,
      ContainerMaint_Parameters parameters,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      result = (ContainerMaint_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) containerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerMaintService) this._Channel).GetDataPoints(this._UserProfile, containerMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerMaintMethod(containerMaint, ContainerMaintMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) containerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ContainerMaint) null, (ContainerMaint_Parameters) null, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus GetDataPoints(ContainerMaint containerMaint)
    {
      return this.GetDataPoints(containerMaint, (ContainerMaint_Parameters) null, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus GetDataPoints(
      ContainerMaint containerMaint,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      return this.GetDataPoints(containerMaint, (ContainerMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ContainerMaint containerMaint,
      ContainerMaint_Parameters parameters,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      result = (ContainerMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) containerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerMaintService) this._Channel).GetWIPMsgs(this._UserProfile, containerMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerMaintMethod(containerMaint, ContainerMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) containerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ContainerMaint) null, (ContainerMaint_Parameters) null, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ContainerMaint containerMaint)
    {
      return this.GetWIPMsgs(containerMaint, (ContainerMaint_Parameters) null, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContainerMaint containerMaint,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      return this.GetWIPMsgs(containerMaint, (ContainerMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ContainerMaint containerMaint,
      ContainerMaint_Parameters parameters,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      result = (ContainerMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) containerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerMaintService) this._Channel).Load(this._UserProfile, containerMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerMaintMethod(containerMaint, ContainerMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) containerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ContainerMaint) null, (ContainerMaint_Parameters) null, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus Load(ContainerMaint containerMaint)
    {
      return this.Load(containerMaint, (ContainerMaint_Parameters) null, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus Load(
      ContainerMaint containerMaint,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      return this.Load(containerMaint, (ContainerMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ContainerMaint containerMaint,
      ContainerMaint_LoadESigDetails_Parameters parameters,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      result = (ContainerMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) containerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerMaintService) this._Channel).LoadESigDetails(this._UserProfile, containerMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerMaintMethod(containerMaint, ContainerMaintMethods.LoadESigDetails, (ContainerMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) containerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ContainerMaint) null, (ContainerMaint_LoadESigDetails_Parameters) null, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ContainerMaint containerMaint)
    {
      return this.LoadESigDetails(containerMaint, (ContainerMaint_LoadESigDetails_Parameters) null, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ContainerMaint containerMaint,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      return this.LoadESigDetails(containerMaint, (ContainerMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ContainerMaint containerMaint,
      ContainerMaint_Parameters parameters,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      result = (ContainerMaint_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) containerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerMaintService) this._Channel).ProcessComputation(this._UserProfile, containerMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerMaintMethod(containerMaint, ContainerMaintMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) containerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ContainerMaint) null, (ContainerMaint_Parameters) null, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus ProcessComputation(ContainerMaint containerMaint)
    {
      return this.ProcessComputation(containerMaint, (ContainerMaint_Parameters) null, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus ProcessComputation(
      ContainerMaint containerMaint,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      return this.ProcessComputation(containerMaint, (ContainerMaint_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ContainerMaint containerMaint,
      ContainerMaint_Parameters parameters,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      result = (ContainerMaint_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) containerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerMaintService) this._Channel).ResolveParametricData(this._UserProfile, containerMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerMaintMethod(containerMaint, ContainerMaintMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) containerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ContainerMaint) null, (ContainerMaint_Parameters) null, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus ResolveParametricData(ContainerMaint containerMaint)
    {
      return this.ResolveParametricData(containerMaint, (ContainerMaint_Parameters) null, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus ResolveParametricData(
      ContainerMaint containerMaint,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      return this.ResolveParametricData(containerMaint, (ContainerMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject containerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerMaint_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ContainerMaint) containerMaint, (ContainerMaint_Parameters) parameters, (ContainerMaint_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject containerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerMaint_Result result1;
        ResultStatus actions = this.GetActions((ContainerMaint) containerMaint, (ContainerMaint_Parameters) parameters, (ContainerMaint_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject containerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerMaint_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ContainerMaint) containerMaint, (ContainerMaint_Parameters) parameters, (ContainerMaint_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject containerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ContainerMaint) containerMaint, (ContainerMaint_LoadESigDetails_Parameters) parameters, (ContainerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject containerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerMaint_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ContainerMaint) containerMaint, (ContainerMaint_Parameters) parameters, (ContainerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject containerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerMaint_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ContainerMaint) containerMaint, (ContainerMaint_Parameters) parameters, (ContainerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject containerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerMaint_Result result1;
        ResultStatus resultStatus = this.Load((ContainerMaint) containerMaint, (ContainerMaint_Parameters) parameters, (ContainerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject containerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ContainerMaint) containerMaint, (ContainerMaint_Parameters) parameters, (ContainerMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      result = (ContainerMaint_Result) null;
      try
      {
        ContainerMaintMethod[] methods = new ContainerMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IContainerMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ContainerMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ContainerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerMaint cdo,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      result = (ContainerMaint_Result) null;
      try
      {
        return ((IContainerMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ContainerMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ContainerMaint) cdo, (ContainerMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      return this.GetEnvironment((ContainerMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ContainerMaint cdo,
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      result = (ContainerMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ContainerMaintMethod(cdo, ContainerMaintMethods.ExecuteTransaction, (ContainerMaint_Parameters) null));
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
        ContainerMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ContainerMaint) cdo, (ContainerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ContainerMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ContainerMaint_Request) null, out ContainerMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ContainerMaint_Request request,
      out ContainerMaint_Result result)
    {
      return this.ExecuteTransaction((ContainerMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ContainerMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ContainerMaintMethod(cdo, ContainerMaintMethods.AddDataTransaction, (ContainerMaint_Parameters) null));
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
        return this.AddDataTransaction((ContainerMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
