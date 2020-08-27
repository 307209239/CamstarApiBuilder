// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProcessTimerTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ProcessTimerTypeMaintService : UserCodeMaintBase
  {
    public ProcessTimerTypeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IProcessTimerTypeMaintService), userProfile);
    }

    public ResultStatus Delete(
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Parameters parameters,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      result = (ProcessTimerTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) processTimerTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerTypeMaintService) this._Channel).Delete(this._UserProfile, processTimerTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerTypeMaintMethod(processTimerTypeMaint, ProcessTimerTypeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) processTimerTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ProcessTimerTypeMaint) null, (ProcessTimerTypeMaint_Parameters) null, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus Delete(ProcessTimerTypeMaint processTimerTypeMaint)
    {
      return this.Delete(processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) null, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus Delete(
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      return this.Delete(processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Parameters parameters,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      result = (ProcessTimerTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) processTimerTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerTypeMaintService) this._Channel).Freeze(this._UserProfile, processTimerTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerTypeMaintMethod(processTimerTypeMaint, ProcessTimerTypeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) processTimerTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ProcessTimerTypeMaint) null, (ProcessTimerTypeMaint_Parameters) null, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus Freeze(ProcessTimerTypeMaint processTimerTypeMaint)
    {
      return this.Freeze(processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) null, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus Freeze(
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      return this.Freeze(processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Parameters parameters,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      result = (ProcessTimerTypeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) processTimerTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerTypeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, processTimerTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerTypeMaintMethod(processTimerTypeMaint, ProcessTimerTypeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) processTimerTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ProcessTimerTypeMaint) null, (ProcessTimerTypeMaint_Parameters) null, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ProcessTimerTypeMaint processTimerTypeMaint)
    {
      return this.GetWIPMsgs(processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) null, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      return this.GetWIPMsgs(processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Parameters parameters,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      result = (ProcessTimerTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) processTimerTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerTypeMaintService) this._Channel).Load(this._UserProfile, processTimerTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerTypeMaintMethod(processTimerTypeMaint, ProcessTimerTypeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) processTimerTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ProcessTimerTypeMaint) null, (ProcessTimerTypeMaint_Parameters) null, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus Load(ProcessTimerTypeMaint processTimerTypeMaint)
    {
      return this.Load(processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) null, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus Load(
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      return this.Load(processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_LoadESigDetails_Parameters parameters,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      result = (ProcessTimerTypeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) processTimerTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerTypeMaintService) this._Channel).LoadESigDetails(this._UserProfile, processTimerTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerTypeMaintMethod(processTimerTypeMaint, ProcessTimerTypeMaintMethods.LoadESigDetails, (ProcessTimerTypeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) processTimerTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ProcessTimerTypeMaint) null, (ProcessTimerTypeMaint_LoadESigDetails_Parameters) null, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ProcessTimerTypeMaint processTimerTypeMaint)
    {
      return this.LoadESigDetails(processTimerTypeMaint, (ProcessTimerTypeMaint_LoadESigDetails_Parameters) null, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      return this.LoadESigDetails(processTimerTypeMaint, (ProcessTimerTypeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Parameters parameters,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      result = (ProcessTimerTypeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) processTimerTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerTypeMaintService) this._Channel).New(this._UserProfile, processTimerTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerTypeMaintMethod(processTimerTypeMaint, ProcessTimerTypeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) processTimerTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ProcessTimerTypeMaint) null, (ProcessTimerTypeMaint_Parameters) null, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus New(ProcessTimerTypeMaint processTimerTypeMaint)
    {
      return this.New(processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) null, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus New(
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      return this.New(processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Parameters parameters,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      result = (ProcessTimerTypeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) processTimerTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerTypeMaintService) this._Channel).NewCopy(this._UserProfile, processTimerTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerTypeMaintMethod(processTimerTypeMaint, ProcessTimerTypeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) processTimerTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ProcessTimerTypeMaint) null, (ProcessTimerTypeMaint_Parameters) null, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus NewCopy(ProcessTimerTypeMaint processTimerTypeMaint)
    {
      return this.NewCopy(processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) null, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus NewCopy(
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      return this.NewCopy(processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Parameters parameters,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      result = (ProcessTimerTypeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) processTimerTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerTypeMaintService) this._Channel).SaveAs(this._UserProfile, processTimerTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerTypeMaintMethod(processTimerTypeMaint, ProcessTimerTypeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) processTimerTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ProcessTimerTypeMaint) null, (ProcessTimerTypeMaint_Parameters) null, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus SaveAs(ProcessTimerTypeMaint processTimerTypeMaint)
    {
      return this.SaveAs(processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) null, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus SaveAs(
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      return this.SaveAs(processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Parameters parameters,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      result = (ProcessTimerTypeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) processTimerTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerTypeMaintService) this._Channel).UnFreeze(this._UserProfile, processTimerTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerTypeMaintMethod(processTimerTypeMaint, ProcessTimerTypeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) processTimerTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ProcessTimerTypeMaint) null, (ProcessTimerTypeMaint_Parameters) null, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(ProcessTimerTypeMaint processTimerTypeMaint)
    {
      return this.UnFreeze(processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) null, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      return this.UnFreeze(processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject processTimerTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerTypeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ProcessTimerTypeMaint) processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) parameters, (ProcessTimerTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject processTimerTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerTypeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ProcessTimerTypeMaint) processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) parameters, (ProcessTimerTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject processTimerTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerTypeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ProcessTimerTypeMaint) processTimerTypeMaint, (ProcessTimerTypeMaint_LoadESigDetails_Parameters) parameters, (ProcessTimerTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject processTimerTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerTypeMaint_Result result1;
        ResultStatus resultStatus = this.New((ProcessTimerTypeMaint) processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) parameters, (ProcessTimerTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject processTimerTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerTypeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ProcessTimerTypeMaint) processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) parameters, (ProcessTimerTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject processTimerTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerTypeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ProcessTimerTypeMaint) processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) parameters, (ProcessTimerTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject processTimerTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerTypeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ProcessTimerTypeMaint) processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) parameters, (ProcessTimerTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject processTimerTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerTypeMaint_Result result1;
        ResultStatus resultStatus = this.Load((ProcessTimerTypeMaint) processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) parameters, (ProcessTimerTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject processTimerTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerTypeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ProcessTimerTypeMaint) processTimerTypeMaint, (ProcessTimerTypeMaint_Parameters) parameters, (ProcessTimerTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      result = (ProcessTimerTypeMaint_Result) null;
      try
      {
        ProcessTimerTypeMaintMethod[] methods = new ProcessTimerTypeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IProcessTimerTypeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ProcessTimerTypeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ProcessTimerTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProcessTimerTypeMaint cdo,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      result = (ProcessTimerTypeMaint_Result) null;
      try
      {
        return ((IProcessTimerTypeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ProcessTimerTypeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ProcessTimerTypeMaint) cdo, (ProcessTimerTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      return this.GetEnvironment((ProcessTimerTypeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ProcessTimerTypeMaint cdo,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      result = (ProcessTimerTypeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerTypeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ProcessTimerTypeMaintMethod(cdo, ProcessTimerTypeMaintMethods.ExecuteTransaction, (ProcessTimerTypeMaint_Parameters) null));
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
        ProcessTimerTypeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ProcessTimerTypeMaint) cdo, (ProcessTimerTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ProcessTimerTypeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ProcessTimerTypeMaint_Request) null, out ProcessTimerTypeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result)
    {
      return this.ExecuteTransaction((ProcessTimerTypeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ProcessTimerTypeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ProcessTimerTypeMaintMethod(cdo, ProcessTimerTypeMaintMethods.AddDataTransaction, (ProcessTimerTypeMaint_Parameters) null));
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
        return this.AddDataTransaction((ProcessTimerTypeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
