// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DictionaryMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DictionaryMaintService : NamedDataObjectMaintBase
  {
    public DictionaryMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDictionaryMaintService), userProfile);
    }

    public ResultStatus Delete(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      result = (DictionaryMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDictionaryMaintService) this._Channel).Delete(this._UserProfile, dictionaryMaint, parameters, request, out result) : this.AddMethod((Method) new DictionaryMaintMethod(dictionaryMaint, DictionaryMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((DictionaryMaint) null, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus Delete(DictionaryMaint dictionaryMaint)
    {
      return this.Delete(dictionaryMaint, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus Delete(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      return this.Delete(dictionaryMaint, (DictionaryMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteOrphanDictionaryLabel(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      result = (DictionaryMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteOrphanDictionaryLabel), (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDictionaryMaintService) this._Channel).DeleteOrphanDictionaryLabel(this._UserProfile, dictionaryMaint, parameters, request, out result) : this.AddMethod((Method) new DictionaryMaintMethod(dictionaryMaint, DictionaryMaintMethods.DeleteOrphanDictionaryLabel, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteOrphanDictionaryLabel), res, (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteOrphanDictionaryLabel()
    {
      return this.DeleteOrphanDictionaryLabel((DictionaryMaint) null, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus DeleteOrphanDictionaryLabel(DictionaryMaint dictionaryMaint)
    {
      return this.DeleteOrphanDictionaryLabel(dictionaryMaint, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus DeleteOrphanDictionaryLabel(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      return this.DeleteOrphanDictionaryLabel(dictionaryMaint, (DictionaryMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      result = (DictionaryMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDictionaryMaintService) this._Channel).Freeze(this._UserProfile, dictionaryMaint, parameters, request, out result) : this.AddMethod((Method) new DictionaryMaintMethod(dictionaryMaint, DictionaryMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((DictionaryMaint) null, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus Freeze(DictionaryMaint dictionaryMaint)
    {
      return this.Freeze(dictionaryMaint, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus Freeze(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      return this.Freeze(dictionaryMaint, (DictionaryMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      result = (DictionaryMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDictionaryMaintService) this._Channel).GetWIPMsgs(this._UserProfile, dictionaryMaint, parameters, request, out result) : this.AddMethod((Method) new DictionaryMaintMethod(dictionaryMaint, DictionaryMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DictionaryMaint) null, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(DictionaryMaint dictionaryMaint)
    {
      return this.GetWIPMsgs(dictionaryMaint, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      return this.GetWIPMsgs(dictionaryMaint, (DictionaryMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      result = (DictionaryMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDictionaryMaintService) this._Channel).Load(this._UserProfile, dictionaryMaint, parameters, request, out result) : this.AddMethod((Method) new DictionaryMaintMethod(dictionaryMaint, DictionaryMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DictionaryMaint) null, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus Load(DictionaryMaint dictionaryMaint)
    {
      return this.Load(dictionaryMaint, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus Load(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      return this.Load(dictionaryMaint, (DictionaryMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_LoadESigDetails_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      result = (DictionaryMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDictionaryMaintService) this._Channel).LoadESigDetails(this._UserProfile, dictionaryMaint, parameters, request, out result) : this.AddMethod((Method) new DictionaryMaintMethod(dictionaryMaint, DictionaryMaintMethods.LoadESigDetails, (DictionaryMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DictionaryMaint) null, (DictionaryMaint_LoadESigDetails_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus LoadESigDetails(DictionaryMaint dictionaryMaint)
    {
      return this.LoadESigDetails(dictionaryMaint, (DictionaryMaint_LoadESigDetails_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      return this.LoadESigDetails(dictionaryMaint, (DictionaryMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus LoadWorkingSetLabels(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      result = (DictionaryMaint_Result) null;
      this.OnBeforeCall(nameof (LoadWorkingSetLabels), (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDictionaryMaintService) this._Channel).LoadWorkingSetLabels(this._UserProfile, dictionaryMaint, parameters, request, out result) : this.AddMethod((Method) new DictionaryMaintMethod(dictionaryMaint, DictionaryMaintMethods.LoadWorkingSetLabels, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadWorkingSetLabels), res, (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadWorkingSetLabels()
    {
      return this.LoadWorkingSetLabels((DictionaryMaint) null, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus LoadWorkingSetLabels(DictionaryMaint dictionaryMaint)
    {
      return this.LoadWorkingSetLabels(dictionaryMaint, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus LoadWorkingSetLabels(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      return this.LoadWorkingSetLabels(dictionaryMaint, (DictionaryMaint_Parameters) null, request, out result);
    }

    public ResultStatus New(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      result = (DictionaryMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDictionaryMaintService) this._Channel).New(this._UserProfile, dictionaryMaint, parameters, request, out result) : this.AddMethod((Method) new DictionaryMaintMethod(dictionaryMaint, DictionaryMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((DictionaryMaint) null, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus New(DictionaryMaint dictionaryMaint)
    {
      return this.New(dictionaryMaint, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus New(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      return this.New(dictionaryMaint, (DictionaryMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      result = (DictionaryMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDictionaryMaintService) this._Channel).NewCopy(this._UserProfile, dictionaryMaint, parameters, request, out result) : this.AddMethod((Method) new DictionaryMaintMethod(dictionaryMaint, DictionaryMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((DictionaryMaint) null, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus NewCopy(DictionaryMaint dictionaryMaint)
    {
      return this.NewCopy(dictionaryMaint, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus NewCopy(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      return this.NewCopy(dictionaryMaint, (DictionaryMaint_Parameters) null, request, out result);
    }

    public ResultStatus RemoveOrphanDictionaryLabels(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      result = (DictionaryMaint_Result) null;
      this.OnBeforeCall(nameof (RemoveOrphanDictionaryLabels), (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDictionaryMaintService) this._Channel).RemoveOrphanDictionaryLabels(this._UserProfile, dictionaryMaint, parameters, request, out result) : this.AddMethod((Method) new DictionaryMaintMethod(dictionaryMaint, DictionaryMaintMethods.RemoveOrphanDictionaryLabels, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (RemoveOrphanDictionaryLabels), res, (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus RemoveOrphanDictionaryLabels()
    {
      return this.RemoveOrphanDictionaryLabels((DictionaryMaint) null, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus RemoveOrphanDictionaryLabels(DictionaryMaint dictionaryMaint)
    {
      return this.RemoveOrphanDictionaryLabels(dictionaryMaint, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus RemoveOrphanDictionaryLabels(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      return this.RemoveOrphanDictionaryLabels(dictionaryMaint, (DictionaryMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      result = (DictionaryMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDictionaryMaintService) this._Channel).SaveAs(this._UserProfile, dictionaryMaint, parameters, request, out result) : this.AddMethod((Method) new DictionaryMaintMethod(dictionaryMaint, DictionaryMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((DictionaryMaint) null, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus SaveAs(DictionaryMaint dictionaryMaint)
    {
      return this.SaveAs(dictionaryMaint, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus SaveAs(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      return this.SaveAs(dictionaryMaint, (DictionaryMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      result = (DictionaryMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDictionaryMaintService) this._Channel).UnFreeze(this._UserProfile, dictionaryMaint, parameters, request, out result) : this.AddMethod((Method) new DictionaryMaintMethod(dictionaryMaint, DictionaryMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) dictionaryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((DictionaryMaint) null, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus UnFreeze(DictionaryMaint dictionaryMaint)
    {
      return this.UnFreeze(dictionaryMaint, (DictionaryMaint_Parameters) null, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus UnFreeze(
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      return this.UnFreeze(dictionaryMaint, (DictionaryMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject dictionaryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DictionaryMaint_Result result1;
        ResultStatus resultStatus = this.Delete((DictionaryMaint) dictionaryMaint, (DictionaryMaint_Parameters) parameters, (DictionaryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject dictionaryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DictionaryMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((DictionaryMaint) dictionaryMaint, (DictionaryMaint_Parameters) parameters, (DictionaryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject dictionaryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DictionaryMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DictionaryMaint) dictionaryMaint, (DictionaryMaint_LoadESigDetails_Parameters) parameters, (DictionaryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject dictionaryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DictionaryMaint_Result result1;
        ResultStatus resultStatus = this.New((DictionaryMaint) dictionaryMaint, (DictionaryMaint_Parameters) parameters, (DictionaryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject dictionaryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DictionaryMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((DictionaryMaint) dictionaryMaint, (DictionaryMaint_Parameters) parameters, (DictionaryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject dictionaryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DictionaryMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((DictionaryMaint) dictionaryMaint, (DictionaryMaint_Parameters) parameters, (DictionaryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject dictionaryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DictionaryMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((DictionaryMaint) dictionaryMaint, (DictionaryMaint_Parameters) parameters, (DictionaryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject dictionaryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DictionaryMaint_Result result1;
        ResultStatus resultStatus = this.Load((DictionaryMaint) dictionaryMaint, (DictionaryMaint_Parameters) parameters, (DictionaryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject dictionaryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DictionaryMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DictionaryMaint) dictionaryMaint, (DictionaryMaint_Parameters) parameters, (DictionaryMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      result = (DictionaryMaint_Result) null;
      try
      {
        DictionaryMaintMethod[] methods = new DictionaryMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDictionaryMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DictionaryMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DictionaryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DictionaryMaint cdo,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      result = (DictionaryMaint_Result) null;
      try
      {
        return ((IDictionaryMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DictionaryMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((DictionaryMaint) cdo, (DictionaryMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      return this.GetEnvironment((DictionaryMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DictionaryMaint cdo,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      result = (DictionaryMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDictionaryMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DictionaryMaintMethod(cdo, DictionaryMaintMethods.ExecuteTransaction, (DictionaryMaint_Parameters) null));
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
        DictionaryMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DictionaryMaint) cdo, (DictionaryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DictionaryMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (DictionaryMaint_Request) null, out DictionaryMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result)
    {
      return this.ExecuteTransaction((DictionaryMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DictionaryMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DictionaryMaintMethod(cdo, DictionaryMaintMethods.AddDataTransaction, (DictionaryMaint_Parameters) null));
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
        return this.AddDataTransaction((DictionaryMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
