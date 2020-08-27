// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.WorkflowMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class WorkflowMaintService : BusinessProcessWorkflowMaintBase
  {
    public WorkflowMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IWorkflowMaintService), userProfile);
    }

    public ResultStatus Delete(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      result = (WorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) workflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkflowMaintService) this._Channel).Delete(this._UserProfile, workflowMaint, parameters, request, out result) : this.AddMethod((Method) new WorkflowMaintMethod(workflowMaint, WorkflowMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) workflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((WorkflowMaint) null, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus Delete(WorkflowMaint workflowMaint)
    {
      return this.Delete(workflowMaint, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus Delete(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      return this.Delete(workflowMaint, (WorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      result = (WorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) workflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkflowMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, workflowMaint, parameters, request, out result) : this.AddMethod((Method) new WorkflowMaintMethod(workflowMaint, WorkflowMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) workflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((WorkflowMaint) null, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(WorkflowMaint workflowMaint)
    {
      return this.DeleteAllRevisions(workflowMaint, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      return this.DeleteAllRevisions(workflowMaint, (WorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      result = (WorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) workflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkflowMaintService) this._Channel).Freeze(this._UserProfile, workflowMaint, parameters, request, out result) : this.AddMethod((Method) new WorkflowMaintMethod(workflowMaint, WorkflowMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) workflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((WorkflowMaint) null, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus Freeze(WorkflowMaint workflowMaint)
    {
      return this.Freeze(workflowMaint, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus Freeze(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      return this.Freeze(workflowMaint, (WorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      result = (WorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) workflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkflowMaintService) this._Channel).GetWIPMsgs(this._UserProfile, workflowMaint, parameters, request, out result) : this.AddMethod((Method) new WorkflowMaintMethod(workflowMaint, WorkflowMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) workflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((WorkflowMaint) null, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(WorkflowMaint workflowMaint)
    {
      return this.GetWIPMsgs(workflowMaint, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      return this.GetWIPMsgs(workflowMaint, (WorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      result = (WorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) workflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkflowMaintService) this._Channel).Load(this._UserProfile, workflowMaint, parameters, request, out result) : this.AddMethod((Method) new WorkflowMaintMethod(workflowMaint, WorkflowMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) workflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((WorkflowMaint) null, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus Load(WorkflowMaint workflowMaint)
    {
      return this.Load(workflowMaint, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus Load(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      return this.Load(workflowMaint, (WorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      WorkflowMaint workflowMaint,
      WorkflowMaint_LoadESigDetails_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      result = (WorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) workflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkflowMaintService) this._Channel).LoadESigDetails(this._UserProfile, workflowMaint, parameters, request, out result) : this.AddMethod((Method) new WorkflowMaintMethod(workflowMaint, WorkflowMaintMethods.LoadESigDetails, (WorkflowMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) workflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((WorkflowMaint) null, (WorkflowMaint_LoadESigDetails_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus LoadESigDetails(WorkflowMaint workflowMaint)
    {
      return this.LoadESigDetails(workflowMaint, (WorkflowMaint_LoadESigDetails_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      return this.LoadESigDetails(workflowMaint, (WorkflowMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      result = (WorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) workflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkflowMaintService) this._Channel).New(this._UserProfile, workflowMaint, parameters, request, out result) : this.AddMethod((Method) new WorkflowMaintMethod(workflowMaint, WorkflowMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) workflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((WorkflowMaint) null, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus New(WorkflowMaint workflowMaint)
    {
      return this.New(workflowMaint, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus New(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      return this.New(workflowMaint, (WorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      result = (WorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) workflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkflowMaintService) this._Channel).NewCopy(this._UserProfile, workflowMaint, parameters, request, out result) : this.AddMethod((Method) new WorkflowMaintMethod(workflowMaint, WorkflowMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) workflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((WorkflowMaint) null, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus NewCopy(WorkflowMaint workflowMaint)
    {
      return this.NewCopy(workflowMaint, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus NewCopy(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      return this.NewCopy(workflowMaint, (WorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      result = (WorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) workflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkflowMaintService) this._Channel).NewRev(this._UserProfile, workflowMaint, parameters, request, out result) : this.AddMethod((Method) new WorkflowMaintMethod(workflowMaint, WorkflowMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) workflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((WorkflowMaint) null, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus NewRev(WorkflowMaint workflowMaint)
    {
      return this.NewRev(workflowMaint, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus NewRev(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      return this.NewRev(workflowMaint, (WorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      result = (WorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) workflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkflowMaintService) this._Channel).NewRevCopy(this._UserProfile, workflowMaint, parameters, request, out result) : this.AddMethod((Method) new WorkflowMaintMethod(workflowMaint, WorkflowMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) workflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((WorkflowMaint) null, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus NewRevCopy(WorkflowMaint workflowMaint)
    {
      return this.NewRevCopy(workflowMaint, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      return this.NewRevCopy(workflowMaint, (WorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      result = (WorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) workflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkflowMaintService) this._Channel).SaveAs(this._UserProfile, workflowMaint, parameters, request, out result) : this.AddMethod((Method) new WorkflowMaintMethod(workflowMaint, WorkflowMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) workflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((WorkflowMaint) null, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus SaveAs(WorkflowMaint workflowMaint)
    {
      return this.SaveAs(workflowMaint, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus SaveAs(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      return this.SaveAs(workflowMaint, (WorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      result = (WorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) workflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkflowMaintService) this._Channel).SaveAsRev(this._UserProfile, workflowMaint, parameters, request, out result) : this.AddMethod((Method) new WorkflowMaintMethod(workflowMaint, WorkflowMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) workflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((WorkflowMaint) null, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus SaveAsRev(WorkflowMaint workflowMaint)
    {
      return this.SaveAsRev(workflowMaint, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      return this.SaveAsRev(workflowMaint, (WorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      result = (WorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) workflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkflowMaintService) this._Channel).UnFreeze(this._UserProfile, workflowMaint, parameters, request, out result) : this.AddMethod((Method) new WorkflowMaintMethod(workflowMaint, WorkflowMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) workflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((WorkflowMaint) null, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus UnFreeze(WorkflowMaint workflowMaint)
    {
      return this.UnFreeze(workflowMaint, (WorkflowMaint_Parameters) null, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus UnFreeze(
      WorkflowMaint workflowMaint,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      return this.UnFreeze(workflowMaint, (WorkflowMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject workflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkflowMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((WorkflowMaint) workflowMaint, (WorkflowMaint_Parameters) parameters, (WorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject workflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkflowMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((WorkflowMaint) workflowMaint, (WorkflowMaint_Parameters) parameters, (WorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject workflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkflowMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((WorkflowMaint) workflowMaint, (WorkflowMaint_Parameters) parameters, (WorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject workflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkflowMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((WorkflowMaint) workflowMaint, (WorkflowMaint_Parameters) parameters, (WorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject workflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkflowMaint_Result result1;
        ResultStatus resultStatus = this.Delete((WorkflowMaint) workflowMaint, (WorkflowMaint_Parameters) parameters, (WorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject workflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkflowMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((WorkflowMaint) workflowMaint, (WorkflowMaint_Parameters) parameters, (WorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject workflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkflowMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((WorkflowMaint) workflowMaint, (WorkflowMaint_LoadESigDetails_Parameters) parameters, (WorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject workflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkflowMaint_Result result1;
        ResultStatus resultStatus = this.New((WorkflowMaint) workflowMaint, (WorkflowMaint_Parameters) parameters, (WorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject workflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkflowMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((WorkflowMaint) workflowMaint, (WorkflowMaint_Parameters) parameters, (WorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject workflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkflowMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((WorkflowMaint) workflowMaint, (WorkflowMaint_Parameters) parameters, (WorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject workflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkflowMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((WorkflowMaint) workflowMaint, (WorkflowMaint_Parameters) parameters, (WorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject workflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkflowMaint_Result result1;
        ResultStatus resultStatus = this.Load((WorkflowMaint) workflowMaint, (WorkflowMaint_Parameters) parameters, (WorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject workflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkflowMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((WorkflowMaint) workflowMaint, (WorkflowMaint_Parameters) parameters, (WorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      result = (WorkflowMaint_Result) null;
      try
      {
        WorkflowMaintMethod[] methods = new WorkflowMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IWorkflowMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        WorkflowMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((WorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      WorkflowMaint cdo,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      result = (WorkflowMaint_Result) null;
      try
      {
        return ((IWorkflowMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        WorkflowMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((WorkflowMaint) cdo, (WorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      return this.GetEnvironment((WorkflowMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      WorkflowMaint cdo,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      result = (WorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkflowMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new WorkflowMaintMethod(cdo, WorkflowMaintMethods.ExecuteTransaction, (WorkflowMaint_Parameters) null));
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
        WorkflowMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((WorkflowMaint) cdo, (WorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(WorkflowMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (WorkflowMaint_Request) null, out WorkflowMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result)
    {
      return this.ExecuteTransaction((WorkflowMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(WorkflowMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new WorkflowMaintMethod(cdo, WorkflowMaintMethods.AddDataTransaction, (WorkflowMaint_Parameters) null));
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
        return this.AddDataTransaction((WorkflowMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
