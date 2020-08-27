// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CompleteActivityDispositionService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CompleteActivityDispositionService : CompleteActivityBase
  {
    public CompleteActivityDispositionService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICompleteActivityDispositionService), userProfile);
    }

    public ResultStatus CreateParametricData(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      result = (CompleteActivityDisposition_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityDispositionService) this._Channel).CreateParametricData(this._UserProfile, completeActivityDisposition, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityDispositionMethod(completeActivityDisposition, CompleteActivityDispositionMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CompleteActivityDisposition) null, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus CreateParametricData(
      CompleteActivityDisposition completeActivityDisposition)
    {
      return this.CreateParametricData(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus CreateParametricData(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      return this.CreateParametricData(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      result = (CompleteActivityDisposition_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityDispositionService) this._Channel).GetActions(this._UserProfile, completeActivityDisposition, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityDispositionMethod(completeActivityDisposition, CompleteActivityDispositionMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CompleteActivityDisposition) null, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus GetActions(
      CompleteActivityDisposition completeActivityDisposition)
    {
      return this.GetActions(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus GetActions(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      return this.GetActions(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, request, out result);
    }

    public ResultStatus GetChecklistEntries(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      result = (CompleteActivityDisposition_Result) null;
      this.OnBeforeCall(nameof (GetChecklistEntries), (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityDispositionService) this._Channel).GetChecklistEntries(this._UserProfile, completeActivityDisposition, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityDispositionMethod(completeActivityDisposition, CompleteActivityDispositionMethods.GetChecklistEntries, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetChecklistEntries), res, (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetChecklistEntries()
    {
      return this.GetChecklistEntries((CompleteActivityDisposition) null, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus GetChecklistEntries(
      CompleteActivityDisposition completeActivityDisposition)
    {
      return this.GetChecklistEntries(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus GetChecklistEntries(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      return this.GetChecklistEntries(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      result = (CompleteActivityDisposition_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityDispositionService) this._Channel).GetDataPoints(this._UserProfile, completeActivityDisposition, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityDispositionMethod(completeActivityDisposition, CompleteActivityDispositionMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CompleteActivityDisposition) null, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus GetDataPoints(
      CompleteActivityDisposition completeActivityDisposition)
    {
      return this.GetDataPoints(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus GetDataPoints(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      return this.GetDataPoints(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, request, out result);
    }

    public ResultStatus GetDispositionDetails(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      result = (CompleteActivityDisposition_Result) null;
      this.OnBeforeCall(nameof (GetDispositionDetails), (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityDispositionService) this._Channel).GetDispositionDetails(this._UserProfile, completeActivityDisposition, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityDispositionMethod(completeActivityDisposition, CompleteActivityDispositionMethods.GetDispositionDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDispositionDetails), res, (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDispositionDetails()
    {
      return this.GetDispositionDetails((CompleteActivityDisposition) null, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus GetDispositionDetails(
      CompleteActivityDisposition completeActivityDisposition)
    {
      return this.GetDispositionDetails(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus GetDispositionDetails(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      return this.GetDispositionDetails(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      result = (CompleteActivityDisposition_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityDispositionService) this._Channel).GetWIPMsgs(this._UserProfile, completeActivityDisposition, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityDispositionMethod(completeActivityDisposition, CompleteActivityDispositionMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CompleteActivityDisposition) null, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CompleteActivityDisposition completeActivityDisposition)
    {
      return this.GetWIPMsgs(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      return this.GetWIPMsgs(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      result = (CompleteActivityDisposition_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityDispositionService) this._Channel).Load(this._UserProfile, completeActivityDisposition, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityDispositionMethod(completeActivityDisposition, CompleteActivityDispositionMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CompleteActivityDisposition) null, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus Load(
      CompleteActivityDisposition completeActivityDisposition)
    {
      return this.Load(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus Load(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      return this.Load(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, request, out result);
    }

    public ResultStatus LoadDataPoints(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      result = (CompleteActivityDisposition_Result) null;
      this.OnBeforeCall(nameof (LoadDataPoints), (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityDispositionService) this._Channel).LoadDataPoints(this._UserProfile, completeActivityDisposition, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityDispositionMethod(completeActivityDisposition, CompleteActivityDispositionMethods.LoadDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadDataPoints), res, (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadDataPoints()
    {
      return this.LoadDataPoints((CompleteActivityDisposition) null, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus LoadDataPoints(
      CompleteActivityDisposition completeActivityDisposition)
    {
      return this.LoadDataPoints(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus LoadDataPoints(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      return this.LoadDataPoints(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      result = (CompleteActivityDisposition_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityDispositionService) this._Channel).LoadESigDetails(this._UserProfile, completeActivityDisposition, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityDispositionMethod(completeActivityDisposition, CompleteActivityDispositionMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CompleteActivityDisposition) null, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus LoadESigDetails(
      CompleteActivityDisposition completeActivityDisposition)
    {
      return this.LoadESigDetails(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus LoadESigDetails(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      return this.LoadESigDetails(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      result = (CompleteActivityDisposition_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityDispositionService) this._Channel).ProcessComputation(this._UserProfile, completeActivityDisposition, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityDispositionMethod(completeActivityDisposition, CompleteActivityDispositionMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CompleteActivityDisposition) null, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus ProcessComputation(
      CompleteActivityDisposition completeActivityDisposition)
    {
      return this.ProcessComputation(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus ProcessComputation(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      return this.ProcessComputation(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      result = (CompleteActivityDisposition_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityDispositionService) this._Channel).ResolveParametricData(this._UserProfile, completeActivityDisposition, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityDispositionMethod(completeActivityDisposition, CompleteActivityDispositionMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) completeActivityDisposition, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CompleteActivityDisposition) null, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus ResolveParametricData(
      CompleteActivityDisposition completeActivityDisposition)
    {
      return this.ResolveParametricData(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus ResolveParametricData(
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      return this.ResolveParametricData(completeActivityDisposition, (CompleteActivityDisposition_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetChecklistEntries(
      DCObject completeActivityDisposition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityDisposition_Result result1;
        ResultStatus checklistEntries = this.GetChecklistEntries((CompleteActivityDisposition) completeActivityDisposition, (CompleteActivityDisposition_Parameters) parameters, (CompleteActivityDisposition_Request) request, out result1);
        result = (Result) result1;
        return checklistEntries;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadDataPoints(
      DCObject completeActivityDisposition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityDisposition_Result result1;
        ResultStatus resultStatus = this.LoadDataPoints((CompleteActivityDisposition) completeActivityDisposition, (CompleteActivityDisposition_Parameters) parameters, (CompleteActivityDisposition_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject completeActivityDisposition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityDisposition_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CompleteActivityDisposition) completeActivityDisposition, (CompleteActivityDisposition_Parameters) parameters, (CompleteActivityDisposition_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject completeActivityDisposition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityDisposition_Result result1;
        ResultStatus actions = this.GetActions((CompleteActivityDisposition) completeActivityDisposition, (CompleteActivityDisposition_Parameters) parameters, (CompleteActivityDisposition_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject completeActivityDisposition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityDisposition_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CompleteActivityDisposition) completeActivityDisposition, (CompleteActivityDisposition_Parameters) parameters, (CompleteActivityDisposition_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject completeActivityDisposition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityDisposition_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CompleteActivityDisposition) completeActivityDisposition, (CompleteActivityDisposition_Parameters) parameters, (CompleteActivityDisposition_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject completeActivityDisposition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityDisposition_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CompleteActivityDisposition) completeActivityDisposition, (CompleteActivityDisposition_Parameters) parameters, (CompleteActivityDisposition_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject completeActivityDisposition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityDisposition_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CompleteActivityDisposition) completeActivityDisposition, (CompleteActivityDisposition_Parameters) parameters, (CompleteActivityDisposition_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject completeActivityDisposition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityDisposition_Result result1;
        ResultStatus resultStatus = this.Load((CompleteActivityDisposition) completeActivityDisposition, (CompleteActivityDisposition_Parameters) parameters, (CompleteActivityDisposition_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject completeActivityDisposition,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivityDisposition_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CompleteActivityDisposition) completeActivityDisposition, (CompleteActivityDisposition_Parameters) parameters, (CompleteActivityDisposition_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      result = (CompleteActivityDisposition_Result) null;
      try
      {
        CompleteActivityDispositionMethod[] methods = new CompleteActivityDispositionMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICompleteActivityDispositionService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CompleteActivityDisposition_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CompleteActivityDisposition_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CompleteActivityDisposition cdo,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      result = (CompleteActivityDisposition_Result) null;
      try
      {
        return ((ICompleteActivityDispositionService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CompleteActivityDisposition_Result result1;
        ResultStatus environment = this.GetEnvironment((CompleteActivityDisposition) cdo, (CompleteActivityDisposition_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      return this.GetEnvironment((CompleteActivityDisposition) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CompleteActivityDisposition cdo,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      result = (CompleteActivityDisposition_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityDispositionService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CompleteActivityDispositionMethod(cdo, CompleteActivityDispositionMethods.ExecuteTransaction, (CompleteActivityDisposition_Parameters) null));
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
        CompleteActivityDisposition_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CompleteActivityDisposition) cdo, (CompleteActivityDisposition_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CompleteActivityDisposition cdo)
    {
      return this.ExecuteTransaction(cdo, (CompleteActivityDisposition_Request) null, out CompleteActivityDisposition_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result)
    {
      return this.ExecuteTransaction((CompleteActivityDisposition) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CompleteActivityDisposition cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CompleteActivityDispositionMethod(cdo, CompleteActivityDispositionMethods.AddDataTransaction, (CompleteActivityDisposition_Parameters) null));
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
        return this.AddDataTransaction((CompleteActivityDisposition) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
