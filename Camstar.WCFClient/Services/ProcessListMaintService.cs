// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProcessListMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ProcessListMaintService : RevisionedObjectMaintBase
  {
    public ProcessListMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IProcessListMaintService), userProfile);
    }

    public ResultStatus Delete(
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      result = (ProcessListMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) processListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessListMaintService) this._Channel).Delete(this._UserProfile, processListMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessListMaintMethod(processListMaint, ProcessListMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) processListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ProcessListMaint) null, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus Delete(ProcessListMaint processListMaint)
    {
      return this.Delete(processListMaint, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus Delete(
      ProcessListMaint processListMaint,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      return this.Delete(processListMaint, (ProcessListMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      result = (ProcessListMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) processListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessListMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, processListMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessListMaintMethod(processListMaint, ProcessListMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) processListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((ProcessListMaint) null, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(ProcessListMaint processListMaint)
    {
      return this.DeleteAllRevisions(processListMaint, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      ProcessListMaint processListMaint,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      return this.DeleteAllRevisions(processListMaint, (ProcessListMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      result = (ProcessListMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) processListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessListMaintService) this._Channel).Freeze(this._UserProfile, processListMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessListMaintMethod(processListMaint, ProcessListMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) processListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ProcessListMaint) null, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus Freeze(ProcessListMaint processListMaint)
    {
      return this.Freeze(processListMaint, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus Freeze(
      ProcessListMaint processListMaint,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      return this.Freeze(processListMaint, (ProcessListMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      result = (ProcessListMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) processListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessListMaintService) this._Channel).GetWIPMsgs(this._UserProfile, processListMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessListMaintMethod(processListMaint, ProcessListMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) processListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ProcessListMaint) null, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ProcessListMaint processListMaint)
    {
      return this.GetWIPMsgs(processListMaint, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ProcessListMaint processListMaint,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      return this.GetWIPMsgs(processListMaint, (ProcessListMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      result = (ProcessListMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) processListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessListMaintService) this._Channel).Load(this._UserProfile, processListMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessListMaintMethod(processListMaint, ProcessListMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) processListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ProcessListMaint) null, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus Load(ProcessListMaint processListMaint)
    {
      return this.Load(processListMaint, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus Load(
      ProcessListMaint processListMaint,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      return this.Load(processListMaint, (ProcessListMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ProcessListMaint processListMaint,
      ProcessListMaint_LoadESigDetails_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      result = (ProcessListMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) processListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessListMaintService) this._Channel).LoadESigDetails(this._UserProfile, processListMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessListMaintMethod(processListMaint, ProcessListMaintMethods.LoadESigDetails, (ProcessListMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) processListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ProcessListMaint) null, (ProcessListMaint_LoadESigDetails_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ProcessListMaint processListMaint)
    {
      return this.LoadESigDetails(processListMaint, (ProcessListMaint_LoadESigDetails_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ProcessListMaint processListMaint,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      return this.LoadESigDetails(processListMaint, (ProcessListMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      result = (ProcessListMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) processListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessListMaintService) this._Channel).New(this._UserProfile, processListMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessListMaintMethod(processListMaint, ProcessListMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) processListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ProcessListMaint) null, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus New(ProcessListMaint processListMaint)
    {
      return this.New(processListMaint, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus New(
      ProcessListMaint processListMaint,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      return this.New(processListMaint, (ProcessListMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      result = (ProcessListMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) processListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessListMaintService) this._Channel).NewCopy(this._UserProfile, processListMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessListMaintMethod(processListMaint, ProcessListMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) processListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ProcessListMaint) null, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus NewCopy(ProcessListMaint processListMaint)
    {
      return this.NewCopy(processListMaint, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus NewCopy(
      ProcessListMaint processListMaint,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      return this.NewCopy(processListMaint, (ProcessListMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      result = (ProcessListMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) processListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessListMaintService) this._Channel).NewRev(this._UserProfile, processListMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessListMaintMethod(processListMaint, ProcessListMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) processListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((ProcessListMaint) null, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus NewRev(ProcessListMaint processListMaint)
    {
      return this.NewRev(processListMaint, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus NewRev(
      ProcessListMaint processListMaint,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      return this.NewRev(processListMaint, (ProcessListMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      result = (ProcessListMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) processListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessListMaintService) this._Channel).NewRevCopy(this._UserProfile, processListMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessListMaintMethod(processListMaint, ProcessListMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) processListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((ProcessListMaint) null, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus NewRevCopy(ProcessListMaint processListMaint)
    {
      return this.NewRevCopy(processListMaint, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      ProcessListMaint processListMaint,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      return this.NewRevCopy(processListMaint, (ProcessListMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      result = (ProcessListMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) processListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessListMaintService) this._Channel).SaveAs(this._UserProfile, processListMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessListMaintMethod(processListMaint, ProcessListMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) processListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ProcessListMaint) null, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus SaveAs(ProcessListMaint processListMaint)
    {
      return this.SaveAs(processListMaint, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus SaveAs(
      ProcessListMaint processListMaint,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      return this.SaveAs(processListMaint, (ProcessListMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      result = (ProcessListMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) processListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessListMaintService) this._Channel).SaveAsRev(this._UserProfile, processListMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessListMaintMethod(processListMaint, ProcessListMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) processListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((ProcessListMaint) null, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus SaveAsRev(ProcessListMaint processListMaint)
    {
      return this.SaveAsRev(processListMaint, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      ProcessListMaint processListMaint,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      return this.SaveAsRev(processListMaint, (ProcessListMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      result = (ProcessListMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) processListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessListMaintService) this._Channel).UnFreeze(this._UserProfile, processListMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessListMaintMethod(processListMaint, ProcessListMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) processListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ProcessListMaint) null, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus UnFreeze(ProcessListMaint processListMaint)
    {
      return this.UnFreeze(processListMaint, (ProcessListMaint_Parameters) null, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ProcessListMaint processListMaint,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      return this.UnFreeze(processListMaint, (ProcessListMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject processListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessListMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((ProcessListMaint) processListMaint, (ProcessListMaint_Parameters) parameters, (ProcessListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject processListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessListMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((ProcessListMaint) processListMaint, (ProcessListMaint_Parameters) parameters, (ProcessListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject processListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessListMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((ProcessListMaint) processListMaint, (ProcessListMaint_Parameters) parameters, (ProcessListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject processListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessListMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((ProcessListMaint) processListMaint, (ProcessListMaint_Parameters) parameters, (ProcessListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject processListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessListMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ProcessListMaint) processListMaint, (ProcessListMaint_Parameters) parameters, (ProcessListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject processListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessListMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ProcessListMaint) processListMaint, (ProcessListMaint_Parameters) parameters, (ProcessListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject processListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessListMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ProcessListMaint) processListMaint, (ProcessListMaint_LoadESigDetails_Parameters) parameters, (ProcessListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject processListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessListMaint_Result result1;
        ResultStatus resultStatus = this.New((ProcessListMaint) processListMaint, (ProcessListMaint_Parameters) parameters, (ProcessListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject processListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessListMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ProcessListMaint) processListMaint, (ProcessListMaint_Parameters) parameters, (ProcessListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject processListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessListMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ProcessListMaint) processListMaint, (ProcessListMaint_Parameters) parameters, (ProcessListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject processListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessListMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ProcessListMaint) processListMaint, (ProcessListMaint_Parameters) parameters, (ProcessListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject processListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessListMaint_Result result1;
        ResultStatus resultStatus = this.Load((ProcessListMaint) processListMaint, (ProcessListMaint_Parameters) parameters, (ProcessListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject processListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessListMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ProcessListMaint) processListMaint, (ProcessListMaint_Parameters) parameters, (ProcessListMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      result = (ProcessListMaint_Result) null;
      try
      {
        ProcessListMaintMethod[] methods = new ProcessListMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IProcessListMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ProcessListMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ProcessListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProcessListMaint cdo,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      result = (ProcessListMaint_Result) null;
      try
      {
        return ((IProcessListMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ProcessListMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ProcessListMaint) cdo, (ProcessListMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      return this.GetEnvironment((ProcessListMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ProcessListMaint cdo,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      result = (ProcessListMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessListMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ProcessListMaintMethod(cdo, ProcessListMaintMethods.ExecuteTransaction, (ProcessListMaint_Parameters) null));
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
        ProcessListMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ProcessListMaint) cdo, (ProcessListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ProcessListMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ProcessListMaint_Request) null, out ProcessListMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result)
    {
      return this.ExecuteTransaction((ProcessListMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ProcessListMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ProcessListMaintMethod(cdo, ProcessListMaintMethods.AddDataTransaction, (ProcessListMaint_Parameters) null));
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
        return this.AddDataTransaction((ProcessListMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
