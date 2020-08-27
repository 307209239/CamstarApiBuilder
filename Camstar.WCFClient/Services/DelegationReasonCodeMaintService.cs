// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DelegationReasonCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DelegationReasonCodeMaintService : UserCodeMaintBase
  {
    public DelegationReasonCodeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDelegationReasonCodeMaintService), userProfile);
    }

    public ResultStatus Delete(
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Parameters parameters,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      result = (DelegationReasonCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) delegationReasonCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationReasonCodeMaintService) this._Channel).Delete(this._UserProfile, delegationReasonCodeMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationReasonCodeMaintMethod(delegationReasonCodeMaint, DelegationReasonCodeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) delegationReasonCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((DelegationReasonCodeMaint) null, (DelegationReasonCodeMaint_Parameters) null, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus Delete(
      DelegationReasonCodeMaint delegationReasonCodeMaint)
    {
      return this.Delete(delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) null, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus Delete(
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      return this.Delete(delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Parameters parameters,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      result = (DelegationReasonCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) delegationReasonCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationReasonCodeMaintService) this._Channel).Freeze(this._UserProfile, delegationReasonCodeMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationReasonCodeMaintMethod(delegationReasonCodeMaint, DelegationReasonCodeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) delegationReasonCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((DelegationReasonCodeMaint) null, (DelegationReasonCodeMaint_Parameters) null, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus Freeze(
      DelegationReasonCodeMaint delegationReasonCodeMaint)
    {
      return this.Freeze(delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) null, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus Freeze(
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      return this.Freeze(delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Parameters parameters,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      result = (DelegationReasonCodeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) delegationReasonCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationReasonCodeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, delegationReasonCodeMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationReasonCodeMaintMethod(delegationReasonCodeMaint, DelegationReasonCodeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) delegationReasonCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DelegationReasonCodeMaint) null, (DelegationReasonCodeMaint_Parameters) null, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DelegationReasonCodeMaint delegationReasonCodeMaint)
    {
      return this.GetWIPMsgs(delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) null, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      return this.GetWIPMsgs(delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Parameters parameters,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      result = (DelegationReasonCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) delegationReasonCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationReasonCodeMaintService) this._Channel).Load(this._UserProfile, delegationReasonCodeMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationReasonCodeMaintMethod(delegationReasonCodeMaint, DelegationReasonCodeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) delegationReasonCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DelegationReasonCodeMaint) null, (DelegationReasonCodeMaint_Parameters) null, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus Load(
      DelegationReasonCodeMaint delegationReasonCodeMaint)
    {
      return this.Load(delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) null, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus Load(
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      return this.Load(delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_LoadESigDetails_Parameters parameters,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      result = (DelegationReasonCodeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) delegationReasonCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationReasonCodeMaintService) this._Channel).LoadESigDetails(this._UserProfile, delegationReasonCodeMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationReasonCodeMaintMethod(delegationReasonCodeMaint, DelegationReasonCodeMaintMethods.LoadESigDetails, (DelegationReasonCodeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) delegationReasonCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DelegationReasonCodeMaint) null, (DelegationReasonCodeMaint_LoadESigDetails_Parameters) null, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      DelegationReasonCodeMaint delegationReasonCodeMaint)
    {
      return this.LoadESigDetails(delegationReasonCodeMaint, (DelegationReasonCodeMaint_LoadESigDetails_Parameters) null, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      return this.LoadESigDetails(delegationReasonCodeMaint, (DelegationReasonCodeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Parameters parameters,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      result = (DelegationReasonCodeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) delegationReasonCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationReasonCodeMaintService) this._Channel).New(this._UserProfile, delegationReasonCodeMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationReasonCodeMaintMethod(delegationReasonCodeMaint, DelegationReasonCodeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) delegationReasonCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((DelegationReasonCodeMaint) null, (DelegationReasonCodeMaint_Parameters) null, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus New(
      DelegationReasonCodeMaint delegationReasonCodeMaint)
    {
      return this.New(delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) null, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus New(
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      return this.New(delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Parameters parameters,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      result = (DelegationReasonCodeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) delegationReasonCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationReasonCodeMaintService) this._Channel).NewCopy(this._UserProfile, delegationReasonCodeMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationReasonCodeMaintMethod(delegationReasonCodeMaint, DelegationReasonCodeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) delegationReasonCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((DelegationReasonCodeMaint) null, (DelegationReasonCodeMaint_Parameters) null, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus NewCopy(
      DelegationReasonCodeMaint delegationReasonCodeMaint)
    {
      return this.NewCopy(delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) null, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus NewCopy(
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      return this.NewCopy(delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Parameters parameters,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      result = (DelegationReasonCodeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) delegationReasonCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationReasonCodeMaintService) this._Channel).SaveAs(this._UserProfile, delegationReasonCodeMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationReasonCodeMaintMethod(delegationReasonCodeMaint, DelegationReasonCodeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) delegationReasonCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((DelegationReasonCodeMaint) null, (DelegationReasonCodeMaint_Parameters) null, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus SaveAs(
      DelegationReasonCodeMaint delegationReasonCodeMaint)
    {
      return this.SaveAs(delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) null, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus SaveAs(
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      return this.SaveAs(delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Parameters parameters,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      result = (DelegationReasonCodeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) delegationReasonCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationReasonCodeMaintService) this._Channel).UnFreeze(this._UserProfile, delegationReasonCodeMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationReasonCodeMaintMethod(delegationReasonCodeMaint, DelegationReasonCodeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) delegationReasonCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((DelegationReasonCodeMaint) null, (DelegationReasonCodeMaint_Parameters) null, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      DelegationReasonCodeMaint delegationReasonCodeMaint)
    {
      return this.UnFreeze(delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) null, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      return this.UnFreeze(delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject delegationReasonCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegationReasonCodeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((DelegationReasonCodeMaint) delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) parameters, (DelegationReasonCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject delegationReasonCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegationReasonCodeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((DelegationReasonCodeMaint) delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) parameters, (DelegationReasonCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject delegationReasonCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegationReasonCodeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DelegationReasonCodeMaint) delegationReasonCodeMaint, (DelegationReasonCodeMaint_LoadESigDetails_Parameters) parameters, (DelegationReasonCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject delegationReasonCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegationReasonCodeMaint_Result result1;
        ResultStatus resultStatus = this.New((DelegationReasonCodeMaint) delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) parameters, (DelegationReasonCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject delegationReasonCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegationReasonCodeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((DelegationReasonCodeMaint) delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) parameters, (DelegationReasonCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject delegationReasonCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegationReasonCodeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((DelegationReasonCodeMaint) delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) parameters, (DelegationReasonCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject delegationReasonCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegationReasonCodeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((DelegationReasonCodeMaint) delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) parameters, (DelegationReasonCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject delegationReasonCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegationReasonCodeMaint_Result result1;
        ResultStatus resultStatus = this.Load((DelegationReasonCodeMaint) delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) parameters, (DelegationReasonCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject delegationReasonCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegationReasonCodeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DelegationReasonCodeMaint) delegationReasonCodeMaint, (DelegationReasonCodeMaint_Parameters) parameters, (DelegationReasonCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      result = (DelegationReasonCodeMaint_Result) null;
      try
      {
        DelegationReasonCodeMaintMethod[] methods = new DelegationReasonCodeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDelegationReasonCodeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DelegationReasonCodeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DelegationReasonCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DelegationReasonCodeMaint cdo,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      result = (DelegationReasonCodeMaint_Result) null;
      try
      {
        return ((IDelegationReasonCodeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DelegationReasonCodeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((DelegationReasonCodeMaint) cdo, (DelegationReasonCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      return this.GetEnvironment((DelegationReasonCodeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DelegationReasonCodeMaint cdo,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      result = (DelegationReasonCodeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationReasonCodeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DelegationReasonCodeMaintMethod(cdo, DelegationReasonCodeMaintMethods.ExecuteTransaction, (DelegationReasonCodeMaint_Parameters) null));
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
        DelegationReasonCodeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DelegationReasonCodeMaint) cdo, (DelegationReasonCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DelegationReasonCodeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (DelegationReasonCodeMaint_Request) null, out DelegationReasonCodeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result)
    {
      return this.ExecuteTransaction((DelegationReasonCodeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DelegationReasonCodeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DelegationReasonCodeMaintMethod(cdo, DelegationReasonCodeMaintMethods.AddDataTransaction, (DelegationReasonCodeMaint_Parameters) null));
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
        return this.AddDataTransaction((DelegationReasonCodeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
