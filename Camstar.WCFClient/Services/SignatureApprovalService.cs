// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SignatureApprovalService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SignatureApprovalService : ApprovalTxnBase
  {
    public SignatureApprovalService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISignatureApprovalService), userProfile);
    }

    public ResultStatus CreateParametricData(
      SignatureApproval signatureApproval,
      SignatureApproval_Parameters parameters,
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      result = (SignatureApproval_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) signatureApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISignatureApprovalService) this._Channel).CreateParametricData(this._UserProfile, signatureApproval, parameters, request, out result) : this.AddMethod((Method) new SignatureApprovalMethod(signatureApproval, SignatureApprovalMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) signatureApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((SignatureApproval) null, (SignatureApproval_Parameters) null, (SignatureApproval_Request) null, out SignatureApproval_Result _);
    }

    public ResultStatus CreateParametricData(SignatureApproval signatureApproval)
    {
      return this.CreateParametricData(signatureApproval, (SignatureApproval_Parameters) null, (SignatureApproval_Request) null, out SignatureApproval_Result _);
    }

    public ResultStatus CreateParametricData(
      SignatureApproval signatureApproval,
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      return this.CreateParametricData(signatureApproval, (SignatureApproval_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      SignatureApproval signatureApproval,
      SignatureApproval_Parameters parameters,
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      result = (SignatureApproval_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) signatureApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISignatureApprovalService) this._Channel).GetActions(this._UserProfile, signatureApproval, parameters, request, out result) : this.AddMethod((Method) new SignatureApprovalMethod(signatureApproval, SignatureApprovalMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) signatureApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((SignatureApproval) null, (SignatureApproval_Parameters) null, (SignatureApproval_Request) null, out SignatureApproval_Result _);
    }

    public ResultStatus GetActions(SignatureApproval signatureApproval)
    {
      return this.GetActions(signatureApproval, (SignatureApproval_Parameters) null, (SignatureApproval_Request) null, out SignatureApproval_Result _);
    }

    public ResultStatus GetActions(
      SignatureApproval signatureApproval,
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      return this.GetActions(signatureApproval, (SignatureApproval_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      SignatureApproval signatureApproval,
      SignatureApproval_Parameters parameters,
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      result = (SignatureApproval_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) signatureApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISignatureApprovalService) this._Channel).GetDataPoints(this._UserProfile, signatureApproval, parameters, request, out result) : this.AddMethod((Method) new SignatureApprovalMethod(signatureApproval, SignatureApprovalMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) signatureApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((SignatureApproval) null, (SignatureApproval_Parameters) null, (SignatureApproval_Request) null, out SignatureApproval_Result _);
    }

    public ResultStatus GetDataPoints(SignatureApproval signatureApproval)
    {
      return this.GetDataPoints(signatureApproval, (SignatureApproval_Parameters) null, (SignatureApproval_Request) null, out SignatureApproval_Result _);
    }

    public ResultStatus GetDataPoints(
      SignatureApproval signatureApproval,
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      return this.GetDataPoints(signatureApproval, (SignatureApproval_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SignatureApproval signatureApproval,
      SignatureApproval_Parameters parameters,
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      result = (SignatureApproval_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) signatureApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISignatureApprovalService) this._Channel).GetWIPMsgs(this._UserProfile, signatureApproval, parameters, request, out result) : this.AddMethod((Method) new SignatureApprovalMethod(signatureApproval, SignatureApprovalMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) signatureApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SignatureApproval) null, (SignatureApproval_Parameters) null, (SignatureApproval_Request) null, out SignatureApproval_Result _);
    }

    public ResultStatus GetWIPMsgs(SignatureApproval signatureApproval)
    {
      return this.GetWIPMsgs(signatureApproval, (SignatureApproval_Parameters) null, (SignatureApproval_Request) null, out SignatureApproval_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SignatureApproval signatureApproval,
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      return this.GetWIPMsgs(signatureApproval, (SignatureApproval_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SignatureApproval signatureApproval,
      SignatureApproval_Parameters parameters,
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      result = (SignatureApproval_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) signatureApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISignatureApprovalService) this._Channel).Load(this._UserProfile, signatureApproval, parameters, request, out result) : this.AddMethod((Method) new SignatureApprovalMethod(signatureApproval, SignatureApprovalMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) signatureApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SignatureApproval) null, (SignatureApproval_Parameters) null, (SignatureApproval_Request) null, out SignatureApproval_Result _);
    }

    public ResultStatus Load(SignatureApproval signatureApproval)
    {
      return this.Load(signatureApproval, (SignatureApproval_Parameters) null, (SignatureApproval_Request) null, out SignatureApproval_Result _);
    }

    public ResultStatus Load(
      SignatureApproval signatureApproval,
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      return this.Load(signatureApproval, (SignatureApproval_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SignatureApproval signatureApproval,
      SignatureApproval_LoadESigDetails_Parameters parameters,
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      result = (SignatureApproval_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) signatureApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISignatureApprovalService) this._Channel).LoadESigDetails(this._UserProfile, signatureApproval, parameters, request, out result) : this.AddMethod((Method) new SignatureApprovalMethod(signatureApproval, SignatureApprovalMethods.LoadESigDetails, (SignatureApproval_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) signatureApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SignatureApproval) null, (SignatureApproval_LoadESigDetails_Parameters) null, (SignatureApproval_Request) null, out SignatureApproval_Result _);
    }

    public ResultStatus LoadESigDetails(SignatureApproval signatureApproval)
    {
      return this.LoadESigDetails(signatureApproval, (SignatureApproval_LoadESigDetails_Parameters) null, (SignatureApproval_Request) null, out SignatureApproval_Result _);
    }

    public ResultStatus LoadESigDetails(
      SignatureApproval signatureApproval,
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      return this.LoadESigDetails(signatureApproval, (SignatureApproval_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      SignatureApproval signatureApproval,
      SignatureApproval_Parameters parameters,
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      result = (SignatureApproval_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) signatureApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISignatureApprovalService) this._Channel).ProcessComputation(this._UserProfile, signatureApproval, parameters, request, out result) : this.AddMethod((Method) new SignatureApprovalMethod(signatureApproval, SignatureApprovalMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) signatureApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((SignatureApproval) null, (SignatureApproval_Parameters) null, (SignatureApproval_Request) null, out SignatureApproval_Result _);
    }

    public ResultStatus ProcessComputation(SignatureApproval signatureApproval)
    {
      return this.ProcessComputation(signatureApproval, (SignatureApproval_Parameters) null, (SignatureApproval_Request) null, out SignatureApproval_Result _);
    }

    public ResultStatus ProcessComputation(
      SignatureApproval signatureApproval,
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      return this.ProcessComputation(signatureApproval, (SignatureApproval_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      SignatureApproval signatureApproval,
      SignatureApproval_Parameters parameters,
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      result = (SignatureApproval_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) signatureApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISignatureApprovalService) this._Channel).ResolveParametricData(this._UserProfile, signatureApproval, parameters, request, out result) : this.AddMethod((Method) new SignatureApprovalMethod(signatureApproval, SignatureApprovalMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) signatureApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((SignatureApproval) null, (SignatureApproval_Parameters) null, (SignatureApproval_Request) null, out SignatureApproval_Result _);
    }

    public ResultStatus ResolveParametricData(SignatureApproval signatureApproval)
    {
      return this.ResolveParametricData(signatureApproval, (SignatureApproval_Parameters) null, (SignatureApproval_Request) null, out SignatureApproval_Result _);
    }

    public ResultStatus ResolveParametricData(
      SignatureApproval signatureApproval,
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      return this.ResolveParametricData(signatureApproval, (SignatureApproval_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject signatureApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SignatureApproval_Result result1;
        ResultStatus parametricData = this.CreateParametricData((SignatureApproval) signatureApproval, (SignatureApproval_Parameters) parameters, (SignatureApproval_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject signatureApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SignatureApproval_Result result1;
        ResultStatus actions = this.GetActions((SignatureApproval) signatureApproval, (SignatureApproval_Parameters) parameters, (SignatureApproval_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject signatureApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SignatureApproval_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((SignatureApproval) signatureApproval, (SignatureApproval_Parameters) parameters, (SignatureApproval_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject signatureApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SignatureApproval_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SignatureApproval) signatureApproval, (SignatureApproval_LoadESigDetails_Parameters) parameters, (SignatureApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject signatureApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SignatureApproval_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((SignatureApproval) signatureApproval, (SignatureApproval_Parameters) parameters, (SignatureApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject signatureApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SignatureApproval_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((SignatureApproval) signatureApproval, (SignatureApproval_Parameters) parameters, (SignatureApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject signatureApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SignatureApproval_Result result1;
        ResultStatus resultStatus = this.Load((SignatureApproval) signatureApproval, (SignatureApproval_Parameters) parameters, (SignatureApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject signatureApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SignatureApproval_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SignatureApproval) signatureApproval, (SignatureApproval_Parameters) parameters, (SignatureApproval_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      result = (SignatureApproval_Result) null;
      try
      {
        SignatureApprovalMethod[] methods = new SignatureApprovalMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISignatureApprovalService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SignatureApproval_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SignatureApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SignatureApproval cdo,
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      result = (SignatureApproval_Result) null;
      try
      {
        return ((ISignatureApprovalService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SignatureApproval_Result result1;
        ResultStatus environment = this.GetEnvironment((SignatureApproval) cdo, (SignatureApproval_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      return this.GetEnvironment((SignatureApproval) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SignatureApproval cdo,
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      result = (SignatureApproval_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISignatureApprovalService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SignatureApprovalMethod(cdo, SignatureApprovalMethods.ExecuteTransaction, (SignatureApproval_Parameters) null));
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
        SignatureApproval_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SignatureApproval) cdo, (SignatureApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SignatureApproval cdo)
    {
      return this.ExecuteTransaction(cdo, (SignatureApproval_Request) null, out SignatureApproval_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SignatureApproval_Request request,
      out SignatureApproval_Result result)
    {
      return this.ExecuteTransaction((SignatureApproval) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SignatureApproval cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SignatureApprovalMethod(cdo, SignatureApprovalMethods.AddDataTransaction, (SignatureApproval_Parameters) null));
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
        return this.AddDataTransaction((SignatureApproval) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
