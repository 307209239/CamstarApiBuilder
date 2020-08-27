// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ApprovalTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ApprovalTxnService : ShopFloorBase
  {
    public ApprovalTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IApprovalTxnService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ApprovalTxn approvalTxn,
      ApprovalTxn_Parameters parameters,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      result = (ApprovalTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) approvalTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalTxnService) this._Channel).CreateParametricData(this._UserProfile, approvalTxn, parameters, request, out result) : this.AddMethod((Method) new ApprovalTxnMethod(approvalTxn, ApprovalTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) approvalTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ApprovalTxn) null, (ApprovalTxn_Parameters) null, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus CreateParametricData(ApprovalTxn approvalTxn)
    {
      return this.CreateParametricData(approvalTxn, (ApprovalTxn_Parameters) null, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      ApprovalTxn approvalTxn,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      return this.CreateParametricData(approvalTxn, (ApprovalTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ApprovalTxn approvalTxn,
      ApprovalTxn_Parameters parameters,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      result = (ApprovalTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) approvalTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalTxnService) this._Channel).GetActions(this._UserProfile, approvalTxn, parameters, request, out result) : this.AddMethod((Method) new ApprovalTxnMethod(approvalTxn, ApprovalTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) approvalTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ApprovalTxn) null, (ApprovalTxn_Parameters) null, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus GetActions(ApprovalTxn approvalTxn)
    {
      return this.GetActions(approvalTxn, (ApprovalTxn_Parameters) null, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus GetActions(
      ApprovalTxn approvalTxn,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      return this.GetActions(approvalTxn, (ApprovalTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetEntry(
      ApprovalTxn approvalTxn,
      ApprovalTxn_Parameters parameters,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      result = (ApprovalTxn_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetEntry), (DCObject) approvalTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalTxnService) this._Channel).GetApprovalSheetEntry(this._UserProfile, approvalTxn, parameters, request, out result) : this.AddMethod((Method) new ApprovalTxnMethod(approvalTxn, ApprovalTxnMethods.GetApprovalSheetEntry, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetEntry), res, (DCObject) approvalTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetEntry()
    {
      return this.GetApprovalSheetEntry((ApprovalTxn) null, (ApprovalTxn_Parameters) null, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus GetApprovalSheetEntry(ApprovalTxn approvalTxn)
    {
      return this.GetApprovalSheetEntry(approvalTxn, (ApprovalTxn_Parameters) null, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus GetApprovalSheetEntry(
      ApprovalTxn approvalTxn,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      return this.GetApprovalSheetEntry(approvalTxn, (ApprovalTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ApprovalTxn approvalTxn,
      ApprovalTxn_Parameters parameters,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      result = (ApprovalTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) approvalTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalTxnService) this._Channel).GetDataPoints(this._UserProfile, approvalTxn, parameters, request, out result) : this.AddMethod((Method) new ApprovalTxnMethod(approvalTxn, ApprovalTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) approvalTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ApprovalTxn) null, (ApprovalTxn_Parameters) null, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus GetDataPoints(ApprovalTxn approvalTxn)
    {
      return this.GetDataPoints(approvalTxn, (ApprovalTxn_Parameters) null, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      ApprovalTxn approvalTxn,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      return this.GetDataPoints(approvalTxn, (ApprovalTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ApprovalTxn approvalTxn,
      ApprovalTxn_Parameters parameters,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      result = (ApprovalTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) approvalTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalTxnService) this._Channel).GetWIPMsgs(this._UserProfile, approvalTxn, parameters, request, out result) : this.AddMethod((Method) new ApprovalTxnMethod(approvalTxn, ApprovalTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) approvalTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ApprovalTxn) null, (ApprovalTxn_Parameters) null, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(ApprovalTxn approvalTxn)
    {
      return this.GetWIPMsgs(approvalTxn, (ApprovalTxn_Parameters) null, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ApprovalTxn approvalTxn,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      return this.GetWIPMsgs(approvalTxn, (ApprovalTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ApprovalTxn approvalTxn,
      ApprovalTxn_Parameters parameters,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      result = (ApprovalTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) approvalTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalTxnService) this._Channel).Load(this._UserProfile, approvalTxn, parameters, request, out result) : this.AddMethod((Method) new ApprovalTxnMethod(approvalTxn, ApprovalTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) approvalTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ApprovalTxn) null, (ApprovalTxn_Parameters) null, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus Load(ApprovalTxn approvalTxn)
    {
      return this.Load(approvalTxn, (ApprovalTxn_Parameters) null, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus Load(
      ApprovalTxn approvalTxn,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      return this.Load(approvalTxn, (ApprovalTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ApprovalTxn approvalTxn,
      ApprovalTxn_LoadESigDetails_Parameters parameters,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      result = (ApprovalTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) approvalTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalTxnService) this._Channel).LoadESigDetails(this._UserProfile, approvalTxn, parameters, request, out result) : this.AddMethod((Method) new ApprovalTxnMethod(approvalTxn, ApprovalTxnMethods.LoadESigDetails, (ApprovalTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) approvalTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ApprovalTxn) null, (ApprovalTxn_LoadESigDetails_Parameters) null, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus LoadESigDetails(ApprovalTxn approvalTxn)
    {
      return this.LoadESigDetails(approvalTxn, (ApprovalTxn_LoadESigDetails_Parameters) null, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      ApprovalTxn approvalTxn,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      return this.LoadESigDetails(approvalTxn, (ApprovalTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ApprovalTxn approvalTxn,
      ApprovalTxn_Parameters parameters,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      result = (ApprovalTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) approvalTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalTxnService) this._Channel).ProcessComputation(this._UserProfile, approvalTxn, parameters, request, out result) : this.AddMethod((Method) new ApprovalTxnMethod(approvalTxn, ApprovalTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) approvalTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ApprovalTxn) null, (ApprovalTxn_Parameters) null, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus ProcessComputation(ApprovalTxn approvalTxn)
    {
      return this.ProcessComputation(approvalTxn, (ApprovalTxn_Parameters) null, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      ApprovalTxn approvalTxn,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      return this.ProcessComputation(approvalTxn, (ApprovalTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ApprovalTxn approvalTxn,
      ApprovalTxn_Parameters parameters,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      result = (ApprovalTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) approvalTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalTxnService) this._Channel).ResolveParametricData(this._UserProfile, approvalTxn, parameters, request, out result) : this.AddMethod((Method) new ApprovalTxnMethod(approvalTxn, ApprovalTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) approvalTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ApprovalTxn) null, (ApprovalTxn_Parameters) null, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus ResolveParametricData(ApprovalTxn approvalTxn)
    {
      return this.ResolveParametricData(approvalTxn, (ApprovalTxn_Parameters) null, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      ApprovalTxn approvalTxn,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      return this.ResolveParametricData(approvalTxn, (ApprovalTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject approvalTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ApprovalTxn) approvalTxn, (ApprovalTxn_Parameters) parameters, (ApprovalTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject approvalTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalTxn_Result result1;
        ResultStatus actions = this.GetActions((ApprovalTxn) approvalTxn, (ApprovalTxn_Parameters) parameters, (ApprovalTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject approvalTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ApprovalTxn) approvalTxn, (ApprovalTxn_Parameters) parameters, (ApprovalTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject approvalTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ApprovalTxn) approvalTxn, (ApprovalTxn_LoadESigDetails_Parameters) parameters, (ApprovalTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject approvalTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ApprovalTxn) approvalTxn, (ApprovalTxn_Parameters) parameters, (ApprovalTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject approvalTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ApprovalTxn) approvalTxn, (ApprovalTxn_Parameters) parameters, (ApprovalTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject approvalTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalTxn_Result result1;
        ResultStatus resultStatus = this.Load((ApprovalTxn) approvalTxn, (ApprovalTxn_Parameters) parameters, (ApprovalTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject approvalTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ApprovalTxn) approvalTxn, (ApprovalTxn_Parameters) parameters, (ApprovalTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      result = (ApprovalTxn_Result) null;
      try
      {
        ApprovalTxnMethod[] methods = new ApprovalTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IApprovalTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ApprovalTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ApprovalTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ApprovalTxn cdo,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      result = (ApprovalTxn_Result) null;
      try
      {
        return ((IApprovalTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ApprovalTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((ApprovalTxn) cdo, (ApprovalTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      return this.GetEnvironment((ApprovalTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ApprovalTxn cdo,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      result = (ApprovalTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ApprovalTxnMethod(cdo, ApprovalTxnMethods.ExecuteTransaction, (ApprovalTxn_Parameters) null));
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
        ApprovalTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ApprovalTxn) cdo, (ApprovalTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ApprovalTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (ApprovalTxn_Request) null, out ApprovalTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result)
    {
      return this.ExecuteTransaction((ApprovalTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ApprovalTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ApprovalTxnMethod(cdo, ApprovalTxnMethods.AddDataTransaction, (ApprovalTxn_Parameters) null));
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
        return this.AddDataTransaction((ApprovalTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
