// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.VoidCPStatusesService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class VoidCPStatusesService : ChangeStatusTxnsBase
  {
    public VoidCPStatusesService(UserProfile userProfile)
    {
      this.Initialize(typeof (IVoidCPStatusesService), userProfile);
    }

    public ResultStatus CreateParametricData(
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Parameters parameters,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      result = (VoidCPStatuses_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) voidCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidCPStatusesService) this._Channel).CreateParametricData(this._UserProfile, voidCPStatuses, parameters, request, out result) : this.AddMethod((Method) new VoidCPStatusesMethod(voidCPStatuses, VoidCPStatusesMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) voidCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((VoidCPStatuses) null, (VoidCPStatuses_Parameters) null, (VoidCPStatuses_Request) null, out VoidCPStatuses_Result _);
    }

    public ResultStatus CreateParametricData(VoidCPStatuses voidCPStatuses)
    {
      return this.CreateParametricData(voidCPStatuses, (VoidCPStatuses_Parameters) null, (VoidCPStatuses_Request) null, out VoidCPStatuses_Result _);
    }

    public ResultStatus CreateParametricData(
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      return this.CreateParametricData(voidCPStatuses, (VoidCPStatuses_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Parameters parameters,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      result = (VoidCPStatuses_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) voidCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidCPStatusesService) this._Channel).GetActions(this._UserProfile, voidCPStatuses, parameters, request, out result) : this.AddMethod((Method) new VoidCPStatusesMethod(voidCPStatuses, VoidCPStatusesMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) voidCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((VoidCPStatuses) null, (VoidCPStatuses_Parameters) null, (VoidCPStatuses_Request) null, out VoidCPStatuses_Result _);
    }

    public ResultStatus GetActions(VoidCPStatuses voidCPStatuses)
    {
      return this.GetActions(voidCPStatuses, (VoidCPStatuses_Parameters) null, (VoidCPStatuses_Request) null, out VoidCPStatuses_Result _);
    }

    public ResultStatus GetActions(
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      return this.GetActions(voidCPStatuses, (VoidCPStatuses_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Parameters parameters,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      result = (VoidCPStatuses_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) voidCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidCPStatusesService) this._Channel).GetDataPoints(this._UserProfile, voidCPStatuses, parameters, request, out result) : this.AddMethod((Method) new VoidCPStatusesMethod(voidCPStatuses, VoidCPStatusesMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) voidCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((VoidCPStatuses) null, (VoidCPStatuses_Parameters) null, (VoidCPStatuses_Request) null, out VoidCPStatuses_Result _);
    }

    public ResultStatus GetDataPoints(VoidCPStatuses voidCPStatuses)
    {
      return this.GetDataPoints(voidCPStatuses, (VoidCPStatuses_Parameters) null, (VoidCPStatuses_Request) null, out VoidCPStatuses_Result _);
    }

    public ResultStatus GetDataPoints(
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      return this.GetDataPoints(voidCPStatuses, (VoidCPStatuses_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Parameters parameters,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      result = (VoidCPStatuses_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) voidCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidCPStatusesService) this._Channel).GetWIPMsgs(this._UserProfile, voidCPStatuses, parameters, request, out result) : this.AddMethod((Method) new VoidCPStatusesMethod(voidCPStatuses, VoidCPStatusesMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) voidCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((VoidCPStatuses) null, (VoidCPStatuses_Parameters) null, (VoidCPStatuses_Request) null, out VoidCPStatuses_Result _);
    }

    public ResultStatus GetWIPMsgs(VoidCPStatuses voidCPStatuses)
    {
      return this.GetWIPMsgs(voidCPStatuses, (VoidCPStatuses_Parameters) null, (VoidCPStatuses_Request) null, out VoidCPStatuses_Result _);
    }

    public ResultStatus GetWIPMsgs(
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      return this.GetWIPMsgs(voidCPStatuses, (VoidCPStatuses_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Parameters parameters,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      result = (VoidCPStatuses_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) voidCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidCPStatusesService) this._Channel).Load(this._UserProfile, voidCPStatuses, parameters, request, out result) : this.AddMethod((Method) new VoidCPStatusesMethod(voidCPStatuses, VoidCPStatusesMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) voidCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((VoidCPStatuses) null, (VoidCPStatuses_Parameters) null, (VoidCPStatuses_Request) null, out VoidCPStatuses_Result _);
    }

    public ResultStatus Load(VoidCPStatuses voidCPStatuses)
    {
      return this.Load(voidCPStatuses, (VoidCPStatuses_Parameters) null, (VoidCPStatuses_Request) null, out VoidCPStatuses_Result _);
    }

    public ResultStatus Load(
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      return this.Load(voidCPStatuses, (VoidCPStatuses_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_LoadESigDetails_Parameters parameters,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      result = (VoidCPStatuses_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) voidCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidCPStatusesService) this._Channel).LoadESigDetails(this._UserProfile, voidCPStatuses, parameters, request, out result) : this.AddMethod((Method) new VoidCPStatusesMethod(voidCPStatuses, VoidCPStatusesMethods.LoadESigDetails, (VoidCPStatuses_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) voidCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((VoidCPStatuses) null, (VoidCPStatuses_LoadESigDetails_Parameters) null, (VoidCPStatuses_Request) null, out VoidCPStatuses_Result _);
    }

    public ResultStatus LoadESigDetails(VoidCPStatuses voidCPStatuses)
    {
      return this.LoadESigDetails(voidCPStatuses, (VoidCPStatuses_LoadESigDetails_Parameters) null, (VoidCPStatuses_Request) null, out VoidCPStatuses_Result _);
    }

    public ResultStatus LoadESigDetails(
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      return this.LoadESigDetails(voidCPStatuses, (VoidCPStatuses_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Parameters parameters,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      result = (VoidCPStatuses_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) voidCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidCPStatusesService) this._Channel).ProcessComputation(this._UserProfile, voidCPStatuses, parameters, request, out result) : this.AddMethod((Method) new VoidCPStatusesMethod(voidCPStatuses, VoidCPStatusesMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) voidCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((VoidCPStatuses) null, (VoidCPStatuses_Parameters) null, (VoidCPStatuses_Request) null, out VoidCPStatuses_Result _);
    }

    public ResultStatus ProcessComputation(VoidCPStatuses voidCPStatuses)
    {
      return this.ProcessComputation(voidCPStatuses, (VoidCPStatuses_Parameters) null, (VoidCPStatuses_Request) null, out VoidCPStatuses_Result _);
    }

    public ResultStatus ProcessComputation(
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      return this.ProcessComputation(voidCPStatuses, (VoidCPStatuses_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Parameters parameters,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      result = (VoidCPStatuses_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) voidCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidCPStatusesService) this._Channel).ResolveParametricData(this._UserProfile, voidCPStatuses, parameters, request, out result) : this.AddMethod((Method) new VoidCPStatusesMethod(voidCPStatuses, VoidCPStatusesMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) voidCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((VoidCPStatuses) null, (VoidCPStatuses_Parameters) null, (VoidCPStatuses_Request) null, out VoidCPStatuses_Result _);
    }

    public ResultStatus ResolveParametricData(VoidCPStatuses voidCPStatuses)
    {
      return this.ResolveParametricData(voidCPStatuses, (VoidCPStatuses_Parameters) null, (VoidCPStatuses_Request) null, out VoidCPStatuses_Result _);
    }

    public ResultStatus ResolveParametricData(
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      return this.ResolveParametricData(voidCPStatuses, (VoidCPStatuses_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject voidCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidCPStatuses_Result result1;
        ResultStatus parametricData = this.CreateParametricData((VoidCPStatuses) voidCPStatuses, (VoidCPStatuses_Parameters) parameters, (VoidCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject voidCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidCPStatuses_Result result1;
        ResultStatus actions = this.GetActions((VoidCPStatuses) voidCPStatuses, (VoidCPStatuses_Parameters) parameters, (VoidCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject voidCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidCPStatuses_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((VoidCPStatuses) voidCPStatuses, (VoidCPStatuses_Parameters) parameters, (VoidCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject voidCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidCPStatuses_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((VoidCPStatuses) voidCPStatuses, (VoidCPStatuses_LoadESigDetails_Parameters) parameters, (VoidCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject voidCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidCPStatuses_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((VoidCPStatuses) voidCPStatuses, (VoidCPStatuses_Parameters) parameters, (VoidCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject voidCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidCPStatuses_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((VoidCPStatuses) voidCPStatuses, (VoidCPStatuses_Parameters) parameters, (VoidCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject voidCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidCPStatuses_Result result1;
        ResultStatus resultStatus = this.Load((VoidCPStatuses) voidCPStatuses, (VoidCPStatuses_Parameters) parameters, (VoidCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject voidCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidCPStatuses_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((VoidCPStatuses) voidCPStatuses, (VoidCPStatuses_Parameters) parameters, (VoidCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      result = (VoidCPStatuses_Result) null;
      try
      {
        VoidCPStatusesMethod[] methods = new VoidCPStatusesMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IVoidCPStatusesService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        VoidCPStatuses_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((VoidCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      VoidCPStatuses cdo,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      result = (VoidCPStatuses_Result) null;
      try
      {
        return ((IVoidCPStatusesService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        VoidCPStatuses_Result result1;
        ResultStatus environment = this.GetEnvironment((VoidCPStatuses) cdo, (VoidCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      return this.GetEnvironment((VoidCPStatuses) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      VoidCPStatuses cdo,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      result = (VoidCPStatuses_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidCPStatusesService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new VoidCPStatusesMethod(cdo, VoidCPStatusesMethods.ExecuteTransaction, (VoidCPStatuses_Parameters) null));
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
        VoidCPStatuses_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((VoidCPStatuses) cdo, (VoidCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(VoidCPStatuses cdo)
    {
      return this.ExecuteTransaction(cdo, (VoidCPStatuses_Request) null, out VoidCPStatuses_Result _);
    }

    public ResultStatus ExecuteTransaction(
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result)
    {
      return this.ExecuteTransaction((VoidCPStatuses) null, request, out result);
    }

    public ResultStatus AddDataTransaction(VoidCPStatuses cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new VoidCPStatusesMethod(cdo, VoidCPStatusesMethods.AddDataTransaction, (VoidCPStatuses_Parameters) null));
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
        return this.AddDataTransaction((VoidCPStatuses) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
