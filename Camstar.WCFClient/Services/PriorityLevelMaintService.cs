// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PriorityLevelMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PriorityLevelMaintService : UserCodeMaintBase
  {
    public PriorityLevelMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPriorityLevelMaintService), userProfile);
    }

    public ResultStatus Delete(
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Parameters parameters,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      result = (PriorityLevelMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) priorityLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityLevelMaintService) this._Channel).Delete(this._UserProfile, priorityLevelMaint, parameters, request, out result) : this.AddMethod((Method) new PriorityLevelMaintMethod(priorityLevelMaint, PriorityLevelMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) priorityLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((PriorityLevelMaint) null, (PriorityLevelMaint_Parameters) null, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus Delete(PriorityLevelMaint priorityLevelMaint)
    {
      return this.Delete(priorityLevelMaint, (PriorityLevelMaint_Parameters) null, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus Delete(
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      return this.Delete(priorityLevelMaint, (PriorityLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Parameters parameters,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      result = (PriorityLevelMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) priorityLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityLevelMaintService) this._Channel).Freeze(this._UserProfile, priorityLevelMaint, parameters, request, out result) : this.AddMethod((Method) new PriorityLevelMaintMethod(priorityLevelMaint, PriorityLevelMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) priorityLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((PriorityLevelMaint) null, (PriorityLevelMaint_Parameters) null, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus Freeze(PriorityLevelMaint priorityLevelMaint)
    {
      return this.Freeze(priorityLevelMaint, (PriorityLevelMaint_Parameters) null, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus Freeze(
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      return this.Freeze(priorityLevelMaint, (PriorityLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Parameters parameters,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      result = (PriorityLevelMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) priorityLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityLevelMaintService) this._Channel).GetWIPMsgs(this._UserProfile, priorityLevelMaint, parameters, request, out result) : this.AddMethod((Method) new PriorityLevelMaintMethod(priorityLevelMaint, PriorityLevelMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) priorityLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PriorityLevelMaint) null, (PriorityLevelMaint_Parameters) null, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(PriorityLevelMaint priorityLevelMaint)
    {
      return this.GetWIPMsgs(priorityLevelMaint, (PriorityLevelMaint_Parameters) null, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      return this.GetWIPMsgs(priorityLevelMaint, (PriorityLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Parameters parameters,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      result = (PriorityLevelMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) priorityLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityLevelMaintService) this._Channel).Load(this._UserProfile, priorityLevelMaint, parameters, request, out result) : this.AddMethod((Method) new PriorityLevelMaintMethod(priorityLevelMaint, PriorityLevelMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) priorityLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PriorityLevelMaint) null, (PriorityLevelMaint_Parameters) null, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus Load(PriorityLevelMaint priorityLevelMaint)
    {
      return this.Load(priorityLevelMaint, (PriorityLevelMaint_Parameters) null, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus Load(
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      return this.Load(priorityLevelMaint, (PriorityLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_LoadESigDetails_Parameters parameters,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      result = (PriorityLevelMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) priorityLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityLevelMaintService) this._Channel).LoadESigDetails(this._UserProfile, priorityLevelMaint, parameters, request, out result) : this.AddMethod((Method) new PriorityLevelMaintMethod(priorityLevelMaint, PriorityLevelMaintMethods.LoadESigDetails, (PriorityLevelMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) priorityLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PriorityLevelMaint) null, (PriorityLevelMaint_LoadESigDetails_Parameters) null, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus LoadESigDetails(PriorityLevelMaint priorityLevelMaint)
    {
      return this.LoadESigDetails(priorityLevelMaint, (PriorityLevelMaint_LoadESigDetails_Parameters) null, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      return this.LoadESigDetails(priorityLevelMaint, (PriorityLevelMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Parameters parameters,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      result = (PriorityLevelMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) priorityLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityLevelMaintService) this._Channel).New(this._UserProfile, priorityLevelMaint, parameters, request, out result) : this.AddMethod((Method) new PriorityLevelMaintMethod(priorityLevelMaint, PriorityLevelMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) priorityLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((PriorityLevelMaint) null, (PriorityLevelMaint_Parameters) null, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus New(PriorityLevelMaint priorityLevelMaint)
    {
      return this.New(priorityLevelMaint, (PriorityLevelMaint_Parameters) null, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus New(
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      return this.New(priorityLevelMaint, (PriorityLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Parameters parameters,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      result = (PriorityLevelMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) priorityLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityLevelMaintService) this._Channel).NewCopy(this._UserProfile, priorityLevelMaint, parameters, request, out result) : this.AddMethod((Method) new PriorityLevelMaintMethod(priorityLevelMaint, PriorityLevelMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) priorityLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((PriorityLevelMaint) null, (PriorityLevelMaint_Parameters) null, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus NewCopy(PriorityLevelMaint priorityLevelMaint)
    {
      return this.NewCopy(priorityLevelMaint, (PriorityLevelMaint_Parameters) null, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus NewCopy(
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      return this.NewCopy(priorityLevelMaint, (PriorityLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Parameters parameters,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      result = (PriorityLevelMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) priorityLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityLevelMaintService) this._Channel).SaveAs(this._UserProfile, priorityLevelMaint, parameters, request, out result) : this.AddMethod((Method) new PriorityLevelMaintMethod(priorityLevelMaint, PriorityLevelMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) priorityLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((PriorityLevelMaint) null, (PriorityLevelMaint_Parameters) null, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus SaveAs(PriorityLevelMaint priorityLevelMaint)
    {
      return this.SaveAs(priorityLevelMaint, (PriorityLevelMaint_Parameters) null, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus SaveAs(
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      return this.SaveAs(priorityLevelMaint, (PriorityLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Parameters parameters,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      result = (PriorityLevelMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) priorityLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityLevelMaintService) this._Channel).UnFreeze(this._UserProfile, priorityLevelMaint, parameters, request, out result) : this.AddMethod((Method) new PriorityLevelMaintMethod(priorityLevelMaint, PriorityLevelMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) priorityLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((PriorityLevelMaint) null, (PriorityLevelMaint_Parameters) null, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus UnFreeze(PriorityLevelMaint priorityLevelMaint)
    {
      return this.UnFreeze(priorityLevelMaint, (PriorityLevelMaint_Parameters) null, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      return this.UnFreeze(priorityLevelMaint, (PriorityLevelMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject priorityLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PriorityLevelMaint_Result result1;
        ResultStatus resultStatus = this.Delete((PriorityLevelMaint) priorityLevelMaint, (PriorityLevelMaint_Parameters) parameters, (PriorityLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject priorityLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PriorityLevelMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((PriorityLevelMaint) priorityLevelMaint, (PriorityLevelMaint_Parameters) parameters, (PriorityLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject priorityLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PriorityLevelMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PriorityLevelMaint) priorityLevelMaint, (PriorityLevelMaint_LoadESigDetails_Parameters) parameters, (PriorityLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject priorityLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PriorityLevelMaint_Result result1;
        ResultStatus resultStatus = this.New((PriorityLevelMaint) priorityLevelMaint, (PriorityLevelMaint_Parameters) parameters, (PriorityLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject priorityLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PriorityLevelMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((PriorityLevelMaint) priorityLevelMaint, (PriorityLevelMaint_Parameters) parameters, (PriorityLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject priorityLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PriorityLevelMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((PriorityLevelMaint) priorityLevelMaint, (PriorityLevelMaint_Parameters) parameters, (PriorityLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject priorityLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PriorityLevelMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((PriorityLevelMaint) priorityLevelMaint, (PriorityLevelMaint_Parameters) parameters, (PriorityLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject priorityLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PriorityLevelMaint_Result result1;
        ResultStatus resultStatus = this.Load((PriorityLevelMaint) priorityLevelMaint, (PriorityLevelMaint_Parameters) parameters, (PriorityLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject priorityLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PriorityLevelMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PriorityLevelMaint) priorityLevelMaint, (PriorityLevelMaint_Parameters) parameters, (PriorityLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      result = (PriorityLevelMaint_Result) null;
      try
      {
        PriorityLevelMaintMethod[] methods = new PriorityLevelMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPriorityLevelMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PriorityLevelMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PriorityLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PriorityLevelMaint cdo,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      result = (PriorityLevelMaint_Result) null;
      try
      {
        return ((IPriorityLevelMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PriorityLevelMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((PriorityLevelMaint) cdo, (PriorityLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      return this.GetEnvironment((PriorityLevelMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PriorityLevelMaint cdo,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      result = (PriorityLevelMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPriorityLevelMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PriorityLevelMaintMethod(cdo, PriorityLevelMaintMethods.ExecuteTransaction, (PriorityLevelMaint_Parameters) null));
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
        PriorityLevelMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PriorityLevelMaint) cdo, (PriorityLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PriorityLevelMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (PriorityLevelMaint_Request) null, out PriorityLevelMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result)
    {
      return this.ExecuteTransaction((PriorityLevelMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PriorityLevelMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PriorityLevelMaintMethod(cdo, PriorityLevelMaintMethods.AddDataTransaction, (PriorityLevelMaint_Parameters) null));
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
        return this.AddDataTransaction((PriorityLevelMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
