// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.WorkCenterMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class WorkCenterMaintService : NamedDataObjectMaintBase
  {
    public WorkCenterMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IWorkCenterMaintService), userProfile);
    }

    public ResultStatus Delete(
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Parameters parameters,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      result = (WorkCenterMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) workCenterMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkCenterMaintService) this._Channel).Delete(this._UserProfile, workCenterMaint, parameters, request, out result) : this.AddMethod((Method) new WorkCenterMaintMethod(workCenterMaint, WorkCenterMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) workCenterMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((WorkCenterMaint) null, (WorkCenterMaint_Parameters) null, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus Delete(WorkCenterMaint workCenterMaint)
    {
      return this.Delete(workCenterMaint, (WorkCenterMaint_Parameters) null, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus Delete(
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      return this.Delete(workCenterMaint, (WorkCenterMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Parameters parameters,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      result = (WorkCenterMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) workCenterMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkCenterMaintService) this._Channel).Freeze(this._UserProfile, workCenterMaint, parameters, request, out result) : this.AddMethod((Method) new WorkCenterMaintMethod(workCenterMaint, WorkCenterMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) workCenterMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((WorkCenterMaint) null, (WorkCenterMaint_Parameters) null, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus Freeze(WorkCenterMaint workCenterMaint)
    {
      return this.Freeze(workCenterMaint, (WorkCenterMaint_Parameters) null, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus Freeze(
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      return this.Freeze(workCenterMaint, (WorkCenterMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Parameters parameters,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      result = (WorkCenterMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) workCenterMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkCenterMaintService) this._Channel).GetWIPMsgs(this._UserProfile, workCenterMaint, parameters, request, out result) : this.AddMethod((Method) new WorkCenterMaintMethod(workCenterMaint, WorkCenterMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) workCenterMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((WorkCenterMaint) null, (WorkCenterMaint_Parameters) null, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(WorkCenterMaint workCenterMaint)
    {
      return this.GetWIPMsgs(workCenterMaint, (WorkCenterMaint_Parameters) null, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      return this.GetWIPMsgs(workCenterMaint, (WorkCenterMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Parameters parameters,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      result = (WorkCenterMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) workCenterMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkCenterMaintService) this._Channel).Load(this._UserProfile, workCenterMaint, parameters, request, out result) : this.AddMethod((Method) new WorkCenterMaintMethod(workCenterMaint, WorkCenterMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) workCenterMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((WorkCenterMaint) null, (WorkCenterMaint_Parameters) null, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus Load(WorkCenterMaint workCenterMaint)
    {
      return this.Load(workCenterMaint, (WorkCenterMaint_Parameters) null, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus Load(
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      return this.Load(workCenterMaint, (WorkCenterMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_LoadESigDetails_Parameters parameters,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      result = (WorkCenterMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) workCenterMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkCenterMaintService) this._Channel).LoadESigDetails(this._UserProfile, workCenterMaint, parameters, request, out result) : this.AddMethod((Method) new WorkCenterMaintMethod(workCenterMaint, WorkCenterMaintMethods.LoadESigDetails, (WorkCenterMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) workCenterMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((WorkCenterMaint) null, (WorkCenterMaint_LoadESigDetails_Parameters) null, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus LoadESigDetails(WorkCenterMaint workCenterMaint)
    {
      return this.LoadESigDetails(workCenterMaint, (WorkCenterMaint_LoadESigDetails_Parameters) null, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      return this.LoadESigDetails(workCenterMaint, (WorkCenterMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Parameters parameters,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      result = (WorkCenterMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) workCenterMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkCenterMaintService) this._Channel).New(this._UserProfile, workCenterMaint, parameters, request, out result) : this.AddMethod((Method) new WorkCenterMaintMethod(workCenterMaint, WorkCenterMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) workCenterMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((WorkCenterMaint) null, (WorkCenterMaint_Parameters) null, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus New(WorkCenterMaint workCenterMaint)
    {
      return this.New(workCenterMaint, (WorkCenterMaint_Parameters) null, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus New(
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      return this.New(workCenterMaint, (WorkCenterMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Parameters parameters,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      result = (WorkCenterMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) workCenterMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkCenterMaintService) this._Channel).NewCopy(this._UserProfile, workCenterMaint, parameters, request, out result) : this.AddMethod((Method) new WorkCenterMaintMethod(workCenterMaint, WorkCenterMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) workCenterMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((WorkCenterMaint) null, (WorkCenterMaint_Parameters) null, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus NewCopy(WorkCenterMaint workCenterMaint)
    {
      return this.NewCopy(workCenterMaint, (WorkCenterMaint_Parameters) null, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus NewCopy(
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      return this.NewCopy(workCenterMaint, (WorkCenterMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Parameters parameters,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      result = (WorkCenterMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) workCenterMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkCenterMaintService) this._Channel).SaveAs(this._UserProfile, workCenterMaint, parameters, request, out result) : this.AddMethod((Method) new WorkCenterMaintMethod(workCenterMaint, WorkCenterMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) workCenterMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((WorkCenterMaint) null, (WorkCenterMaint_Parameters) null, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus SaveAs(WorkCenterMaint workCenterMaint)
    {
      return this.SaveAs(workCenterMaint, (WorkCenterMaint_Parameters) null, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus SaveAs(
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      return this.SaveAs(workCenterMaint, (WorkCenterMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Parameters parameters,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      result = (WorkCenterMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) workCenterMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkCenterMaintService) this._Channel).UnFreeze(this._UserProfile, workCenterMaint, parameters, request, out result) : this.AddMethod((Method) new WorkCenterMaintMethod(workCenterMaint, WorkCenterMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) workCenterMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((WorkCenterMaint) null, (WorkCenterMaint_Parameters) null, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus UnFreeze(WorkCenterMaint workCenterMaint)
    {
      return this.UnFreeze(workCenterMaint, (WorkCenterMaint_Parameters) null, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus UnFreeze(
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      return this.UnFreeze(workCenterMaint, (WorkCenterMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject workCenterMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkCenterMaint_Result result1;
        ResultStatus resultStatus = this.Delete((WorkCenterMaint) workCenterMaint, (WorkCenterMaint_Parameters) parameters, (WorkCenterMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject workCenterMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkCenterMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((WorkCenterMaint) workCenterMaint, (WorkCenterMaint_Parameters) parameters, (WorkCenterMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject workCenterMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkCenterMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((WorkCenterMaint) workCenterMaint, (WorkCenterMaint_LoadESigDetails_Parameters) parameters, (WorkCenterMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject workCenterMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkCenterMaint_Result result1;
        ResultStatus resultStatus = this.New((WorkCenterMaint) workCenterMaint, (WorkCenterMaint_Parameters) parameters, (WorkCenterMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject workCenterMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkCenterMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((WorkCenterMaint) workCenterMaint, (WorkCenterMaint_Parameters) parameters, (WorkCenterMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject workCenterMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkCenterMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((WorkCenterMaint) workCenterMaint, (WorkCenterMaint_Parameters) parameters, (WorkCenterMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject workCenterMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkCenterMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((WorkCenterMaint) workCenterMaint, (WorkCenterMaint_Parameters) parameters, (WorkCenterMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject workCenterMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkCenterMaint_Result result1;
        ResultStatus resultStatus = this.Load((WorkCenterMaint) workCenterMaint, (WorkCenterMaint_Parameters) parameters, (WorkCenterMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject workCenterMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WorkCenterMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((WorkCenterMaint) workCenterMaint, (WorkCenterMaint_Parameters) parameters, (WorkCenterMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      result = (WorkCenterMaint_Result) null;
      try
      {
        WorkCenterMaintMethod[] methods = new WorkCenterMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IWorkCenterMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        WorkCenterMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((WorkCenterMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      WorkCenterMaint cdo,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      result = (WorkCenterMaint_Result) null;
      try
      {
        return ((IWorkCenterMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        WorkCenterMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((WorkCenterMaint) cdo, (WorkCenterMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      return this.GetEnvironment((WorkCenterMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      WorkCenterMaint cdo,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      result = (WorkCenterMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWorkCenterMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new WorkCenterMaintMethod(cdo, WorkCenterMaintMethods.ExecuteTransaction, (WorkCenterMaint_Parameters) null));
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
        WorkCenterMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((WorkCenterMaint) cdo, (WorkCenterMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(WorkCenterMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (WorkCenterMaint_Request) null, out WorkCenterMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result)
    {
      return this.ExecuteTransaction((WorkCenterMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(WorkCenterMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new WorkCenterMaintMethod(cdo, WorkCenterMaintMethods.AddDataTransaction, (WorkCenterMaint_Parameters) null));
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
        return this.AddDataTransaction((WorkCenterMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
