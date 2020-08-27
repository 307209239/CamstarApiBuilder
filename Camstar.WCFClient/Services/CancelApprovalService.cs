// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CancelApprovalService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CancelApprovalService : ApprovalTxnBase
  {
    public CancelApprovalService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICancelApprovalService), userProfile);
    }

    public ResultStatus CreateParametricData(
      CancelApproval cancelApproval,
      CancelApproval_Parameters parameters,
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      result = (CancelApproval_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) cancelApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICancelApprovalService) this._Channel).CreateParametricData(this._UserProfile, cancelApproval, parameters, request, out result) : this.AddMethod((Method) new CancelApprovalMethod(cancelApproval, CancelApprovalMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) cancelApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CancelApproval) null, (CancelApproval_Parameters) null, (CancelApproval_Request) null, out CancelApproval_Result _);
    }

    public ResultStatus CreateParametricData(CancelApproval cancelApproval)
    {
      return this.CreateParametricData(cancelApproval, (CancelApproval_Parameters) null, (CancelApproval_Request) null, out CancelApproval_Result _);
    }

    public ResultStatus CreateParametricData(
      CancelApproval cancelApproval,
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      return this.CreateParametricData(cancelApproval, (CancelApproval_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CancelApproval cancelApproval,
      CancelApproval_Parameters parameters,
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      result = (CancelApproval_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) cancelApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICancelApprovalService) this._Channel).GetActions(this._UserProfile, cancelApproval, parameters, request, out result) : this.AddMethod((Method) new CancelApprovalMethod(cancelApproval, CancelApprovalMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) cancelApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CancelApproval) null, (CancelApproval_Parameters) null, (CancelApproval_Request) null, out CancelApproval_Result _);
    }

    public ResultStatus GetActions(CancelApproval cancelApproval)
    {
      return this.GetActions(cancelApproval, (CancelApproval_Parameters) null, (CancelApproval_Request) null, out CancelApproval_Result _);
    }

    public ResultStatus GetActions(
      CancelApproval cancelApproval,
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      return this.GetActions(cancelApproval, (CancelApproval_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CancelApproval cancelApproval,
      CancelApproval_Parameters parameters,
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      result = (CancelApproval_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) cancelApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICancelApprovalService) this._Channel).GetDataPoints(this._UserProfile, cancelApproval, parameters, request, out result) : this.AddMethod((Method) new CancelApprovalMethod(cancelApproval, CancelApprovalMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) cancelApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CancelApproval) null, (CancelApproval_Parameters) null, (CancelApproval_Request) null, out CancelApproval_Result _);
    }

    public ResultStatus GetDataPoints(CancelApproval cancelApproval)
    {
      return this.GetDataPoints(cancelApproval, (CancelApproval_Parameters) null, (CancelApproval_Request) null, out CancelApproval_Result _);
    }

    public ResultStatus GetDataPoints(
      CancelApproval cancelApproval,
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      return this.GetDataPoints(cancelApproval, (CancelApproval_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CancelApproval cancelApproval,
      CancelApproval_Parameters parameters,
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      result = (CancelApproval_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) cancelApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICancelApprovalService) this._Channel).GetWIPMsgs(this._UserProfile, cancelApproval, parameters, request, out result) : this.AddMethod((Method) new CancelApprovalMethod(cancelApproval, CancelApprovalMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) cancelApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CancelApproval) null, (CancelApproval_Parameters) null, (CancelApproval_Request) null, out CancelApproval_Result _);
    }

    public ResultStatus GetWIPMsgs(CancelApproval cancelApproval)
    {
      return this.GetWIPMsgs(cancelApproval, (CancelApproval_Parameters) null, (CancelApproval_Request) null, out CancelApproval_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CancelApproval cancelApproval,
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      return this.GetWIPMsgs(cancelApproval, (CancelApproval_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CancelApproval cancelApproval,
      CancelApproval_Parameters parameters,
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      result = (CancelApproval_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) cancelApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICancelApprovalService) this._Channel).Load(this._UserProfile, cancelApproval, parameters, request, out result) : this.AddMethod((Method) new CancelApprovalMethod(cancelApproval, CancelApprovalMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) cancelApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CancelApproval) null, (CancelApproval_Parameters) null, (CancelApproval_Request) null, out CancelApproval_Result _);
    }

    public ResultStatus Load(CancelApproval cancelApproval)
    {
      return this.Load(cancelApproval, (CancelApproval_Parameters) null, (CancelApproval_Request) null, out CancelApproval_Result _);
    }

    public ResultStatus Load(
      CancelApproval cancelApproval,
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      return this.Load(cancelApproval, (CancelApproval_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CancelApproval cancelApproval,
      CancelApproval_LoadESigDetails_Parameters parameters,
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      result = (CancelApproval_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) cancelApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICancelApprovalService) this._Channel).LoadESigDetails(this._UserProfile, cancelApproval, parameters, request, out result) : this.AddMethod((Method) new CancelApprovalMethod(cancelApproval, CancelApprovalMethods.LoadESigDetails, (CancelApproval_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) cancelApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CancelApproval) null, (CancelApproval_LoadESigDetails_Parameters) null, (CancelApproval_Request) null, out CancelApproval_Result _);
    }

    public ResultStatus LoadESigDetails(CancelApproval cancelApproval)
    {
      return this.LoadESigDetails(cancelApproval, (CancelApproval_LoadESigDetails_Parameters) null, (CancelApproval_Request) null, out CancelApproval_Result _);
    }

    public ResultStatus LoadESigDetails(
      CancelApproval cancelApproval,
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      return this.LoadESigDetails(cancelApproval, (CancelApproval_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CancelApproval cancelApproval,
      CancelApproval_Parameters parameters,
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      result = (CancelApproval_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) cancelApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICancelApprovalService) this._Channel).ProcessComputation(this._UserProfile, cancelApproval, parameters, request, out result) : this.AddMethod((Method) new CancelApprovalMethod(cancelApproval, CancelApprovalMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) cancelApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CancelApproval) null, (CancelApproval_Parameters) null, (CancelApproval_Request) null, out CancelApproval_Result _);
    }

    public ResultStatus ProcessComputation(CancelApproval cancelApproval)
    {
      return this.ProcessComputation(cancelApproval, (CancelApproval_Parameters) null, (CancelApproval_Request) null, out CancelApproval_Result _);
    }

    public ResultStatus ProcessComputation(
      CancelApproval cancelApproval,
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      return this.ProcessComputation(cancelApproval, (CancelApproval_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CancelApproval cancelApproval,
      CancelApproval_Parameters parameters,
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      result = (CancelApproval_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) cancelApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICancelApprovalService) this._Channel).ResolveParametricData(this._UserProfile, cancelApproval, parameters, request, out result) : this.AddMethod((Method) new CancelApprovalMethod(cancelApproval, CancelApprovalMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) cancelApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CancelApproval) null, (CancelApproval_Parameters) null, (CancelApproval_Request) null, out CancelApproval_Result _);
    }

    public ResultStatus ResolveParametricData(CancelApproval cancelApproval)
    {
      return this.ResolveParametricData(cancelApproval, (CancelApproval_Parameters) null, (CancelApproval_Request) null, out CancelApproval_Result _);
    }

    public ResultStatus ResolveParametricData(
      CancelApproval cancelApproval,
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      return this.ResolveParametricData(cancelApproval, (CancelApproval_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject cancelApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CancelApproval_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CancelApproval) cancelApproval, (CancelApproval_Parameters) parameters, (CancelApproval_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject cancelApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CancelApproval_Result result1;
        ResultStatus actions = this.GetActions((CancelApproval) cancelApproval, (CancelApproval_Parameters) parameters, (CancelApproval_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject cancelApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CancelApproval_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CancelApproval) cancelApproval, (CancelApproval_Parameters) parameters, (CancelApproval_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject cancelApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CancelApproval_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CancelApproval) cancelApproval, (CancelApproval_LoadESigDetails_Parameters) parameters, (CancelApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject cancelApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CancelApproval_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CancelApproval) cancelApproval, (CancelApproval_Parameters) parameters, (CancelApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject cancelApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CancelApproval_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CancelApproval) cancelApproval, (CancelApproval_Parameters) parameters, (CancelApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject cancelApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CancelApproval_Result result1;
        ResultStatus resultStatus = this.Load((CancelApproval) cancelApproval, (CancelApproval_Parameters) parameters, (CancelApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject cancelApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CancelApproval_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CancelApproval) cancelApproval, (CancelApproval_Parameters) parameters, (CancelApproval_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      result = (CancelApproval_Result) null;
      try
      {
        CancelApprovalMethod[] methods = new CancelApprovalMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICancelApprovalService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CancelApproval_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CancelApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CancelApproval cdo,
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      result = (CancelApproval_Result) null;
      try
      {
        return ((ICancelApprovalService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CancelApproval_Result result1;
        ResultStatus environment = this.GetEnvironment((CancelApproval) cdo, (CancelApproval_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      return this.GetEnvironment((CancelApproval) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CancelApproval cdo,
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      result = (CancelApproval_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICancelApprovalService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CancelApprovalMethod(cdo, CancelApprovalMethods.ExecuteTransaction, (CancelApproval_Parameters) null));
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
        CancelApproval_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CancelApproval) cdo, (CancelApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CancelApproval cdo)
    {
      return this.ExecuteTransaction(cdo, (CancelApproval_Request) null, out CancelApproval_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CancelApproval_Request request,
      out CancelApproval_Result result)
    {
      return this.ExecuteTransaction((CancelApproval) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CancelApproval cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CancelApprovalMethod(cdo, CancelApprovalMethods.AddDataTransaction, (CancelApproval_Parameters) null));
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
        return this.AddDataTransaction((CancelApproval) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
