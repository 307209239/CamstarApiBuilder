// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReplaceReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ReplaceReasonMaintService : UserCodeMaintBase
  {
    public ReplaceReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IReplaceReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Parameters parameters,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      result = (ReplaceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) replaceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReplaceReasonMaintService) this._Channel).Delete(this._UserProfile, replaceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReplaceReasonMaintMethod(replaceReasonMaint, ReplaceReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) replaceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ReplaceReasonMaint) null, (ReplaceReasonMaint_Parameters) null, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus Delete(ReplaceReasonMaint replaceReasonMaint)
    {
      return this.Delete(replaceReasonMaint, (ReplaceReasonMaint_Parameters) null, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus Delete(
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      return this.Delete(replaceReasonMaint, (ReplaceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Parameters parameters,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      result = (ReplaceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) replaceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReplaceReasonMaintService) this._Channel).Freeze(this._UserProfile, replaceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReplaceReasonMaintMethod(replaceReasonMaint, ReplaceReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) replaceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ReplaceReasonMaint) null, (ReplaceReasonMaint_Parameters) null, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus Freeze(ReplaceReasonMaint replaceReasonMaint)
    {
      return this.Freeze(replaceReasonMaint, (ReplaceReasonMaint_Parameters) null, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      return this.Freeze(replaceReasonMaint, (ReplaceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Parameters parameters,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      result = (ReplaceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) replaceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReplaceReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, replaceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReplaceReasonMaintMethod(replaceReasonMaint, ReplaceReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) replaceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ReplaceReasonMaint) null, (ReplaceReasonMaint_Parameters) null, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ReplaceReasonMaint replaceReasonMaint)
    {
      return this.GetWIPMsgs(replaceReasonMaint, (ReplaceReasonMaint_Parameters) null, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      return this.GetWIPMsgs(replaceReasonMaint, (ReplaceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Parameters parameters,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      result = (ReplaceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) replaceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReplaceReasonMaintService) this._Channel).Load(this._UserProfile, replaceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReplaceReasonMaintMethod(replaceReasonMaint, ReplaceReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) replaceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ReplaceReasonMaint) null, (ReplaceReasonMaint_Parameters) null, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus Load(ReplaceReasonMaint replaceReasonMaint)
    {
      return this.Load(replaceReasonMaint, (ReplaceReasonMaint_Parameters) null, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus Load(
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      return this.Load(replaceReasonMaint, (ReplaceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_LoadESigDetails_Parameters parameters,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      result = (ReplaceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) replaceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReplaceReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, replaceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReplaceReasonMaintMethod(replaceReasonMaint, ReplaceReasonMaintMethods.LoadESigDetails, (ReplaceReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) replaceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ReplaceReasonMaint) null, (ReplaceReasonMaint_LoadESigDetails_Parameters) null, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ReplaceReasonMaint replaceReasonMaint)
    {
      return this.LoadESigDetails(replaceReasonMaint, (ReplaceReasonMaint_LoadESigDetails_Parameters) null, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      return this.LoadESigDetails(replaceReasonMaint, (ReplaceReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Parameters parameters,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      result = (ReplaceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) replaceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReplaceReasonMaintService) this._Channel).New(this._UserProfile, replaceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReplaceReasonMaintMethod(replaceReasonMaint, ReplaceReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) replaceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ReplaceReasonMaint) null, (ReplaceReasonMaint_Parameters) null, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus New(ReplaceReasonMaint replaceReasonMaint)
    {
      return this.New(replaceReasonMaint, (ReplaceReasonMaint_Parameters) null, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus New(
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      return this.New(replaceReasonMaint, (ReplaceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Parameters parameters,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      result = (ReplaceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) replaceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReplaceReasonMaintService) this._Channel).NewCopy(this._UserProfile, replaceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReplaceReasonMaintMethod(replaceReasonMaint, ReplaceReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) replaceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ReplaceReasonMaint) null, (ReplaceReasonMaint_Parameters) null, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus NewCopy(ReplaceReasonMaint replaceReasonMaint)
    {
      return this.NewCopy(replaceReasonMaint, (ReplaceReasonMaint_Parameters) null, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      return this.NewCopy(replaceReasonMaint, (ReplaceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Parameters parameters,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      result = (ReplaceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) replaceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReplaceReasonMaintService) this._Channel).SaveAs(this._UserProfile, replaceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReplaceReasonMaintMethod(replaceReasonMaint, ReplaceReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) replaceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ReplaceReasonMaint) null, (ReplaceReasonMaint_Parameters) null, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus SaveAs(ReplaceReasonMaint replaceReasonMaint)
    {
      return this.SaveAs(replaceReasonMaint, (ReplaceReasonMaint_Parameters) null, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      return this.SaveAs(replaceReasonMaint, (ReplaceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Parameters parameters,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      result = (ReplaceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) replaceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReplaceReasonMaintService) this._Channel).UnFreeze(this._UserProfile, replaceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReplaceReasonMaintMethod(replaceReasonMaint, ReplaceReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) replaceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ReplaceReasonMaint) null, (ReplaceReasonMaint_Parameters) null, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(ReplaceReasonMaint replaceReasonMaint)
    {
      return this.UnFreeze(replaceReasonMaint, (ReplaceReasonMaint_Parameters) null, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      return this.UnFreeze(replaceReasonMaint, (ReplaceReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject replaceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReplaceReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ReplaceReasonMaint) replaceReasonMaint, (ReplaceReasonMaint_Parameters) parameters, (ReplaceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject replaceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReplaceReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ReplaceReasonMaint) replaceReasonMaint, (ReplaceReasonMaint_Parameters) parameters, (ReplaceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject replaceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReplaceReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ReplaceReasonMaint) replaceReasonMaint, (ReplaceReasonMaint_LoadESigDetails_Parameters) parameters, (ReplaceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject replaceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReplaceReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((ReplaceReasonMaint) replaceReasonMaint, (ReplaceReasonMaint_Parameters) parameters, (ReplaceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject replaceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReplaceReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ReplaceReasonMaint) replaceReasonMaint, (ReplaceReasonMaint_Parameters) parameters, (ReplaceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject replaceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReplaceReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ReplaceReasonMaint) replaceReasonMaint, (ReplaceReasonMaint_Parameters) parameters, (ReplaceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject replaceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReplaceReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ReplaceReasonMaint) replaceReasonMaint, (ReplaceReasonMaint_Parameters) parameters, (ReplaceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject replaceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReplaceReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((ReplaceReasonMaint) replaceReasonMaint, (ReplaceReasonMaint_Parameters) parameters, (ReplaceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject replaceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReplaceReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ReplaceReasonMaint) replaceReasonMaint, (ReplaceReasonMaint_Parameters) parameters, (ReplaceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      result = (ReplaceReasonMaint_Result) null;
      try
      {
        ReplaceReasonMaintMethod[] methods = new ReplaceReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IReplaceReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ReplaceReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ReplaceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReplaceReasonMaint cdo,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      result = (ReplaceReasonMaint_Result) null;
      try
      {
        return ((IReplaceReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ReplaceReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ReplaceReasonMaint) cdo, (ReplaceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      return this.GetEnvironment((ReplaceReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ReplaceReasonMaint cdo,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      result = (ReplaceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReplaceReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ReplaceReasonMaintMethod(cdo, ReplaceReasonMaintMethods.ExecuteTransaction, (ReplaceReasonMaint_Parameters) null));
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
        ReplaceReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ReplaceReasonMaint) cdo, (ReplaceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ReplaceReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ReplaceReasonMaint_Request) null, out ReplaceReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result)
    {
      return this.ExecuteTransaction((ReplaceReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ReplaceReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ReplaceReasonMaintMethod(cdo, ReplaceReasonMaintMethods.AddDataTransaction, (ReplaceReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((ReplaceReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
