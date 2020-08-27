// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MasterDataCatalogMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MasterDataCatalogMaintService : NamedDataObjectMaintBase
  {
    public MasterDataCatalogMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMasterDataCatalogMaintService), userProfile);
    }

    public ResultStatus Delete(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      result = (MasterDataCatalogMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterDataCatalogMaintService) this._Channel).Delete(this._UserProfile, masterDataCatalogMaint, parameters, request, out result) : this.AddMethod((Method) new MasterDataCatalogMaintMethod(masterDataCatalogMaint, MasterDataCatalogMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((MasterDataCatalogMaint) null, (MasterDataCatalogMaint_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus Delete(MasterDataCatalogMaint masterDataCatalogMaint)
    {
      return this.Delete(masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus Delete(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      return this.Delete(masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      result = (MasterDataCatalogMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterDataCatalogMaintService) this._Channel).Freeze(this._UserProfile, masterDataCatalogMaint, parameters, request, out result) : this.AddMethod((Method) new MasterDataCatalogMaintMethod(masterDataCatalogMaint, MasterDataCatalogMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((MasterDataCatalogMaint) null, (MasterDataCatalogMaint_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus Freeze(MasterDataCatalogMaint masterDataCatalogMaint)
    {
      return this.Freeze(masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus Freeze(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      return this.Freeze(masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      result = (MasterDataCatalogMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterDataCatalogMaintService) this._Channel).GetWIPMsgs(this._UserProfile, masterDataCatalogMaint, parameters, request, out result) : this.AddMethod((Method) new MasterDataCatalogMaintMethod(masterDataCatalogMaint, MasterDataCatalogMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MasterDataCatalogMaint) null, (MasterDataCatalogMaint_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(MasterDataCatalogMaint masterDataCatalogMaint)
    {
      return this.GetWIPMsgs(masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      return this.GetWIPMsgs(masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      result = (MasterDataCatalogMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterDataCatalogMaintService) this._Channel).Load(this._UserProfile, masterDataCatalogMaint, parameters, request, out result) : this.AddMethod((Method) new MasterDataCatalogMaintMethod(masterDataCatalogMaint, MasterDataCatalogMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MasterDataCatalogMaint) null, (MasterDataCatalogMaint_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus Load(MasterDataCatalogMaint masterDataCatalogMaint)
    {
      return this.Load(masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus Load(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      return this.Load(masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_LoadESigDetails_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      result = (MasterDataCatalogMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterDataCatalogMaintService) this._Channel).LoadESigDetails(this._UserProfile, masterDataCatalogMaint, parameters, request, out result) : this.AddMethod((Method) new MasterDataCatalogMaintMethod(masterDataCatalogMaint, MasterDataCatalogMaintMethods.LoadESigDetails, (MasterDataCatalogMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MasterDataCatalogMaint) null, (MasterDataCatalogMaint_LoadESigDetails_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus LoadESigDetails(MasterDataCatalogMaint masterDataCatalogMaint)
    {
      return this.LoadESigDetails(masterDataCatalogMaint, (MasterDataCatalogMaint_LoadESigDetails_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      return this.LoadESigDetails(masterDataCatalogMaint, (MasterDataCatalogMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus LoadMasterDataCatalogDtl(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      result = (MasterDataCatalogMaint_Result) null;
      this.OnBeforeCall(nameof (LoadMasterDataCatalogDtl), (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterDataCatalogMaintService) this._Channel).LoadMasterDataCatalogDtl(this._UserProfile, masterDataCatalogMaint, parameters, request, out result) : this.AddMethod((Method) new MasterDataCatalogMaintMethod(masterDataCatalogMaint, MasterDataCatalogMaintMethods.LoadMasterDataCatalogDtl, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadMasterDataCatalogDtl), res, (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadMasterDataCatalogDtl()
    {
      return this.LoadMasterDataCatalogDtl((MasterDataCatalogMaint) null, (MasterDataCatalogMaint_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus LoadMasterDataCatalogDtl(
      MasterDataCatalogMaint masterDataCatalogMaint)
    {
      return this.LoadMasterDataCatalogDtl(masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus LoadMasterDataCatalogDtl(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      return this.LoadMasterDataCatalogDtl(masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) null, request, out result);
    }

    public ResultStatus New(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      result = (MasterDataCatalogMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterDataCatalogMaintService) this._Channel).New(this._UserProfile, masterDataCatalogMaint, parameters, request, out result) : this.AddMethod((Method) new MasterDataCatalogMaintMethod(masterDataCatalogMaint, MasterDataCatalogMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((MasterDataCatalogMaint) null, (MasterDataCatalogMaint_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus New(MasterDataCatalogMaint masterDataCatalogMaint)
    {
      return this.New(masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus New(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      return this.New(masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      result = (MasterDataCatalogMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterDataCatalogMaintService) this._Channel).NewCopy(this._UserProfile, masterDataCatalogMaint, parameters, request, out result) : this.AddMethod((Method) new MasterDataCatalogMaintMethod(masterDataCatalogMaint, MasterDataCatalogMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((MasterDataCatalogMaint) null, (MasterDataCatalogMaint_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus NewCopy(MasterDataCatalogMaint masterDataCatalogMaint)
    {
      return this.NewCopy(masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus NewCopy(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      return this.NewCopy(masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      result = (MasterDataCatalogMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterDataCatalogMaintService) this._Channel).SaveAs(this._UserProfile, masterDataCatalogMaint, parameters, request, out result) : this.AddMethod((Method) new MasterDataCatalogMaintMethod(masterDataCatalogMaint, MasterDataCatalogMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((MasterDataCatalogMaint) null, (MasterDataCatalogMaint_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus SaveAs(MasterDataCatalogMaint masterDataCatalogMaint)
    {
      return this.SaveAs(masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus SaveAs(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      return this.SaveAs(masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      result = (MasterDataCatalogMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterDataCatalogMaintService) this._Channel).UnFreeze(this._UserProfile, masterDataCatalogMaint, parameters, request, out result) : this.AddMethod((Method) new MasterDataCatalogMaintMethod(masterDataCatalogMaint, MasterDataCatalogMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) masterDataCatalogMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((MasterDataCatalogMaint) null, (MasterDataCatalogMaint_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus UnFreeze(MasterDataCatalogMaint masterDataCatalogMaint)
    {
      return this.UnFreeze(masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) null, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus UnFreeze(
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      return this.UnFreeze(masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject masterDataCatalogMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterDataCatalogMaint_Result result1;
        ResultStatus resultStatus = this.Delete((MasterDataCatalogMaint) masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) parameters, (MasterDataCatalogMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject masterDataCatalogMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterDataCatalogMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((MasterDataCatalogMaint) masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) parameters, (MasterDataCatalogMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject masterDataCatalogMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterDataCatalogMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MasterDataCatalogMaint) masterDataCatalogMaint, (MasterDataCatalogMaint_LoadESigDetails_Parameters) parameters, (MasterDataCatalogMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject masterDataCatalogMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterDataCatalogMaint_Result result1;
        ResultStatus resultStatus = this.New((MasterDataCatalogMaint) masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) parameters, (MasterDataCatalogMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject masterDataCatalogMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterDataCatalogMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((MasterDataCatalogMaint) masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) parameters, (MasterDataCatalogMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject masterDataCatalogMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterDataCatalogMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((MasterDataCatalogMaint) masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) parameters, (MasterDataCatalogMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject masterDataCatalogMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterDataCatalogMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((MasterDataCatalogMaint) masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) parameters, (MasterDataCatalogMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject masterDataCatalogMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterDataCatalogMaint_Result result1;
        ResultStatus resultStatus = this.Load((MasterDataCatalogMaint) masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) parameters, (MasterDataCatalogMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject masterDataCatalogMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterDataCatalogMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MasterDataCatalogMaint) masterDataCatalogMaint, (MasterDataCatalogMaint_Parameters) parameters, (MasterDataCatalogMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      result = (MasterDataCatalogMaint_Result) null;
      try
      {
        MasterDataCatalogMaintMethod[] methods = new MasterDataCatalogMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMasterDataCatalogMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MasterDataCatalogMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MasterDataCatalogMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MasterDataCatalogMaint cdo,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      result = (MasterDataCatalogMaint_Result) null;
      try
      {
        return ((IMasterDataCatalogMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MasterDataCatalogMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((MasterDataCatalogMaint) cdo, (MasterDataCatalogMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      return this.GetEnvironment((MasterDataCatalogMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MasterDataCatalogMaint cdo,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      result = (MasterDataCatalogMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterDataCatalogMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MasterDataCatalogMaintMethod(cdo, MasterDataCatalogMaintMethods.ExecuteTransaction, (MasterDataCatalogMaint_Parameters) null));
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
        MasterDataCatalogMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MasterDataCatalogMaint) cdo, (MasterDataCatalogMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MasterDataCatalogMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (MasterDataCatalogMaint_Request) null, out MasterDataCatalogMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result)
    {
      return this.ExecuteTransaction((MasterDataCatalogMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MasterDataCatalogMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MasterDataCatalogMaintMethod(cdo, MasterDataCatalogMaintMethods.AddDataTransaction, (MasterDataCatalogMaint_Parameters) null));
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
        return this.AddDataTransaction((MasterDataCatalogMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
