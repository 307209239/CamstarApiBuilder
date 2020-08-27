// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MoveTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MoveTxnService : ContainerTxnBase
  {
    public MoveTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMoveTxnService), userProfile);
    }

    public ResultStatus AdditionalValidations(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (AdditionalValidations), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).AdditionalValidations(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.AdditionalValidations, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AdditionalValidations), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AdditionalValidations()
    {
      return this.AdditionalValidations((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus AdditionalValidations(MoveTxn moveTxn)
    {
      return this.AdditionalValidations(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus AdditionalValidations(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.AdditionalValidations(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus AssignCellContainerClearance(
      MoveTxn moveTxn,
      MoveTxn_AssignCellContainerClearance_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (AssignCellContainerClearance), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).AssignCellContainerClearance(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.AssignCellContainerClearance, (MoveTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AssignCellContainerClearance), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AssignCellContainerClearance()
    {
      return this.AssignCellContainerClearance((MoveTxn) null, (MoveTxn_AssignCellContainerClearance_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus AssignCellContainerClearance(MoveTxn moveTxn)
    {
      return this.AssignCellContainerClearance(moveTxn, (MoveTxn_AssignCellContainerClearance_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus AssignCellContainerClearance(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.AssignCellContainerClearance(moveTxn, (MoveTxn_AssignCellContainerClearance_Parameters) null, request, out result);
    }

    public ResultStatus AssignCellMfgOrderClearance(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (AssignCellMfgOrderClearance), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).AssignCellMfgOrderClearance(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.AssignCellMfgOrderClearance, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AssignCellMfgOrderClearance), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AssignCellMfgOrderClearance()
    {
      return this.AssignCellMfgOrderClearance((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus AssignCellMfgOrderClearance(MoveTxn moveTxn)
    {
      return this.AssignCellMfgOrderClearance(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus AssignCellMfgOrderClearance(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.AssignCellMfgOrderClearance(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus ClearCompletedTasks(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (ClearCompletedTasks), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).ClearCompletedTasks(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.ClearCompletedTasks, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ClearCompletedTasks), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ClearCompletedTasks()
    {
      return this.ClearCompletedTasks((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ClearCompletedTasks(MoveTxn moveTxn)
    {
      return this.ClearCompletedTasks(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ClearCompletedTasks(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.ClearCompletedTasks(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).CreateParametricData(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus CreateParametricData(MoveTxn moveTxn)
    {
      return this.CreateParametricData(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.CreateParametricData(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus Execute_Move_Specific(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (Execute_Move_Specific), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).Execute_Move_Specific(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.Execute_Move_Specific, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Execute_Move_Specific), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Execute_Move_Specific()
    {
      return this.Execute_Move_Specific((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus Execute_Move_Specific(MoveTxn moveTxn)
    {
      return this.Execute_Move_Specific(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus Execute_Move_Specific(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.Execute_Move_Specific(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus FreezeFromState(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (FreezeFromState), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).FreezeFromState(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.FreezeFromState, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (FreezeFromState), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus FreezeFromState()
    {
      return this.FreezeFromState((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus FreezeFromState(MoveTxn moveTxn)
    {
      return this.FreezeFromState(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus FreezeFromState(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.FreezeFromState(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).GetActions(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus GetActions(MoveTxn moveTxn)
    {
      return this.GetActions(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus GetActions(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.GetActions(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).GetDataPoints(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus GetDataPoints(MoveTxn moveTxn)
    {
      return this.GetDataPoints(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.GetDataPoints(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).GetWIPMsgs(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(MoveTxn moveTxn)
    {
      return this.GetWIPMsgs(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.GetWIPMsgs(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).Load(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus Load(MoveTxn moveTxn)
    {
      return this.Load(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus Load(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.Load(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MoveTxn moveTxn,
      MoveTxn_LoadESigDetails_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).LoadESigDetails(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.LoadESigDetails, (MoveTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MoveTxn) null, (MoveTxn_LoadESigDetails_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus LoadESigDetails(MoveTxn moveTxn)
    {
      return this.LoadESigDetails(moveTxn, (MoveTxn_LoadESigDetails_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.LoadESigDetails(moveTxn, (MoveTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).ProcessComputation(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ProcessComputation(MoveTxn moveTxn)
    {
      return this.ProcessComputation(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.ProcessComputation(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus ProcessElectronicProceduresPreMove(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessElectronicProceduresPreMove), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).ProcessElectronicProceduresPreMove(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.ProcessElectronicProceduresPreMove, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessElectronicProceduresPreMove), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessElectronicProceduresPreMove()
    {
      return this.ProcessElectronicProceduresPreMove((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ProcessElectronicProceduresPreMove(MoveTxn moveTxn)
    {
      return this.ProcessElectronicProceduresPreMove(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ProcessElectronicProceduresPreMove(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.ProcessElectronicProceduresPreMove(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus RejectNonconformingMtl(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (RejectNonconformingMtl), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).RejectNonconformingMtl(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.RejectNonconformingMtl, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (RejectNonconformingMtl), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus RejectNonconformingMtl()
    {
      return this.RejectNonconformingMtl((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus RejectNonconformingMtl(MoveTxn moveTxn)
    {
      return this.RejectNonconformingMtl(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus RejectNonconformingMtl(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.RejectNonconformingMtl(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).ResolveParametricData(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ResolveParametricData(MoveTxn moveTxn)
    {
      return this.ResolveParametricData(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.ResolveParametricData(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus UpdateFromStepPass(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (UpdateFromStepPass), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).UpdateFromStepPass(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.UpdateFromStepPass, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UpdateFromStepPass), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UpdateFromStepPass()
    {
      return this.UpdateFromStepPass((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus UpdateFromStepPass(MoveTxn moveTxn)
    {
      return this.UpdateFromStepPass(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus UpdateFromStepPass(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.UpdateFromStepPass(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus UpdateToStepPass(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (UpdateToStepPass), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).UpdateToStepPass(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.UpdateToStepPass, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UpdateToStepPass), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UpdateToStepPass()
    {
      return this.UpdateToStepPass((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus UpdateToStepPass(MoveTxn moveTxn)
    {
      return this.UpdateToStepPass(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus UpdateToStepPass(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.UpdateToStepPass(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidateCellContainerClearance(
      MoveTxn moveTxn,
      MoveTxn_ValidateCellContainerClearance_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (ValidateCellContainerClearance), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).ValidateCellContainerClearance(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.ValidateCellContainerClearance, (MoveTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateCellContainerClearance), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateCellContainerClearance()
    {
      return this.ValidateCellContainerClearance((MoveTxn) null, (MoveTxn_ValidateCellContainerClearance_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ValidateCellContainerClearance(MoveTxn moveTxn)
    {
      return this.ValidateCellContainerClearance(moveTxn, (MoveTxn_ValidateCellContainerClearance_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ValidateCellContainerClearance(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.ValidateCellContainerClearance(moveTxn, (MoveTxn_ValidateCellContainerClearance_Parameters) null, request, out result);
    }

    public ResultStatus ValidateCellMfgOrderClearance(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (ValidateCellMfgOrderClearance), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).ValidateCellMfgOrderClearance(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.ValidateCellMfgOrderClearance, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateCellMfgOrderClearance), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateCellMfgOrderClearance()
    {
      return this.ValidateCellMfgOrderClearance((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ValidateCellMfgOrderClearance(MoveTxn moveTxn)
    {
      return this.ValidateCellMfgOrderClearance(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ValidateCellMfgOrderClearance(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.ValidateCellMfgOrderClearance(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidateContainerInProcess(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (ValidateContainerInProcess), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).ValidateContainerInProcess(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.ValidateContainerInProcess, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateContainerInProcess), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateContainerInProcess()
    {
      return this.ValidateContainerInProcess((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ValidateContainerInProcess(MoveTxn moveTxn)
    {
      return this.ValidateContainerInProcess(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ValidateContainerInProcess(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.ValidateContainerInProcess(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidatePath(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (ValidatePath), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).ValidatePath(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.ValidatePath, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidatePath), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidatePath()
    {
      return this.ValidatePath((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ValidatePath(MoveTxn moveTxn)
    {
      return this.ValidatePath(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ValidatePath(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.ValidatePath(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidatePathToStepExists(
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (ValidatePathToStepExists), (DCObject) moveTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).ValidatePathToStepExists(this._UserProfile, moveTxn, parameters, request, out result) : this.AddMethod((Method) new MoveTxnMethod(moveTxn, MoveTxnMethods.ValidatePathToStepExists, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidatePathToStepExists), res, (DCObject) moveTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidatePathToStepExists()
    {
      return this.ValidatePathToStepExists((MoveTxn) null, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ValidatePathToStepExists(MoveTxn moveTxn)
    {
      return this.ValidatePathToStepExists(moveTxn, (MoveTxn_Parameters) null, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ValidatePathToStepExists(
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.ValidatePathToStepExists(moveTxn, (MoveTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject moveTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((MoveTxn) moveTxn, (MoveTxn_Parameters) parameters, (MoveTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject moveTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveTxn_Result result1;
        ResultStatus actions = this.GetActions((MoveTxn) moveTxn, (MoveTxn_Parameters) parameters, (MoveTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject moveTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((MoveTxn) moveTxn, (MoveTxn_Parameters) parameters, (MoveTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject moveTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MoveTxn) moveTxn, (MoveTxn_LoadESigDetails_Parameters) parameters, (MoveTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject moveTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((MoveTxn) moveTxn, (MoveTxn_Parameters) parameters, (MoveTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject moveTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((MoveTxn) moveTxn, (MoveTxn_Parameters) parameters, (MoveTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject moveTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveTxn_Result result1;
        ResultStatus resultStatus = this.Load((MoveTxn) moveTxn, (MoveTxn_Parameters) parameters, (MoveTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject moveTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MoveTxn) moveTxn, (MoveTxn_Parameters) parameters, (MoveTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      try
      {
        MoveTxnMethod[] methods = new MoveTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMoveTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MoveTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MoveTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveTxn cdo,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      try
      {
        return ((IMoveTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MoveTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((MoveTxn) cdo, (MoveTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.GetEnvironment((MoveTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MoveTxn cdo,
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      result = (MoveTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MoveTxnMethod(cdo, MoveTxnMethods.ExecuteTransaction, (MoveTxn_Parameters) null));
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
        MoveTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MoveTxn) cdo, (MoveTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MoveTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (MoveTxn_Request) null, out MoveTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MoveTxn_Request request,
      out MoveTxn_Result result)
    {
      return this.ExecuteTransaction((MoveTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MoveTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MoveTxnMethod(cdo, MoveTxnMethods.AddDataTransaction, (MoveTxn_Parameters) null));
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
        return this.AddDataTransaction((MoveTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
