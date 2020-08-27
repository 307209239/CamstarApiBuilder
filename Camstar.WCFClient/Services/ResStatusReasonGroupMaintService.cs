// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResStatusReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResStatusReasonGroupMaintService : UserCodeGroupMaintBase
  {
    public ResStatusReasonGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResStatusReasonGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Parameters parameters,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      result = (ResStatusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) resStatusReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusReasonGroupMaintService) this._Channel).Delete(this._UserProfile, resStatusReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResStatusReasonGroupMaintMethod(resStatusReasonGroupMaint, ResStatusReasonGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) resStatusReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ResStatusReasonGroupMaint) null, (ResStatusReasonGroupMaint_Parameters) null, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint)
    {
      return this.Delete(resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) null, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      return this.Delete(resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Parameters parameters,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      result = (ResStatusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) resStatusReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusReasonGroupMaintService) this._Channel).Freeze(this._UserProfile, resStatusReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResStatusReasonGroupMaintMethod(resStatusReasonGroupMaint, ResStatusReasonGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) resStatusReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ResStatusReasonGroupMaint) null, (ResStatusReasonGroupMaint_Parameters) null, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint)
    {
      return this.Freeze(resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) null, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      return this.Freeze(resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Parameters parameters,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      result = (ResStatusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) resStatusReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusReasonGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, resStatusReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResStatusReasonGroupMaintMethod(resStatusReasonGroupMaint, ResStatusReasonGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) resStatusReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResStatusReasonGroupMaint) null, (ResStatusReasonGroupMaint_Parameters) null, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint)
    {
      return this.GetWIPMsgs(resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) null, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      return this.GetWIPMsgs(resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Parameters parameters,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      result = (ResStatusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) resStatusReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusReasonGroupMaintService) this._Channel).Load(this._UserProfile, resStatusReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResStatusReasonGroupMaintMethod(resStatusReasonGroupMaint, ResStatusReasonGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) resStatusReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ResStatusReasonGroupMaint) null, (ResStatusReasonGroupMaint_Parameters) null, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus Load(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint)
    {
      return this.Load(resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) null, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus Load(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      return this.Load(resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_LoadESigDetails_Parameters parameters,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      result = (ResStatusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) resStatusReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusReasonGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, resStatusReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResStatusReasonGroupMaintMethod(resStatusReasonGroupMaint, ResStatusReasonGroupMaintMethods.LoadESigDetails, (ResStatusReasonGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) resStatusReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ResStatusReasonGroupMaint) null, (ResStatusReasonGroupMaint_LoadESigDetails_Parameters) null, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint)
    {
      return this.LoadESigDetails(resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_LoadESigDetails_Parameters) null, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      return this.LoadESigDetails(resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Parameters parameters,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      result = (ResStatusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) resStatusReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusReasonGroupMaintService) this._Channel).New(this._UserProfile, resStatusReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResStatusReasonGroupMaintMethod(resStatusReasonGroupMaint, ResStatusReasonGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) resStatusReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ResStatusReasonGroupMaint) null, (ResStatusReasonGroupMaint_Parameters) null, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus New(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint)
    {
      return this.New(resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) null, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus New(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      return this.New(resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Parameters parameters,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      result = (ResStatusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) resStatusReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusReasonGroupMaintService) this._Channel).NewCopy(this._UserProfile, resStatusReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResStatusReasonGroupMaintMethod(resStatusReasonGroupMaint, ResStatusReasonGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) resStatusReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ResStatusReasonGroupMaint) null, (ResStatusReasonGroupMaint_Parameters) null, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint)
    {
      return this.NewCopy(resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) null, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      return this.NewCopy(resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Parameters parameters,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      result = (ResStatusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) resStatusReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusReasonGroupMaintService) this._Channel).SaveAs(this._UserProfile, resStatusReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResStatusReasonGroupMaintMethod(resStatusReasonGroupMaint, ResStatusReasonGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) resStatusReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ResStatusReasonGroupMaint) null, (ResStatusReasonGroupMaint_Parameters) null, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint)
    {
      return this.SaveAs(resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) null, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      return this.SaveAs(resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Parameters parameters,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      result = (ResStatusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) resStatusReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusReasonGroupMaintService) this._Channel).UnFreeze(this._UserProfile, resStatusReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResStatusReasonGroupMaintMethod(resStatusReasonGroupMaint, ResStatusReasonGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) resStatusReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ResStatusReasonGroupMaint) null, (ResStatusReasonGroupMaint_Parameters) null, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint)
    {
      return this.UnFreeze(resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) null, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      return this.UnFreeze(resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject resStatusReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResStatusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ResStatusReasonGroupMaint) resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) parameters, (ResStatusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject resStatusReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResStatusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ResStatusReasonGroupMaint) resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) parameters, (ResStatusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject resStatusReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResStatusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ResStatusReasonGroupMaint) resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_LoadESigDetails_Parameters) parameters, (ResStatusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject resStatusReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResStatusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((ResStatusReasonGroupMaint) resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) parameters, (ResStatusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject resStatusReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResStatusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ResStatusReasonGroupMaint) resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) parameters, (ResStatusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject resStatusReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResStatusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ResStatusReasonGroupMaint) resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) parameters, (ResStatusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject resStatusReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResStatusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ResStatusReasonGroupMaint) resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) parameters, (ResStatusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject resStatusReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResStatusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((ResStatusReasonGroupMaint) resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) parameters, (ResStatusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject resStatusReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResStatusReasonGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResStatusReasonGroupMaint) resStatusReasonGroupMaint, (ResStatusReasonGroupMaint_Parameters) parameters, (ResStatusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      result = (ResStatusReasonGroupMaint_Result) null;
      try
      {
        ResStatusReasonGroupMaintMethod[] methods = new ResStatusReasonGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResStatusReasonGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ResStatusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResStatusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResStatusReasonGroupMaint cdo,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      result = (ResStatusReasonGroupMaint_Result) null;
      try
      {
        return ((IResStatusReasonGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ResStatusReasonGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ResStatusReasonGroupMaint) cdo, (ResStatusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      return this.GetEnvironment((ResStatusReasonGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResStatusReasonGroupMaint cdo,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      result = (ResStatusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusReasonGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResStatusReasonGroupMaintMethod(cdo, ResStatusReasonGroupMaintMethods.ExecuteTransaction, (ResStatusReasonGroupMaint_Parameters) null));
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
        ResStatusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResStatusReasonGroupMaint) cdo, (ResStatusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResStatusReasonGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ResStatusReasonGroupMaint_Request) null, out ResStatusReasonGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result)
    {
      return this.ExecuteTransaction((ResStatusReasonGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResStatusReasonGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResStatusReasonGroupMaintMethod(cdo, ResStatusReasonGroupMaintMethods.AddDataTransaction, (ResStatusReasonGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((ResStatusReasonGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
