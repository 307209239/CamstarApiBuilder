// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReworkReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ReworkReasonGroupMaintService : UserCodeGroupMaintBase
  {
    public ReworkReasonGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IReworkReasonGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Parameters parameters,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      result = (ReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) reworkReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonGroupMaintService) this._Channel).Delete(this._UserProfile, reworkReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ReworkReasonGroupMaintMethod(reworkReasonGroupMaint, ReworkReasonGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) reworkReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ReworkReasonGroupMaint) null, (ReworkReasonGroupMaint_Parameters) null, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(ReworkReasonGroupMaint reworkReasonGroupMaint)
    {
      return this.Delete(reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) null, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      return this.Delete(reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Parameters parameters,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      result = (ReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) reworkReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonGroupMaintService) this._Channel).Freeze(this._UserProfile, reworkReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ReworkReasonGroupMaintMethod(reworkReasonGroupMaint, ReworkReasonGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) reworkReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ReworkReasonGroupMaint) null, (ReworkReasonGroupMaint_Parameters) null, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(ReworkReasonGroupMaint reworkReasonGroupMaint)
    {
      return this.Freeze(reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) null, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      return this.Freeze(reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Parameters parameters,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      result = (ReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) reworkReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, reworkReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ReworkReasonGroupMaintMethod(reworkReasonGroupMaint, ReworkReasonGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) reworkReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ReworkReasonGroupMaint) null, (ReworkReasonGroupMaint_Parameters) null, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ReworkReasonGroupMaint reworkReasonGroupMaint)
    {
      return this.GetWIPMsgs(reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) null, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      return this.GetWIPMsgs(reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Parameters parameters,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      result = (ReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) reworkReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonGroupMaintService) this._Channel).Load(this._UserProfile, reworkReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ReworkReasonGroupMaintMethod(reworkReasonGroupMaint, ReworkReasonGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) reworkReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ReworkReasonGroupMaint) null, (ReworkReasonGroupMaint_Parameters) null, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus Load(ReworkReasonGroupMaint reworkReasonGroupMaint)
    {
      return this.Load(reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) null, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus Load(
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      return this.Load(reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_LoadESigDetails_Parameters parameters,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      result = (ReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) reworkReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, reworkReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ReworkReasonGroupMaintMethod(reworkReasonGroupMaint, ReworkReasonGroupMaintMethods.LoadESigDetails, (ReworkReasonGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) reworkReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ReworkReasonGroupMaint) null, (ReworkReasonGroupMaint_LoadESigDetails_Parameters) null, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ReworkReasonGroupMaint reworkReasonGroupMaint)
    {
      return this.LoadESigDetails(reworkReasonGroupMaint, (ReworkReasonGroupMaint_LoadESigDetails_Parameters) null, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      return this.LoadESigDetails(reworkReasonGroupMaint, (ReworkReasonGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Parameters parameters,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      result = (ReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) reworkReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonGroupMaintService) this._Channel).New(this._UserProfile, reworkReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ReworkReasonGroupMaintMethod(reworkReasonGroupMaint, ReworkReasonGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) reworkReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ReworkReasonGroupMaint) null, (ReworkReasonGroupMaint_Parameters) null, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus New(ReworkReasonGroupMaint reworkReasonGroupMaint)
    {
      return this.New(reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) null, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus New(
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      return this.New(reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Parameters parameters,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      result = (ReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) reworkReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonGroupMaintService) this._Channel).NewCopy(this._UserProfile, reworkReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ReworkReasonGroupMaintMethod(reworkReasonGroupMaint, ReworkReasonGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) reworkReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ReworkReasonGroupMaint) null, (ReworkReasonGroupMaint_Parameters) null, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(ReworkReasonGroupMaint reworkReasonGroupMaint)
    {
      return this.NewCopy(reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) null, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      return this.NewCopy(reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Parameters parameters,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      result = (ReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) reworkReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonGroupMaintService) this._Channel).SaveAs(this._UserProfile, reworkReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ReworkReasonGroupMaintMethod(reworkReasonGroupMaint, ReworkReasonGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) reworkReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ReworkReasonGroupMaint) null, (ReworkReasonGroupMaint_Parameters) null, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(ReworkReasonGroupMaint reworkReasonGroupMaint)
    {
      return this.SaveAs(reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) null, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      return this.SaveAs(reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Parameters parameters,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      result = (ReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) reworkReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonGroupMaintService) this._Channel).UnFreeze(this._UserProfile, reworkReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ReworkReasonGroupMaintMethod(reworkReasonGroupMaint, ReworkReasonGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) reworkReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ReworkReasonGroupMaint) null, (ReworkReasonGroupMaint_Parameters) null, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(ReworkReasonGroupMaint reworkReasonGroupMaint)
    {
      return this.UnFreeze(reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) null, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      return this.UnFreeze(reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject reworkReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ReworkReasonGroupMaint) reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) parameters, (ReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject reworkReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ReworkReasonGroupMaint) reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) parameters, (ReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject reworkReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ReworkReasonGroupMaint) reworkReasonGroupMaint, (ReworkReasonGroupMaint_LoadESigDetails_Parameters) parameters, (ReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject reworkReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((ReworkReasonGroupMaint) reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) parameters, (ReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject reworkReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ReworkReasonGroupMaint) reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) parameters, (ReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject reworkReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ReworkReasonGroupMaint) reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) parameters, (ReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject reworkReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ReworkReasonGroupMaint) reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) parameters, (ReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject reworkReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((ReworkReasonGroupMaint) reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) parameters, (ReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject reworkReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReworkReasonGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ReworkReasonGroupMaint) reworkReasonGroupMaint, (ReworkReasonGroupMaint_Parameters) parameters, (ReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      result = (ReworkReasonGroupMaint_Result) null;
      try
      {
        ReworkReasonGroupMaintMethod[] methods = new ReworkReasonGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IReworkReasonGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReworkReasonGroupMaint cdo,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      result = (ReworkReasonGroupMaint_Result) null;
      try
      {
        return ((IReworkReasonGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ReworkReasonGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ReworkReasonGroupMaint) cdo, (ReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      return this.GetEnvironment((ReworkReasonGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ReworkReasonGroupMaint cdo,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      result = (ReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ReworkReasonGroupMaintMethod(cdo, ReworkReasonGroupMaintMethods.ExecuteTransaction, (ReworkReasonGroupMaint_Parameters) null));
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
        ReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ReworkReasonGroupMaint) cdo, (ReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ReworkReasonGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ReworkReasonGroupMaint_Request) null, out ReworkReasonGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result)
    {
      return this.ExecuteTransaction((ReworkReasonGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ReworkReasonGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ReworkReasonGroupMaintMethod(cdo, ReworkReasonGroupMaintMethods.AddDataTransaction, (ReworkReasonGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((ReworkReasonGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
