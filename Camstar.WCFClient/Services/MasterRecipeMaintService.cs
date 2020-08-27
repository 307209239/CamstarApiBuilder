// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MasterRecipeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MasterRecipeMaintService : ProductionProcessMaintBase
  {
    public MasterRecipeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMasterRecipeMaintService), userProfile);
    }

    public ResultStatus Delete(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      result = (MasterRecipeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterRecipeMaintService) this._Channel).Delete(this._UserProfile, masterRecipeMaint, parameters, request, out result) : this.AddMethod((Method) new MasterRecipeMaintMethod(masterRecipeMaint, MasterRecipeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((MasterRecipeMaint) null, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus Delete(MasterRecipeMaint masterRecipeMaint)
    {
      return this.Delete(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus Delete(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      return this.Delete(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      result = (MasterRecipeMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterRecipeMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, masterRecipeMaint, parameters, request, out result) : this.AddMethod((Method) new MasterRecipeMaintMethod(masterRecipeMaint, MasterRecipeMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((MasterRecipeMaint) null, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(MasterRecipeMaint masterRecipeMaint)
    {
      return this.DeleteAllRevisions(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      return this.DeleteAllRevisions(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      result = (MasterRecipeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterRecipeMaintService) this._Channel).Freeze(this._UserProfile, masterRecipeMaint, parameters, request, out result) : this.AddMethod((Method) new MasterRecipeMaintMethod(masterRecipeMaint, MasterRecipeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((MasterRecipeMaint) null, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus Freeze(MasterRecipeMaint masterRecipeMaint)
    {
      return this.Freeze(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus Freeze(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      return this.Freeze(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      result = (MasterRecipeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterRecipeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, masterRecipeMaint, parameters, request, out result) : this.AddMethod((Method) new MasterRecipeMaintMethod(masterRecipeMaint, MasterRecipeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MasterRecipeMaint) null, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(MasterRecipeMaint masterRecipeMaint)
    {
      return this.GetWIPMsgs(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      return this.GetWIPMsgs(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      result = (MasterRecipeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterRecipeMaintService) this._Channel).Load(this._UserProfile, masterRecipeMaint, parameters, request, out result) : this.AddMethod((Method) new MasterRecipeMaintMethod(masterRecipeMaint, MasterRecipeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MasterRecipeMaint) null, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus Load(MasterRecipeMaint masterRecipeMaint)
    {
      return this.Load(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus Load(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      return this.Load(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_LoadESigDetails_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      result = (MasterRecipeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterRecipeMaintService) this._Channel).LoadESigDetails(this._UserProfile, masterRecipeMaint, parameters, request, out result) : this.AddMethod((Method) new MasterRecipeMaintMethod(masterRecipeMaint, MasterRecipeMaintMethods.LoadESigDetails, (MasterRecipeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MasterRecipeMaint) null, (MasterRecipeMaint_LoadESigDetails_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(MasterRecipeMaint masterRecipeMaint)
    {
      return this.LoadESigDetails(masterRecipeMaint, (MasterRecipeMaint_LoadESigDetails_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      return this.LoadESigDetails(masterRecipeMaint, (MasterRecipeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      result = (MasterRecipeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterRecipeMaintService) this._Channel).New(this._UserProfile, masterRecipeMaint, parameters, request, out result) : this.AddMethod((Method) new MasterRecipeMaintMethod(masterRecipeMaint, MasterRecipeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((MasterRecipeMaint) null, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus New(MasterRecipeMaint masterRecipeMaint)
    {
      return this.New(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus New(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      return this.New(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      result = (MasterRecipeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterRecipeMaintService) this._Channel).NewCopy(this._UserProfile, masterRecipeMaint, parameters, request, out result) : this.AddMethod((Method) new MasterRecipeMaintMethod(masterRecipeMaint, MasterRecipeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((MasterRecipeMaint) null, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus NewCopy(MasterRecipeMaint masterRecipeMaint)
    {
      return this.NewCopy(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus NewCopy(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      return this.NewCopy(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      result = (MasterRecipeMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterRecipeMaintService) this._Channel).NewRev(this._UserProfile, masterRecipeMaint, parameters, request, out result) : this.AddMethod((Method) new MasterRecipeMaintMethod(masterRecipeMaint, MasterRecipeMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((MasterRecipeMaint) null, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus NewRev(MasterRecipeMaint masterRecipeMaint)
    {
      return this.NewRev(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus NewRev(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      return this.NewRev(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      result = (MasterRecipeMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterRecipeMaintService) this._Channel).NewRevCopy(this._UserProfile, masterRecipeMaint, parameters, request, out result) : this.AddMethod((Method) new MasterRecipeMaintMethod(masterRecipeMaint, MasterRecipeMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((MasterRecipeMaint) null, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus NewRevCopy(MasterRecipeMaint masterRecipeMaint)
    {
      return this.NewRevCopy(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      return this.NewRevCopy(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      result = (MasterRecipeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterRecipeMaintService) this._Channel).SaveAs(this._UserProfile, masterRecipeMaint, parameters, request, out result) : this.AddMethod((Method) new MasterRecipeMaintMethod(masterRecipeMaint, MasterRecipeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((MasterRecipeMaint) null, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus SaveAs(MasterRecipeMaint masterRecipeMaint)
    {
      return this.SaveAs(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus SaveAs(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      return this.SaveAs(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      result = (MasterRecipeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterRecipeMaintService) this._Channel).SaveAsRev(this._UserProfile, masterRecipeMaint, parameters, request, out result) : this.AddMethod((Method) new MasterRecipeMaintMethod(masterRecipeMaint, MasterRecipeMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((MasterRecipeMaint) null, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus SaveAsRev(MasterRecipeMaint masterRecipeMaint)
    {
      return this.SaveAsRev(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      return this.SaveAsRev(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      result = (MasterRecipeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterRecipeMaintService) this._Channel).UnFreeze(this._UserProfile, masterRecipeMaint, parameters, request, out result) : this.AddMethod((Method) new MasterRecipeMaintMethod(masterRecipeMaint, MasterRecipeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) masterRecipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((MasterRecipeMaint) null, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus UnFreeze(MasterRecipeMaint masterRecipeMaint)
    {
      return this.UnFreeze(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      return this.UnFreeze(masterRecipeMaint, (MasterRecipeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject masterRecipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterRecipeMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((MasterRecipeMaint) masterRecipeMaint, (MasterRecipeMaint_Parameters) parameters, (MasterRecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject masterRecipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterRecipeMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((MasterRecipeMaint) masterRecipeMaint, (MasterRecipeMaint_Parameters) parameters, (MasterRecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject masterRecipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterRecipeMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((MasterRecipeMaint) masterRecipeMaint, (MasterRecipeMaint_Parameters) parameters, (MasterRecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject masterRecipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterRecipeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((MasterRecipeMaint) masterRecipeMaint, (MasterRecipeMaint_Parameters) parameters, (MasterRecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject masterRecipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterRecipeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((MasterRecipeMaint) masterRecipeMaint, (MasterRecipeMaint_Parameters) parameters, (MasterRecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject masterRecipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterRecipeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((MasterRecipeMaint) masterRecipeMaint, (MasterRecipeMaint_Parameters) parameters, (MasterRecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject masterRecipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterRecipeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MasterRecipeMaint) masterRecipeMaint, (MasterRecipeMaint_LoadESigDetails_Parameters) parameters, (MasterRecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject masterRecipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterRecipeMaint_Result result1;
        ResultStatus resultStatus = this.New((MasterRecipeMaint) masterRecipeMaint, (MasterRecipeMaint_Parameters) parameters, (MasterRecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject masterRecipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterRecipeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((MasterRecipeMaint) masterRecipeMaint, (MasterRecipeMaint_Parameters) parameters, (MasterRecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject masterRecipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterRecipeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((MasterRecipeMaint) masterRecipeMaint, (MasterRecipeMaint_Parameters) parameters, (MasterRecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject masterRecipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterRecipeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((MasterRecipeMaint) masterRecipeMaint, (MasterRecipeMaint_Parameters) parameters, (MasterRecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject masterRecipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterRecipeMaint_Result result1;
        ResultStatus resultStatus = this.Load((MasterRecipeMaint) masterRecipeMaint, (MasterRecipeMaint_Parameters) parameters, (MasterRecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject masterRecipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MasterRecipeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MasterRecipeMaint) masterRecipeMaint, (MasterRecipeMaint_Parameters) parameters, (MasterRecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      result = (MasterRecipeMaint_Result) null;
      try
      {
        MasterRecipeMaintMethod[] methods = new MasterRecipeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMasterRecipeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MasterRecipeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MasterRecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MasterRecipeMaint cdo,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      result = (MasterRecipeMaint_Result) null;
      try
      {
        return ((IMasterRecipeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MasterRecipeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((MasterRecipeMaint) cdo, (MasterRecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      return this.GetEnvironment((MasterRecipeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MasterRecipeMaint cdo,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      result = (MasterRecipeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMasterRecipeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MasterRecipeMaintMethod(cdo, MasterRecipeMaintMethods.ExecuteTransaction, (MasterRecipeMaint_Parameters) null));
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
        MasterRecipeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MasterRecipeMaint) cdo, (MasterRecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MasterRecipeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (MasterRecipeMaint_Request) null, out MasterRecipeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result)
    {
      return this.ExecuteTransaction((MasterRecipeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MasterRecipeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MasterRecipeMaintMethod(cdo, MasterRecipeMaintMethods.AddDataTransaction, (MasterRecipeMaint_Parameters) null));
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
        return this.AddDataTransaction((MasterRecipeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
