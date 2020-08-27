// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerAttrMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ContainerAttrMaintService : ContainerTxnBase
  {
    public ContainerAttrMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IContainerAttrMaintService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Parameters parameters,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      result = (ContainerAttrMaint_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) containerAttrMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerAttrMaintService) this._Channel).CreateParametricData(this._UserProfile, containerAttrMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerAttrMaintMethod(containerAttrMaint, ContainerAttrMaintMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) containerAttrMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ContainerAttrMaint) null, (ContainerAttrMaint_Parameters) null, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus CreateParametricData(ContainerAttrMaint containerAttrMaint)
    {
      return this.CreateParametricData(containerAttrMaint, (ContainerAttrMaint_Parameters) null, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus CreateParametricData(
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      return this.CreateParametricData(containerAttrMaint, (ContainerAttrMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Parameters parameters,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      result = (ContainerAttrMaint_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) containerAttrMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerAttrMaintService) this._Channel).GetActions(this._UserProfile, containerAttrMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerAttrMaintMethod(containerAttrMaint, ContainerAttrMaintMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) containerAttrMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ContainerAttrMaint) null, (ContainerAttrMaint_Parameters) null, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus GetActions(ContainerAttrMaint containerAttrMaint)
    {
      return this.GetActions(containerAttrMaint, (ContainerAttrMaint_Parameters) null, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus GetActions(
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      return this.GetActions(containerAttrMaint, (ContainerAttrMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetAttributes(
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Parameters parameters,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      result = (ContainerAttrMaint_Result) null;
      this.OnBeforeCall(nameof (GetAttributes), (DCObject) containerAttrMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerAttrMaintService) this._Channel).GetAttributes(this._UserProfile, containerAttrMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerAttrMaintMethod(containerAttrMaint, ContainerAttrMaintMethods.GetAttributes, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetAttributes), res, (DCObject) containerAttrMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetAttributes()
    {
      return this.GetAttributes((ContainerAttrMaint) null, (ContainerAttrMaint_Parameters) null, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus GetAttributes(ContainerAttrMaint containerAttrMaint)
    {
      return this.GetAttributes(containerAttrMaint, (ContainerAttrMaint_Parameters) null, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus GetAttributes(
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      return this.GetAttributes(containerAttrMaint, (ContainerAttrMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Parameters parameters,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      result = (ContainerAttrMaint_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) containerAttrMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerAttrMaintService) this._Channel).GetDataPoints(this._UserProfile, containerAttrMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerAttrMaintMethod(containerAttrMaint, ContainerAttrMaintMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) containerAttrMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ContainerAttrMaint) null, (ContainerAttrMaint_Parameters) null, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus GetDataPoints(ContainerAttrMaint containerAttrMaint)
    {
      return this.GetDataPoints(containerAttrMaint, (ContainerAttrMaint_Parameters) null, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus GetDataPoints(
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      return this.GetDataPoints(containerAttrMaint, (ContainerAttrMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Parameters parameters,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      result = (ContainerAttrMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) containerAttrMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerAttrMaintService) this._Channel).GetWIPMsgs(this._UserProfile, containerAttrMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerAttrMaintMethod(containerAttrMaint, ContainerAttrMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) containerAttrMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ContainerAttrMaint) null, (ContainerAttrMaint_Parameters) null, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ContainerAttrMaint containerAttrMaint)
    {
      return this.GetWIPMsgs(containerAttrMaint, (ContainerAttrMaint_Parameters) null, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      return this.GetWIPMsgs(containerAttrMaint, (ContainerAttrMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Parameters parameters,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      result = (ContainerAttrMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) containerAttrMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerAttrMaintService) this._Channel).Load(this._UserProfile, containerAttrMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerAttrMaintMethod(containerAttrMaint, ContainerAttrMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) containerAttrMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ContainerAttrMaint) null, (ContainerAttrMaint_Parameters) null, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus Load(ContainerAttrMaint containerAttrMaint)
    {
      return this.Load(containerAttrMaint, (ContainerAttrMaint_Parameters) null, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus Load(
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      return this.Load(containerAttrMaint, (ContainerAttrMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_LoadESigDetails_Parameters parameters,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      result = (ContainerAttrMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) containerAttrMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerAttrMaintService) this._Channel).LoadESigDetails(this._UserProfile, containerAttrMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerAttrMaintMethod(containerAttrMaint, ContainerAttrMaintMethods.LoadESigDetails, (ContainerAttrMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) containerAttrMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ContainerAttrMaint) null, (ContainerAttrMaint_LoadESigDetails_Parameters) null, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ContainerAttrMaint containerAttrMaint)
    {
      return this.LoadESigDetails(containerAttrMaint, (ContainerAttrMaint_LoadESigDetails_Parameters) null, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      return this.LoadESigDetails(containerAttrMaint, (ContainerAttrMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Parameters parameters,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      result = (ContainerAttrMaint_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) containerAttrMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerAttrMaintService) this._Channel).ProcessComputation(this._UserProfile, containerAttrMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerAttrMaintMethod(containerAttrMaint, ContainerAttrMaintMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) containerAttrMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ContainerAttrMaint) null, (ContainerAttrMaint_Parameters) null, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus ProcessComputation(ContainerAttrMaint containerAttrMaint)
    {
      return this.ProcessComputation(containerAttrMaint, (ContainerAttrMaint_Parameters) null, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus ProcessComputation(
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      return this.ProcessComputation(containerAttrMaint, (ContainerAttrMaint_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Parameters parameters,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      result = (ContainerAttrMaint_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) containerAttrMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerAttrMaintService) this._Channel).ResolveParametricData(this._UserProfile, containerAttrMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerAttrMaintMethod(containerAttrMaint, ContainerAttrMaintMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) containerAttrMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ContainerAttrMaint) null, (ContainerAttrMaint_Parameters) null, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus ResolveParametricData(ContainerAttrMaint containerAttrMaint)
    {
      return this.ResolveParametricData(containerAttrMaint, (ContainerAttrMaint_Parameters) null, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus ResolveParametricData(
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      return this.ResolveParametricData(containerAttrMaint, (ContainerAttrMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject containerAttrMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerAttrMaint_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ContainerAttrMaint) containerAttrMaint, (ContainerAttrMaint_Parameters) parameters, (ContainerAttrMaint_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject containerAttrMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerAttrMaint_Result result1;
        ResultStatus actions = this.GetActions((ContainerAttrMaint) containerAttrMaint, (ContainerAttrMaint_Parameters) parameters, (ContainerAttrMaint_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject containerAttrMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerAttrMaint_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ContainerAttrMaint) containerAttrMaint, (ContainerAttrMaint_Parameters) parameters, (ContainerAttrMaint_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject containerAttrMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerAttrMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ContainerAttrMaint) containerAttrMaint, (ContainerAttrMaint_LoadESigDetails_Parameters) parameters, (ContainerAttrMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject containerAttrMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerAttrMaint_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ContainerAttrMaint) containerAttrMaint, (ContainerAttrMaint_Parameters) parameters, (ContainerAttrMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject containerAttrMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerAttrMaint_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ContainerAttrMaint) containerAttrMaint, (ContainerAttrMaint_Parameters) parameters, (ContainerAttrMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject containerAttrMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerAttrMaint_Result result1;
        ResultStatus resultStatus = this.Load((ContainerAttrMaint) containerAttrMaint, (ContainerAttrMaint_Parameters) parameters, (ContainerAttrMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject containerAttrMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerAttrMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ContainerAttrMaint) containerAttrMaint, (ContainerAttrMaint_Parameters) parameters, (ContainerAttrMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      result = (ContainerAttrMaint_Result) null;
      try
      {
        ContainerAttrMaintMethod[] methods = new ContainerAttrMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IContainerAttrMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ContainerAttrMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ContainerAttrMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerAttrMaint cdo,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      result = (ContainerAttrMaint_Result) null;
      try
      {
        return ((IContainerAttrMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ContainerAttrMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ContainerAttrMaint) cdo, (ContainerAttrMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      return this.GetEnvironment((ContainerAttrMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ContainerAttrMaint cdo,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      result = (ContainerAttrMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerAttrMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ContainerAttrMaintMethod(cdo, ContainerAttrMaintMethods.ExecuteTransaction, (ContainerAttrMaint_Parameters) null));
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
        ContainerAttrMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ContainerAttrMaint) cdo, (ContainerAttrMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ContainerAttrMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ContainerAttrMaint_Request) null, out ContainerAttrMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result)
    {
      return this.ExecuteTransaction((ContainerAttrMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ContainerAttrMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ContainerAttrMaintMethod(cdo, ContainerAttrMaintMethods.AddDataTransaction, (ContainerAttrMaint_Parameters) null));
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
        return this.AddDataTransaction((ContainerAttrMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
