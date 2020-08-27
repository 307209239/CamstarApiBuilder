// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CompleteActivityInvestigationService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CompleteActivityInvestigationService : CompleteActivityBase
  {
    public CompleteActivityInvestigationService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICompleteActivityInvestigationService), userProfile);
    }

    public ResultStatus CreateParametricData(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      result = (CompleteActivityInvestigation_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityInvestigationService) this._Channel).CreateParametricData(this._UserProfile, completeActivityInvestigation, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityInvestigationMethod(completeActivityInvestigation, CompleteActivityInvestigationMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CompleteActivityInvestigation) null, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus CreateParametricData(
      CompleteActivityInvestigation completeActivityInvestigation)
    {
      return this.CreateParametricData(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus CreateParametricData(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      return this.CreateParametricData(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      result = (CompleteActivityInvestigation_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityInvestigationService) this._Channel).GetActions(this._UserProfile, completeActivityInvestigation, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityInvestigationMethod(completeActivityInvestigation, CompleteActivityInvestigationMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CompleteActivityInvestigation) null, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus GetActions(
      CompleteActivityInvestigation completeActivityInvestigation)
    {
      return this.GetActions(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus GetActions(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      return this.GetActions(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, request, out result);
    }

    public ResultStatus GetChecklistEntries(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      result = (CompleteActivityInvestigation_Result) null;
      this.OnBeforeCall(nameof (GetChecklistEntries), (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityInvestigationService) this._Channel).GetChecklistEntries(this._UserProfile, completeActivityInvestigation, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityInvestigationMethod(completeActivityInvestigation, CompleteActivityInvestigationMethods.GetChecklistEntries, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetChecklistEntries), res, (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetChecklistEntries()
    {
      return this.GetChecklistEntries((CompleteActivityInvestigation) null, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus GetChecklistEntries(
      CompleteActivityInvestigation completeActivityInvestigation)
    {
      return this.GetChecklistEntries(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus GetChecklistEntries(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      return this.GetChecklistEntries(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      result = (CompleteActivityInvestigation_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityInvestigationService) this._Channel).GetDataPoints(this._UserProfile, completeActivityInvestigation, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityInvestigationMethod(completeActivityInvestigation, CompleteActivityInvestigationMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CompleteActivityInvestigation) null, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus GetDataPoints(
      CompleteActivityInvestigation completeActivityInvestigation)
    {
      return this.GetDataPoints(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus GetDataPoints(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      return this.GetDataPoints(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, request, out result);
    }

    public ResultStatus GetFailureDetails(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      result = (CompleteActivityInvestigation_Result) null;
      this.OnBeforeCall(nameof (GetFailureDetails), (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityInvestigationService) this._Channel).GetFailureDetails(this._UserProfile, completeActivityInvestigation, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityInvestigationMethod(completeActivityInvestigation, CompleteActivityInvestigationMethods.GetFailureDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetFailureDetails), res, (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetFailureDetails()
    {
      return this.GetFailureDetails((CompleteActivityInvestigation) null, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus GetFailureDetails(
      CompleteActivityInvestigation completeActivityInvestigation)
    {
      return this.GetFailureDetails(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus GetFailureDetails(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      return this.GetFailureDetails(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      result = (CompleteActivityInvestigation_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityInvestigationService) this._Channel).GetWIPMsgs(this._UserProfile, completeActivityInvestigation, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityInvestigationMethod(completeActivityInvestigation, CompleteActivityInvestigationMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CompleteActivityInvestigation) null, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CompleteActivityInvestigation completeActivityInvestigation)
    {
      return this.GetWIPMsgs(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      return this.GetWIPMsgs(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      result = (CompleteActivityInvestigation_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityInvestigationService) this._Channel).Load(this._UserProfile, completeActivityInvestigation, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityInvestigationMethod(completeActivityInvestigation, CompleteActivityInvestigationMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CompleteActivityInvestigation) null, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus Load(
      CompleteActivityInvestigation completeActivityInvestigation)
    {
      return this.Load(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus Load(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      return this.Load(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, request, out result);
    }

    public ResultStatus LoadDataPoints(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      result = (CompleteActivityInvestigation_Result) null;
      this.OnBeforeCall(nameof (LoadDataPoints), (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityInvestigationService) this._Channel).LoadDataPoints(this._UserProfile, completeActivityInvestigation, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityInvestigationMethod(completeActivityInvestigation, CompleteActivityInvestigationMethods.LoadDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadDataPoints), res, (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadDataPoints()
    {
      return this.LoadDataPoints((CompleteActivityInvestigation) null, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus LoadDataPoints(
      CompleteActivityInvestigation completeActivityInvestigation)
    {
      return this.LoadDataPoints(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus LoadDataPoints(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      return this.LoadDataPoints(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      result = (CompleteActivityInvestigation_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityInvestigationService) this._Channel).LoadESigDetails(this._UserProfile, completeActivityInvestigation, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityInvestigationMethod(completeActivityInvestigation, CompleteActivityInvestigationMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CompleteActivityInvestigation) null, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus LoadESigDetails(
      CompleteActivityInvestigation completeActivityInvestigation)
    {
      return this.LoadESigDetails(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus LoadESigDetails(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      return this.LoadESigDetails(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      result = (CompleteActivityInvestigation_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityInvestigationService) this._Channel).ProcessComputation(this._UserProfile, completeActivityInvestigation, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityInvestigationMethod(completeActivityInvestigation, CompleteActivityInvestigationMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CompleteActivityInvestigation) null, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus ProcessComputation(
      CompleteActivityInvestigation completeActivityInvestigation)
    {
      return this.ProcessComputation(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus ProcessComputation(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      return this.ProcessComputation(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      result = (CompleteActivityInvestigation_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityInvestigationService) this._Channel).ResolveParametricData(this._UserProfile, completeActivityInvestigation, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityInvestigationMethod(completeActivityInvestigation, CompleteActivityInvestigationMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CompleteActivityInvestigation) null, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus ResolveParametricData(
      CompleteActivityInvestigation completeActivityInvestigation)
    {
      return this.ResolveParametricData(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus ResolveParametricData(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      return this.ResolveParametricData(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, request, out result);
    }

    public ResultStatus SaveFailureDetails(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      result = (CompleteActivityInvestigation_Result) null;
      this.OnBeforeCall(nameof (SaveFailureDetails), (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityInvestigationService) this._Channel).SaveFailureDetails(this._UserProfile, completeActivityInvestigation, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityInvestigationMethod(completeActivityInvestigation, CompleteActivityInvestigationMethods.SaveFailureDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveFailureDetails), res, (DCObject) completeActivityInvestigation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveFailureDetails()
    {
      return this.SaveFailureDetails((CompleteActivityInvestigation) null, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus SaveFailureDetails(
      CompleteActivityInvestigation completeActivityInvestigation)
    {
      return this.SaveFailureDetails(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus SaveFailureDetails(
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      return this.SaveFailureDetails(completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetChecklistEntries(
      DCObject completeActivityInvestigation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityInvestigation_Result result1;
        ResultStatus checklistEntries = this.GetChecklistEntries((CompleteActivityInvestigation) completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) parameters, (CompleteActivityInvestigation_Request) request, out result1);
        result = (Result) result1;
        return checklistEntries;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadDataPoints(
      DCObject completeActivityInvestigation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityInvestigation_Result result1;
        ResultStatus resultStatus = this.LoadDataPoints((CompleteActivityInvestigation) completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) parameters, (CompleteActivityInvestigation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject completeActivityInvestigation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityInvestigation_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CompleteActivityInvestigation) completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) parameters, (CompleteActivityInvestigation_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject completeActivityInvestigation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityInvestigation_Result result1;
        ResultStatus actions = this.GetActions((CompleteActivityInvestigation) completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) parameters, (CompleteActivityInvestigation_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject completeActivityInvestigation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityInvestigation_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CompleteActivityInvestigation) completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) parameters, (CompleteActivityInvestigation_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject completeActivityInvestigation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityInvestigation_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CompleteActivityInvestigation) completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) parameters, (CompleteActivityInvestigation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject completeActivityInvestigation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityInvestigation_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CompleteActivityInvestigation) completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) parameters, (CompleteActivityInvestigation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject completeActivityInvestigation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityInvestigation_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CompleteActivityInvestigation) completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) parameters, (CompleteActivityInvestigation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject completeActivityInvestigation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityInvestigation_Result result1;
        ResultStatus resultStatus = this.Load((CompleteActivityInvestigation) completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) parameters, (CompleteActivityInvestigation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject completeActivityInvestigation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityInvestigation_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CompleteActivityInvestigation) completeActivityInvestigation, (CompleteActivityInvestigation_Parameters) parameters, (CompleteActivityInvestigation_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      result = (CompleteActivityInvestigation_Result) null;
      try
      {
        CompleteActivityInvestigationMethod[] methods = new CompleteActivityInvestigationMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICompleteActivityInvestigationService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CompleteActivityInvestigation_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CompleteActivityInvestigation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CompleteActivityInvestigation cdo,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      result = (CompleteActivityInvestigation_Result) null;
      try
      {
        return ((ICompleteActivityInvestigationService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CompleteActivityInvestigation_Result result1;
        ResultStatus environment = this.GetEnvironment((CompleteActivityInvestigation) cdo, (CompleteActivityInvestigation_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      return this.GetEnvironment((CompleteActivityInvestigation) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CompleteActivityInvestigation cdo,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      result = (CompleteActivityInvestigation_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityInvestigationService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CompleteActivityInvestigationMethod(cdo, CompleteActivityInvestigationMethods.ExecuteTransaction, (CompleteActivityInvestigation_Parameters) null));
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
        CompleteActivityInvestigation_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CompleteActivityInvestigation) cdo, (CompleteActivityInvestigation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CompleteActivityInvestigation cdo)
    {
      return this.ExecuteTransaction(cdo, (CompleteActivityInvestigation_Request) null, out CompleteActivityInvestigation_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result)
    {
      return this.ExecuteTransaction((CompleteActivityInvestigation) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CompleteActivityInvestigation cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CompleteActivityInvestigationMethod(cdo, CompleteActivityInvestigationMethods.AddDataTransaction, (CompleteActivityInvestigation_Parameters) null));
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
        return this.AddDataTransaction((CompleteActivityInvestigation) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
