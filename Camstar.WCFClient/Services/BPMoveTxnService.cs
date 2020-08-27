// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BPMoveTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BPMoveTxnService : BusinessProcessTxnBase
  {
    public BPMoveTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBPMoveTxnService), userProfile);
    }

    public ResultStatus AdditionalValidations(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      result = (BPMoveTxn_Result) null;
      this.OnBeforeCall(nameof (AdditionalValidations), (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveTxnService) this._Channel).AdditionalValidations(this._UserProfile, bPMoveTxn, parameters, request, out result) : this.AddMethod((Method) new BPMoveTxnMethod(bPMoveTxn, BPMoveTxnMethods.AdditionalValidations, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AdditionalValidations), res, (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AdditionalValidations()
    {
      return this.AdditionalValidations((BPMoveTxn) null, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus AdditionalValidations(BPMoveTxn bPMoveTxn)
    {
      return this.AdditionalValidations(bPMoveTxn, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus AdditionalValidations(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      return this.AdditionalValidations(bPMoveTxn, (BPMoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      result = (BPMoveTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveTxnService) this._Channel).CreateParametricData(this._UserProfile, bPMoveTxn, parameters, request, out result) : this.AddMethod((Method) new BPMoveTxnMethod(bPMoveTxn, BPMoveTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((BPMoveTxn) null, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus CreateParametricData(BPMoveTxn bPMoveTxn)
    {
      return this.CreateParametricData(bPMoveTxn, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      return this.CreateParametricData(bPMoveTxn, (BPMoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      result = (BPMoveTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveTxnService) this._Channel).GetActions(this._UserProfile, bPMoveTxn, parameters, request, out result) : this.AddMethod((Method) new BPMoveTxnMethod(bPMoveTxn, BPMoveTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((BPMoveTxn) null, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus GetActions(BPMoveTxn bPMoveTxn)
    {
      return this.GetActions(bPMoveTxn, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus GetActions(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      return this.GetActions(bPMoveTxn, (BPMoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      result = (BPMoveTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveTxnService) this._Channel).GetDataPoints(this._UserProfile, bPMoveTxn, parameters, request, out result) : this.AddMethod((Method) new BPMoveTxnMethod(bPMoveTxn, BPMoveTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((BPMoveTxn) null, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus GetDataPoints(BPMoveTxn bPMoveTxn)
    {
      return this.GetDataPoints(bPMoveTxn, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      return this.GetDataPoints(bPMoveTxn, (BPMoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      result = (BPMoveTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveTxnService) this._Channel).GetWIPMsgs(this._UserProfile, bPMoveTxn, parameters, request, out result) : this.AddMethod((Method) new BPMoveTxnMethod(bPMoveTxn, BPMoveTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BPMoveTxn) null, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(BPMoveTxn bPMoveTxn)
    {
      return this.GetWIPMsgs(bPMoveTxn, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      return this.GetWIPMsgs(bPMoveTxn, (BPMoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      result = (BPMoveTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveTxnService) this._Channel).Load(this._UserProfile, bPMoveTxn, parameters, request, out result) : this.AddMethod((Method) new BPMoveTxnMethod(bPMoveTxn, BPMoveTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BPMoveTxn) null, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus Load(BPMoveTxn bPMoveTxn)
    {
      return this.Load(bPMoveTxn, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus Load(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      return this.Load(bPMoveTxn, (BPMoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_LoadESigDetails_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      result = (BPMoveTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveTxnService) this._Channel).LoadESigDetails(this._UserProfile, bPMoveTxn, parameters, request, out result) : this.AddMethod((Method) new BPMoveTxnMethod(bPMoveTxn, BPMoveTxnMethods.LoadESigDetails, (BPMoveTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BPMoveTxn) null, (BPMoveTxn_LoadESigDetails_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus LoadESigDetails(BPMoveTxn bPMoveTxn)
    {
      return this.LoadESigDetails(bPMoveTxn, (BPMoveTxn_LoadESigDetails_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      return this.LoadESigDetails(bPMoveTxn, (BPMoveTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      result = (BPMoveTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveTxnService) this._Channel).ProcessComputation(this._UserProfile, bPMoveTxn, parameters, request, out result) : this.AddMethod((Method) new BPMoveTxnMethod(bPMoveTxn, BPMoveTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((BPMoveTxn) null, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus ProcessComputation(BPMoveTxn bPMoveTxn)
    {
      return this.ProcessComputation(bPMoveTxn, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      return this.ProcessComputation(bPMoveTxn, (BPMoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      result = (BPMoveTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveTxnService) this._Channel).ResolveParametricData(this._UserProfile, bPMoveTxn, parameters, request, out result) : this.AddMethod((Method) new BPMoveTxnMethod(bPMoveTxn, BPMoveTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((BPMoveTxn) null, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus ResolveParametricData(BPMoveTxn bPMoveTxn)
    {
      return this.ResolveParametricData(bPMoveTxn, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      return this.ResolveParametricData(bPMoveTxn, (BPMoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidatePath(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      result = (BPMoveTxn_Result) null;
      this.OnBeforeCall(nameof (ValidatePath), (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveTxnService) this._Channel).ValidatePath(this._UserProfile, bPMoveTxn, parameters, request, out result) : this.AddMethod((Method) new BPMoveTxnMethod(bPMoveTxn, BPMoveTxnMethods.ValidatePath, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidatePath), res, (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidatePath()
    {
      return this.ValidatePath((BPMoveTxn) null, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus ValidatePath(BPMoveTxn bPMoveTxn)
    {
      return this.ValidatePath(bPMoveTxn, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus ValidatePath(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      return this.ValidatePath(bPMoveTxn, (BPMoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidatePathToStepExists(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      result = (BPMoveTxn_Result) null;
      this.OnBeforeCall(nameof (ValidatePathToStepExists), (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveTxnService) this._Channel).ValidatePathToStepExists(this._UserProfile, bPMoveTxn, parameters, request, out result) : this.AddMethod((Method) new BPMoveTxnMethod(bPMoveTxn, BPMoveTxnMethods.ValidatePathToStepExists, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidatePathToStepExists), res, (DCObject) bPMoveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidatePathToStepExists()
    {
      return this.ValidatePathToStepExists((BPMoveTxn) null, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus ValidatePathToStepExists(BPMoveTxn bPMoveTxn)
    {
      return this.ValidatePathToStepExists(bPMoveTxn, (BPMoveTxn_Parameters) null, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus ValidatePathToStepExists(
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      return this.ValidatePathToStepExists(bPMoveTxn, (BPMoveTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject bPMoveTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((BPMoveTxn) bPMoveTxn, (BPMoveTxn_Parameters) parameters, (BPMoveTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject bPMoveTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveTxn_Result result1;
        ResultStatus actions = this.GetActions((BPMoveTxn) bPMoveTxn, (BPMoveTxn_Parameters) parameters, (BPMoveTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject bPMoveTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((BPMoveTxn) bPMoveTxn, (BPMoveTxn_Parameters) parameters, (BPMoveTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject bPMoveTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BPMoveTxn) bPMoveTxn, (BPMoveTxn_LoadESigDetails_Parameters) parameters, (BPMoveTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject bPMoveTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((BPMoveTxn) bPMoveTxn, (BPMoveTxn_Parameters) parameters, (BPMoveTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject bPMoveTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((BPMoveTxn) bPMoveTxn, (BPMoveTxn_Parameters) parameters, (BPMoveTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject bPMoveTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveTxn_Result result1;
        ResultStatus resultStatus = this.Load((BPMoveTxn) bPMoveTxn, (BPMoveTxn_Parameters) parameters, (BPMoveTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject bPMoveTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BPMoveTxn) bPMoveTxn, (BPMoveTxn_Parameters) parameters, (BPMoveTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      result = (BPMoveTxn_Result) null;
      try
      {
        BPMoveTxnMethod[] methods = new BPMoveTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBPMoveTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BPMoveTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BPMoveTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BPMoveTxn cdo,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      result = (BPMoveTxn_Result) null;
      try
      {
        return ((IBPMoveTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BPMoveTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((BPMoveTxn) cdo, (BPMoveTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      return this.GetEnvironment((BPMoveTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BPMoveTxn cdo,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      result = (BPMoveTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BPMoveTxnMethod(cdo, BPMoveTxnMethods.ExecuteTransaction, (BPMoveTxn_Parameters) null));
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
        BPMoveTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BPMoveTxn) cdo, (BPMoveTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BPMoveTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (BPMoveTxn_Request) null, out BPMoveTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result)
    {
      return this.ExecuteTransaction((BPMoveTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BPMoveTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BPMoveTxnMethod(cdo, BPMoveTxnMethods.AddDataTransaction, (BPMoveTxn_Parameters) null));
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
        return this.AddDataTransaction((BPMoveTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
