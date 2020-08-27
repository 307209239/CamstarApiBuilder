// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReleaseReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ReleaseReasonMaintService : UserCodeMaintBase
  {
    public ReleaseReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IReleaseReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      ReleaseReasonMaint releaseReasonMaint,
      ReleaseReasonMaint_Parameters parameters,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      result = (ReleaseReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) releaseReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseReasonMaintService) this._Channel).Delete(this._UserProfile, releaseReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReleaseReasonMaintMethod(releaseReasonMaint, ReleaseReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) releaseReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ReleaseReasonMaint) null, (ReleaseReasonMaint_Parameters) null, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus Delete(ReleaseReasonMaint releaseReasonMaint)
    {
      return this.Delete(releaseReasonMaint, (ReleaseReasonMaint_Parameters) null, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus Delete(
      ReleaseReasonMaint releaseReasonMaint,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      return this.Delete(releaseReasonMaint, (ReleaseReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ReleaseReasonMaint releaseReasonMaint,
      ReleaseReasonMaint_Parameters parameters,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      result = (ReleaseReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) releaseReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseReasonMaintService) this._Channel).Freeze(this._UserProfile, releaseReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReleaseReasonMaintMethod(releaseReasonMaint, ReleaseReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) releaseReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ReleaseReasonMaint) null, (ReleaseReasonMaint_Parameters) null, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus Freeze(ReleaseReasonMaint releaseReasonMaint)
    {
      return this.Freeze(releaseReasonMaint, (ReleaseReasonMaint_Parameters) null, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      ReleaseReasonMaint releaseReasonMaint,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      return this.Freeze(releaseReasonMaint, (ReleaseReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ReleaseReasonMaint releaseReasonMaint,
      ReleaseReasonMaint_Parameters parameters,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      result = (ReleaseReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) releaseReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, releaseReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReleaseReasonMaintMethod(releaseReasonMaint, ReleaseReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) releaseReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ReleaseReasonMaint) null, (ReleaseReasonMaint_Parameters) null, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ReleaseReasonMaint releaseReasonMaint)
    {
      return this.GetWIPMsgs(releaseReasonMaint, (ReleaseReasonMaint_Parameters) null, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ReleaseReasonMaint releaseReasonMaint,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      return this.GetWIPMsgs(releaseReasonMaint, (ReleaseReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ReleaseReasonMaint releaseReasonMaint,
      ReleaseReasonMaint_Parameters parameters,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      result = (ReleaseReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) releaseReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseReasonMaintService) this._Channel).Load(this._UserProfile, releaseReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReleaseReasonMaintMethod(releaseReasonMaint, ReleaseReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) releaseReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ReleaseReasonMaint) null, (ReleaseReasonMaint_Parameters) null, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus Load(ReleaseReasonMaint releaseReasonMaint)
    {
      return this.Load(releaseReasonMaint, (ReleaseReasonMaint_Parameters) null, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus Load(
      ReleaseReasonMaint releaseReasonMaint,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      return this.Load(releaseReasonMaint, (ReleaseReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ReleaseReasonMaint releaseReasonMaint,
      ReleaseReasonMaint_LoadESigDetails_Parameters parameters,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      result = (ReleaseReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) releaseReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, releaseReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReleaseReasonMaintMethod(releaseReasonMaint, ReleaseReasonMaintMethods.LoadESigDetails, (ReleaseReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) releaseReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ReleaseReasonMaint) null, (ReleaseReasonMaint_LoadESigDetails_Parameters) null, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ReleaseReasonMaint releaseReasonMaint)
    {
      return this.LoadESigDetails(releaseReasonMaint, (ReleaseReasonMaint_LoadESigDetails_Parameters) null, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ReleaseReasonMaint releaseReasonMaint,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      return this.LoadESigDetails(releaseReasonMaint, (ReleaseReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ReleaseReasonMaint releaseReasonMaint,
      ReleaseReasonMaint_Parameters parameters,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      result = (ReleaseReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) releaseReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseReasonMaintService) this._Channel).New(this._UserProfile, releaseReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReleaseReasonMaintMethod(releaseReasonMaint, ReleaseReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) releaseReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ReleaseReasonMaint) null, (ReleaseReasonMaint_Parameters) null, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus New(ReleaseReasonMaint releaseReasonMaint)
    {
      return this.New(releaseReasonMaint, (ReleaseReasonMaint_Parameters) null, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus New(
      ReleaseReasonMaint releaseReasonMaint,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      return this.New(releaseReasonMaint, (ReleaseReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ReleaseReasonMaint releaseReasonMaint,
      ReleaseReasonMaint_Parameters parameters,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      result = (ReleaseReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) releaseReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseReasonMaintService) this._Channel).NewCopy(this._UserProfile, releaseReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReleaseReasonMaintMethod(releaseReasonMaint, ReleaseReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) releaseReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ReleaseReasonMaint) null, (ReleaseReasonMaint_Parameters) null, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus NewCopy(ReleaseReasonMaint releaseReasonMaint)
    {
      return this.NewCopy(releaseReasonMaint, (ReleaseReasonMaint_Parameters) null, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      ReleaseReasonMaint releaseReasonMaint,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      return this.NewCopy(releaseReasonMaint, (ReleaseReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ReleaseReasonMaint releaseReasonMaint,
      ReleaseReasonMaint_Parameters parameters,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      result = (ReleaseReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) releaseReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseReasonMaintService) this._Channel).SaveAs(this._UserProfile, releaseReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReleaseReasonMaintMethod(releaseReasonMaint, ReleaseReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) releaseReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ReleaseReasonMaint) null, (ReleaseReasonMaint_Parameters) null, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus SaveAs(ReleaseReasonMaint releaseReasonMaint)
    {
      return this.SaveAs(releaseReasonMaint, (ReleaseReasonMaint_Parameters) null, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      ReleaseReasonMaint releaseReasonMaint,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      return this.SaveAs(releaseReasonMaint, (ReleaseReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ReleaseReasonMaint releaseReasonMaint,
      ReleaseReasonMaint_Parameters parameters,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      result = (ReleaseReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) releaseReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseReasonMaintService) this._Channel).UnFreeze(this._UserProfile, releaseReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReleaseReasonMaintMethod(releaseReasonMaint, ReleaseReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) releaseReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ReleaseReasonMaint) null, (ReleaseReasonMaint_Parameters) null, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(ReleaseReasonMaint releaseReasonMaint)
    {
      return this.UnFreeze(releaseReasonMaint, (ReleaseReasonMaint_Parameters) null, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ReleaseReasonMaint releaseReasonMaint,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      return this.UnFreeze(releaseReasonMaint, (ReleaseReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject releaseReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReleaseReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ReleaseReasonMaint) releaseReasonMaint, (ReleaseReasonMaint_Parameters) parameters, (ReleaseReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject releaseReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReleaseReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ReleaseReasonMaint) releaseReasonMaint, (ReleaseReasonMaint_Parameters) parameters, (ReleaseReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject releaseReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReleaseReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ReleaseReasonMaint) releaseReasonMaint, (ReleaseReasonMaint_LoadESigDetails_Parameters) parameters, (ReleaseReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject releaseReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReleaseReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((ReleaseReasonMaint) releaseReasonMaint, (ReleaseReasonMaint_Parameters) parameters, (ReleaseReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject releaseReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReleaseReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ReleaseReasonMaint) releaseReasonMaint, (ReleaseReasonMaint_Parameters) parameters, (ReleaseReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject releaseReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReleaseReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ReleaseReasonMaint) releaseReasonMaint, (ReleaseReasonMaint_Parameters) parameters, (ReleaseReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject releaseReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReleaseReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ReleaseReasonMaint) releaseReasonMaint, (ReleaseReasonMaint_Parameters) parameters, (ReleaseReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject releaseReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReleaseReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((ReleaseReasonMaint) releaseReasonMaint, (ReleaseReasonMaint_Parameters) parameters, (ReleaseReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject releaseReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReleaseReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ReleaseReasonMaint) releaseReasonMaint, (ReleaseReasonMaint_Parameters) parameters, (ReleaseReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      result = (ReleaseReasonMaint_Result) null;
      try
      {
        ReleaseReasonMaintMethod[] methods = new ReleaseReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IReleaseReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ReleaseReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ReleaseReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReleaseReasonMaint cdo,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      result = (ReleaseReasonMaint_Result) null;
      try
      {
        return ((IReleaseReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ReleaseReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ReleaseReasonMaint) cdo, (ReleaseReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      return this.GetEnvironment((ReleaseReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ReleaseReasonMaint cdo,
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      result = (ReleaseReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ReleaseReasonMaintMethod(cdo, ReleaseReasonMaintMethods.ExecuteTransaction, (ReleaseReasonMaint_Parameters) null));
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
        ReleaseReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ReleaseReasonMaint) cdo, (ReleaseReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ReleaseReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ReleaseReasonMaint_Request) null, out ReleaseReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ReleaseReasonMaint_Request request,
      out ReleaseReasonMaint_Result result)
    {
      return this.ExecuteTransaction((ReleaseReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ReleaseReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ReleaseReasonMaintMethod(cdo, ReleaseReasonMaintMethods.AddDataTransaction, (ReleaseReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((ReleaseReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
