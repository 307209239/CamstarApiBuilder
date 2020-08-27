// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MoveStdService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MoveStdService : MoveTxnBase
  {
    public MoveStdService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMoveStdService), userProfile);
    }

    public ResultStatus CreateParametricData(
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      result = (MoveStd_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) moveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdService) this._Channel).CreateParametricData(this._UserProfile, moveStd, parameters, request, out result) : this.AddMethod((Method) new MoveStdMethod(moveStd, MoveStdMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) moveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((MoveStd) null, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus CreateParametricData(MoveStd moveStd)
    {
      return this.CreateParametricData(moveStd, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus CreateParametricData(
      MoveStd moveStd,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      return this.CreateParametricData(moveStd, (MoveStd_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      result = (MoveStd_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) moveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdService) this._Channel).GetActions(this._UserProfile, moveStd, parameters, request, out result) : this.AddMethod((Method) new MoveStdMethod(moveStd, MoveStdMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) moveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((MoveStd) null, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus GetActions(MoveStd moveStd)
    {
      return this.GetActions(moveStd, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus GetActions(
      MoveStd moveStd,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      return this.GetActions(moveStd, (MoveStd_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      result = (MoveStd_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) moveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdService) this._Channel).GetDataPoints(this._UserProfile, moveStd, parameters, request, out result) : this.AddMethod((Method) new MoveStdMethod(moveStd, MoveStdMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) moveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((MoveStd) null, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus GetDataPoints(MoveStd moveStd)
    {
      return this.GetDataPoints(moveStd, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus GetDataPoints(
      MoveStd moveStd,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      return this.GetDataPoints(moveStd, (MoveStd_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      result = (MoveStd_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) moveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdService) this._Channel).GetWIPMsgs(this._UserProfile, moveStd, parameters, request, out result) : this.AddMethod((Method) new MoveStdMethod(moveStd, MoveStdMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) moveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MoveStd) null, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus GetWIPMsgs(MoveStd moveStd)
    {
      return this.GetWIPMsgs(moveStd, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MoveStd moveStd,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      return this.GetWIPMsgs(moveStd, (MoveStd_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      result = (MoveStd_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) moveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdService) this._Channel).Load(this._UserProfile, moveStd, parameters, request, out result) : this.AddMethod((Method) new MoveStdMethod(moveStd, MoveStdMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) moveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MoveStd) null, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus Load(MoveStd moveStd)
    {
      return this.Load(moveStd, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus Load(
      MoveStd moveStd,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      return this.Load(moveStd, (MoveStd_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MoveStd moveStd,
      MoveStd_LoadESigDetails_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      result = (MoveStd_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) moveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdService) this._Channel).LoadESigDetails(this._UserProfile, moveStd, parameters, request, out result) : this.AddMethod((Method) new MoveStdMethod(moveStd, MoveStdMethods.LoadESigDetails, (MoveStd_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) moveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MoveStd) null, (MoveStd_LoadESigDetails_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus LoadESigDetails(MoveStd moveStd)
    {
      return this.LoadESigDetails(moveStd, (MoveStd_LoadESigDetails_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus LoadESigDetails(
      MoveStd moveStd,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      return this.LoadESigDetails(moveStd, (MoveStd_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus MoveStd_LotSamplingValidations(
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      result = (MoveStd_Result) null;
      this.OnBeforeCall(nameof (MoveStd_LotSamplingValidations), (DCObject) moveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdService) this._Channel).MoveStd_LotSamplingValidations(this._UserProfile, moveStd, parameters, request, out result) : this.AddMethod((Method) new MoveStdMethod(moveStd, MoveStdMethods.MoveStd_LotSamplingValidations, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (MoveStd_LotSamplingValidations), res, (DCObject) moveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus MoveStd_LotSamplingValidations()
    {
      return this.MoveStd_LotSamplingValidations((MoveStd) null, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus MoveStd_LotSamplingValidations(MoveStd moveStd)
    {
      return this.MoveStd_LotSamplingValidations(moveStd, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus MoveStd_LotSamplingValidations(
      MoveStd moveStd,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      return this.MoveStd_LotSamplingValidations(moveStd, (MoveStd_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      result = (MoveStd_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) moveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdService) this._Channel).ProcessComputation(this._UserProfile, moveStd, parameters, request, out result) : this.AddMethod((Method) new MoveStdMethod(moveStd, MoveStdMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) moveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((MoveStd) null, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus ProcessComputation(MoveStd moveStd)
    {
      return this.ProcessComputation(moveStd, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus ProcessComputation(
      MoveStd moveStd,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      return this.ProcessComputation(moveStd, (MoveStd_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      result = (MoveStd_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) moveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdService) this._Channel).ResolveParametricData(this._UserProfile, moveStd, parameters, request, out result) : this.AddMethod((Method) new MoveStdMethod(moveStd, MoveStdMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) moveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((MoveStd) null, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus ResolveParametricData(MoveStd moveStd)
    {
      return this.ResolveParametricData(moveStd, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus ResolveParametricData(
      MoveStd moveStd,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      return this.ResolveParametricData(moveStd, (MoveStd_Parameters) null, request, out result);
    }

    public ResultStatus Sampling_MoveValidations(
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      result = (MoveStd_Result) null;
      this.OnBeforeCall(nameof (Sampling_MoveValidations), (DCObject) moveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdService) this._Channel).Sampling_MoveValidations(this._UserProfile, moveStd, parameters, request, out result) : this.AddMethod((Method) new MoveStdMethod(moveStd, MoveStdMethods.Sampling_MoveValidations, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Sampling_MoveValidations), res, (DCObject) moveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Sampling_MoveValidations()
    {
      return this.Sampling_MoveValidations((MoveStd) null, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus Sampling_MoveValidations(MoveStd moveStd)
    {
      return this.Sampling_MoveValidations(moveStd, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus Sampling_MoveValidations(
      MoveStd moveStd,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      return this.Sampling_MoveValidations(moveStd, (MoveStd_Parameters) null, request, out result);
    }

    public ResultStatus SamplingValidation(
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      result = (MoveStd_Result) null;
      this.OnBeforeCall(nameof (SamplingValidation), (DCObject) moveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdService) this._Channel).SamplingValidation(this._UserProfile, moveStd, parameters, request, out result) : this.AddMethod((Method) new MoveStdMethod(moveStd, MoveStdMethods.SamplingValidation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SamplingValidation), res, (DCObject) moveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SamplingValidation()
    {
      return this.SamplingValidation((MoveStd) null, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus SamplingValidation(MoveStd moveStd)
    {
      return this.SamplingValidation(moveStd, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus SamplingValidation(
      MoveStd moveStd,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      return this.SamplingValidation(moveStd, (MoveStd_Parameters) null, request, out result);
    }

    public ResultStatus ValidateEProcedure(
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      result = (MoveStd_Result) null;
      this.OnBeforeCall(nameof (ValidateEProcedure), (DCObject) moveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdService) this._Channel).ValidateEProcedure(this._UserProfile, moveStd, parameters, request, out result) : this.AddMethod((Method) new MoveStdMethod(moveStd, MoveStdMethods.ValidateEProcedure, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateEProcedure), res, (DCObject) moveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateEProcedure()
    {
      return this.ValidateEProcedure((MoveStd) null, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus ValidateEProcedure(MoveStd moveStd)
    {
      return this.ValidateEProcedure(moveStd, (MoveStd_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus ValidateEProcedure(
      MoveStd moveStd,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      return this.ValidateEProcedure(moveStd, (MoveStd_Parameters) null, request, out result);
    }

    public ResultStatus ValidateTaskComplete(
      MoveStd moveStd,
      MoveStd_ValidateTaskComplete_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      result = (MoveStd_Result) null;
      this.OnBeforeCall(nameof (ValidateTaskComplete), (DCObject) moveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdService) this._Channel).ValidateTaskComplete(this._UserProfile, moveStd, parameters, request, out result) : this.AddMethod((Method) new MoveStdMethod(moveStd, MoveStdMethods.ValidateTaskComplete, (MoveStd_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateTaskComplete), res, (DCObject) moveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateTaskComplete()
    {
      return this.ValidateTaskComplete((MoveStd) null, (MoveStd_ValidateTaskComplete_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus ValidateTaskComplete(MoveStd moveStd)
    {
      return this.ValidateTaskComplete(moveStd, (MoveStd_ValidateTaskComplete_Parameters) null, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus ValidateTaskComplete(
      MoveStd moveStd,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      return this.ValidateTaskComplete(moveStd, (MoveStd_ValidateTaskComplete_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject moveStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveStd_Result result1;
        ResultStatus parametricData = this.CreateParametricData((MoveStd) moveStd, (MoveStd_Parameters) parameters, (MoveStd_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject moveStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveStd_Result result1;
        ResultStatus actions = this.GetActions((MoveStd) moveStd, (MoveStd_Parameters) parameters, (MoveStd_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject moveStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveStd_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((MoveStd) moveStd, (MoveStd_Parameters) parameters, (MoveStd_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject moveStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveStd_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MoveStd) moveStd, (MoveStd_LoadESigDetails_Parameters) parameters, (MoveStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject moveStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveStd_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((MoveStd) moveStd, (MoveStd_Parameters) parameters, (MoveStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject moveStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveStd_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((MoveStd) moveStd, (MoveStd_Parameters) parameters, (MoveStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject moveStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveStd_Result result1;
        ResultStatus resultStatus = this.Load((MoveStd) moveStd, (MoveStd_Parameters) parameters, (MoveStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject moveStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveStd_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MoveStd) moveStd, (MoveStd_Parameters) parameters, (MoveStd_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      result = (MoveStd_Result) null;
      try
      {
        MoveStdMethod[] methods = new MoveStdMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMoveStdService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MoveStd_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MoveStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveStd cdo,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      result = (MoveStd_Result) null;
      try
      {
        return ((IMoveStdService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MoveStd_Result result1;
        ResultStatus environment = this.GetEnvironment((MoveStd) cdo, (MoveStd_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      return this.GetEnvironment((MoveStd) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MoveStd cdo,
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      result = (MoveStd_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MoveStdMethod(cdo, MoveStdMethods.ExecuteTransaction, (MoveStd_Parameters) null));
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
        MoveStd_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MoveStd) cdo, (MoveStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MoveStd cdo)
    {
      return this.ExecuteTransaction(cdo, (MoveStd_Request) null, out MoveStd_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MoveStd_Request request,
      out MoveStd_Result result)
    {
      return this.ExecuteTransaction((MoveStd) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MoveStd cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MoveStdMethod(cdo, MoveStdMethods.AddDataTransaction, (MoveStd_Parameters) null));
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
        return this.AddDataTransaction((MoveStd) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
