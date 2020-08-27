// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MSMQTransportMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MSMQTransportMaintService : DataTransportMaintBase
  {
    public MSMQTransportMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMSMQTransportMaintService), userProfile);
    }

    public ResultStatus Delete(
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Parameters parameters,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      result = (MSMQTransportMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) mSMQTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMSMQTransportMaintService) this._Channel).Delete(this._UserProfile, mSMQTransportMaint, parameters, request, out result) : this.AddMethod((Method) new MSMQTransportMaintMethod(mSMQTransportMaint, MSMQTransportMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) mSMQTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((MSMQTransportMaint) null, (MSMQTransportMaint_Parameters) null, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus Delete(MSMQTransportMaint mSMQTransportMaint)
    {
      return this.Delete(mSMQTransportMaint, (MSMQTransportMaint_Parameters) null, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus Delete(
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      return this.Delete(mSMQTransportMaint, (MSMQTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Parameters parameters,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      result = (MSMQTransportMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) mSMQTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMSMQTransportMaintService) this._Channel).Freeze(this._UserProfile, mSMQTransportMaint, parameters, request, out result) : this.AddMethod((Method) new MSMQTransportMaintMethod(mSMQTransportMaint, MSMQTransportMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) mSMQTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((MSMQTransportMaint) null, (MSMQTransportMaint_Parameters) null, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus Freeze(MSMQTransportMaint mSMQTransportMaint)
    {
      return this.Freeze(mSMQTransportMaint, (MSMQTransportMaint_Parameters) null, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus Freeze(
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      return this.Freeze(mSMQTransportMaint, (MSMQTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Parameters parameters,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      result = (MSMQTransportMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) mSMQTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMSMQTransportMaintService) this._Channel).GetWIPMsgs(this._UserProfile, mSMQTransportMaint, parameters, request, out result) : this.AddMethod((Method) new MSMQTransportMaintMethod(mSMQTransportMaint, MSMQTransportMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) mSMQTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MSMQTransportMaint) null, (MSMQTransportMaint_Parameters) null, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(MSMQTransportMaint mSMQTransportMaint)
    {
      return this.GetWIPMsgs(mSMQTransportMaint, (MSMQTransportMaint_Parameters) null, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      return this.GetWIPMsgs(mSMQTransportMaint, (MSMQTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Parameters parameters,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      result = (MSMQTransportMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) mSMQTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMSMQTransportMaintService) this._Channel).Load(this._UserProfile, mSMQTransportMaint, parameters, request, out result) : this.AddMethod((Method) new MSMQTransportMaintMethod(mSMQTransportMaint, MSMQTransportMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) mSMQTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MSMQTransportMaint) null, (MSMQTransportMaint_Parameters) null, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus Load(MSMQTransportMaint mSMQTransportMaint)
    {
      return this.Load(mSMQTransportMaint, (MSMQTransportMaint_Parameters) null, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus Load(
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      return this.Load(mSMQTransportMaint, (MSMQTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_LoadESigDetails_Parameters parameters,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      result = (MSMQTransportMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) mSMQTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMSMQTransportMaintService) this._Channel).LoadESigDetails(this._UserProfile, mSMQTransportMaint, parameters, request, out result) : this.AddMethod((Method) new MSMQTransportMaintMethod(mSMQTransportMaint, MSMQTransportMaintMethods.LoadESigDetails, (MSMQTransportMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) mSMQTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MSMQTransportMaint) null, (MSMQTransportMaint_LoadESigDetails_Parameters) null, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus LoadESigDetails(MSMQTransportMaint mSMQTransportMaint)
    {
      return this.LoadESigDetails(mSMQTransportMaint, (MSMQTransportMaint_LoadESigDetails_Parameters) null, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      return this.LoadESigDetails(mSMQTransportMaint, (MSMQTransportMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Parameters parameters,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      result = (MSMQTransportMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) mSMQTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMSMQTransportMaintService) this._Channel).New(this._UserProfile, mSMQTransportMaint, parameters, request, out result) : this.AddMethod((Method) new MSMQTransportMaintMethod(mSMQTransportMaint, MSMQTransportMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) mSMQTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((MSMQTransportMaint) null, (MSMQTransportMaint_Parameters) null, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus New(MSMQTransportMaint mSMQTransportMaint)
    {
      return this.New(mSMQTransportMaint, (MSMQTransportMaint_Parameters) null, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus New(
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      return this.New(mSMQTransportMaint, (MSMQTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Parameters parameters,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      result = (MSMQTransportMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) mSMQTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMSMQTransportMaintService) this._Channel).NewCopy(this._UserProfile, mSMQTransportMaint, parameters, request, out result) : this.AddMethod((Method) new MSMQTransportMaintMethod(mSMQTransportMaint, MSMQTransportMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) mSMQTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((MSMQTransportMaint) null, (MSMQTransportMaint_Parameters) null, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus NewCopy(MSMQTransportMaint mSMQTransportMaint)
    {
      return this.NewCopy(mSMQTransportMaint, (MSMQTransportMaint_Parameters) null, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus NewCopy(
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      return this.NewCopy(mSMQTransportMaint, (MSMQTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Parameters parameters,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      result = (MSMQTransportMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) mSMQTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMSMQTransportMaintService) this._Channel).SaveAs(this._UserProfile, mSMQTransportMaint, parameters, request, out result) : this.AddMethod((Method) new MSMQTransportMaintMethod(mSMQTransportMaint, MSMQTransportMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) mSMQTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((MSMQTransportMaint) null, (MSMQTransportMaint_Parameters) null, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus SaveAs(MSMQTransportMaint mSMQTransportMaint)
    {
      return this.SaveAs(mSMQTransportMaint, (MSMQTransportMaint_Parameters) null, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus SaveAs(
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      return this.SaveAs(mSMQTransportMaint, (MSMQTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Parameters parameters,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      result = (MSMQTransportMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) mSMQTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMSMQTransportMaintService) this._Channel).UnFreeze(this._UserProfile, mSMQTransportMaint, parameters, request, out result) : this.AddMethod((Method) new MSMQTransportMaintMethod(mSMQTransportMaint, MSMQTransportMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) mSMQTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((MSMQTransportMaint) null, (MSMQTransportMaint_Parameters) null, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus UnFreeze(MSMQTransportMaint mSMQTransportMaint)
    {
      return this.UnFreeze(mSMQTransportMaint, (MSMQTransportMaint_Parameters) null, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus UnFreeze(
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      return this.UnFreeze(mSMQTransportMaint, (MSMQTransportMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject mSMQTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MSMQTransportMaint_Result result1;
        ResultStatus resultStatus = this.Delete((MSMQTransportMaint) mSMQTransportMaint, (MSMQTransportMaint_Parameters) parameters, (MSMQTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject mSMQTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MSMQTransportMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((MSMQTransportMaint) mSMQTransportMaint, (MSMQTransportMaint_Parameters) parameters, (MSMQTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject mSMQTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MSMQTransportMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MSMQTransportMaint) mSMQTransportMaint, (MSMQTransportMaint_LoadESigDetails_Parameters) parameters, (MSMQTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject mSMQTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MSMQTransportMaint_Result result1;
        ResultStatus resultStatus = this.New((MSMQTransportMaint) mSMQTransportMaint, (MSMQTransportMaint_Parameters) parameters, (MSMQTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject mSMQTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MSMQTransportMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((MSMQTransportMaint) mSMQTransportMaint, (MSMQTransportMaint_Parameters) parameters, (MSMQTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject mSMQTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MSMQTransportMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((MSMQTransportMaint) mSMQTransportMaint, (MSMQTransportMaint_Parameters) parameters, (MSMQTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject mSMQTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MSMQTransportMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((MSMQTransportMaint) mSMQTransportMaint, (MSMQTransportMaint_Parameters) parameters, (MSMQTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject mSMQTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MSMQTransportMaint_Result result1;
        ResultStatus resultStatus = this.Load((MSMQTransportMaint) mSMQTransportMaint, (MSMQTransportMaint_Parameters) parameters, (MSMQTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject mSMQTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MSMQTransportMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MSMQTransportMaint) mSMQTransportMaint, (MSMQTransportMaint_Parameters) parameters, (MSMQTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      result = (MSMQTransportMaint_Result) null;
      try
      {
        MSMQTransportMaintMethod[] methods = new MSMQTransportMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMSMQTransportMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MSMQTransportMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MSMQTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MSMQTransportMaint cdo,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      result = (MSMQTransportMaint_Result) null;
      try
      {
        return ((IMSMQTransportMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MSMQTransportMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((MSMQTransportMaint) cdo, (MSMQTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      return this.GetEnvironment((MSMQTransportMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MSMQTransportMaint cdo,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      result = (MSMQTransportMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMSMQTransportMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MSMQTransportMaintMethod(cdo, MSMQTransportMaintMethods.ExecuteTransaction, (MSMQTransportMaint_Parameters) null));
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
        MSMQTransportMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MSMQTransportMaint) cdo, (MSMQTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MSMQTransportMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (MSMQTransportMaint_Request) null, out MSMQTransportMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result)
    {
      return this.ExecuteTransaction((MSMQTransportMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MSMQTransportMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MSMQTransportMaintMethod(cdo, MSMQTransportMaintMethods.AddDataTransaction, (MSMQTransportMaint_Parameters) null));
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
        return this.AddDataTransaction((MSMQTransportMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
