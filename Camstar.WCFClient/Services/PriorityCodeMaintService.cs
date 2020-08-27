// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PriorityCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PriorityCodeMaintService : UserCodeWithWMMaintBase
  {
    public PriorityCodeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPriorityCodeMaintService), userProfile);
    }

    public ResultStatus Delete(
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Parameters parameters,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      result = (PriorityCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) priorityCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityCodeMaintService) this._Channel).Delete(this._UserProfile, priorityCodeMaint, parameters, request, out result) : this.AddMethod((Method) new PriorityCodeMaintMethod(priorityCodeMaint, PriorityCodeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) priorityCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((PriorityCodeMaint) null, (PriorityCodeMaint_Parameters) null, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus Delete(PriorityCodeMaint priorityCodeMaint)
    {
      return this.Delete(priorityCodeMaint, (PriorityCodeMaint_Parameters) null, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus Delete(
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      return this.Delete(priorityCodeMaint, (PriorityCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Parameters parameters,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      result = (PriorityCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) priorityCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityCodeMaintService) this._Channel).Freeze(this._UserProfile, priorityCodeMaint, parameters, request, out result) : this.AddMethod((Method) new PriorityCodeMaintMethod(priorityCodeMaint, PriorityCodeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) priorityCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((PriorityCodeMaint) null, (PriorityCodeMaint_Parameters) null, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus Freeze(PriorityCodeMaint priorityCodeMaint)
    {
      return this.Freeze(priorityCodeMaint, (PriorityCodeMaint_Parameters) null, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus Freeze(
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      return this.Freeze(priorityCodeMaint, (PriorityCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Parameters parameters,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      result = (PriorityCodeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) priorityCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityCodeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, priorityCodeMaint, parameters, request, out result) : this.AddMethod((Method) new PriorityCodeMaintMethod(priorityCodeMaint, PriorityCodeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) priorityCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PriorityCodeMaint) null, (PriorityCodeMaint_Parameters) null, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(PriorityCodeMaint priorityCodeMaint)
    {
      return this.GetWIPMsgs(priorityCodeMaint, (PriorityCodeMaint_Parameters) null, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      return this.GetWIPMsgs(priorityCodeMaint, (PriorityCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Parameters parameters,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      result = (PriorityCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) priorityCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityCodeMaintService) this._Channel).Load(this._UserProfile, priorityCodeMaint, parameters, request, out result) : this.AddMethod((Method) new PriorityCodeMaintMethod(priorityCodeMaint, PriorityCodeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) priorityCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PriorityCodeMaint) null, (PriorityCodeMaint_Parameters) null, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus Load(PriorityCodeMaint priorityCodeMaint)
    {
      return this.Load(priorityCodeMaint, (PriorityCodeMaint_Parameters) null, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus Load(
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      return this.Load(priorityCodeMaint, (PriorityCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_LoadESigDetails_Parameters parameters,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      result = (PriorityCodeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) priorityCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityCodeMaintService) this._Channel).LoadESigDetails(this._UserProfile, priorityCodeMaint, parameters, request, out result) : this.AddMethod((Method) new PriorityCodeMaintMethod(priorityCodeMaint, PriorityCodeMaintMethods.LoadESigDetails, (PriorityCodeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) priorityCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PriorityCodeMaint) null, (PriorityCodeMaint_LoadESigDetails_Parameters) null, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(PriorityCodeMaint priorityCodeMaint)
    {
      return this.LoadESigDetails(priorityCodeMaint, (PriorityCodeMaint_LoadESigDetails_Parameters) null, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      return this.LoadESigDetails(priorityCodeMaint, (PriorityCodeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Parameters parameters,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      result = (PriorityCodeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) priorityCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityCodeMaintService) this._Channel).New(this._UserProfile, priorityCodeMaint, parameters, request, out result) : this.AddMethod((Method) new PriorityCodeMaintMethod(priorityCodeMaint, PriorityCodeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) priorityCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((PriorityCodeMaint) null, (PriorityCodeMaint_Parameters) null, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus New(PriorityCodeMaint priorityCodeMaint)
    {
      return this.New(priorityCodeMaint, (PriorityCodeMaint_Parameters) null, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus New(
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      return this.New(priorityCodeMaint, (PriorityCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Parameters parameters,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      result = (PriorityCodeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) priorityCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityCodeMaintService) this._Channel).NewCopy(this._UserProfile, priorityCodeMaint, parameters, request, out result) : this.AddMethod((Method) new PriorityCodeMaintMethod(priorityCodeMaint, PriorityCodeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) priorityCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((PriorityCodeMaint) null, (PriorityCodeMaint_Parameters) null, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus NewCopy(PriorityCodeMaint priorityCodeMaint)
    {
      return this.NewCopy(priorityCodeMaint, (PriorityCodeMaint_Parameters) null, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus NewCopy(
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      return this.NewCopy(priorityCodeMaint, (PriorityCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Parameters parameters,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      result = (PriorityCodeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) priorityCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityCodeMaintService) this._Channel).SaveAs(this._UserProfile, priorityCodeMaint, parameters, request, out result) : this.AddMethod((Method) new PriorityCodeMaintMethod(priorityCodeMaint, PriorityCodeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) priorityCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((PriorityCodeMaint) null, (PriorityCodeMaint_Parameters) null, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus SaveAs(PriorityCodeMaint priorityCodeMaint)
    {
      return this.SaveAs(priorityCodeMaint, (PriorityCodeMaint_Parameters) null, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus SaveAs(
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      return this.SaveAs(priorityCodeMaint, (PriorityCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Parameters parameters,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      result = (PriorityCodeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) priorityCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityCodeMaintService) this._Channel).UnFreeze(this._UserProfile, priorityCodeMaint, parameters, request, out result) : this.AddMethod((Method) new PriorityCodeMaintMethod(priorityCodeMaint, PriorityCodeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) priorityCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((PriorityCodeMaint) null, (PriorityCodeMaint_Parameters) null, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(PriorityCodeMaint priorityCodeMaint)
    {
      return this.UnFreeze(priorityCodeMaint, (PriorityCodeMaint_Parameters) null, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      return this.UnFreeze(priorityCodeMaint, (PriorityCodeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject priorityCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PriorityCodeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((PriorityCodeMaint) priorityCodeMaint, (PriorityCodeMaint_Parameters) parameters, (PriorityCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject priorityCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PriorityCodeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((PriorityCodeMaint) priorityCodeMaint, (PriorityCodeMaint_Parameters) parameters, (PriorityCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject priorityCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PriorityCodeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PriorityCodeMaint) priorityCodeMaint, (PriorityCodeMaint_LoadESigDetails_Parameters) parameters, (PriorityCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject priorityCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PriorityCodeMaint_Result result1;
        ResultStatus resultStatus = this.New((PriorityCodeMaint) priorityCodeMaint, (PriorityCodeMaint_Parameters) parameters, (PriorityCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject priorityCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PriorityCodeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((PriorityCodeMaint) priorityCodeMaint, (PriorityCodeMaint_Parameters) parameters, (PriorityCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject priorityCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PriorityCodeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((PriorityCodeMaint) priorityCodeMaint, (PriorityCodeMaint_Parameters) parameters, (PriorityCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject priorityCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PriorityCodeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((PriorityCodeMaint) priorityCodeMaint, (PriorityCodeMaint_Parameters) parameters, (PriorityCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject priorityCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PriorityCodeMaint_Result result1;
        ResultStatus resultStatus = this.Load((PriorityCodeMaint) priorityCodeMaint, (PriorityCodeMaint_Parameters) parameters, (PriorityCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject priorityCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PriorityCodeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PriorityCodeMaint) priorityCodeMaint, (PriorityCodeMaint_Parameters) parameters, (PriorityCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      result = (PriorityCodeMaint_Result) null;
      try
      {
        PriorityCodeMaintMethod[] methods = new PriorityCodeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPriorityCodeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PriorityCodeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PriorityCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PriorityCodeMaint cdo,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      result = (PriorityCodeMaint_Result) null;
      try
      {
        return ((IPriorityCodeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PriorityCodeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((PriorityCodeMaint) cdo, (PriorityCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      return this.GetEnvironment((PriorityCodeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PriorityCodeMaint cdo,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      result = (PriorityCodeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityCodeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PriorityCodeMaintMethod(cdo, PriorityCodeMaintMethods.ExecuteTransaction, (PriorityCodeMaint_Parameters) null));
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
        PriorityCodeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PriorityCodeMaint) cdo, (PriorityCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PriorityCodeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (PriorityCodeMaint_Request) null, out PriorityCodeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result)
    {
      return this.ExecuteTransaction((PriorityCodeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PriorityCodeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PriorityCodeMaintMethod(cdo, PriorityCodeMaintMethods.AddDataTransaction, (PriorityCodeMaint_Parameters) null));
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
        return this.AddDataTransaction((PriorityCodeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
