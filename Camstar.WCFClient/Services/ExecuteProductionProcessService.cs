// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ExecuteProductionProcessService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ExecuteProductionProcessService : ContainerTxnBase
  {
    public ExecuteProductionProcessService(UserProfile userProfile)
    {
      this.Initialize(typeof (IExecuteProductionProcessService), userProfile);
    }

    public ResultStatus AddCompletedTask(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (AddCompletedTask), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).AddCompletedTask(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.AddCompletedTask, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddCompletedTask), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddCompletedTask()
    {
      return this.AddCompletedTask((ExecuteProductionProcess) null, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus AddCompletedTask(
      ExecuteProductionProcess executeProductionProcess)
    {
      return this.AddCompletedTask(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus AddCompletedTask(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.AddCompletedTask(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, request, out result);
    }

    public ResultStatus AssignCellContainerClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_AssignCellContainerClearance_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (AssignCellContainerClearance), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).AssignCellContainerClearance(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.AssignCellContainerClearance, (ExecuteProductionProcess_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AssignCellContainerClearance), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AssignCellContainerClearance()
    {
      return this.AssignCellContainerClearance((ExecuteProductionProcess) null, (ExecuteProductionProcess_AssignCellContainerClearance_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus AssignCellContainerClearance(
      ExecuteProductionProcess executeProductionProcess)
    {
      return this.AssignCellContainerClearance(executeProductionProcess, (ExecuteProductionProcess_AssignCellContainerClearance_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus AssignCellContainerClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.AssignCellContainerClearance(executeProductionProcess, (ExecuteProductionProcess_AssignCellContainerClearance_Parameters) null, request, out result);
    }

    public ResultStatus AssignCellMfgOrderClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (AssignCellMfgOrderClearance), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).AssignCellMfgOrderClearance(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.AssignCellMfgOrderClearance, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AssignCellMfgOrderClearance), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AssignCellMfgOrderClearance()
    {
      return this.AssignCellMfgOrderClearance((ExecuteProductionProcess) null, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus AssignCellMfgOrderClearance(
      ExecuteProductionProcess executeProductionProcess)
    {
      return this.AssignCellMfgOrderClearance(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus AssignCellMfgOrderClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.AssignCellMfgOrderClearance(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, request, out result);
    }

    public ResultStatus AssignStationContainerClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_AssignStationContainerClearance_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (AssignStationContainerClearance), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).AssignStationContainerClearance(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.AssignStationContainerClearance, (ExecuteProductionProcess_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AssignStationContainerClearance), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AssignStationContainerClearance()
    {
      return this.AssignStationContainerClearance((ExecuteProductionProcess) null, (ExecuteProductionProcess_AssignStationContainerClearance_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus AssignStationContainerClearance(
      ExecuteProductionProcess executeProductionProcess)
    {
      return this.AssignStationContainerClearance(executeProductionProcess, (ExecuteProductionProcess_AssignStationContainerClearance_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus AssignStationContainerClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.AssignStationContainerClearance(executeProductionProcess, (ExecuteProductionProcess_AssignStationContainerClearance_Parameters) null, request, out result);
    }

    public ResultStatus AssignStationMfgOrderClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (AssignStationMfgOrderClearance), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).AssignStationMfgOrderClearance(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.AssignStationMfgOrderClearance, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AssignStationMfgOrderClearance), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AssignStationMfgOrderClearance()
    {
      return this.AssignStationMfgOrderClearance((ExecuteProductionProcess) null, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus AssignStationMfgOrderClearance(
      ExecuteProductionProcess executeProductionProcess)
    {
      return this.AssignStationMfgOrderClearance(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus AssignStationMfgOrderClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.AssignStationMfgOrderClearance(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, request, out result);
    }

    public ResultStatus ClearStationContainerClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_ClearStationContainerClearance_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (ClearStationContainerClearance), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).ClearStationContainerClearance(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.ClearStationContainerClearance, (ExecuteProductionProcess_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ClearStationContainerClearance), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ClearStationContainerClearance()
    {
      return this.ClearStationContainerClearance((ExecuteProductionProcess) null, (ExecuteProductionProcess_ClearStationContainerClearance_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus ClearStationContainerClearance(
      ExecuteProductionProcess executeProductionProcess)
    {
      return this.ClearStationContainerClearance(executeProductionProcess, (ExecuteProductionProcess_ClearStationContainerClearance_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus ClearStationContainerClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.ClearStationContainerClearance(executeProductionProcess, (ExecuteProductionProcess_ClearStationContainerClearance_Parameters) null, request, out result);
    }

    public ResultStatus ClearStationMfgOrderClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (ClearStationMfgOrderClearance), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).ClearStationMfgOrderClearance(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.ClearStationMfgOrderClearance, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ClearStationMfgOrderClearance), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ClearStationMfgOrderClearance()
    {
      return this.ClearStationMfgOrderClearance((ExecuteProductionProcess) null, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus ClearStationMfgOrderClearance(
      ExecuteProductionProcess executeProductionProcess)
    {
      return this.ClearStationMfgOrderClearance(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus ClearStationMfgOrderClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.ClearStationMfgOrderClearance(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).CreateParametricData(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ExecuteProductionProcess) null, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus CreateParametricData(
      ExecuteProductionProcess executeProductionProcess)
    {
      return this.CreateParametricData(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus CreateParametricData(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.CreateParametricData(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).GetActions(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ExecuteProductionProcess) null, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus GetActions(ExecuteProductionProcess executeProductionProcess)
    {
      return this.GetActions(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus GetActions(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.GetActions(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).GetDataPoints(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ExecuteProductionProcess) null, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus GetDataPoints(ExecuteProductionProcess executeProductionProcess)
    {
      return this.GetDataPoints(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus GetDataPoints(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.GetDataPoints(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).GetWIPMsgs(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ExecuteProductionProcess) null, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus GetWIPMsgs(ExecuteProductionProcess executeProductionProcess)
    {
      return this.GetWIPMsgs(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.GetWIPMsgs(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).Load(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ExecuteProductionProcess) null, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus Load(ExecuteProductionProcess executeProductionProcess)
    {
      return this.Load(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus Load(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.Load(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_LoadESigDetails_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).LoadESigDetails(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.LoadESigDetails, (ExecuteProductionProcess_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ExecuteProductionProcess) null, (ExecuteProductionProcess_LoadESigDetails_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus LoadESigDetails(
      ExecuteProductionProcess executeProductionProcess)
    {
      return this.LoadESigDetails(executeProductionProcess, (ExecuteProductionProcess_LoadESigDetails_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus LoadESigDetails(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.LoadESigDetails(executeProductionProcess, (ExecuteProductionProcess_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus LoadProcessListDetails(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (LoadProcessListDetails), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).LoadProcessListDetails(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.LoadProcessListDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadProcessListDetails), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadProcessListDetails()
    {
      return this.LoadProcessListDetails((ExecuteProductionProcess) null, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus LoadProcessListDetails(
      ExecuteProductionProcess executeProductionProcess)
    {
      return this.LoadProcessListDetails(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus LoadProcessListDetails(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.LoadProcessListDetails(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).ProcessComputation(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ExecuteProductionProcess) null, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus ProcessComputation(
      ExecuteProductionProcess executeProductionProcess)
    {
      return this.ProcessComputation(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus ProcessComputation(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.ProcessComputation(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).ResolveParametricData(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ExecuteProductionProcess) null, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus ResolveParametricData(
      ExecuteProductionProcess executeProductionProcess)
    {
      return this.ResolveParametricData(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus ResolveParametricData(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.ResolveParametricData(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, request, out result);
    }

    public ResultStatus SetLastCompletedTask(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (SetLastCompletedTask), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).SetLastCompletedTask(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.SetLastCompletedTask, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetLastCompletedTask), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetLastCompletedTask()
    {
      return this.SetLastCompletedTask((ExecuteProductionProcess) null, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus SetLastCompletedTask(
      ExecuteProductionProcess executeProductionProcess)
    {
      return this.SetLastCompletedTask(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus SetLastCompletedTask(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.SetLastCompletedTask(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, request, out result);
    }

    public ResultStatus UpdateCompletedTask(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (UpdateCompletedTask), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).UpdateCompletedTask(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.UpdateCompletedTask, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UpdateCompletedTask), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UpdateCompletedTask()
    {
      return this.UpdateCompletedTask((ExecuteProductionProcess) null, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus UpdateCompletedTask(
      ExecuteProductionProcess executeProductionProcess)
    {
      return this.UpdateCompletedTask(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus UpdateCompletedTask(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.UpdateCompletedTask(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, request, out result);
    }

    public ResultStatus ValidateCellContainerClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_ValidateCellContainerClearance_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (ValidateCellContainerClearance), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).ValidateCellContainerClearance(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.ValidateCellContainerClearance, (ExecuteProductionProcess_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateCellContainerClearance), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateCellContainerClearance()
    {
      return this.ValidateCellContainerClearance((ExecuteProductionProcess) null, (ExecuteProductionProcess_ValidateCellContainerClearance_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus ValidateCellContainerClearance(
      ExecuteProductionProcess executeProductionProcess)
    {
      return this.ValidateCellContainerClearance(executeProductionProcess, (ExecuteProductionProcess_ValidateCellContainerClearance_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus ValidateCellContainerClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.ValidateCellContainerClearance(executeProductionProcess, (ExecuteProductionProcess_ValidateCellContainerClearance_Parameters) null, request, out result);
    }

    public ResultStatus ValidateCellMfgOrderClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (ValidateCellMfgOrderClearance), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).ValidateCellMfgOrderClearance(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.ValidateCellMfgOrderClearance, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateCellMfgOrderClearance), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateCellMfgOrderClearance()
    {
      return this.ValidateCellMfgOrderClearance((ExecuteProductionProcess) null, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus ValidateCellMfgOrderClearance(
      ExecuteProductionProcess executeProductionProcess)
    {
      return this.ValidateCellMfgOrderClearance(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus ValidateCellMfgOrderClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.ValidateCellMfgOrderClearance(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, request, out result);
    }

    public ResultStatus ValidateStationContainerClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_ValidateStationContainerClearance_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (ValidateStationContainerClearance), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).ValidateStationContainerClearance(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.ValidateStationContainerClearance, (ExecuteProductionProcess_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateStationContainerClearance), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateStationContainerClearance()
    {
      return this.ValidateStationContainerClearance((ExecuteProductionProcess) null, (ExecuteProductionProcess_ValidateStationContainerClearance_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus ValidateStationContainerClearance(
      ExecuteProductionProcess executeProductionProcess)
    {
      return this.ValidateStationContainerClearance(executeProductionProcess, (ExecuteProductionProcess_ValidateStationContainerClearance_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus ValidateStationContainerClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.ValidateStationContainerClearance(executeProductionProcess, (ExecuteProductionProcess_ValidateStationContainerClearance_Parameters) null, request, out result);
    }

    public ResultStatus ValidateStationMfgOrderClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (ValidateStationMfgOrderClearance), (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).ValidateStationMfgOrderClearance(this._UserProfile, executeProductionProcess, parameters, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(executeProductionProcess, ExecuteProductionProcessMethods.ValidateStationMfgOrderClearance, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateStationMfgOrderClearance), res, (DCObject) executeProductionProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateStationMfgOrderClearance()
    {
      return this.ValidateStationMfgOrderClearance((ExecuteProductionProcess) null, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus ValidateStationMfgOrderClearance(
      ExecuteProductionProcess executeProductionProcess)
    {
      return this.ValidateStationMfgOrderClearance(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus ValidateStationMfgOrderClearance(
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.ValidateStationMfgOrderClearance(executeProductionProcess, (ExecuteProductionProcess_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject executeProductionProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteProductionProcess_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ExecuteProductionProcess) executeProductionProcess, (ExecuteProductionProcess_Parameters) parameters, (ExecuteProductionProcess_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject executeProductionProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteProductionProcess_Result result1;
        ResultStatus actions = this.GetActions((ExecuteProductionProcess) executeProductionProcess, (ExecuteProductionProcess_Parameters) parameters, (ExecuteProductionProcess_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject executeProductionProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteProductionProcess_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ExecuteProductionProcess) executeProductionProcess, (ExecuteProductionProcess_Parameters) parameters, (ExecuteProductionProcess_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject executeProductionProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteProductionProcess_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ExecuteProductionProcess) executeProductionProcess, (ExecuteProductionProcess_LoadESigDetails_Parameters) parameters, (ExecuteProductionProcess_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject executeProductionProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteProductionProcess_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ExecuteProductionProcess) executeProductionProcess, (ExecuteProductionProcess_Parameters) parameters, (ExecuteProductionProcess_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject executeProductionProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteProductionProcess_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ExecuteProductionProcess) executeProductionProcess, (ExecuteProductionProcess_Parameters) parameters, (ExecuteProductionProcess_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject executeProductionProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteProductionProcess_Result result1;
        ResultStatus resultStatus = this.Load((ExecuteProductionProcess) executeProductionProcess, (ExecuteProductionProcess_Parameters) parameters, (ExecuteProductionProcess_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject executeProductionProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteProductionProcess_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ExecuteProductionProcess) executeProductionProcess, (ExecuteProductionProcess_Parameters) parameters, (ExecuteProductionProcess_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      try
      {
        ExecuteProductionProcessMethod[] methods = new ExecuteProductionProcessMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IExecuteProductionProcessService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ExecuteProductionProcess_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ExecuteProductionProcess_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ExecuteProductionProcess cdo,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      try
      {
        return ((IExecuteProductionProcessService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ExecuteProductionProcess_Result result1;
        ResultStatus environment = this.GetEnvironment((ExecuteProductionProcess) cdo, (ExecuteProductionProcess_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.GetEnvironment((ExecuteProductionProcess) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ExecuteProductionProcess cdo,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      result = (ExecuteProductionProcess_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteProductionProcessService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ExecuteProductionProcessMethod(cdo, ExecuteProductionProcessMethods.ExecuteTransaction, (ExecuteProductionProcess_Parameters) null));
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
        ExecuteProductionProcess_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ExecuteProductionProcess) cdo, (ExecuteProductionProcess_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ExecuteProductionProcess cdo)
    {
      return this.ExecuteTransaction(cdo, (ExecuteProductionProcess_Request) null, out ExecuteProductionProcess_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result)
    {
      return this.ExecuteTransaction((ExecuteProductionProcess) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ExecuteProductionProcess cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ExecuteProductionProcessMethod(cdo, ExecuteProductionProcessMethods.AddDataTransaction, (ExecuteProductionProcess_Parameters) null));
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
        return this.AddDataTransaction((ExecuteProductionProcess) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
