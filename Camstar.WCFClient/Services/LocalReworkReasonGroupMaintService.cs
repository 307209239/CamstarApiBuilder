// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.LocalReworkReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class LocalReworkReasonGroupMaintService : UserCodeGroupMaintBase
  {
    public LocalReworkReasonGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ILocalReworkReasonGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Parameters parameters,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      result = (LocalReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) localReworkReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonGroupMaintService) this._Channel).Delete(this._UserProfile, localReworkReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new LocalReworkReasonGroupMaintMethod(localReworkReasonGroupMaint, LocalReworkReasonGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) localReworkReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((LocalReworkReasonGroupMaint) null, (LocalReworkReasonGroupMaint_Parameters) null, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint)
    {
      return this.Delete(localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) null, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      return this.Delete(localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Parameters parameters,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      result = (LocalReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) localReworkReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonGroupMaintService) this._Channel).Freeze(this._UserProfile, localReworkReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new LocalReworkReasonGroupMaintMethod(localReworkReasonGroupMaint, LocalReworkReasonGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) localReworkReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((LocalReworkReasonGroupMaint) null, (LocalReworkReasonGroupMaint_Parameters) null, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint)
    {
      return this.Freeze(localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) null, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      return this.Freeze(localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Parameters parameters,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      result = (LocalReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) localReworkReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, localReworkReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new LocalReworkReasonGroupMaintMethod(localReworkReasonGroupMaint, LocalReworkReasonGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) localReworkReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((LocalReworkReasonGroupMaint) null, (LocalReworkReasonGroupMaint_Parameters) null, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint)
    {
      return this.GetWIPMsgs(localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) null, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      return this.GetWIPMsgs(localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Parameters parameters,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      result = (LocalReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) localReworkReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonGroupMaintService) this._Channel).Load(this._UserProfile, localReworkReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new LocalReworkReasonGroupMaintMethod(localReworkReasonGroupMaint, LocalReworkReasonGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) localReworkReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((LocalReworkReasonGroupMaint) null, (LocalReworkReasonGroupMaint_Parameters) null, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus Load(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint)
    {
      return this.Load(localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) null, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus Load(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      return this.Load(localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_LoadESigDetails_Parameters parameters,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      result = (LocalReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) localReworkReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, localReworkReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new LocalReworkReasonGroupMaintMethod(localReworkReasonGroupMaint, LocalReworkReasonGroupMaintMethods.LoadESigDetails, (LocalReworkReasonGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) localReworkReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((LocalReworkReasonGroupMaint) null, (LocalReworkReasonGroupMaint_LoadESigDetails_Parameters) null, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint)
    {
      return this.LoadESigDetails(localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_LoadESigDetails_Parameters) null, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      return this.LoadESigDetails(localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Parameters parameters,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      result = (LocalReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) localReworkReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonGroupMaintService) this._Channel).New(this._UserProfile, localReworkReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new LocalReworkReasonGroupMaintMethod(localReworkReasonGroupMaint, LocalReworkReasonGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) localReworkReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((LocalReworkReasonGroupMaint) null, (LocalReworkReasonGroupMaint_Parameters) null, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus New(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint)
    {
      return this.New(localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) null, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus New(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      return this.New(localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Parameters parameters,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      result = (LocalReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) localReworkReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonGroupMaintService) this._Channel).NewCopy(this._UserProfile, localReworkReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new LocalReworkReasonGroupMaintMethod(localReworkReasonGroupMaint, LocalReworkReasonGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) localReworkReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((LocalReworkReasonGroupMaint) null, (LocalReworkReasonGroupMaint_Parameters) null, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint)
    {
      return this.NewCopy(localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) null, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      return this.NewCopy(localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Parameters parameters,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      result = (LocalReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) localReworkReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonGroupMaintService) this._Channel).SaveAs(this._UserProfile, localReworkReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new LocalReworkReasonGroupMaintMethod(localReworkReasonGroupMaint, LocalReworkReasonGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) localReworkReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((LocalReworkReasonGroupMaint) null, (LocalReworkReasonGroupMaint_Parameters) null, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint)
    {
      return this.SaveAs(localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) null, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      return this.SaveAs(localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Parameters parameters,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      result = (LocalReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) localReworkReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonGroupMaintService) this._Channel).UnFreeze(this._UserProfile, localReworkReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new LocalReworkReasonGroupMaintMethod(localReworkReasonGroupMaint, LocalReworkReasonGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) localReworkReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((LocalReworkReasonGroupMaint) null, (LocalReworkReasonGroupMaint_Parameters) null, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint)
    {
      return this.UnFreeze(localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) null, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      return this.UnFreeze(localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject localReworkReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LocalReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((LocalReworkReasonGroupMaint) localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) parameters, (LocalReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject localReworkReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LocalReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((LocalReworkReasonGroupMaint) localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) parameters, (LocalReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject localReworkReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LocalReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((LocalReworkReasonGroupMaint) localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_LoadESigDetails_Parameters) parameters, (LocalReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject localReworkReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LocalReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((LocalReworkReasonGroupMaint) localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) parameters, (LocalReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject localReworkReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LocalReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((LocalReworkReasonGroupMaint) localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) parameters, (LocalReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject localReworkReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LocalReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((LocalReworkReasonGroupMaint) localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) parameters, (LocalReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject localReworkReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LocalReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((LocalReworkReasonGroupMaint) localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) parameters, (LocalReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject localReworkReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LocalReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((LocalReworkReasonGroupMaint) localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) parameters, (LocalReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject localReworkReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LocalReworkReasonGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((LocalReworkReasonGroupMaint) localReworkReasonGroupMaint, (LocalReworkReasonGroupMaint_Parameters) parameters, (LocalReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      result = (LocalReworkReasonGroupMaint_Result) null;
      try
      {
        LocalReworkReasonGroupMaintMethod[] methods = new LocalReworkReasonGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ILocalReworkReasonGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        LocalReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((LocalReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      LocalReworkReasonGroupMaint cdo,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      result = (LocalReworkReasonGroupMaint_Result) null;
      try
      {
        return ((ILocalReworkReasonGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        LocalReworkReasonGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((LocalReworkReasonGroupMaint) cdo, (LocalReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      return this.GetEnvironment((LocalReworkReasonGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      LocalReworkReasonGroupMaint cdo,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      result = (LocalReworkReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new LocalReworkReasonGroupMaintMethod(cdo, LocalReworkReasonGroupMaintMethods.ExecuteTransaction, (LocalReworkReasonGroupMaint_Parameters) null));
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
        LocalReworkReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((LocalReworkReasonGroupMaint) cdo, (LocalReworkReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(LocalReworkReasonGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (LocalReworkReasonGroupMaint_Request) null, out LocalReworkReasonGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result)
    {
      return this.ExecuteTransaction((LocalReworkReasonGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(LocalReworkReasonGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new LocalReworkReasonGroupMaintMethod(cdo, LocalReworkReasonGroupMaintMethods.AddDataTransaction, (LocalReworkReasonGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((LocalReworkReasonGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
