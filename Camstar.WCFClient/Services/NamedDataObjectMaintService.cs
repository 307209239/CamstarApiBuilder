// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NamedDataObjectMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class NamedDataObjectMaintService : MaintenanceBase
  {
    public NamedDataObjectMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (INamedDataObjectMaintService), userProfile);
    }

    public ResultStatus Delete(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Parameters parameters,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      result = (NamedDataObjectMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedDataObjectMaintService) this._Channel).Delete(this._UserProfile, namedDataObjectMaint, parameters, request, out result) : this.AddMethod((Method) new NamedDataObjectMaintMethod(namedDataObjectMaint, NamedDataObjectMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((NamedDataObjectMaint) null, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus Delete(NamedDataObjectMaint namedDataObjectMaint)
    {
      return this.Delete(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus Delete(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      return this.Delete(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Parameters parameters,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      result = (NamedDataObjectMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedDataObjectMaintService) this._Channel).Freeze(this._UserProfile, namedDataObjectMaint, parameters, request, out result) : this.AddMethod((Method) new NamedDataObjectMaintMethod(namedDataObjectMaint, NamedDataObjectMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((NamedDataObjectMaint) null, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus Freeze(NamedDataObjectMaint namedDataObjectMaint)
    {
      return this.Freeze(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus Freeze(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      return this.Freeze(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Parameters parameters,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      result = (NamedDataObjectMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedDataObjectMaintService) this._Channel).GetWIPMsgs(this._UserProfile, namedDataObjectMaint, parameters, request, out result) : this.AddMethod((Method) new NamedDataObjectMaintMethod(namedDataObjectMaint, NamedDataObjectMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((NamedDataObjectMaint) null, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(NamedDataObjectMaint namedDataObjectMaint)
    {
      return this.GetWIPMsgs(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      return this.GetWIPMsgs(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Parameters parameters,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      result = (NamedDataObjectMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedDataObjectMaintService) this._Channel).Load(this._UserProfile, namedDataObjectMaint, parameters, request, out result) : this.AddMethod((Method) new NamedDataObjectMaintMethod(namedDataObjectMaint, NamedDataObjectMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((NamedDataObjectMaint) null, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus Load(NamedDataObjectMaint namedDataObjectMaint)
    {
      return this.Load(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus Load(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      return this.Load(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_LoadESigDetails_Parameters parameters,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      result = (NamedDataObjectMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedDataObjectMaintService) this._Channel).LoadESigDetails(this._UserProfile, namedDataObjectMaint, parameters, request, out result) : this.AddMethod((Method) new NamedDataObjectMaintMethod(namedDataObjectMaint, NamedDataObjectMaintMethods.LoadESigDetails, (NamedDataObjectMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((NamedDataObjectMaint) null, (NamedDataObjectMaint_LoadESigDetails_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus LoadESigDetails(NamedDataObjectMaint namedDataObjectMaint)
    {
      return this.LoadESigDetails(namedDataObjectMaint, (NamedDataObjectMaint_LoadESigDetails_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      return this.LoadESigDetails(namedDataObjectMaint, (NamedDataObjectMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Parameters parameters,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      result = (NamedDataObjectMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedDataObjectMaintService) this._Channel).New(this._UserProfile, namedDataObjectMaint, parameters, request, out result) : this.AddMethod((Method) new NamedDataObjectMaintMethod(namedDataObjectMaint, NamedDataObjectMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((NamedDataObjectMaint) null, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus New(NamedDataObjectMaint namedDataObjectMaint)
    {
      return this.New(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus New(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      return this.New(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Parameters parameters,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      result = (NamedDataObjectMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedDataObjectMaintService) this._Channel).NewCopy(this._UserProfile, namedDataObjectMaint, parameters, request, out result) : this.AddMethod((Method) new NamedDataObjectMaintMethod(namedDataObjectMaint, NamedDataObjectMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((NamedDataObjectMaint) null, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus NewCopy(NamedDataObjectMaint namedDataObjectMaint)
    {
      return this.NewCopy(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus NewCopy(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      return this.NewCopy(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Parameters parameters,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      result = (NamedDataObjectMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedDataObjectMaintService) this._Channel).SaveAs(this._UserProfile, namedDataObjectMaint, parameters, request, out result) : this.AddMethod((Method) new NamedDataObjectMaintMethod(namedDataObjectMaint, NamedDataObjectMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((NamedDataObjectMaint) null, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus SaveAs(NamedDataObjectMaint namedDataObjectMaint)
    {
      return this.SaveAs(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus SaveAs(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      return this.SaveAs(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Parameters parameters,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      result = (NamedDataObjectMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedDataObjectMaintService) this._Channel).UnFreeze(this._UserProfile, namedDataObjectMaint, parameters, request, out result) : this.AddMethod((Method) new NamedDataObjectMaintMethod(namedDataObjectMaint, NamedDataObjectMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((NamedDataObjectMaint) null, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus UnFreeze(NamedDataObjectMaint namedDataObjectMaint)
    {
      return this.UnFreeze(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus UnFreeze(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      return this.UnFreeze(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus ValidateLock(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Parameters parameters,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      result = (NamedDataObjectMaint_Result) null;
      this.OnBeforeCall(nameof (ValidateLock), (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedDataObjectMaintService) this._Channel).ValidateLock(this._UserProfile, namedDataObjectMaint, parameters, request, out result) : this.AddMethod((Method) new NamedDataObjectMaintMethod(namedDataObjectMaint, NamedDataObjectMaintMethods.ValidateLock, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateLock), res, (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateLock()
    {
      return this.ValidateLock((NamedDataObjectMaint) null, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus ValidateLock(NamedDataObjectMaint namedDataObjectMaint)
    {
      return this.ValidateLock(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus ValidateLock(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      return this.ValidateLock(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus ValidateMasterDataCatalog(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Parameters parameters,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      result = (NamedDataObjectMaint_Result) null;
      this.OnBeforeCall(nameof (ValidateMasterDataCatalog), (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedDataObjectMaintService) this._Channel).ValidateMasterDataCatalog(this._UserProfile, namedDataObjectMaint, parameters, request, out result) : this.AddMethod((Method) new NamedDataObjectMaintMethod(namedDataObjectMaint, NamedDataObjectMaintMethods.ValidateMasterDataCatalog, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateMasterDataCatalog), res, (DCObject) namedDataObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateMasterDataCatalog()
    {
      return this.ValidateMasterDataCatalog((NamedDataObjectMaint) null, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus ValidateMasterDataCatalog(
      NamedDataObjectMaint namedDataObjectMaint)
    {
      return this.ValidateMasterDataCatalog(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus ValidateMasterDataCatalog(
      NamedDataObjectMaint namedDataObjectMaint,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      return this.ValidateMasterDataCatalog(namedDataObjectMaint, (NamedDataObjectMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject namedDataObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NamedDataObjectMaint_Result result1;
        ResultStatus resultStatus = this.Delete((NamedDataObjectMaint) namedDataObjectMaint, (NamedDataObjectMaint_Parameters) parameters, (NamedDataObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject namedDataObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NamedDataObjectMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((NamedDataObjectMaint) namedDataObjectMaint, (NamedDataObjectMaint_Parameters) parameters, (NamedDataObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject namedDataObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NamedDataObjectMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((NamedDataObjectMaint) namedDataObjectMaint, (NamedDataObjectMaint_LoadESigDetails_Parameters) parameters, (NamedDataObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject namedDataObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NamedDataObjectMaint_Result result1;
        ResultStatus resultStatus = this.New((NamedDataObjectMaint) namedDataObjectMaint, (NamedDataObjectMaint_Parameters) parameters, (NamedDataObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject namedDataObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NamedDataObjectMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((NamedDataObjectMaint) namedDataObjectMaint, (NamedDataObjectMaint_Parameters) parameters, (NamedDataObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject namedDataObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NamedDataObjectMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((NamedDataObjectMaint) namedDataObjectMaint, (NamedDataObjectMaint_Parameters) parameters, (NamedDataObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject namedDataObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NamedDataObjectMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((NamedDataObjectMaint) namedDataObjectMaint, (NamedDataObjectMaint_Parameters) parameters, (NamedDataObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject namedDataObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NamedDataObjectMaint_Result result1;
        ResultStatus resultStatus = this.Load((NamedDataObjectMaint) namedDataObjectMaint, (NamedDataObjectMaint_Parameters) parameters, (NamedDataObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject namedDataObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NamedDataObjectMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((NamedDataObjectMaint) namedDataObjectMaint, (NamedDataObjectMaint_Parameters) parameters, (NamedDataObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      result = (NamedDataObjectMaint_Result) null;
      try
      {
        NamedDataObjectMaintMethod[] methods = new NamedDataObjectMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((INamedDataObjectMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        NamedDataObjectMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((NamedDataObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NamedDataObjectMaint cdo,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      result = (NamedDataObjectMaint_Result) null;
      try
      {
        return ((INamedDataObjectMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        NamedDataObjectMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((NamedDataObjectMaint) cdo, (NamedDataObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      return this.GetEnvironment((NamedDataObjectMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      NamedDataObjectMaint cdo,
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      result = (NamedDataObjectMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedDataObjectMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new NamedDataObjectMaintMethod(cdo, NamedDataObjectMaintMethods.ExecuteTransaction, (NamedDataObjectMaint_Parameters) null));
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
        NamedDataObjectMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((NamedDataObjectMaint) cdo, (NamedDataObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(NamedDataObjectMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (NamedDataObjectMaint_Request) null, out NamedDataObjectMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      NamedDataObjectMaint_Request request,
      out NamedDataObjectMaint_Result result)
    {
      return this.ExecuteTransaction((NamedDataObjectMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(NamedDataObjectMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new NamedDataObjectMaintMethod(cdo, NamedDataObjectMaintMethods.AddDataTransaction, (NamedDataObjectMaint_Parameters) null));
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
        return this.AddDataTransaction((NamedDataObjectMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
