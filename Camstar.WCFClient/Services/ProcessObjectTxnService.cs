// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProcessObjectTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ProcessObjectTxnService : QualityTxnBase
  {
    public ProcessObjectTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IProcessObjectTxnService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      result = (ProcessObjectTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) processObjectTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTxnService) this._Channel).CreateParametricData(this._UserProfile, processObjectTxn, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTxnMethod(processObjectTxn, ProcessObjectTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) processObjectTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ProcessObjectTxn) null, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus CreateParametricData(ProcessObjectTxn processObjectTxn)
    {
      return this.CreateParametricData(processObjectTxn, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      return this.CreateParametricData(processObjectTxn, (ProcessObjectTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      result = (ProcessObjectTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) processObjectTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTxnService) this._Channel).GetActions(this._UserProfile, processObjectTxn, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTxnMethod(processObjectTxn, ProcessObjectTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) processObjectTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ProcessObjectTxn) null, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus GetActions(ProcessObjectTxn processObjectTxn)
    {
      return this.GetActions(processObjectTxn, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus GetActions(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      return this.GetActions(processObjectTxn, (ProcessObjectTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetDetails(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      result = (ProcessObjectTxn_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetDetails), (DCObject) processObjectTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTxnService) this._Channel).GetApprovalSheetDetails(this._UserProfile, processObjectTxn, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTxnMethod(processObjectTxn, ProcessObjectTxnMethods.GetApprovalSheetDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetDetails), res, (DCObject) processObjectTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetDetails()
    {
      return this.GetApprovalSheetDetails((ProcessObjectTxn) null, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus GetApprovalSheetDetails(ProcessObjectTxn processObjectTxn)
    {
      return this.GetApprovalSheetDetails(processObjectTxn, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus GetApprovalSheetDetails(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      return this.GetApprovalSheetDetails(processObjectTxn, (ProcessObjectTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      result = (ProcessObjectTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) processObjectTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTxnService) this._Channel).GetDataPoints(this._UserProfile, processObjectTxn, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTxnMethod(processObjectTxn, ProcessObjectTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) processObjectTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ProcessObjectTxn) null, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus GetDataPoints(ProcessObjectTxn processObjectTxn)
    {
      return this.GetDataPoints(processObjectTxn, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      return this.GetDataPoints(processObjectTxn, (ProcessObjectTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      result = (ProcessObjectTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) processObjectTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTxnService) this._Channel).GetWIPMsgs(this._UserProfile, processObjectTxn, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTxnMethod(processObjectTxn, ProcessObjectTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) processObjectTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ProcessObjectTxn) null, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(ProcessObjectTxn processObjectTxn)
    {
      return this.GetWIPMsgs(processObjectTxn, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      return this.GetWIPMsgs(processObjectTxn, (ProcessObjectTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      result = (ProcessObjectTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) processObjectTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTxnService) this._Channel).Load(this._UserProfile, processObjectTxn, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTxnMethod(processObjectTxn, ProcessObjectTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) processObjectTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ProcessObjectTxn) null, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus Load(ProcessObjectTxn processObjectTxn)
    {
      return this.Load(processObjectTxn, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus Load(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      return this.Load(processObjectTxn, (ProcessObjectTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      result = (ProcessObjectTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) processObjectTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTxnService) this._Channel).LoadESigDetails(this._UserProfile, processObjectTxn, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTxnMethod(processObjectTxn, ProcessObjectTxnMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) processObjectTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ProcessObjectTxn) null, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus LoadESigDetails(ProcessObjectTxn processObjectTxn)
    {
      return this.LoadESigDetails(processObjectTxn, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      return this.LoadESigDetails(processObjectTxn, (ProcessObjectTxn_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      result = (ProcessObjectTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) processObjectTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTxnService) this._Channel).ProcessComputation(this._UserProfile, processObjectTxn, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTxnMethod(processObjectTxn, ProcessObjectTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) processObjectTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ProcessObjectTxn) null, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus ProcessComputation(ProcessObjectTxn processObjectTxn)
    {
      return this.ProcessComputation(processObjectTxn, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      return this.ProcessComputation(processObjectTxn, (ProcessObjectTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      result = (ProcessObjectTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) processObjectTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTxnService) this._Channel).ResolveParametricData(this._UserProfile, processObjectTxn, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTxnMethod(processObjectTxn, ProcessObjectTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) processObjectTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ProcessObjectTxn) null, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus ResolveParametricData(ProcessObjectTxn processObjectTxn)
    {
      return this.ResolveParametricData(processObjectTxn, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      return this.ResolveParametricData(processObjectTxn, (ProcessObjectTxn_Parameters) null, request, out result);
    }

    public ResultStatus SaveApprovalSheet(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      result = (ProcessObjectTxn_Result) null;
      this.OnBeforeCall(nameof (SaveApprovalSheet), (DCObject) processObjectTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTxnService) this._Channel).SaveApprovalSheet(this._UserProfile, processObjectTxn, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTxnMethod(processObjectTxn, ProcessObjectTxnMethods.SaveApprovalSheet, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveApprovalSheet), res, (DCObject) processObjectTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveApprovalSheet()
    {
      return this.SaveApprovalSheet((ProcessObjectTxn) null, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus SaveApprovalSheet(ProcessObjectTxn processObjectTxn)
    {
      return this.SaveApprovalSheet(processObjectTxn, (ProcessObjectTxn_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus SaveApprovalSheet(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      return this.SaveApprovalSheet(processObjectTxn, (ProcessObjectTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidateReassignmentAllowed(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_ValidateReassignmentAllowed_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      result = (ProcessObjectTxn_Result) null;
      this.OnBeforeCall(nameof (ValidateReassignmentAllowed), (DCObject) processObjectTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTxnService) this._Channel).ValidateReassignmentAllowed(this._UserProfile, processObjectTxn, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTxnMethod(processObjectTxn, ProcessObjectTxnMethods.ValidateReassignmentAllowed, (ProcessObjectTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateReassignmentAllowed), res, (DCObject) processObjectTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateReassignmentAllowed()
    {
      return this.ValidateReassignmentAllowed((ProcessObjectTxn) null, (ProcessObjectTxn_ValidateReassignmentAllowed_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus ValidateReassignmentAllowed(ProcessObjectTxn processObjectTxn)
    {
      return this.ValidateReassignmentAllowed(processObjectTxn, (ProcessObjectTxn_ValidateReassignmentAllowed_Parameters) null, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus ValidateReassignmentAllowed(
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      return this.ValidateReassignmentAllowed(processObjectTxn, (ProcessObjectTxn_ValidateReassignmentAllowed_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject processObjectTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ProcessObjectTxn) processObjectTxn, (ProcessObjectTxn_Parameters) parameters, (ProcessObjectTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject processObjectTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectTxn_Result result1;
        ResultStatus actions = this.GetActions((ProcessObjectTxn) processObjectTxn, (ProcessObjectTxn_Parameters) parameters, (ProcessObjectTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject processObjectTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ProcessObjectTxn) processObjectTxn, (ProcessObjectTxn_Parameters) parameters, (ProcessObjectTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject processObjectTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ProcessObjectTxn) processObjectTxn, (ProcessObjectTxn_Parameters) parameters, (ProcessObjectTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject processObjectTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ProcessObjectTxn) processObjectTxn, (ProcessObjectTxn_Parameters) parameters, (ProcessObjectTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject processObjectTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ProcessObjectTxn) processObjectTxn, (ProcessObjectTxn_Parameters) parameters, (ProcessObjectTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject processObjectTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectTxn_Result result1;
        ResultStatus resultStatus = this.Load((ProcessObjectTxn) processObjectTxn, (ProcessObjectTxn_Parameters) parameters, (ProcessObjectTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject processObjectTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ProcessObjectTxn) processObjectTxn, (ProcessObjectTxn_Parameters) parameters, (ProcessObjectTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      result = (ProcessObjectTxn_Result) null;
      try
      {
        ProcessObjectTxnMethod[] methods = new ProcessObjectTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IProcessObjectTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ProcessObjectTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ProcessObjectTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProcessObjectTxn cdo,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      result = (ProcessObjectTxn_Result) null;
      try
      {
        return ((IProcessObjectTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ProcessObjectTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((ProcessObjectTxn) cdo, (ProcessObjectTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      return this.GetEnvironment((ProcessObjectTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ProcessObjectTxn cdo,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      result = (ProcessObjectTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ProcessObjectTxnMethod(cdo, ProcessObjectTxnMethods.ExecuteTransaction, (ProcessObjectTxn_Parameters) null));
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
        ProcessObjectTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ProcessObjectTxn) cdo, (ProcessObjectTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ProcessObjectTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (ProcessObjectTxn_Request) null, out ProcessObjectTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result)
    {
      return this.ExecuteTransaction((ProcessObjectTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ProcessObjectTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ProcessObjectTxnMethod(cdo, ProcessObjectTxnMethods.AddDataTransaction, (ProcessObjectTxn_Parameters) null));
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
        return this.AddDataTransaction((ProcessObjectTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
