// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProcessTimerMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ProcessTimerMaintService : RevisionedObjectMaintBase
  {
    public ProcessTimerMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IProcessTimerMaintService), userProfile);
    }

    public ResultStatus Delete(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) processTimerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerMaintService) this._Channel).Delete(this._UserProfile, processTimerMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerMaintMethod(processTimerMaint, ProcessTimerMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) processTimerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ProcessTimerMaint) null, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus Delete(ProcessTimerMaint processTimerMaint)
    {
      return this.Delete(processTimerMaint, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus Delete(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.Delete(processTimerMaint, (ProcessTimerMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) processTimerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, processTimerMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerMaintMethod(processTimerMaint, ProcessTimerMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) processTimerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((ProcessTimerMaint) null, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(ProcessTimerMaint processTimerMaint)
    {
      return this.DeleteAllRevisions(processTimerMaint, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.DeleteAllRevisions(processTimerMaint, (ProcessTimerMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) processTimerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerMaintService) this._Channel).Freeze(this._UserProfile, processTimerMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerMaintMethod(processTimerMaint, ProcessTimerMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) processTimerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ProcessTimerMaint) null, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus Freeze(ProcessTimerMaint processTimerMaint)
    {
      return this.Freeze(processTimerMaint, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus Freeze(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.Freeze(processTimerMaint, (ProcessTimerMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) processTimerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerMaintService) this._Channel).GetWIPMsgs(this._UserProfile, processTimerMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerMaintMethod(processTimerMaint, ProcessTimerMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) processTimerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ProcessTimerMaint) null, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ProcessTimerMaint processTimerMaint)
    {
      return this.GetWIPMsgs(processTimerMaint, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.GetWIPMsgs(processTimerMaint, (ProcessTimerMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) processTimerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerMaintService) this._Channel).Load(this._UserProfile, processTimerMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerMaintMethod(processTimerMaint, ProcessTimerMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) processTimerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ProcessTimerMaint) null, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus Load(ProcessTimerMaint processTimerMaint)
    {
      return this.Load(processTimerMaint, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus Load(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.Load(processTimerMaint, (ProcessTimerMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_LoadESigDetails_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) processTimerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerMaintService) this._Channel).LoadESigDetails(this._UserProfile, processTimerMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerMaintMethod(processTimerMaint, ProcessTimerMaintMethods.LoadESigDetails, (ProcessTimerMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) processTimerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ProcessTimerMaint) null, (ProcessTimerMaint_LoadESigDetails_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ProcessTimerMaint processTimerMaint)
    {
      return this.LoadESigDetails(processTimerMaint, (ProcessTimerMaint_LoadESigDetails_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.LoadESigDetails(processTimerMaint, (ProcessTimerMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) processTimerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerMaintService) this._Channel).New(this._UserProfile, processTimerMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerMaintMethod(processTimerMaint, ProcessTimerMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) processTimerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ProcessTimerMaint) null, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus New(ProcessTimerMaint processTimerMaint)
    {
      return this.New(processTimerMaint, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus New(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.New(processTimerMaint, (ProcessTimerMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) processTimerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerMaintService) this._Channel).NewCopy(this._UserProfile, processTimerMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerMaintMethod(processTimerMaint, ProcessTimerMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) processTimerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ProcessTimerMaint) null, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus NewCopy(ProcessTimerMaint processTimerMaint)
    {
      return this.NewCopy(processTimerMaint, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus NewCopy(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.NewCopy(processTimerMaint, (ProcessTimerMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) processTimerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerMaintService) this._Channel).NewRev(this._UserProfile, processTimerMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerMaintMethod(processTimerMaint, ProcessTimerMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) processTimerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((ProcessTimerMaint) null, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus NewRev(ProcessTimerMaint processTimerMaint)
    {
      return this.NewRev(processTimerMaint, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus NewRev(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.NewRev(processTimerMaint, (ProcessTimerMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) processTimerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerMaintService) this._Channel).NewRevCopy(this._UserProfile, processTimerMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerMaintMethod(processTimerMaint, ProcessTimerMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) processTimerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((ProcessTimerMaint) null, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus NewRevCopy(ProcessTimerMaint processTimerMaint)
    {
      return this.NewRevCopy(processTimerMaint, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.NewRevCopy(processTimerMaint, (ProcessTimerMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) processTimerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerMaintService) this._Channel).SaveAs(this._UserProfile, processTimerMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerMaintMethod(processTimerMaint, ProcessTimerMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) processTimerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ProcessTimerMaint) null, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus SaveAs(ProcessTimerMaint processTimerMaint)
    {
      return this.SaveAs(processTimerMaint, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus SaveAs(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.SaveAs(processTimerMaint, (ProcessTimerMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) processTimerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerMaintService) this._Channel).SaveAsRev(this._UserProfile, processTimerMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerMaintMethod(processTimerMaint, ProcessTimerMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) processTimerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((ProcessTimerMaint) null, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus SaveAsRev(ProcessTimerMaint processTimerMaint)
    {
      return this.SaveAsRev(processTimerMaint, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.SaveAsRev(processTimerMaint, (ProcessTimerMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) processTimerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerMaintService) this._Channel).UnFreeze(this._UserProfile, processTimerMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerMaintMethod(processTimerMaint, ProcessTimerMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) processTimerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ProcessTimerMaint) null, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus UnFreeze(ProcessTimerMaint processTimerMaint)
    {
      return this.UnFreeze(processTimerMaint, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.UnFreeze(processTimerMaint, (ProcessTimerMaint_Parameters) null, request, out result);
    }

    public ResultStatus ValidateMaxTimeDtl(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      this.OnBeforeCall(nameof (ValidateMaxTimeDtl), (DCObject) processTimerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerMaintService) this._Channel).ValidateMaxTimeDtl(this._UserProfile, processTimerMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerMaintMethod(processTimerMaint, ProcessTimerMaintMethods.ValidateMaxTimeDtl, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateMaxTimeDtl), res, (DCObject) processTimerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateMaxTimeDtl()
    {
      return this.ValidateMaxTimeDtl((ProcessTimerMaint) null, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus ValidateMaxTimeDtl(ProcessTimerMaint processTimerMaint)
    {
      return this.ValidateMaxTimeDtl(processTimerMaint, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus ValidateMaxTimeDtl(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.ValidateMaxTimeDtl(processTimerMaint, (ProcessTimerMaint_Parameters) null, request, out result);
    }

    public ResultStatus ValidateMinTimeDtl(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      this.OnBeforeCall(nameof (ValidateMinTimeDtl), (DCObject) processTimerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerMaintService) this._Channel).ValidateMinTimeDtl(this._UserProfile, processTimerMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerMaintMethod(processTimerMaint, ProcessTimerMaintMethods.ValidateMinTimeDtl, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateMinTimeDtl), res, (DCObject) processTimerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateMinTimeDtl()
    {
      return this.ValidateMinTimeDtl((ProcessTimerMaint) null, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus ValidateMinTimeDtl(ProcessTimerMaint processTimerMaint)
    {
      return this.ValidateMinTimeDtl(processTimerMaint, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus ValidateMinTimeDtl(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.ValidateMinTimeDtl(processTimerMaint, (ProcessTimerMaint_Parameters) null, request, out result);
    }

    public ResultStatus ValidateProcessTime(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      this.OnBeforeCall(nameof (ValidateProcessTime), (DCObject) processTimerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerMaintService) this._Channel).ValidateProcessTime(this._UserProfile, processTimerMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerMaintMethod(processTimerMaint, ProcessTimerMaintMethods.ValidateProcessTime, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateProcessTime), res, (DCObject) processTimerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateProcessTime()
    {
      return this.ValidateProcessTime((ProcessTimerMaint) null, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus ValidateProcessTime(ProcessTimerMaint processTimerMaint)
    {
      return this.ValidateProcessTime(processTimerMaint, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus ValidateProcessTime(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.ValidateProcessTime(processTimerMaint, (ProcessTimerMaint_Parameters) null, request, out result);
    }

    public ResultStatus ValidateTime(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      this.OnBeforeCall(nameof (ValidateTime), (DCObject) processTimerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerMaintService) this._Channel).ValidateTime(this._UserProfile, processTimerMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerMaintMethod(processTimerMaint, ProcessTimerMaintMethods.ValidateTime, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateTime), res, (DCObject) processTimerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateTime()
    {
      return this.ValidateTime((ProcessTimerMaint) null, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus ValidateTime(ProcessTimerMaint processTimerMaint)
    {
      return this.ValidateTime(processTimerMaint, (ProcessTimerMaint_Parameters) null, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus ValidateTime(
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.ValidateTime(processTimerMaint, (ProcessTimerMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject processTimerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((ProcessTimerMaint) processTimerMaint, (ProcessTimerMaint_Parameters) parameters, (ProcessTimerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject processTimerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((ProcessTimerMaint) processTimerMaint, (ProcessTimerMaint_Parameters) parameters, (ProcessTimerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject processTimerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((ProcessTimerMaint) processTimerMaint, (ProcessTimerMaint_Parameters) parameters, (ProcessTimerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject processTimerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((ProcessTimerMaint) processTimerMaint, (ProcessTimerMaint_Parameters) parameters, (ProcessTimerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject processTimerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ProcessTimerMaint) processTimerMaint, (ProcessTimerMaint_Parameters) parameters, (ProcessTimerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject processTimerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ProcessTimerMaint) processTimerMaint, (ProcessTimerMaint_Parameters) parameters, (ProcessTimerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject processTimerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ProcessTimerMaint) processTimerMaint, (ProcessTimerMaint_LoadESigDetails_Parameters) parameters, (ProcessTimerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject processTimerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerMaint_Result result1;
        ResultStatus resultStatus = this.New((ProcessTimerMaint) processTimerMaint, (ProcessTimerMaint_Parameters) parameters, (ProcessTimerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject processTimerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ProcessTimerMaint) processTimerMaint, (ProcessTimerMaint_Parameters) parameters, (ProcessTimerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject processTimerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ProcessTimerMaint) processTimerMaint, (ProcessTimerMaint_Parameters) parameters, (ProcessTimerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject processTimerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ProcessTimerMaint) processTimerMaint, (ProcessTimerMaint_Parameters) parameters, (ProcessTimerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject processTimerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerMaint_Result result1;
        ResultStatus resultStatus = this.Load((ProcessTimerMaint) processTimerMaint, (ProcessTimerMaint_Parameters) parameters, (ProcessTimerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject processTimerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ProcessTimerMaint) processTimerMaint, (ProcessTimerMaint_Parameters) parameters, (ProcessTimerMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      try
      {
        ProcessTimerMaintMethod[] methods = new ProcessTimerMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IProcessTimerMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ProcessTimerMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ProcessTimerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProcessTimerMaint cdo,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      try
      {
        return ((IProcessTimerMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ProcessTimerMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ProcessTimerMaint) cdo, (ProcessTimerMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.GetEnvironment((ProcessTimerMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ProcessTimerMaint cdo,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      result = (ProcessTimerMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ProcessTimerMaintMethod(cdo, ProcessTimerMaintMethods.ExecuteTransaction, (ProcessTimerMaint_Parameters) null));
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
        ProcessTimerMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ProcessTimerMaint) cdo, (ProcessTimerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ProcessTimerMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ProcessTimerMaint_Request) null, out ProcessTimerMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result)
    {
      return this.ExecuteTransaction((ProcessTimerMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ProcessTimerMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ProcessTimerMaintMethod(cdo, ProcessTimerMaintMethods.AddDataTransaction, (ProcessTimerMaint_Parameters) null));
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
        return this.AddDataTransaction((ProcessTimerMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
