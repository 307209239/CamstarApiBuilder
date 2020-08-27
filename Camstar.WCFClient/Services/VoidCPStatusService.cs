// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.VoidCPStatusService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class VoidCPStatusService : ChangeStatusTxnBase
  {
    public VoidCPStatusService(UserProfile userProfile)
    {
      this.Initialize(typeof (IVoidCPStatusService), userProfile);
    }

    public ResultStatus CreateParametricData(
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Parameters parameters,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      result = (VoidCPStatus_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) voidCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidCPStatusService) this._Channel).CreateParametricData(this._UserProfile, voidCPStatus, parameters, request, out result) : this.AddMethod((Method) new VoidCPStatusMethod(voidCPStatus, VoidCPStatusMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) voidCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((VoidCPStatus) null, (VoidCPStatus_Parameters) null, (VoidCPStatus_Request) null, out VoidCPStatus_Result _);
    }

    public ResultStatus CreateParametricData(VoidCPStatus voidCPStatus)
    {
      return this.CreateParametricData(voidCPStatus, (VoidCPStatus_Parameters) null, (VoidCPStatus_Request) null, out VoidCPStatus_Result _);
    }

    public ResultStatus CreateParametricData(
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      return this.CreateParametricData(voidCPStatus, (VoidCPStatus_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Parameters parameters,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      result = (VoidCPStatus_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) voidCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidCPStatusService) this._Channel).GetActions(this._UserProfile, voidCPStatus, parameters, request, out result) : this.AddMethod((Method) new VoidCPStatusMethod(voidCPStatus, VoidCPStatusMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) voidCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((VoidCPStatus) null, (VoidCPStatus_Parameters) null, (VoidCPStatus_Request) null, out VoidCPStatus_Result _);
    }

    public ResultStatus GetActions(VoidCPStatus voidCPStatus)
    {
      return this.GetActions(voidCPStatus, (VoidCPStatus_Parameters) null, (VoidCPStatus_Request) null, out VoidCPStatus_Result _);
    }

    public ResultStatus GetActions(
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      return this.GetActions(voidCPStatus, (VoidCPStatus_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Parameters parameters,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      result = (VoidCPStatus_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) voidCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidCPStatusService) this._Channel).GetDataPoints(this._UserProfile, voidCPStatus, parameters, request, out result) : this.AddMethod((Method) new VoidCPStatusMethod(voidCPStatus, VoidCPStatusMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) voidCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((VoidCPStatus) null, (VoidCPStatus_Parameters) null, (VoidCPStatus_Request) null, out VoidCPStatus_Result _);
    }

    public ResultStatus GetDataPoints(VoidCPStatus voidCPStatus)
    {
      return this.GetDataPoints(voidCPStatus, (VoidCPStatus_Parameters) null, (VoidCPStatus_Request) null, out VoidCPStatus_Result _);
    }

    public ResultStatus GetDataPoints(
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      return this.GetDataPoints(voidCPStatus, (VoidCPStatus_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Parameters parameters,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      result = (VoidCPStatus_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) voidCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidCPStatusService) this._Channel).GetWIPMsgs(this._UserProfile, voidCPStatus, parameters, request, out result) : this.AddMethod((Method) new VoidCPStatusMethod(voidCPStatus, VoidCPStatusMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) voidCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((VoidCPStatus) null, (VoidCPStatus_Parameters) null, (VoidCPStatus_Request) null, out VoidCPStatus_Result _);
    }

    public ResultStatus GetWIPMsgs(VoidCPStatus voidCPStatus)
    {
      return this.GetWIPMsgs(voidCPStatus, (VoidCPStatus_Parameters) null, (VoidCPStatus_Request) null, out VoidCPStatus_Result _);
    }

    public ResultStatus GetWIPMsgs(
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      return this.GetWIPMsgs(voidCPStatus, (VoidCPStatus_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Parameters parameters,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      result = (VoidCPStatus_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) voidCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidCPStatusService) this._Channel).Load(this._UserProfile, voidCPStatus, parameters, request, out result) : this.AddMethod((Method) new VoidCPStatusMethod(voidCPStatus, VoidCPStatusMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) voidCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((VoidCPStatus) null, (VoidCPStatus_Parameters) null, (VoidCPStatus_Request) null, out VoidCPStatus_Result _);
    }

    public ResultStatus Load(VoidCPStatus voidCPStatus)
    {
      return this.Load(voidCPStatus, (VoidCPStatus_Parameters) null, (VoidCPStatus_Request) null, out VoidCPStatus_Result _);
    }

    public ResultStatus Load(
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      return this.Load(voidCPStatus, (VoidCPStatus_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      VoidCPStatus voidCPStatus,
      VoidCPStatus_LoadESigDetails_Parameters parameters,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      result = (VoidCPStatus_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) voidCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidCPStatusService) this._Channel).LoadESigDetails(this._UserProfile, voidCPStatus, parameters, request, out result) : this.AddMethod((Method) new VoidCPStatusMethod(voidCPStatus, VoidCPStatusMethods.LoadESigDetails, (VoidCPStatus_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) voidCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((VoidCPStatus) null, (VoidCPStatus_LoadESigDetails_Parameters) null, (VoidCPStatus_Request) null, out VoidCPStatus_Result _);
    }

    public ResultStatus LoadESigDetails(VoidCPStatus voidCPStatus)
    {
      return this.LoadESigDetails(voidCPStatus, (VoidCPStatus_LoadESigDetails_Parameters) null, (VoidCPStatus_Request) null, out VoidCPStatus_Result _);
    }

    public ResultStatus LoadESigDetails(
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      return this.LoadESigDetails(voidCPStatus, (VoidCPStatus_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Parameters parameters,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      result = (VoidCPStatus_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) voidCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidCPStatusService) this._Channel).ProcessComputation(this._UserProfile, voidCPStatus, parameters, request, out result) : this.AddMethod((Method) new VoidCPStatusMethod(voidCPStatus, VoidCPStatusMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) voidCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((VoidCPStatus) null, (VoidCPStatus_Parameters) null, (VoidCPStatus_Request) null, out VoidCPStatus_Result _);
    }

    public ResultStatus ProcessComputation(VoidCPStatus voidCPStatus)
    {
      return this.ProcessComputation(voidCPStatus, (VoidCPStatus_Parameters) null, (VoidCPStatus_Request) null, out VoidCPStatus_Result _);
    }

    public ResultStatus ProcessComputation(
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      return this.ProcessComputation(voidCPStatus, (VoidCPStatus_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Parameters parameters,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      result = (VoidCPStatus_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) voidCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidCPStatusService) this._Channel).ResolveParametricData(this._UserProfile, voidCPStatus, parameters, request, out result) : this.AddMethod((Method) new VoidCPStatusMethod(voidCPStatus, VoidCPStatusMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) voidCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((VoidCPStatus) null, (VoidCPStatus_Parameters) null, (VoidCPStatus_Request) null, out VoidCPStatus_Result _);
    }

    public ResultStatus ResolveParametricData(VoidCPStatus voidCPStatus)
    {
      return this.ResolveParametricData(voidCPStatus, (VoidCPStatus_Parameters) null, (VoidCPStatus_Request) null, out VoidCPStatus_Result _);
    }

    public ResultStatus ResolveParametricData(
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      return this.ResolveParametricData(voidCPStatus, (VoidCPStatus_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject voidCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidCPStatus_Result result1;
        ResultStatus parametricData = this.CreateParametricData((VoidCPStatus) voidCPStatus, (VoidCPStatus_Parameters) parameters, (VoidCPStatus_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject voidCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidCPStatus_Result result1;
        ResultStatus actions = this.GetActions((VoidCPStatus) voidCPStatus, (VoidCPStatus_Parameters) parameters, (VoidCPStatus_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject voidCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidCPStatus_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((VoidCPStatus) voidCPStatus, (VoidCPStatus_Parameters) parameters, (VoidCPStatus_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject voidCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidCPStatus_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((VoidCPStatus) voidCPStatus, (VoidCPStatus_LoadESigDetails_Parameters) parameters, (VoidCPStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject voidCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidCPStatus_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((VoidCPStatus) voidCPStatus, (VoidCPStatus_Parameters) parameters, (VoidCPStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject voidCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidCPStatus_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((VoidCPStatus) voidCPStatus, (VoidCPStatus_Parameters) parameters, (VoidCPStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject voidCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidCPStatus_Result result1;
        ResultStatus resultStatus = this.Load((VoidCPStatus) voidCPStatus, (VoidCPStatus_Parameters) parameters, (VoidCPStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject voidCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidCPStatus_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((VoidCPStatus) voidCPStatus, (VoidCPStatus_Parameters) parameters, (VoidCPStatus_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      result = (VoidCPStatus_Result) null;
      try
      {
        VoidCPStatusMethod[] methods = new VoidCPStatusMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IVoidCPStatusService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        VoidCPStatus_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((VoidCPStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      VoidCPStatus cdo,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      result = (VoidCPStatus_Result) null;
      try
      {
        return ((IVoidCPStatusService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        VoidCPStatus_Result result1;
        ResultStatus environment = this.GetEnvironment((VoidCPStatus) cdo, (VoidCPStatus_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      return this.GetEnvironment((VoidCPStatus) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      VoidCPStatus cdo,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      result = (VoidCPStatus_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidCPStatusService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new VoidCPStatusMethod(cdo, VoidCPStatusMethods.ExecuteTransaction, (VoidCPStatus_Parameters) null));
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
        VoidCPStatus_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((VoidCPStatus) cdo, (VoidCPStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(VoidCPStatus cdo)
    {
      return this.ExecuteTransaction(cdo, (VoidCPStatus_Request) null, out VoidCPStatus_Result _);
    }

    public ResultStatus ExecuteTransaction(
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result)
    {
      return this.ExecuteTransaction((VoidCPStatus) null, request, out result);
    }

    public ResultStatus AddDataTransaction(VoidCPStatus cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new VoidCPStatusMethod(cdo, VoidCPStatusMethods.AddDataTransaction, (VoidCPStatus_Parameters) null));
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
        return this.AddDataTransaction((VoidCPStatus) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
