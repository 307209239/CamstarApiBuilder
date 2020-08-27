// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RollupReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RollupReasonMaintService : UserCodeMaintBase
  {
    public RollupReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRollupReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Parameters parameters,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      result = (RollupReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) rollupReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonMaintService) this._Channel).Delete(this._UserProfile, rollupReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RollupReasonMaintMethod(rollupReasonMaint, RollupReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) rollupReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((RollupReasonMaint) null, (RollupReasonMaint_Parameters) null, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus Delete(RollupReasonMaint rollupReasonMaint)
    {
      return this.Delete(rollupReasonMaint, (RollupReasonMaint_Parameters) null, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus Delete(
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      return this.Delete(rollupReasonMaint, (RollupReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Parameters parameters,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      result = (RollupReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) rollupReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonMaintService) this._Channel).Freeze(this._UserProfile, rollupReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RollupReasonMaintMethod(rollupReasonMaint, RollupReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) rollupReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((RollupReasonMaint) null, (RollupReasonMaint_Parameters) null, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus Freeze(RollupReasonMaint rollupReasonMaint)
    {
      return this.Freeze(rollupReasonMaint, (RollupReasonMaint_Parameters) null, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      return this.Freeze(rollupReasonMaint, (RollupReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Parameters parameters,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      result = (RollupReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) rollupReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, rollupReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RollupReasonMaintMethod(rollupReasonMaint, RollupReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) rollupReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RollupReasonMaint) null, (RollupReasonMaint_Parameters) null, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(RollupReasonMaint rollupReasonMaint)
    {
      return this.GetWIPMsgs(rollupReasonMaint, (RollupReasonMaint_Parameters) null, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      return this.GetWIPMsgs(rollupReasonMaint, (RollupReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Parameters parameters,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      result = (RollupReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) rollupReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonMaintService) this._Channel).Load(this._UserProfile, rollupReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RollupReasonMaintMethod(rollupReasonMaint, RollupReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) rollupReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RollupReasonMaint) null, (RollupReasonMaint_Parameters) null, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus Load(RollupReasonMaint rollupReasonMaint)
    {
      return this.Load(rollupReasonMaint, (RollupReasonMaint_Parameters) null, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus Load(
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      return this.Load(rollupReasonMaint, (RollupReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_LoadESigDetails_Parameters parameters,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      result = (RollupReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) rollupReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, rollupReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RollupReasonMaintMethod(rollupReasonMaint, RollupReasonMaintMethods.LoadESigDetails, (RollupReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) rollupReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RollupReasonMaint) null, (RollupReasonMaint_LoadESigDetails_Parameters) null, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(RollupReasonMaint rollupReasonMaint)
    {
      return this.LoadESigDetails(rollupReasonMaint, (RollupReasonMaint_LoadESigDetails_Parameters) null, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      return this.LoadESigDetails(rollupReasonMaint, (RollupReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Parameters parameters,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      result = (RollupReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) rollupReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonMaintService) this._Channel).New(this._UserProfile, rollupReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RollupReasonMaintMethod(rollupReasonMaint, RollupReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) rollupReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((RollupReasonMaint) null, (RollupReasonMaint_Parameters) null, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus New(RollupReasonMaint rollupReasonMaint)
    {
      return this.New(rollupReasonMaint, (RollupReasonMaint_Parameters) null, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus New(
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      return this.New(rollupReasonMaint, (RollupReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Parameters parameters,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      result = (RollupReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) rollupReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonMaintService) this._Channel).NewCopy(this._UserProfile, rollupReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RollupReasonMaintMethod(rollupReasonMaint, RollupReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) rollupReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((RollupReasonMaint) null, (RollupReasonMaint_Parameters) null, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus NewCopy(RollupReasonMaint rollupReasonMaint)
    {
      return this.NewCopy(rollupReasonMaint, (RollupReasonMaint_Parameters) null, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      return this.NewCopy(rollupReasonMaint, (RollupReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Parameters parameters,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      result = (RollupReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) rollupReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonMaintService) this._Channel).SaveAs(this._UserProfile, rollupReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RollupReasonMaintMethod(rollupReasonMaint, RollupReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) rollupReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((RollupReasonMaint) null, (RollupReasonMaint_Parameters) null, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus SaveAs(RollupReasonMaint rollupReasonMaint)
    {
      return this.SaveAs(rollupReasonMaint, (RollupReasonMaint_Parameters) null, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      return this.SaveAs(rollupReasonMaint, (RollupReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Parameters parameters,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      result = (RollupReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) rollupReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonMaintService) this._Channel).UnFreeze(this._UserProfile, rollupReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RollupReasonMaintMethod(rollupReasonMaint, RollupReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) rollupReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((RollupReasonMaint) null, (RollupReasonMaint_Parameters) null, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(RollupReasonMaint rollupReasonMaint)
    {
      return this.UnFreeze(rollupReasonMaint, (RollupReasonMaint_Parameters) null, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      return this.UnFreeze(rollupReasonMaint, (RollupReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject rollupReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RollupReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((RollupReasonMaint) rollupReasonMaint, (RollupReasonMaint_Parameters) parameters, (RollupReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject rollupReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RollupReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((RollupReasonMaint) rollupReasonMaint, (RollupReasonMaint_Parameters) parameters, (RollupReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject rollupReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RollupReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RollupReasonMaint) rollupReasonMaint, (RollupReasonMaint_LoadESigDetails_Parameters) parameters, (RollupReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject rollupReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RollupReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((RollupReasonMaint) rollupReasonMaint, (RollupReasonMaint_Parameters) parameters, (RollupReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject rollupReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RollupReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((RollupReasonMaint) rollupReasonMaint, (RollupReasonMaint_Parameters) parameters, (RollupReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject rollupReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RollupReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((RollupReasonMaint) rollupReasonMaint, (RollupReasonMaint_Parameters) parameters, (RollupReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject rollupReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RollupReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((RollupReasonMaint) rollupReasonMaint, (RollupReasonMaint_Parameters) parameters, (RollupReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject rollupReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RollupReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((RollupReasonMaint) rollupReasonMaint, (RollupReasonMaint_Parameters) parameters, (RollupReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject rollupReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RollupReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RollupReasonMaint) rollupReasonMaint, (RollupReasonMaint_Parameters) parameters, (RollupReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      result = (RollupReasonMaint_Result) null;
      try
      {
        RollupReasonMaintMethod[] methods = new RollupReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRollupReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RollupReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RollupReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RollupReasonMaint cdo,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      result = (RollupReasonMaint_Result) null;
      try
      {
        return ((IRollupReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RollupReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((RollupReasonMaint) cdo, (RollupReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      return this.GetEnvironment((RollupReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RollupReasonMaint cdo,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      result = (RollupReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRollupReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RollupReasonMaintMethod(cdo, RollupReasonMaintMethods.ExecuteTransaction, (RollupReasonMaint_Parameters) null));
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
        RollupReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RollupReasonMaint) cdo, (RollupReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RollupReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (RollupReasonMaint_Request) null, out RollupReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result)
    {
      return this.ExecuteTransaction((RollupReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RollupReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RollupReasonMaintMethod(cdo, RollupReasonMaintMethods.AddDataTransaction, (RollupReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((RollupReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
