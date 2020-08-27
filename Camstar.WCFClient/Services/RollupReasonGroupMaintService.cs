// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RollupReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RollupReasonGroupMaintService : UserCodeGroupMaintBase
  {
    public RollupReasonGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRollupReasonGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Parameters parameters,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      result = (RollupReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) rollupReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonGroupMaintService) this._Channel).Delete(this._UserProfile, rollupReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new RollupReasonGroupMaintMethod(rollupReasonGroupMaint, RollupReasonGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) rollupReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((RollupReasonGroupMaint) null, (RollupReasonGroupMaint_Parameters) null, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(RollupReasonGroupMaint rollupReasonGroupMaint)
    {
      return this.Delete(rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) null, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      return this.Delete(rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Parameters parameters,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      result = (RollupReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) rollupReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonGroupMaintService) this._Channel).Freeze(this._UserProfile, rollupReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new RollupReasonGroupMaintMethod(rollupReasonGroupMaint, RollupReasonGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) rollupReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((RollupReasonGroupMaint) null, (RollupReasonGroupMaint_Parameters) null, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(RollupReasonGroupMaint rollupReasonGroupMaint)
    {
      return this.Freeze(rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) null, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      return this.Freeze(rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Parameters parameters,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      result = (RollupReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) rollupReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, rollupReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new RollupReasonGroupMaintMethod(rollupReasonGroupMaint, RollupReasonGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) rollupReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RollupReasonGroupMaint) null, (RollupReasonGroupMaint_Parameters) null, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(RollupReasonGroupMaint rollupReasonGroupMaint)
    {
      return this.GetWIPMsgs(rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) null, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      return this.GetWIPMsgs(rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Parameters parameters,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      result = (RollupReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) rollupReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonGroupMaintService) this._Channel).Load(this._UserProfile, rollupReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new RollupReasonGroupMaintMethod(rollupReasonGroupMaint, RollupReasonGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) rollupReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RollupReasonGroupMaint) null, (RollupReasonGroupMaint_Parameters) null, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus Load(RollupReasonGroupMaint rollupReasonGroupMaint)
    {
      return this.Load(rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) null, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus Load(
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      return this.Load(rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_LoadESigDetails_Parameters parameters,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      result = (RollupReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) rollupReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, rollupReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new RollupReasonGroupMaintMethod(rollupReasonGroupMaint, RollupReasonGroupMaintMethods.LoadESigDetails, (RollupReasonGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) rollupReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RollupReasonGroupMaint) null, (RollupReasonGroupMaint_LoadESigDetails_Parameters) null, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(RollupReasonGroupMaint rollupReasonGroupMaint)
    {
      return this.LoadESigDetails(rollupReasonGroupMaint, (RollupReasonGroupMaint_LoadESigDetails_Parameters) null, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      return this.LoadESigDetails(rollupReasonGroupMaint, (RollupReasonGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Parameters parameters,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      result = (RollupReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) rollupReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonGroupMaintService) this._Channel).New(this._UserProfile, rollupReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new RollupReasonGroupMaintMethod(rollupReasonGroupMaint, RollupReasonGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) rollupReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((RollupReasonGroupMaint) null, (RollupReasonGroupMaint_Parameters) null, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus New(RollupReasonGroupMaint rollupReasonGroupMaint)
    {
      return this.New(rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) null, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus New(
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      return this.New(rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Parameters parameters,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      result = (RollupReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) rollupReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonGroupMaintService) this._Channel).NewCopy(this._UserProfile, rollupReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new RollupReasonGroupMaintMethod(rollupReasonGroupMaint, RollupReasonGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) rollupReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((RollupReasonGroupMaint) null, (RollupReasonGroupMaint_Parameters) null, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(RollupReasonGroupMaint rollupReasonGroupMaint)
    {
      return this.NewCopy(rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) null, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      return this.NewCopy(rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Parameters parameters,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      result = (RollupReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) rollupReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonGroupMaintService) this._Channel).SaveAs(this._UserProfile, rollupReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new RollupReasonGroupMaintMethod(rollupReasonGroupMaint, RollupReasonGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) rollupReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((RollupReasonGroupMaint) null, (RollupReasonGroupMaint_Parameters) null, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(RollupReasonGroupMaint rollupReasonGroupMaint)
    {
      return this.SaveAs(rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) null, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      return this.SaveAs(rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Parameters parameters,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      result = (RollupReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) rollupReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonGroupMaintService) this._Channel).UnFreeze(this._UserProfile, rollupReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new RollupReasonGroupMaintMethod(rollupReasonGroupMaint, RollupReasonGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) rollupReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((RollupReasonGroupMaint) null, (RollupReasonGroupMaint_Parameters) null, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(RollupReasonGroupMaint rollupReasonGroupMaint)
    {
      return this.UnFreeze(rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) null, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      return this.UnFreeze(rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject rollupReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RollupReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((RollupReasonGroupMaint) rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) parameters, (RollupReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject rollupReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RollupReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((RollupReasonGroupMaint) rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) parameters, (RollupReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject rollupReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RollupReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RollupReasonGroupMaint) rollupReasonGroupMaint, (RollupReasonGroupMaint_LoadESigDetails_Parameters) parameters, (RollupReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject rollupReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RollupReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((RollupReasonGroupMaint) rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) parameters, (RollupReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject rollupReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RollupReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((RollupReasonGroupMaint) rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) parameters, (RollupReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject rollupReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RollupReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((RollupReasonGroupMaint) rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) parameters, (RollupReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject rollupReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RollupReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((RollupReasonGroupMaint) rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) parameters, (RollupReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject rollupReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RollupReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((RollupReasonGroupMaint) rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) parameters, (RollupReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject rollupReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RollupReasonGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RollupReasonGroupMaint) rollupReasonGroupMaint, (RollupReasonGroupMaint_Parameters) parameters, (RollupReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      result = (RollupReasonGroupMaint_Result) null;
      try
      {
        RollupReasonGroupMaintMethod[] methods = new RollupReasonGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRollupReasonGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RollupReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RollupReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RollupReasonGroupMaint cdo,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      result = (RollupReasonGroupMaint_Result) null;
      try
      {
        return ((IRollupReasonGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RollupReasonGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((RollupReasonGroupMaint) cdo, (RollupReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      return this.GetEnvironment((RollupReasonGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RollupReasonGroupMaint cdo,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      result = (RollupReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RollupReasonGroupMaintMethod(cdo, RollupReasonGroupMaintMethods.ExecuteTransaction, (RollupReasonGroupMaint_Parameters) null));
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
        RollupReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RollupReasonGroupMaint) cdo, (RollupReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RollupReasonGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (RollupReasonGroupMaint_Request) null, out RollupReasonGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result)
    {
      return this.ExecuteTransaction((RollupReasonGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RollupReasonGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RollupReasonGroupMaintMethod(cdo, RollupReasonGroupMaintMethods.AddDataTransaction, (RollupReasonGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((RollupReasonGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
