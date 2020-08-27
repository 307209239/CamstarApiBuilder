// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TaskListMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class TaskListMaintService : ProcessListMaintBase
  {
    public TaskListMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ITaskListMaintService), userProfile);
    }

    public ResultStatus Delete(
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      result = (TaskListMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) taskListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITaskListMaintService) this._Channel).Delete(this._UserProfile, taskListMaint, parameters, request, out result) : this.AddMethod((Method) new TaskListMaintMethod(taskListMaint, TaskListMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) taskListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((TaskListMaint) null, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus Delete(TaskListMaint taskListMaint)
    {
      return this.Delete(taskListMaint, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus Delete(
      TaskListMaint taskListMaint,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      return this.Delete(taskListMaint, (TaskListMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      result = (TaskListMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) taskListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITaskListMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, taskListMaint, parameters, request, out result) : this.AddMethod((Method) new TaskListMaintMethod(taskListMaint, TaskListMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) taskListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((TaskListMaint) null, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(TaskListMaint taskListMaint)
    {
      return this.DeleteAllRevisions(taskListMaint, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      TaskListMaint taskListMaint,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      return this.DeleteAllRevisions(taskListMaint, (TaskListMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      result = (TaskListMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) taskListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITaskListMaintService) this._Channel).Freeze(this._UserProfile, taskListMaint, parameters, request, out result) : this.AddMethod((Method) new TaskListMaintMethod(taskListMaint, TaskListMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) taskListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((TaskListMaint) null, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus Freeze(TaskListMaint taskListMaint)
    {
      return this.Freeze(taskListMaint, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus Freeze(
      TaskListMaint taskListMaint,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      return this.Freeze(taskListMaint, (TaskListMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      result = (TaskListMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) taskListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITaskListMaintService) this._Channel).GetWIPMsgs(this._UserProfile, taskListMaint, parameters, request, out result) : this.AddMethod((Method) new TaskListMaintMethod(taskListMaint, TaskListMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) taskListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((TaskListMaint) null, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(TaskListMaint taskListMaint)
    {
      return this.GetWIPMsgs(taskListMaint, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      TaskListMaint taskListMaint,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      return this.GetWIPMsgs(taskListMaint, (TaskListMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      result = (TaskListMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) taskListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITaskListMaintService) this._Channel).Load(this._UserProfile, taskListMaint, parameters, request, out result) : this.AddMethod((Method) new TaskListMaintMethod(taskListMaint, TaskListMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) taskListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((TaskListMaint) null, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus Load(TaskListMaint taskListMaint)
    {
      return this.Load(taskListMaint, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus Load(
      TaskListMaint taskListMaint,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      return this.Load(taskListMaint, (TaskListMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      TaskListMaint taskListMaint,
      TaskListMaint_LoadESigDetails_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      result = (TaskListMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) taskListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITaskListMaintService) this._Channel).LoadESigDetails(this._UserProfile, taskListMaint, parameters, request, out result) : this.AddMethod((Method) new TaskListMaintMethod(taskListMaint, TaskListMaintMethods.LoadESigDetails, (TaskListMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) taskListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((TaskListMaint) null, (TaskListMaint_LoadESigDetails_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus LoadESigDetails(TaskListMaint taskListMaint)
    {
      return this.LoadESigDetails(taskListMaint, (TaskListMaint_LoadESigDetails_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      TaskListMaint taskListMaint,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      return this.LoadESigDetails(taskListMaint, (TaskListMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      result = (TaskListMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) taskListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITaskListMaintService) this._Channel).New(this._UserProfile, taskListMaint, parameters, request, out result) : this.AddMethod((Method) new TaskListMaintMethod(taskListMaint, TaskListMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) taskListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((TaskListMaint) null, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus New(TaskListMaint taskListMaint)
    {
      return this.New(taskListMaint, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus New(
      TaskListMaint taskListMaint,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      return this.New(taskListMaint, (TaskListMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      result = (TaskListMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) taskListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITaskListMaintService) this._Channel).NewCopy(this._UserProfile, taskListMaint, parameters, request, out result) : this.AddMethod((Method) new TaskListMaintMethod(taskListMaint, TaskListMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) taskListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((TaskListMaint) null, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus NewCopy(TaskListMaint taskListMaint)
    {
      return this.NewCopy(taskListMaint, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus NewCopy(
      TaskListMaint taskListMaint,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      return this.NewCopy(taskListMaint, (TaskListMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      result = (TaskListMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) taskListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITaskListMaintService) this._Channel).NewRev(this._UserProfile, taskListMaint, parameters, request, out result) : this.AddMethod((Method) new TaskListMaintMethod(taskListMaint, TaskListMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) taskListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((TaskListMaint) null, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus NewRev(TaskListMaint taskListMaint)
    {
      return this.NewRev(taskListMaint, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus NewRev(
      TaskListMaint taskListMaint,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      return this.NewRev(taskListMaint, (TaskListMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      result = (TaskListMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) taskListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITaskListMaintService) this._Channel).NewRevCopy(this._UserProfile, taskListMaint, parameters, request, out result) : this.AddMethod((Method) new TaskListMaintMethod(taskListMaint, TaskListMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) taskListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((TaskListMaint) null, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus NewRevCopy(TaskListMaint taskListMaint)
    {
      return this.NewRevCopy(taskListMaint, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      TaskListMaint taskListMaint,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      return this.NewRevCopy(taskListMaint, (TaskListMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      result = (TaskListMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) taskListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITaskListMaintService) this._Channel).SaveAs(this._UserProfile, taskListMaint, parameters, request, out result) : this.AddMethod((Method) new TaskListMaintMethod(taskListMaint, TaskListMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) taskListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((TaskListMaint) null, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus SaveAs(TaskListMaint taskListMaint)
    {
      return this.SaveAs(taskListMaint, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus SaveAs(
      TaskListMaint taskListMaint,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      return this.SaveAs(taskListMaint, (TaskListMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      result = (TaskListMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) taskListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITaskListMaintService) this._Channel).SaveAsRev(this._UserProfile, taskListMaint, parameters, request, out result) : this.AddMethod((Method) new TaskListMaintMethod(taskListMaint, TaskListMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) taskListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((TaskListMaint) null, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus SaveAsRev(TaskListMaint taskListMaint)
    {
      return this.SaveAsRev(taskListMaint, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      TaskListMaint taskListMaint,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      return this.SaveAsRev(taskListMaint, (TaskListMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      result = (TaskListMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) taskListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITaskListMaintService) this._Channel).UnFreeze(this._UserProfile, taskListMaint, parameters, request, out result) : this.AddMethod((Method) new TaskListMaintMethod(taskListMaint, TaskListMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) taskListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((TaskListMaint) null, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus UnFreeze(TaskListMaint taskListMaint)
    {
      return this.UnFreeze(taskListMaint, (TaskListMaint_Parameters) null, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus UnFreeze(
      TaskListMaint taskListMaint,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      return this.UnFreeze(taskListMaint, (TaskListMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject taskListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TaskListMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((TaskListMaint) taskListMaint, (TaskListMaint_Parameters) parameters, (TaskListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject taskListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TaskListMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((TaskListMaint) taskListMaint, (TaskListMaint_Parameters) parameters, (TaskListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject taskListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TaskListMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((TaskListMaint) taskListMaint, (TaskListMaint_Parameters) parameters, (TaskListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject taskListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TaskListMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((TaskListMaint) taskListMaint, (TaskListMaint_Parameters) parameters, (TaskListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject taskListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TaskListMaint_Result result1;
        ResultStatus resultStatus = this.Delete((TaskListMaint) taskListMaint, (TaskListMaint_Parameters) parameters, (TaskListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject taskListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TaskListMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((TaskListMaint) taskListMaint, (TaskListMaint_Parameters) parameters, (TaskListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject taskListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TaskListMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((TaskListMaint) taskListMaint, (TaskListMaint_LoadESigDetails_Parameters) parameters, (TaskListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject taskListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TaskListMaint_Result result1;
        ResultStatus resultStatus = this.New((TaskListMaint) taskListMaint, (TaskListMaint_Parameters) parameters, (TaskListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject taskListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TaskListMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((TaskListMaint) taskListMaint, (TaskListMaint_Parameters) parameters, (TaskListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject taskListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TaskListMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((TaskListMaint) taskListMaint, (TaskListMaint_Parameters) parameters, (TaskListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject taskListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TaskListMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((TaskListMaint) taskListMaint, (TaskListMaint_Parameters) parameters, (TaskListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject taskListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TaskListMaint_Result result1;
        ResultStatus resultStatus = this.Load((TaskListMaint) taskListMaint, (TaskListMaint_Parameters) parameters, (TaskListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject taskListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TaskListMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((TaskListMaint) taskListMaint, (TaskListMaint_Parameters) parameters, (TaskListMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      result = (TaskListMaint_Result) null;
      try
      {
        TaskListMaintMethod[] methods = new TaskListMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ITaskListMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        TaskListMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((TaskListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TaskListMaint cdo,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      result = (TaskListMaint_Result) null;
      try
      {
        return ((ITaskListMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        TaskListMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((TaskListMaint) cdo, (TaskListMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      return this.GetEnvironment((TaskListMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      TaskListMaint cdo,
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      result = (TaskListMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITaskListMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new TaskListMaintMethod(cdo, TaskListMaintMethods.ExecuteTransaction, (TaskListMaint_Parameters) null));
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
        TaskListMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((TaskListMaint) cdo, (TaskListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(TaskListMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (TaskListMaint_Request) null, out TaskListMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      TaskListMaint_Request request,
      out TaskListMaint_Result result)
    {
      return this.ExecuteTransaction((TaskListMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(TaskListMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new TaskListMaintMethod(cdo, TaskListMaintMethods.AddDataTransaction, (TaskListMaint_Parameters) null));
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
        return this.AddDataTransaction((TaskListMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
