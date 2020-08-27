// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DelegationTaskMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DelegationTaskMaintService : SubentityMaintenanceBase
  {
    public DelegationTaskMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDelegationTaskMaintService), userProfile);
    }

    public ResultStatus Delete(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      result = (DelegationTaskMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationTaskMaintService) this._Channel).Delete(this._UserProfile, delegationTaskMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationTaskMaintMethod(delegationTaskMaint, DelegationTaskMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((DelegationTaskMaint) null, (DelegationTaskMaint_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus Delete(DelegationTaskMaint delegationTaskMaint)
    {
      return this.Delete(delegationTaskMaint, (DelegationTaskMaint_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus Delete(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      return this.Delete(delegationTaskMaint, (DelegationTaskMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      result = (DelegationTaskMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationTaskMaintService) this._Channel).Freeze(this._UserProfile, delegationTaskMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationTaskMaintMethod(delegationTaskMaint, DelegationTaskMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((DelegationTaskMaint) null, (DelegationTaskMaint_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus Freeze(DelegationTaskMaint delegationTaskMaint)
    {
      return this.Freeze(delegationTaskMaint, (DelegationTaskMaint_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus Freeze(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      return this.Freeze(delegationTaskMaint, (DelegationTaskMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      result = (DelegationTaskMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationTaskMaintService) this._Channel).GetWIPMsgs(this._UserProfile, delegationTaskMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationTaskMaintMethod(delegationTaskMaint, DelegationTaskMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DelegationTaskMaint) null, (DelegationTaskMaint_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(DelegationTaskMaint delegationTaskMaint)
    {
      return this.GetWIPMsgs(delegationTaskMaint, (DelegationTaskMaint_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      return this.GetWIPMsgs(delegationTaskMaint, (DelegationTaskMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      result = (DelegationTaskMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationTaskMaintService) this._Channel).Load(this._UserProfile, delegationTaskMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationTaskMaintMethod(delegationTaskMaint, DelegationTaskMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DelegationTaskMaint) null, (DelegationTaskMaint_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus Load(DelegationTaskMaint delegationTaskMaint)
    {
      return this.Load(delegationTaskMaint, (DelegationTaskMaint_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus Load(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      return this.Load(delegationTaskMaint, (DelegationTaskMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_LoadESigDetails_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      result = (DelegationTaskMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationTaskMaintService) this._Channel).LoadESigDetails(this._UserProfile, delegationTaskMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationTaskMaintMethod(delegationTaskMaint, DelegationTaskMaintMethods.LoadESigDetails, (DelegationTaskMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DelegationTaskMaint) null, (DelegationTaskMaint_LoadESigDetails_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus LoadESigDetails(DelegationTaskMaint delegationTaskMaint)
    {
      return this.LoadESigDetails(delegationTaskMaint, (DelegationTaskMaint_LoadESigDetails_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      return this.LoadESigDetails(delegationTaskMaint, (DelegationTaskMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      result = (DelegationTaskMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationTaskMaintService) this._Channel).New(this._UserProfile, delegationTaskMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationTaskMaintMethod(delegationTaskMaint, DelegationTaskMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((DelegationTaskMaint) null, (DelegationTaskMaint_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus New(DelegationTaskMaint delegationTaskMaint)
    {
      return this.New(delegationTaskMaint, (DelegationTaskMaint_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus New(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      return this.New(delegationTaskMaint, (DelegationTaskMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      result = (DelegationTaskMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationTaskMaintService) this._Channel).NewCopy(this._UserProfile, delegationTaskMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationTaskMaintMethod(delegationTaskMaint, DelegationTaskMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((DelegationTaskMaint) null, (DelegationTaskMaint_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus NewCopy(DelegationTaskMaint delegationTaskMaint)
    {
      return this.NewCopy(delegationTaskMaint, (DelegationTaskMaint_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus NewCopy(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      return this.NewCopy(delegationTaskMaint, (DelegationTaskMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      result = (DelegationTaskMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationTaskMaintService) this._Channel).SaveAs(this._UserProfile, delegationTaskMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationTaskMaintMethod(delegationTaskMaint, DelegationTaskMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((DelegationTaskMaint) null, (DelegationTaskMaint_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus SaveAs(DelegationTaskMaint delegationTaskMaint)
    {
      return this.SaveAs(delegationTaskMaint, (DelegationTaskMaint_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus SaveAs(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      return this.SaveAs(delegationTaskMaint, (DelegationTaskMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      result = (DelegationTaskMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationTaskMaintService) this._Channel).UnFreeze(this._UserProfile, delegationTaskMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationTaskMaintMethod(delegationTaskMaint, DelegationTaskMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((DelegationTaskMaint) null, (DelegationTaskMaint_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus UnFreeze(DelegationTaskMaint delegationTaskMaint)
    {
      return this.UnFreeze(delegationTaskMaint, (DelegationTaskMaint_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus UnFreeze(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      return this.UnFreeze(delegationTaskMaint, (DelegationTaskMaint_Parameters) null, request, out result);
    }

    public ResultStatus Validate(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      result = (DelegationTaskMaint_Result) null;
      this.OnBeforeCall(nameof (Validate), (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationTaskMaintService) this._Channel).Validate(this._UserProfile, delegationTaskMaint, parameters, request, out result) : this.AddMethod((Method) new DelegationTaskMaintMethod(delegationTaskMaint, DelegationTaskMaintMethods.Validate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Validate), res, (DCObject) delegationTaskMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Validate()
    {
      return this.Validate((DelegationTaskMaint) null, (DelegationTaskMaint_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus Validate(DelegationTaskMaint delegationTaskMaint)
    {
      return this.Validate(delegationTaskMaint, (DelegationTaskMaint_Parameters) null, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus Validate(
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      return this.Validate(delegationTaskMaint, (DelegationTaskMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject delegationTaskMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegationTaskMaint_Result result1;
        ResultStatus resultStatus = this.Delete((DelegationTaskMaint) delegationTaskMaint, (DelegationTaskMaint_Parameters) parameters, (DelegationTaskMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject delegationTaskMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegationTaskMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((DelegationTaskMaint) delegationTaskMaint, (DelegationTaskMaint_Parameters) parameters, (DelegationTaskMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject delegationTaskMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegationTaskMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DelegationTaskMaint) delegationTaskMaint, (DelegationTaskMaint_LoadESigDetails_Parameters) parameters, (DelegationTaskMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject delegationTaskMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegationTaskMaint_Result result1;
        ResultStatus resultStatus = this.New((DelegationTaskMaint) delegationTaskMaint, (DelegationTaskMaint_Parameters) parameters, (DelegationTaskMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject delegationTaskMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegationTaskMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((DelegationTaskMaint) delegationTaskMaint, (DelegationTaskMaint_Parameters) parameters, (DelegationTaskMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject delegationTaskMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegationTaskMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((DelegationTaskMaint) delegationTaskMaint, (DelegationTaskMaint_Parameters) parameters, (DelegationTaskMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject delegationTaskMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegationTaskMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((DelegationTaskMaint) delegationTaskMaint, (DelegationTaskMaint_Parameters) parameters, (DelegationTaskMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject delegationTaskMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegationTaskMaint_Result result1;
        ResultStatus resultStatus = this.Load((DelegationTaskMaint) delegationTaskMaint, (DelegationTaskMaint_Parameters) parameters, (DelegationTaskMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject delegationTaskMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegationTaskMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DelegationTaskMaint) delegationTaskMaint, (DelegationTaskMaint_Parameters) parameters, (DelegationTaskMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      result = (DelegationTaskMaint_Result) null;
      try
      {
        DelegationTaskMaintMethod[] methods = new DelegationTaskMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDelegationTaskMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DelegationTaskMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DelegationTaskMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DelegationTaskMaint cdo,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      result = (DelegationTaskMaint_Result) null;
      try
      {
        return ((IDelegationTaskMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DelegationTaskMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((DelegationTaskMaint) cdo, (DelegationTaskMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      return this.GetEnvironment((DelegationTaskMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DelegationTaskMaint cdo,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      result = (DelegationTaskMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegationTaskMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DelegationTaskMaintMethod(cdo, DelegationTaskMaintMethods.ExecuteTransaction, (DelegationTaskMaint_Parameters) null));
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
        DelegationTaskMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DelegationTaskMaint) cdo, (DelegationTaskMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DelegationTaskMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (DelegationTaskMaint_Request) null, out DelegationTaskMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result)
    {
      return this.ExecuteTransaction((DelegationTaskMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DelegationTaskMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DelegationTaskMaintMethod(cdo, DelegationTaskMaintMethods.AddDataTransaction, (DelegationTaskMaint_Parameters) null));
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
        return this.AddDataTransaction((DelegationTaskMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
