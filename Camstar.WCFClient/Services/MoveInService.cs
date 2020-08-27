// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MoveInService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MoveInService : ContainerTxnBase
  {
    public MoveInService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMoveInService), userProfile);
    }

    public ResultStatus AssignCellContainerClearance(
      MoveIn moveIn,
      MoveIn_AssignCellContainerClearance_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      result = (MoveIn_Result) null;
      this.OnBeforeCall(nameof (AssignCellContainerClearance), (DCObject) moveIn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveInService) this._Channel).AssignCellContainerClearance(this._UserProfile, moveIn, parameters, request, out result) : this.AddMethod((Method) new MoveInMethod(moveIn, MoveInMethods.AssignCellContainerClearance, (MoveIn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AssignCellContainerClearance), res, (DCObject) moveIn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AssignCellContainerClearance()
    {
      return this.AssignCellContainerClearance((MoveIn) null, (MoveIn_AssignCellContainerClearance_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus AssignCellContainerClearance(MoveIn moveIn)
    {
      return this.AssignCellContainerClearance(moveIn, (MoveIn_AssignCellContainerClearance_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus AssignCellContainerClearance(
      MoveIn moveIn,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      return this.AssignCellContainerClearance(moveIn, (MoveIn_AssignCellContainerClearance_Parameters) null, request, out result);
    }

    public ResultStatus AssignCellMfgOrderClearance(
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      result = (MoveIn_Result) null;
      this.OnBeforeCall(nameof (AssignCellMfgOrderClearance), (DCObject) moveIn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveInService) this._Channel).AssignCellMfgOrderClearance(this._UserProfile, moveIn, parameters, request, out result) : this.AddMethod((Method) new MoveInMethod(moveIn, MoveInMethods.AssignCellMfgOrderClearance, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AssignCellMfgOrderClearance), res, (DCObject) moveIn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AssignCellMfgOrderClearance()
    {
      return this.AssignCellMfgOrderClearance((MoveIn) null, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus AssignCellMfgOrderClearance(MoveIn moveIn)
    {
      return this.AssignCellMfgOrderClearance(moveIn, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus AssignCellMfgOrderClearance(
      MoveIn moveIn,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      return this.AssignCellMfgOrderClearance(moveIn, (MoveIn_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      result = (MoveIn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) moveIn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveInService) this._Channel).CreateParametricData(this._UserProfile, moveIn, parameters, request, out result) : this.AddMethod((Method) new MoveInMethod(moveIn, MoveInMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) moveIn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((MoveIn) null, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus CreateParametricData(MoveIn moveIn)
    {
      return this.CreateParametricData(moveIn, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus CreateParametricData(
      MoveIn moveIn,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      return this.CreateParametricData(moveIn, (MoveIn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      result = (MoveIn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) moveIn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveInService) this._Channel).GetActions(this._UserProfile, moveIn, parameters, request, out result) : this.AddMethod((Method) new MoveInMethod(moveIn, MoveInMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) moveIn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((MoveIn) null, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus GetActions(MoveIn moveIn)
    {
      return this.GetActions(moveIn, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus GetActions(
      MoveIn moveIn,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      return this.GetActions(moveIn, (MoveIn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      result = (MoveIn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) moveIn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveInService) this._Channel).GetDataPoints(this._UserProfile, moveIn, parameters, request, out result) : this.AddMethod((Method) new MoveInMethod(moveIn, MoveInMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) moveIn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((MoveIn) null, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus GetDataPoints(MoveIn moveIn)
    {
      return this.GetDataPoints(moveIn, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus GetDataPoints(
      MoveIn moveIn,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      return this.GetDataPoints(moveIn, (MoveIn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      result = (MoveIn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) moveIn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveInService) this._Channel).GetWIPMsgs(this._UserProfile, moveIn, parameters, request, out result) : this.AddMethod((Method) new MoveInMethod(moveIn, MoveInMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) moveIn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MoveIn) null, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus GetWIPMsgs(MoveIn moveIn)
    {
      return this.GetWIPMsgs(moveIn, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MoveIn moveIn,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      return this.GetWIPMsgs(moveIn, (MoveIn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      result = (MoveIn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) moveIn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveInService) this._Channel).Load(this._UserProfile, moveIn, parameters, request, out result) : this.AddMethod((Method) new MoveInMethod(moveIn, MoveInMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) moveIn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MoveIn) null, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus Load(MoveIn moveIn)
    {
      return this.Load(moveIn, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus Load(
      MoveIn moveIn,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      return this.Load(moveIn, (MoveIn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MoveIn moveIn,
      MoveIn_LoadESigDetails_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      result = (MoveIn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) moveIn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveInService) this._Channel).LoadESigDetails(this._UserProfile, moveIn, parameters, request, out result) : this.AddMethod((Method) new MoveInMethod(moveIn, MoveInMethods.LoadESigDetails, (MoveIn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) moveIn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MoveIn) null, (MoveIn_LoadESigDetails_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus LoadESigDetails(MoveIn moveIn)
    {
      return this.LoadESigDetails(moveIn, (MoveIn_LoadESigDetails_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus LoadESigDetails(
      MoveIn moveIn,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      return this.LoadESigDetails(moveIn, (MoveIn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      result = (MoveIn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) moveIn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveInService) this._Channel).ProcessComputation(this._UserProfile, moveIn, parameters, request, out result) : this.AddMethod((Method) new MoveInMethod(moveIn, MoveInMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) moveIn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((MoveIn) null, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus ProcessComputation(MoveIn moveIn)
    {
      return this.ProcessComputation(moveIn, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus ProcessComputation(
      MoveIn moveIn,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      return this.ProcessComputation(moveIn, (MoveIn_Parameters) null, request, out result);
    }

    public ResultStatus RejectNonconformingMtl(
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      result = (MoveIn_Result) null;
      this.OnBeforeCall(nameof (RejectNonconformingMtl), (DCObject) moveIn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveInService) this._Channel).RejectNonconformingMtl(this._UserProfile, moveIn, parameters, request, out result) : this.AddMethod((Method) new MoveInMethod(moveIn, MoveInMethods.RejectNonconformingMtl, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (RejectNonconformingMtl), res, (DCObject) moveIn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus RejectNonconformingMtl()
    {
      return this.RejectNonconformingMtl((MoveIn) null, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus RejectNonconformingMtl(MoveIn moveIn)
    {
      return this.RejectNonconformingMtl(moveIn, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus RejectNonconformingMtl(
      MoveIn moveIn,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      return this.RejectNonconformingMtl(moveIn, (MoveIn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      result = (MoveIn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) moveIn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveInService) this._Channel).ResolveParametricData(this._UserProfile, moveIn, parameters, request, out result) : this.AddMethod((Method) new MoveInMethod(moveIn, MoveInMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) moveIn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((MoveIn) null, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus ResolveParametricData(MoveIn moveIn)
    {
      return this.ResolveParametricData(moveIn, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus ResolveParametricData(
      MoveIn moveIn,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      return this.ResolveParametricData(moveIn, (MoveIn_Parameters) null, request, out result);
    }

    public ResultStatus ValidateCellContainerClearance(
      MoveIn moveIn,
      MoveIn_ValidateCellContainerClearance_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      result = (MoveIn_Result) null;
      this.OnBeforeCall(nameof (ValidateCellContainerClearance), (DCObject) moveIn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveInService) this._Channel).ValidateCellContainerClearance(this._UserProfile, moveIn, parameters, request, out result) : this.AddMethod((Method) new MoveInMethod(moveIn, MoveInMethods.ValidateCellContainerClearance, (MoveIn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateCellContainerClearance), res, (DCObject) moveIn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateCellContainerClearance()
    {
      return this.ValidateCellContainerClearance((MoveIn) null, (MoveIn_ValidateCellContainerClearance_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus ValidateCellContainerClearance(MoveIn moveIn)
    {
      return this.ValidateCellContainerClearance(moveIn, (MoveIn_ValidateCellContainerClearance_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus ValidateCellContainerClearance(
      MoveIn moveIn,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      return this.ValidateCellContainerClearance(moveIn, (MoveIn_ValidateCellContainerClearance_Parameters) null, request, out result);
    }

    public ResultStatus ValidateCellMfgOrderClearance(
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      result = (MoveIn_Result) null;
      this.OnBeforeCall(nameof (ValidateCellMfgOrderClearance), (DCObject) moveIn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveInService) this._Channel).ValidateCellMfgOrderClearance(this._UserProfile, moveIn, parameters, request, out result) : this.AddMethod((Method) new MoveInMethod(moveIn, MoveInMethods.ValidateCellMfgOrderClearance, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateCellMfgOrderClearance), res, (DCObject) moveIn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateCellMfgOrderClearance()
    {
      return this.ValidateCellMfgOrderClearance((MoveIn) null, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus ValidateCellMfgOrderClearance(MoveIn moveIn)
    {
      return this.ValidateCellMfgOrderClearance(moveIn, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus ValidateCellMfgOrderClearance(
      MoveIn moveIn,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      return this.ValidateCellMfgOrderClearance(moveIn, (MoveIn_Parameters) null, request, out result);
    }

    public ResultStatus ValidateQueueTime(
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      result = (MoveIn_Result) null;
      this.OnBeforeCall(nameof (ValidateQueueTime), (DCObject) moveIn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveInService) this._Channel).ValidateQueueTime(this._UserProfile, moveIn, parameters, request, out result) : this.AddMethod((Method) new MoveInMethod(moveIn, MoveInMethods.ValidateQueueTime, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateQueueTime), res, (DCObject) moveIn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateQueueTime()
    {
      return this.ValidateQueueTime((MoveIn) null, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus ValidateQueueTime(MoveIn moveIn)
    {
      return this.ValidateQueueTime(moveIn, (MoveIn_Parameters) null, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus ValidateQueueTime(
      MoveIn moveIn,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      return this.ValidateQueueTime(moveIn, (MoveIn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject moveIn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveIn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((MoveIn) moveIn, (MoveIn_Parameters) parameters, (MoveIn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject moveIn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveIn_Result result1;
        ResultStatus actions = this.GetActions((MoveIn) moveIn, (MoveIn_Parameters) parameters, (MoveIn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject moveIn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveIn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((MoveIn) moveIn, (MoveIn_Parameters) parameters, (MoveIn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject moveIn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveIn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MoveIn) moveIn, (MoveIn_LoadESigDetails_Parameters) parameters, (MoveIn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject moveIn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveIn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((MoveIn) moveIn, (MoveIn_Parameters) parameters, (MoveIn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject moveIn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveIn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((MoveIn) moveIn, (MoveIn_Parameters) parameters, (MoveIn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject moveIn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveIn_Result result1;
        ResultStatus resultStatus = this.Load((MoveIn) moveIn, (MoveIn_Parameters) parameters, (MoveIn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject moveIn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveIn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MoveIn) moveIn, (MoveIn_Parameters) parameters, (MoveIn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      result = (MoveIn_Result) null;
      try
      {
        MoveInMethod[] methods = new MoveInMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMoveInService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MoveIn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MoveIn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveIn cdo,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      result = (MoveIn_Result) null;
      try
      {
        return ((IMoveInService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MoveIn_Result result1;
        ResultStatus environment = this.GetEnvironment((MoveIn) cdo, (MoveIn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(MoveIn_Request request, out MoveIn_Result result)
    {
      return this.GetEnvironment((MoveIn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MoveIn cdo,
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      result = (MoveIn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveInService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MoveInMethod(cdo, MoveInMethods.ExecuteTransaction, (MoveIn_Parameters) null));
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
        MoveIn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MoveIn) cdo, (MoveIn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MoveIn cdo)
    {
      return this.ExecuteTransaction(cdo, (MoveIn_Request) null, out MoveIn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MoveIn_Request request,
      out MoveIn_Result result)
    {
      return this.ExecuteTransaction((MoveIn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MoveIn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MoveInMethod(cdo, MoveInMethods.AddDataTransaction, (MoveIn_Parameters) null));
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
        return this.AddDataTransaction((MoveIn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
